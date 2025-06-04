using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
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
    public partial class frmCapacitacioAdjuntoTipoHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmCapacitacioAdjuntoTipoHome(UserLogin user)
        {
            InitializeComponent();
            usuarioLog = user;
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetTipoAdjunto_capacitacion", cnx);
                    dsCapacitacion1.adjuntos_tipo.Clear();
                    da.Fill(dsCapacitacion1.adjuntos_tipo);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCapacitacioAdjuntoTipoCRUD frm = new frmCapacitacioAdjuntoTipoCRUD(frmCapacitacioAdjuntoTipoCRUD.TipoTransaccionPlanilla.Nuevo, usuarioLog);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.adjuntos_tipoRow)gvTipo.GetFocusedDataRow();

                if (row != null)
                {
                    frmCapacitacioAdjuntoTipoCRUD frm = new frmCapacitacioAdjuntoTipoCRUD(frmCapacitacioAdjuntoTipoCRUD.TipoTransaccionPlanilla.Editar, row.id, usuarioLog);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsCapacitacion.adjuntos_tipoRow)gvTipo.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                var respuesta = CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta == DialogResult.Yes)
                {

                    using (SqlCommand cmd = new SqlCommand("dbo.uspDisableTipoAdjunto_capacitacion", cnx))
                    {
                        cnx.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = row.id;
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                    }

                    CajaDialogo.Information("Datos deshabilitados!");
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}