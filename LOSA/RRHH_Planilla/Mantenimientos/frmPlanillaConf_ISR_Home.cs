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
    public partial class frmPlanillaConf_ISR_Home : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmPlanillaConf_ISR_Home(UserLogin user)
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

                dsMantenimientoPlanilla.Conf_ISR_header.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetConf_ISR_H", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType= CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@active", SqlDbType.Int).Value=toggleSwitch1.EditValue;
                    da.Fill(dsMantenimientoPlanilla.Conf_ISR_header);
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
                frmPlanillaConf_ISR frm = new frmPlanillaConf_ISR(frmPlanillaConf_ISR.TipoTransaccionPlanilla.Nuevo, usuarioLog);

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
                var row = (dsMantenimientoPlanilla.Conf_ISR_headerRow)gvISR.GetFocusedDataRow();

                if (row != null)
                {
                    frmPlanillaConf_ISR frm = new frmPlanillaConf_ISR(frmPlanillaConf_ISR.TipoTransaccionPlanilla.Editar,row.id,usuarioLog);

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
                var row = (dsMantenimientoPlanilla.Conf_ISR_headerRow)gvISR.GetFocusedDataRow();

                if ((bool)toggleSwitch1.EditValue==false) 
                {
                    CajaDialogo.Error("Este elemento no se puede deshabilitar porqueya esta deshabilitado");
                    return;
                }
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDisableISR_Conf", cnx))
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

        private void btnDetalle_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row=(dsMantenimientoPlanilla.Conf_ISR_headerRow)gvISR.GetFocusedDataRow() ;

                frmPlanillaConf_ISR_ViewDetail frm = new frmPlanillaConf_ISR_ViewDetail(row.id);

                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}