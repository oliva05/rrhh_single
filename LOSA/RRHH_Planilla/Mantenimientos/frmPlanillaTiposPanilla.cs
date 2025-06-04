using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
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

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmPlanillaTiposPanilla : DevExpress.XtraEditors.XtraForm
    {
        PlanillaTipoPlanilla tiposPlanilla = new PlanillaTipoPlanilla();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int tipoPlanilla_id;
        public frmPlanillaTiposPanilla(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCurrency();
            CargarDatosSchedulePay();
        }

        public frmPlanillaTiposPanilla(TipoTransaccionPlanilla transact, int id_tiposPlanilla, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            tipoPlanilla_id = id_tiposPlanilla;
            CargarDatosCurrency();
            CargarDatosSchedulePay();

            usuario = user_p;
 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (slueMoneda.EditValue==null)
            {
                CajaDialogo.Error("Debe de seleccionar una moneda");
                return;
            }

            if (string.IsNullOrEmpty(cbTipoCalculo.Text))
            {
                CajaDialogo.Error("Debe de seleccionar un tipo de calculo");
                return;
            }

            if (string.IsNullOrEmpty(slueProgamarPago.Text))
            {
                CajaDialogo.Error("Debe de seleccionar un programación de pago");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[dbo].[uspInsertTipoPlanillaV2]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = slueMoneda.EditValue;
                            cmd.Parameters.Add("@compute_type", SqlDbType.VarChar).Value = cbTipoCalculo.Text;
                            cmd.Parameters.Add("@schedule_pay_id", SqlDbType.VarChar).Value = slueProgamarPago.EditValue;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateTipoPlanillaV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tiposPlanilla.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = slueMoneda.EditValue;
                            cmd.Parameters.Add("@compute_type", SqlDbType.VarChar).Value = cbTipoCalculo.EditValue;
                            cmd.Parameters.Add("@schedule_pay_id", SqlDbType.VarChar).Value = slueProgamarPago.EditValue;


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPlanillaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                tiposPlanilla = new PlanillaTipoPlanilla();


                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    tiposPlanilla.RecuperaRegistro(tipoPlanilla_id);

                    txtNombre.Text= tiposPlanilla.Name;
                    //ceDiasTrabajados.EditValue = tiposPlanilla.WorkedDay;
                    //ceFeriados.EditValue = tiposPlanilla.HolidayDays;
                    //ceHistorico.EditValue = tiposPlanilla.Historical;
                    slueMoneda.EditValue = tiposPlanilla.CurrencyID;
                    slueProgamarPago.EditValue = tiposPlanilla.SchedulePayId;
                    cbTipoCalculo.EditValue = tiposPlanilla.ComputeType;
                   
                }
                else
                {
                //deFechaInicio.EditValue = DateTime.Now;
                //deFechaFin.EditValue = DateTime.Now;

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
         

        public void CargarDatosCurrency()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.currency.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCurrency", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.currency);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosSchedulePay()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.schedule_pay.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSchedulePay", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.schedule_pay);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}