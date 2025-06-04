using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
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

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frmExpedienteCRUDPreview : DevExpress.XtraEditors.XtraForm
    {
        HrEmployee empleado= new HrEmployee();
        UserLogin usuario = new UserLogin();

        public frmExpedienteCRUDPreview(int employee_id,UserLogin usuarioLogueado)
        {
            InitializeComponent();
            empleado.RecuperarDatosPorId(employee_id);
            usuario = usuarioLogueado;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmExpedienteCRUD frm = new frmExpedienteCRUD();

            if (frm.ShowDialog()== DialogResult.OK)
            {
                // Crear una nueva fila
                DataRow nuevaFila = dsMaestroEmpleados1.expediente_empleado.NewRow();

                // Asignar valores a las columnas de la nueva fila
                nuevaFila["id"] = 0;
                nuevaFila["file_name_"] = frm.expediente.FileName;
                nuevaFila["descripcion"] = frm.expediente.Descripcion;
                nuevaFila["tipo_expediente"] = frm.expediente.Tipo;
                nuevaFila["path"] = frm.expediente.Path;
                nuevaFila["file_name_original"] = frm.expediente.FileNameOriginal;
                nuevaFila["tipo_expediente_id"] = frm.expediente.TipoId;

                // Agregar la fila al DataTable
                dsMaestroEmpleados1.expediente_empleado.Rows.Add(nuevaFila);

                dsMaestroEmpleados1.AcceptChanges();
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

                foreach (var item in dsMaestroEmpleados1.expediente_empleado)
                {
                   using (SqlCommand cmd = new SqlCommand("uspInsertExpedienteEmpleado", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = transaction;

                        cmd.Parameters.AddWithValue("@path",dp.FTP_RRHH_Expedientes+item.file_name_);
                        cmd.Parameters.AddWithValue("@file_name",item.file_name_original);
                        cmd.Parameters.AddWithValue("@id_tipo", item.tipo_expediente_id);
                        cmd.Parameters.AddWithValue("@descripcion",item.descripcion);
                        cmd.Parameters.AddWithValue("@id_employee", empleado.Id);
                        cmd.Parameters.AddWithValue("@code",empleado.Barcode);
                        cmd.Parameters.AddWithValue("@user_id", usuario.Id);

                        cmd.ExecuteNonQuery();

                        if (Upload(item.path,item.file_name_))
                        {
                            transaction.Commit();
                            this.DialogResult = DialogResult.OK;
                        }
                            cnx.Close();

                    }
                }
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
                    return ftp1.GuardarArchivoRRHHExpediente(usuario, fileName, pathFile);
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