using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Logistica.CheckList.Models;
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

namespace LOSA.Logistica.CheckList
{
    public partial class frmCheckListItemsCRUD : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoTransaccion
        {
            Save = 1,
            Update = 2,
            Delete = 3
        }

        UserLogin usuario = new UserLogin();

        TipoTransaccion transaccionActual;
            CheckListItem item = new CheckListItem();

        public frmCheckListItemsCRUD(TipoTransaccion pTransaccionActual, UserLogin pUsr)
        {
            InitializeComponent();
            this.transaccionActual = pTransaccionActual;
            this.usuario = pUsr;

             
        }

        public frmCheckListItemsCRUD(TipoTransaccion pTransaccionActual, int id_item)
        {
            InitializeComponent();
            this.transaccionActual = pTransaccionActual;


            if (transaccionActual == TipoTransaccion.Update)
            {
                if (item.RecuperarRegistroPorId(id_item))
                {
                    txtNombreCorto.Text = item.NombreCorto;
                    txtNombreLargo.Text = item.NombreLargo;
                    txtModelo.Text = item.Modelo;
                    txtCodigo.Text = item.Codigo;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtNombreCorto.Text))
                {
                    CajaDialogo.Error("Debe asignarle un nombre corto al Equipo");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombreLargo.Text))
                {
                    CajaDialogo.Error("Debe asignarle un nombre largo al Equipo");
                    return;
                }

                if (string.IsNullOrEmpty(txtModelo.Text))
                {
                    CajaDialogo.Error("Debe asignarle un modelo al Equipo");
                    return;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CajaDialogo.Error("Debe asignarle un codigo al Equipo");
                    return;
                }

                DataOperations dp = new DataOperations ();


                switch (transaccionActual)
                {
                    case TipoTransaccion.Save:
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                        {
                            SqlCommand command = new SqlCommand("uspInsertChecklistItem", connection);

                            command.CommandType = CommandType.StoredProcedure;

                            // Agregar parámetros al procedimiento almacenado
                            command.Parameters.AddWithValue("@NombreCorto", txtNombreCorto.Text);
                            command.Parameters.AddWithValue("@NombreLargo", txtNombreLargo.Text);
                            command.Parameters.AddWithValue("@Barcode", DBNull.Value);
                            command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                            command.Parameters.AddWithValue("@IdTipo", DBNull.Value);
                            command.Parameters.AddWithValue("@IdSubtipo", DBNull.Value);
                            command.Parameters.AddWithValue("@OemBase", DBNull.Value);
                            command.Parameters.AddWithValue("@IdTipoMantenimiento", DBNull.Value);
                            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                            command.Parameters.AddWithValue("@IdUsuarioCreado", usuario.Id);
                            command.Parameters.AddWithValue("@IdIndicador", DBNull.Value);
                            command.Parameters.AddWithValue("@MontoMantenimientoPreventivo", DBNull.Value);
                            command.Parameters.AddWithValue("@IdZona", DBNull.Value);
                            command.Parameters.AddWithValue("@Valor", DBNull.Value);


                            // Abrir conexión y ejecutar el comando
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            CajaDialogo.Information("Datos Guardados!");
                            this.DialogResult = DialogResult.OK;

                        }
                        break;
                    case TipoTransaccion.Update:
                        using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                        {
                            SqlCommand command = new SqlCommand("uspUpdateChecklistItem", connection);

                            command.CommandType = CommandType.StoredProcedure;

                            // Agregar parámetros al procedimiento almacenado
                            command.Parameters.AddWithValue("@Id", item.Id);
                            command.Parameters.AddWithValue("@NombreCorto", txtNombreCorto.Text);
                            command.Parameters.AddWithValue("@NombreLargo", txtNombreLargo.Text);
                            command.Parameters.AddWithValue("@Barcode", DBNull.Value);
                            command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                            command.Parameters.AddWithValue("@IdTipo", DBNull.Value);
                            command.Parameters.AddWithValue("@IdSubtipo", DBNull.Value);
                            command.Parameters.AddWithValue("@OemBase", DBNull.Value);
                            command.Parameters.AddWithValue("@IdTipoMantenimiento", DBNull.Value);
                            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                            command.Parameters.AddWithValue("@IdUsuarioCreado", usuario.Id);
                            command.Parameters.AddWithValue("@IdIndicador", DBNull.Value);
                            command.Parameters.AddWithValue("@MontoMantenimientoPreventivo", DBNull.Value);
                            command.Parameters.AddWithValue("@IdZona", DBNull.Value);
                            command.Parameters.AddWithValue("@Valor", DBNull.Value);


                            // Abrir conexión y ejecutar el comando
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            CajaDialogo.Information("Datos Actualizados!");
                            this.DialogResult = DialogResult.OK;

                        }
                        break;
                    case TipoTransaccion.Delete:
                        break;
                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
               
            }
        }
    }
}