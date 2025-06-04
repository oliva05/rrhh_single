using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.RRHH_Planilla.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.BenefitsDeductions
{
    public partial class frmBenefitsDeductionsCRUD : DevExpress.XtraEditors.XtraForm
    {

        TipoTransaccionPlanilla transaccion_tipo;
        UserLogin usuario = new UserLogin();
        int contrato_id;
        //int id_benefit_deduction;
        Hr_BenefitDeduction benefit_deduction = new Hr_BenefitDeduction();
        DetalleContrato contratoActual = new DetalleContrato();
        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }
        public frmBenefitsDeductionsCRUD(TipoTransaccionPlanilla transaccion,UserLogin pUser,int contract_id)
        {
            InitializeComponent();
            CargarDatosConcepts();
            CargarDatosTipo();
            CargarDatosBenefitsDeductionsTipo();
            transaccion_tipo=transaccion;
            usuario=pUser;
            contrato_id=contract_id;

            contratoActual.RecuperarRegistroPorId(contrato_id);
        }


        public frmBenefitsDeductionsCRUD(TipoTransaccionPlanilla transaccion, UserLogin pUser, int contract_id,int benefit_deduction_id)
        {
            InitializeComponent();
            CargarDatosConcepts();
            CargarDatosTipo();
            CargarDatosBenefitsDeductionsTipo();
            transaccion_tipo = transaccion;
            usuario = pUser;
            contrato_id = contract_id;
            //id_benefit_deduction = benefit_deduction_id;
            benefit_deduction.RecuperarRegistroPorId(benefit_deduction_id);
            contratoActual.RecuperarRegistroPorId(contrato_id);

        }
        public void CargarDatosConcepts()
    {
        try
        {
            DataOperations dp = new DataOperations();

            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

            dsMantenimientoPlanilla1.Concepts.Clear();

            using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadConcept", cnx))
            {
                cnx.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@active", SqlDbType.Bit).Value = true;
                da.Fill(dsMantenimientoPlanilla1.Concepts);
                cnx.Close();
            }
        }
        catch (Exception ex)
        {
            CajaDialogo.Error(ex.Message);
        }
    }
        public void CargarDatosTipo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.benefit_deduction_type.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetBenefitsDeductionsType", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.benefit_deduction_type);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }


        public void CargarDatosBenefitsDeductionsTipo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsColaborador1.benefits_deductions_tipo.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadBenefisDeductionsTipo", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsColaborador1.benefits_deductions_tipo);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                

                if (slueConcepto.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar un concepto");
                    return;
                }

                if (Convert.ToInt32(slueTipo.EditValue)==1 && Convert.ToInt32(seCuotas.Text)<=0)// Periodo Finito
                {
                    
                    CajaDialogo.Error("Debe de ingresar las cuotas correctas!");
                    return;
                }
                else
                {
                    if (slueTipo.EditValue == null)
                    {
                        CajaDialogo.Error("Debe de ingresar las cuotas correctas!");
                        return;
                    }

                }

                if (txtValor.EditValue == null)
                {
                    CajaDialogo.Error("Debe de ingresar un valor correcto para el concepto " + slueConcepto.Text);
                    return;
                }

                if (Convert.ToDecimal( txtValor.EditValue) <= 0)
                {
                    CajaDialogo.Error("Debe de ingresar un valor correcto para el concepto "+slueConcepto.Text);
                    return;
                }

                if ( slueTypeBD.EditValue==null)
                {
                    CajaDialogo.Error("Seleccione un tipo (Beneficio o Deducción)");
                    return;
                }



                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("uspInsertBenefitDeductionV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@applicable_date", deFechaAplicable.EditValue);
                            cmd.Parameters.AddWithValue("@comments", txtComments.Text);
                            cmd.Parameters.AddWithValue("@concept_id", slueConcepto.EditValue);
                            cmd.Parameters.AddWithValue("user_id", usuario.Id);
                            cmd.Parameters.AddWithValue("@contract_id", contrato_id);
                            cmd.Parameters.AddWithValue("@value", txtValor.EditValue);
                            //cmd.Parameters.Add("@ammount", SqlDbType.Decimal).Value = string.IsNullOrEmpty(seCuotas.Text) ? DBNull.Value : seCuotas.EditValue;

                            int tipo = Convert.ToInt32(slueTipo.EditValue);
                            if (tipo == 2)
                                cmd.Parameters.AddWithValue("@ammount", 1);
                            else
                                cmd.Parameters.AddWithValue("@ammount", seCuotas.EditValue);

                            cmd.Parameters.AddWithValue("@id_type", slueTipo.EditValue);
                            cmd.Parameters.AddWithValue("@id_tipo", slueTypeBD.EditValue);

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:

                        using (SqlCommand cmd = new SqlCommand("uspUpdateBenefitDeductionV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@applicable_date", deFechaAplicable.EditValue);
                            cmd.Parameters.AddWithValue("@comments", txtComments.Text);
                            cmd.Parameters.AddWithValue("@concept_id",  slueConcepto.EditValue);
                            cmd.Parameters.AddWithValue("user_id", usuario.Id);
                            cmd.Parameters.AddWithValue("@contract_id", contrato_id);
                            cmd.Parameters.AddWithValue("@value", txtValor.EditValue);
                            //cmd.Parameters.Add("@month_deductions", SqlDbType.Int).Value = string.IsNullOrEmpty(seCuotas.Text) ? DBNull.Value : seCuotas.EditValue);
                            
                            int tipo = Convert.ToInt32(slueTipo.EditValue);
                            if (tipo == 2)
                                cmd.Parameters.AddWithValue("@month_deductions", 1);
                            else
                                cmd.Parameters.AddWithValue("@month_deductions", seCuotas.EditValue);

                            cmd.Parameters.AddWithValue("@id_type", slueTipo.EditValue);
                            cmd.Parameters.AddWithValue("@id", benefit_deduction.Id);
                            cmd.Parameters.AddWithValue("@id_tipo", slueTypeBD.EditValue);


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

        private void frmBenefitsDeductionsCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                if (contratoActual != null)
                {
                    //CambiarMascaraMoneda(contratoActual.Moneda);

                    if (TipoTransaccionPlanilla.Editar == transaccion_tipo)
                    {
                        deFechaAplicable.EditValue = benefit_deduction.ApplicableDate;
                        slueConcepto.EditValue = benefit_deduction.ConceptoId;
                        slueTipo.EditValue = benefit_deduction.PeriocidadId;
                        seCuotas.EditValue = benefit_deduction.Cuotas;
                        txtValor.EditValue = benefit_deduction.Valor;
                        slueTypeBD.EditValue = benefit_deduction.TipoId;
                        txtComments.Text = benefit_deduction.Comentarios;

                        if (benefit_deduction.Cuotas == 0)
                        {
                            lblMontoOriginal.Text = $"Valor quincenal: L {(benefit_deduction.Valor).ToString("N2")}";
                        }
                        else
                            lblMontoOriginal.Text = $"Valor quincenal: L {(benefit_deduction.Valor / (benefit_deduction.Cuotas*2)).ToString("N2")}";
                    }
                    else
                    {

                    deFechaAplicable.EditValue = DateTime.Now;
                    }
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

        private void slueTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(slueTipo.EditValue)==2)// es periodo infinito.
            {
                seCuotas.Enabled = false;
                seCuotas.EditValue = null;
            }
            else
            {
                seCuotas.Enabled = true;
            }
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int cuotas = 0;
                decimal valor = 0;
                //lblMontoOriginal.Visible = true;

                if (seCuotas.EditValue == null)
                {
                    cuotas = 0;
                }
                else
                {
                    cuotas = Convert.ToInt32(seCuotas.EditValue);
                }

                if (txtValor.EditValue == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToDecimal(txtValor.EditValue);
                }

                if (cuotas == 0)
                {
                    lblMontoOriginal.Text = $"Valor quincenal: L {(valor).ToString("N2")}";
                }
                else
                {
                    lblMontoOriginal.Text = $"Valor quincenal: L {(valor / 2).ToString("N2")}";
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CambiarMascaraMoneda(string moneda)
        {
            try
            {

                switch (moneda.ToUpper())
                {
                    case "USD": // Dólares
                        txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtValor.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtValor.Properties.Mask.Culture = new CultureInfo("en-US"); // Formato de EE.UU. (USD)
                        txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
                        break;

                    case "HNL": // Lempiras
                        txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        txtValor.Properties.Mask.EditMask = "c"; // Formato monetario
                        txtValor.Properties.Mask.Culture = new CultureInfo("es-HN"); // Formato de Honduras (HNL)
                        txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
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