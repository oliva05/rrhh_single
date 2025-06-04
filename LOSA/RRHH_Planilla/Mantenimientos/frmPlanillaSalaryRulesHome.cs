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
    public partial class frmPlanillaSalaryRulesHome : DevExpress.XtraEditors.XtraForm
    {
        UserLogin usuarioLog;
        public frmPlanillaSalaryRulesHome(UserLogin user)
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

                dsMantenimientoPlanilla1.salary_rule.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetSalaryRules", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType= CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@mostrar_deshabilitados", SqlDbType.Bit).Value = toggleSwitch1.EditValue;

                    da.Fill(dsMantenimientoPlanilla1.salary_rule);
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
                frmPlanillaSalaryRules frm = new frmPlanillaSalaryRules(frmPlanillaSalaryRules.TipoTransaccionPlanilla.Nuevo, usuarioLog);

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
                var row = (dsMantenimientoPlanilla.salary_ruleRow)gvSalaryRule.GetFocusedDataRow();

                if (row != null)
                {
                    if (row.active == false)
                    {
                        CajaDialogo.Error("No se puede editar debido a que ya está deshabilitada");
                        return;
                    }

                    frmPlanillaBancos frm = new frmPlanillaBancos(frmPlanillaBancos.TipoTransaccionPlanilla.Editar,row.id,usuarioLog);

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
                var row = (dsMantenimientoPlanilla.salary_ruleRow)gvSalaryRule.GetFocusedDataRow();

                if (row.active==false)
                {
                    CajaDialogo.Error("No se puede deshabilitar debido a que ya está deshabilitada");
                    return;
                }
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                   var respuesta= CajaDialogo.Pregunta("¿Desea eliminar el registro?");

                if (respuesta== DialogResult.Yes)
                {

                using (SqlCommand cmd = new SqlCommand("dbo.uspDisableSalaryRule", cnx))
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

        private void btnEditar_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row =(dsMantenimientoPlanilla.salary_ruleRow)gvSalaryRule.GetFocusedDataRow() ;

                if (row.active == false)
                {
                    CajaDialogo.Error("No se puede editar debido a que ya está deshabilitada");
                    return;
                }

                frmPlanillaSalaryRules frm = new frmPlanillaSalaryRules(frmPlanillaSalaryRules.TipoTransaccionPlanilla.Editar,row.id,usuarioLog);

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

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            CargarDatos();
        }

        
    }
}