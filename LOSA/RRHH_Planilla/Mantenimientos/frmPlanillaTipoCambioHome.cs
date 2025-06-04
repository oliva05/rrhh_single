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
using static LOSA.RRHH_Planilla.Mantenimientos.frmPlanillaCategoria;

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmPlanillaTipoCambioHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmPlanillaTipoCambioHome(UserLogin user)
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

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.hr_tipo_cambio.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadTipoCambioV2", cnx))
                {
                    cnx.Open();

                    da.SelectCommand.CommandType= CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@active",toggleSwitch1.EditValue);

                    da.Fill(dsMantenimientoPlanilla.hr_tipo_cambio);
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
                frmPlanillaTipoCambio frm = new frmPlanillaTipoCambio(frmPlanillaTipoCambio.TipoTransaccionPlanilla.Nuevo, usuarioLog);

                if (frm.ShowDialog()== DialogResult.OK)
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
                var row = (dsMantenimientoPlanilla.hr_tipo_cambioRow)gvTC.GetFocusedDataRow();

                if (row != null)
                {
                    if (row.active == false)
                    {
                        CajaDialogo.Error("No se puede editar debido a que ya está deshabilitada");
                        return;
                    }

                    frmPlanillaTipoCambio frm = new frmPlanillaTipoCambio(frmPlanillaTipoCambio.TipoTransaccionPlanilla.Editar,row.id,usuarioLog);

                    if (frm.ShowDialog()== DialogResult.OK)
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
                var row = (dsMantenimientoPlanilla.hr_tipo_cambioRow)gvTC.GetFocusedDataRow();

                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                if (row.active == false)
                {
                    CajaDialogo.Error("No se puede deshabilitar debido a que ya está deshabilitada");
                    return;
                }

                var respuesta= CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDeshabilitarTipoCambio", cnx))
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}