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
    public partial class frmPlanillaTipoContrato : DevExpress.XtraEditors.XtraForm
    {
        PlanillaTipoContrato tipoContrato = new PlanillaTipoContrato();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int contrato_tipo_id;
        public frmPlanillaTipoContrato(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarCalendario();
            CargarConfVacaciones();
            CargarContratoFormato();
        }

        public frmPlanillaTipoContrato(TipoTransaccionPlanilla transact, int id_tipo_contrato, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            contrato_tipo_id = id_tipo_contrato;
            usuario = user_p;
            CargarCalendario();
            CargarConfVacaciones();
            CargarContratoFormato();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (slueConfVacaciones.EditValue==null)
            {
                CajaDialogo.Error("Debe de seleccionar una configuraciòn de vacaciones");
                return;
            }

            if (slueHorasTrabajo.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar las horas de trabajo");
                return;
            }

            if (slueHorasTrabVac.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar las horas de trabajo de vacaciones");
                return;
            }

            if (slueContratoFormato.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar un formato de contrato");
                return;
            }

            if (cbSchedulePay.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar una programaciòn de pago");
                return;
            }


            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[dbo].[uspInsertTipoContrato]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@secuencia", SqlDbType.Int).Value = txtSecuencia.Text;
                            cmd.Parameters.Add("@configuracion_vacaciones", SqlDbType.Int).Value = slueConfVacaciones.EditValue;
                            cmd.Parameters.Add("@horario_vacaciones_trabajo", SqlDbType.Int).Value = slueHorasTrabVac.EditValue;
                            cmd.Parameters.Add("@horario_trabajo", SqlDbType.Int).Value = slueHorasTrabajo.EditValue;
                            cmd.Parameters.Add("@pago_programado", SqlDbType.VarChar).Value = cbSchedulePay.Text;
                            cmd.Parameters.Add("@formato_contrato", SqlDbType.Int).Value = slueContratoFormato.EditValue;
                            cmd.Parameters.Add("@otro_formato_contrato", SqlDbType.Int).Value = DBNull.Value;
                           
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateTipoContrato", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = tipoContrato.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@secuencia", SqlDbType.Int).Value = txtSecuencia.Text;
                            cmd.Parameters.Add("@configuracion_vacaciones", SqlDbType.Int).Value = slueConfVacaciones.EditValue;
                            cmd.Parameters.Add("@horario_vacaciones_trabajo", SqlDbType.Int).Value = slueHorasTrabVac.EditValue;
                            cmd.Parameters.Add("@horario_trabajo", SqlDbType.Int).Value = slueHorasTrabajo.EditValue;
                            cmd.Parameters.Add("@pago_programado", SqlDbType.VarChar).Value = cbSchedulePay.Text;
                            cmd.Parameters.Add("@formato_contrato", SqlDbType.Int).Value = slueContratoFormato.EditValue;
                            cmd.Parameters.Add("@otro_formato_contrato", SqlDbType.Int).Value = DBNull.Value;

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
                tipoContrato= new PlanillaTipoContrato();

                tipoContrato.RecuperaRegistro(contrato_tipo_id);


                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= tipoContrato.Name;
                    txtSecuencia.Text=tipoContrato.Secuencia.ToString();
                    slueContratoFormato.EditValue = tipoContrato.FormatoContratoId;
                    slueHorasTrabajo.EditValue = tipoContrato.HorarioTrabajo;
                    slueHorasTrabVac.EditValue = tipoContrato.HorarioVacacionesTrabajo;
                    slueConfVacaciones.EditValue = tipoContrato.ConfVacaciones;
                    cbSchedulePay.Text = tipoContrato.PagoProgramado;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       public void CargarCalendario()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.res_calendar.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoad_res_Calendar", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.res_calendar);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void CargarConfVacaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.hr_vacation_configuratiion.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoad_hr_vacation_configuration", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.hr_vacation_configuratiion);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void CargarContratoFormato()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.hr_contract_format.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadContratoFormato", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.hr_contract_format);
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