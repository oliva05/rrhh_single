using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases.Colaborador;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosContrato;
using System.Data.SqlClient;

namespace LOSA.RRHH_Planilla.Mantenimientos.ContratoRRHH
{
    public partial class frmAddAjusteISR_Contrato : DevExpress.XtraEditors.XtraForm
    {
        HrEmployee EmpleadoObject;
        string codigoEmpleado;
        UserLogin UsuarioLogeado;
        DateTime FechaActualDB = DateTime.Now;
        DataOperations dp;
        public int IdEmployee { get; set; }
        public int Anio { get; set; }
        public int Cuotas { get; set; }
        public decimal Monto { get; set; }
        public decimal Ingresos { get; set; }
        public decimal MontoAfp { get; set; }
        HrConfIsrAjusteSaldos ConfActual;

        TipoTransaccion TipoTransaccionActual;
        public enum TipoTransaccion
        {
            Insert = 1,
            Update = 2, 
            Delete = 3
        }


        public frmAddAjusteISR_Contrato(UserLogin usuario, int EmpleadoId, TipoTransaccion pTipoTransaccion, HrConfIsrAjusteSaldos pConfActual)
        {
            InitializeComponent();
            TipoTransaccionActual = pTipoTransaccion;
            dp = new DataOperations();
            UsuarioLogeado = usuario;
            ConfActual = pConfActual;
            EmpleadoObject = new HrEmployee();
            FechaActualDB = dp.Now();
            if(EmpleadoObject.RecuperarDatosPorId(EmpleadoId))
            {
                codigoEmpleado = EmpleadoObject.Barcode;
                lblEmpleado.Text = codigoEmpleado + " - " + EmpleadoObject.Name;
                IdEmployee = EmpleadoId;
                Anio = FechaActualDB.Year;
                Cuotas = 0;
                Monto = 0;
                Ingresos = 0;
                MontoAfp = 0;
                tggEnable.Visible = lblHabilitado.Visible = false;

                switch (TipoTransaccionActual)
                {
                    case TipoTransaccion.Insert:

                        spinEditAnio.EditValue = Anio;
                        spinEditCantCuotas.EditValue = Cuotas;
                        txtISR_Deducido.EditValue = Monto;
                        txtIngresosDevengados.EditValue = Ingresos;
                        txtAFP_Deducido.EditValue = MontoAfp;
                        break;
                    case TipoTransaccion.Update:
                        cmdAgregarAjuste.Text = "Actualizar";
                        tggEnable.Visible = lblHabilitado.Visible = true;
                        spinEditAnio.EditValue = ConfActual.Anio;
                        spinEditCantCuotas.EditValue = ConfActual.Cuotas;
                        txtISR_Deducido.EditValue = ConfActual.Monto;
                        txtIngresosDevengados.EditValue = ConfActual.Ingresos;
                        txtAFP_Deducido.EditValue = ConfActual.MontoAfp;
                        tggEnable.IsOn = ConfActual.Enable;
                        break;

                        default:

                        break;
                }

            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdAgregarAjuste_Click(object sender, EventArgs e)
        {
            if(spinEditAnio.Value <= 1999)
            {
                CajaDialogo.Error("Debe ingresar un año valido!");
                spinEditAnio.Focus();
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                switch (TipoTransaccionActual)
                {
                    case TipoTransaccion.Insert:
                        SqlCommand cmdA = new SqlCommand("dbo.[sp_CheckEmployeeAdjustment]", con);
                        cmdA.CommandType = CommandType.StoredProcedure;
                        cmdA.Parameters.AddWithValue("@id_employee", EmpleadoObject.Id);
                        cmdA.Parameters.AddWithValue("@anio", spinEditAnio.Value);
                        int Result = dp.ValidateNumberInt32(cmdA.ExecuteScalar());

                        if (Result == 1)
                        {
                            CajaDialogo.Error("Este empleado ya tiene saldos iniciales para el año seleccionado!");
                            spinEditAnio.Focus();
                            return;
                        }

                        SqlCommand cmd = new SqlCommand("dbo.[sp_Insert_hr_conf_isr_ajuste_saldos]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_employee", EmpleadoObject.Id);
                        cmd.Parameters.AddWithValue("@anio", spinEditAnio.Value);
                        cmd.Parameters.AddWithValue("@cuotas", Cuotas);
                        cmd.Parameters.AddWithValue("@monto", Monto);
                        cmd.Parameters.AddWithValue("@ingresos", Ingresos);
                        cmd.Parameters.AddWithValue("@monto_afp", MontoAfp);

                        cmd.ExecuteNonQuery();        
                        break;
                    case TipoTransaccion.Update:
                        SqlCommand cmdC = new SqlCommand("dbo.[sp_Update_hr_conf_isr_ajuste_saldos]", con);
                        cmdC.CommandType = CommandType.StoredProcedure;
                        cmdC.Parameters.AddWithValue("@id", ConfActual.Id);
                        cmdC.Parameters.AddWithValue("@id_employee", EmpleadoObject.Id);
                        cmdC.Parameters.AddWithValue("@anio", spinEditAnio.Value);
                        cmdC.Parameters.AddWithValue("@cuotas", Cuotas);
                        cmdC.Parameters.AddWithValue("@monto", Monto);
                        cmdC.Parameters.AddWithValue("@ingresos", Ingresos);
                        cmdC.Parameters.AddWithValue("@monto_afp", MontoAfp);
                        cmdC.Parameters.AddWithValue("@enable", tggEnable.IsOn);

                        cmdC.ExecuteNonQuery();
                        break; 
                    default:break;
                }

                con.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void txtISR_Deducido_EditValueChanged(object sender, EventArgs e)
        {
            //decimal val = 0;
            //try
            //{
            //    val = Convert.ToDecimal()
            //}
            //catch 
            //{

            //}
            Monto = dp.ValidateNumberDecimal(txtISR_Deducido.EditValue);
        }

        private void txtIngresosDevengados_EditValueChanged(object sender, EventArgs e)
        {
            Ingresos = dp.ValidateNumberDecimal(txtIngresosDevengados.EditValue);
        }

        private void txtAFP_Deducido_EditValueChanged(object sender, EventArgs e)
        {
            MontoAfp = dp.ValidateNumberDecimal(txtAFP_Deducido.EditValue);
        }

        private void spinEditCantCuotas_EditValueChanged(object sender, EventArgs e)
        {
            Cuotas = dp.ValidateNumberInt32(spinEditCantCuotas.Value);
        }

        private void spinEditAnio_EditValueChanged(object sender, EventArgs e)
        {
            Anio = dp.ValidateNumberInt32(spinEditAnio.Value);
        }
    }
}