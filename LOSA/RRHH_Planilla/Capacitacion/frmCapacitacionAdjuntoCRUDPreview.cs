using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.RRHH_Planilla.Capacitacion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Capacitacion
{
    public partial class frmCapacitacionAdjuntoCRUDPreview : DevExpress.XtraEditors.XtraForm
    {
        CapacitacionClass capacitacionActual= new CapacitacionClass();
        UserLogin usuario = new UserLogin();

        public frmCapacitacionAdjuntoCRUDPreview(int capacitacion_id,UserLogin usuarioLogueado)
        {
            InitializeComponent();
            capacitacionActual.RecuperaRegistrosByCapacitacionId(capacitacion_id);
            usuario = usuarioLogueado;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCapacitacionAdjuntoCRUD frm = new frmCapacitacionAdjuntoCRUD();

            if (frm.ShowDialog()== DialogResult.OK)
            {
                // Crear una nueva fila
                DataRow nuevaFila = dsCapacitacion1.capacitacion_adjuntos.NewRow();

                // Asignar valores a las columnas de la nueva fila
                nuevaFila["id"] = 0;
                nuevaFila["file_name_"] = frm.adjuntos.FileName;
                nuevaFila["descripcion"] = frm.adjuntos.Descripcion;
                nuevaFila["tipo_adjunto"] = frm.adjuntos.Tipo;
                nuevaFila["path_"] = frm.adjuntos.Path;
                nuevaFila["file_name_original"] = frm.adjuntos.FileNameOriginal;
                nuevaFila["tipo_adjunto_id"] = frm.adjuntos.TipoId;

                // Agregar la fila al DataTable
                dsCapacitacion1.capacitacion_adjuntos.Rows.Add(nuevaFila);

                dsCapacitacion1.AcceptChanges();
                btnSave.Enabled = true;
            }
        }

        private void btnDelete_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gvArchivos.DeleteRow(gvArchivos.FocusedRowHandle);

            if (gvArchivos.RowCount==0)
            {
                btnSave.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
            cnx.Open();

            SqlTransaction transaction = cnx.BeginTransaction();
            try
            {

                foreach (var item in dsCapacitacion1.capacitacion_adjuntos)
                {
                    using (SqlCommand cmd = new SqlCommand("uspInsertCapacitacionAdjuntos", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@path", dp.FTP_RRHH_Capacitaciones + item.file_name_);
                        cmd.Parameters.AddWithValue("@file_name", item.file_name_original);
                        cmd.Parameters.AddWithValue("@id_tipo", item.tipo_adjunto_id);
                        cmd.Parameters.AddWithValue("@descripcion", item.descripcion);
                        cmd.Parameters.AddWithValue("@id_capacitacion", capacitacionActual.Id);
                        cmd.Parameters.AddWithValue("@user_id", usuario.Id);

                        cmd.ExecuteNonQuery();

                        if (Upload(item.path_, item.file_name_))
                        {
                            transaction.Commit();
                            this.DialogResult = DialogResult.OK;
                        }

                    }
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                transaction.Rollback();
            }
        }

        private bool Upload(string pathFile, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargó la imagen");
                    return false;
                }
                else
                {
                    FTP_Class ftp1 = new FTP_Class();
                    return ftp1.GuardarArchivoRRHHCapacitacion(usuario, fileName, pathFile);
                }
            }

            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        private void frmExpedienteCRUDPreview_Load(object sender, EventArgs e)
        {
            if (gvArchivos.RowCount==0)
            {
                btnSave.Enabled = false;
            }
        }
    }
}