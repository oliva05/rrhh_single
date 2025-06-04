using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Capacitacion;
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

namespace LOSA.RRHH_Planilla.Mantenimientos
{
    public partial class frmCapacitacionPresupuestoCRUD : DevExpress.XtraEditors.XtraForm
    {
        CapacitacionPresupuestoClass presupuesto = new CapacitacionPresupuestoClass();

        public enum TipoTransaccion
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccion transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int presupuesto_id;
        public frmCapacitacionPresupuestoCRUD(TipoTransaccion transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCurrency();    
        }

        public frmCapacitacionPresupuestoCRUD(TipoTransaccion transact, int id_presupuesto, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            presupuesto_id = id_presupuesto;           
            usuario = user_p;
            CargarDatosCurrency();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe de ingresar una Descripción");
                return;
            }

            if ( txtPresupuesto.EditValue==null)
            {
                CajaDialogo.Error("Debe de ingresar un presupuesto");
                return;
            }

            if ((decimal)txtPresupuesto.EditValue == 0)
            {
                CajaDialogo.Error("Debe de ingresar un presupuesto válido");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccion.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[uspInsertPresupuestoCapacitacion]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@descripcion",SqlDbType.VarChar).Value=txtDescripcion.Text;
                            cmd.Parameters.Add("@presupuesto", SqlDbType.VarChar).Value = txtPresupuesto.EditValue;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = slueMoneda.EditValue;
                            cmd.Parameters.Add("@monto_cambio", SqlDbType.Decimal).Value = txtMontoCambio.EditValue;
                            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = deAnio.DateTime.Year;                           

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccion.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdatePresupuestoCapacitacion", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = presupuesto.Id;
                            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;
                            cmd.Parameters.Add("@presupuesto", SqlDbType.VarChar).Value = txtPresupuesto.EditValue;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = slueMoneda.EditValue;
                            cmd.Parameters.Add("@monto_cambio", SqlDbType.Decimal).Value = txtMontoCambio.EditValue;
                            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = deAnio.DateTime.Year;


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
                presupuesto=new CapacitacionPresupuestoClass();

                presupuesto.RecuperaRegistrosById (presupuesto_id);                

                if (TipoTransaccion.Editar==transaccion_tipo)
                {
                    txtDescripcion.Text= presupuesto.Descripcion;
                    txtPresupuesto.EditValue = presupuesto.Presupuesto;
                    deAnio.EditValue = new DateTime( presupuesto.Anio,1,1);
                    slueMoneda.EditValue = presupuesto.CurrencyID;
                    txtMontoCambio.EditValue = presupuesto.MontoCambio;
                    //txtNombreLargo.Text= departamento.NombreLargo;
      
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

                dsCapacitacion1.currency.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadCurrency", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsCapacitacion1.currency);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void slueMoneda_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)slueMoneda.EditValue==2)
            {
                txtMontoCambio.Enabled = true;
                btnTC.Enabled = true;
                txtMontoCambio.EditValue = 1;
            }
            else
            {
                txtMontoCambio.Enabled=false;
                btnTC.Enabled=false;
                txtMontoCambio.EditValue = 1;
            }
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionarTasaCambio frm = new frmSeleccionarTasaCambio();

                if (frm.ShowDialog()== DialogResult.OK)
                {
                    txtMontoCambio.EditValue = frm.tasa_cambio;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}