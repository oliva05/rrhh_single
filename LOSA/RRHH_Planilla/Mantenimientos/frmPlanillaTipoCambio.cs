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
    public partial class frmPlanillaTipoCambio : DevExpress.XtraEditors.XtraForm
    {
        PlanillaTipoCambio tipo_cambio = new PlanillaTipoCambio();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int tipo_cambio_id;
        public frmPlanillaTipoCambio(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosTC();
 
  
        }

        public frmPlanillaTipoCambio(TipoTransaccionPlanilla transact, int id_departamento, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            tipo_cambio_id = id_departamento;
            CargarDatosTC();

            usuario = user_p;
    

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(txtMonto.EditValue)<0)
            {
                CajaDialogo.Error("Debe de ingresar una monto correcto");
                return;
            }

            if (string.IsNullOrEmpty(deFecha.Text))
            {
                CajaDialogo.Error("Debe de ingresar una Fecha");
                return;
            }

            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                CajaDialogo.Error("Debe de ingresar un monto");
                return;
            }

            

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[dbo].[uspInsertTipoCambio]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id_moneda_procedencia", SqlDbType.Int).Value=slueProcedencia.EditValue;
                            cmd.Parameters.Add("@id_moneda_destino", SqlDbType.Int).Value=slueDestino.EditValue;
                            cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = txtMonto.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = deFecha.EditValue;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateTipoCambio", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tipo_cambio.ID;
                            cmd.Parameters.Add("@id_moneda_procedencia", SqlDbType.Int).Value = slueProcedencia.EditValue;
                            cmd.Parameters.Add("@id_moneda_destino", SqlDbType.Int).Value = slueDestino.EditValue;
                            cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = txtMonto.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = deFecha.EditValue;

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
                tipo_cambio=new PlanillaTipoCambio();

                tipo_cambio.RecuperaRegistro(tipo_cambio_id);
                slueProcedencia.EditValue = 2; // Default USD
                slueDestino.EditValue = 44; //Default HND
                deFecha.EditValue=DateTime.Now;

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    deFecha.Text = tipo_cambio.FechaTC.ToString();
                    slueDestino.EditValue = tipo_cambio.MonedaDestinoID;
                    slueProcedencia.EditValue = tipo_cambio.MonedaProcedenciaID;
                    txtMonto.Text=tipo_cambio.Monto.ToString();

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosTC()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.currency.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCurrency", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.currency);
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