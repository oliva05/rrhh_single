using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
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
    public partial class frmDeductionsCRUD_PayslipLine : DevExpress.XtraEditors.XtraForm
    {

        TipoTransaccionPlanilla transaccion_tipo;
        UserLogin usuario = new UserLogin();
        int contrato_id;
        //int id_benefit_deduction;
        Hr_BenefitDeduction benefit_deduction = new Hr_BenefitDeduction();
        Conceptos conceptoActual = new Conceptos();  
        DetalleContrato contratoActual = new DetalleContrato();
        PlanillaSalaryRule ReglaSalarialActual;
        DataOperations dp;
        int SlipId;
        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }
        public frmDeductionsCRUD_PayslipLine(TipoTransaccionPlanilla transaccion,UserLogin pUser,int pIdSlip)
        {
            InitializeComponent();
            dp = new DataOperations();
            SlipId = pIdSlip;
            CargarDatosConcepts();
            //CargarDatosTipo();
            //CargarDatosBenefitsDeductionsTipo();
            transaccion_tipo=transaccion;
            usuario=pUser;
           

            //contratoActual.RecuperarRegistroPorId(contrato_id);
        }


        public frmDeductionsCRUD_PayslipLine(TipoTransaccionPlanilla transaccion, UserLogin pUser, int contract_id,int benefit_deduction_id)
        {
            InitializeComponent();
            CargarDatosConcepts();
            //CargarDatosTipo();
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

                using (SqlDataAdapter da = new SqlDataAdapter("[uspLoadConcept_v2]", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@slip_id",SlipId);
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

                if(conceptoActual == null)
                {
                    CajaDialogo.Error("Debe de seleccionar un concepto");
                    return;
                }
                
                if (!conceptoActual.Recuperado)
                {
                    CajaDialogo.Error("Debe de seleccionar un concepto");
                    return;
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

                if(conceptoActual.ID ==5)
                {
                    if(string.IsNullOrEmpty(txtComments.Text) || txtComments.Text.Length <= 5)
                    {
                        CajaDialogo.Error("Es obligatorio indicar una descripción o comentario válido!");
                        return;
                    }
                }

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("InsertBenefitOrDeductionManual", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            //cmd.Parameters.Add("@applicable_date", SqlDbType.Date).Value = deFechaAplicable.EditValue;
                            cmd.Parameters.AddWithValue("@slip_id", SlipId);
                            cmd.Parameters.AddWithValue("@amount",txtValor.EditValue);
                            cmd.Parameters.AddWithValue("@total", txtValor.EditValue);
                            cmd.Parameters.AddWithValue("@name", conceptoActual.Name);
                            cmd.Parameters.AddWithValue("@category_id", conceptoActual.CategoriaID);

                            if (conceptoActual.CategoriaID == 2)//Beneficio
                            {
                                cmd.Parameters.AddWithValue("@salary_rule_id", 47);
                                cmd.Parameters.AddWithValue("@salary_rule_name", conceptoActual.Name);
                                cmd.Parameters.AddWithValue("@code", "BEN");
                            }
                            else
                            {
                                if (conceptoActual.CategoriaID == 4)//Deduccion
                                {
                                    cmd.Parameters.AddWithValue("@salary_rule_id", 50);
                                    cmd.Parameters.AddWithValue("@salary_rule_name", conceptoActual.Name);
                                    cmd.Parameters.AddWithValue("@code", "DEDU");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@salary_rule_id", DBNull.Value);
                                    cmd.Parameters.AddWithValue("@salary_rule_name", DBNull.Value);
                                    cmd.Parameters.AddWithValue("@code", DBNull.Value);
                                }
                            }

                            cmd.Parameters.AddWithValue("@nota", txtComments.Text);
                            cmd.Parameters.AddWithValue("@concepto_id", conceptoActual.ID);
                            
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        //CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case TipoTransaccionPlanilla.Editar:

                        using (SqlCommand cmd = new SqlCommand("uspUpdateBenefitDeductionV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            //cmd.Parameters.Add("@applicable_date", SqlDbType.Date).Value = deFechaAplicable.EditValue;
                            cmd.Parameters.Add("@comments", SqlDbType.VarChar).Value = txtComments.Text;
                            cmd.Parameters.Add("@concept_id", SqlDbType.Int).Value = slueConcepto.EditValue;
                            cmd.Parameters.Add("user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@contract_id", SqlDbType.Int).Value = contrato_id;
                            cmd.Parameters.Add("@value", SqlDbType.Float).Value = txtValor.EditValue;
                            //cmd.Parameters.Add("@month_deductions", SqlDbType.Int).Value = string.IsNullOrEmpty(txtCuotas.Text) ? DBNull.Value : txtCuotas.EditValue;
                            //cmd.Parameters.Add("@ammount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtCuotas.Text);
                            //cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = slueTipo.EditValue;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = benefit_deduction.Id;
                            //cmd.Parameters.Add("@id_tipo", SqlDbType.Int).Value = slueTypeBD.EditValue;


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        //CajaDialogo.Information("Datos Actualizados");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void frmDeductionsCRUD_PayslipLine_Load(object sender, EventArgs e)
        {
            //if (contratoActual != null)
            //{
            //    CambiarMascaraMoneda(contratoActual.Moneda);

            //    if (TipoTransaccionPlanilla.Editar == transaccion_tipo)
            //    {
            //        deFechaAplicable.EditValue = benefit_deduction.ApplicableDate;
            //        slueConcepto.EditValue = benefit_deduction.ConceptoId;
            //        slueTipo.EditValue = benefit_deduction.PeriocidadId;
            //        txtCuotas.EditValue = benefit_deduction.Cuotas;
            //        txtValor.EditValue = benefit_deduction.Valor;
            //        slueTypeBD.EditValue = benefit_deduction.TipoId;
            //        lblMontoOriginal.Text = $"Valor quincenal: {contratoActual.SimboloMoneda}{(benefit_deduction.Valor / benefit_deduction.Cuotas).ToString("N2")}";
            //    }
            //    deFechaAplicable.EditValue = DateTime.Now;
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slueTipo_EditValueChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(slueTipo.EditValue)==2)// es periodo infinito.
            //{
            //    txtCuotas.Enabled = false;
            //    txtCuotas.EditValue = null;
            //}
            //else
            //{
            //    txtCuotas.Enabled = true;
            //}
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int cuotas = 0;
            //    decimal valor = 0;
            //    lblMontoOriginal.Visible = true;

            //    if (txtCuotas.EditValue == null)
            //    {
            //        cuotas = 0;
            //    }
            //    else
            //    {
            //        cuotas = Convert.ToInt32(txtCuotas.EditValue)*2;
            //    }

            //    if (txtValor.EditValue == null)
            //    {
            //        valor = 0;
            //    }
            //    else
            //    {
            //        valor = Convert.ToDecimal(txtValor.EditValue);
            //    }


            //    lblMontoOriginal.Text = $"Valor quincenal: {contratoActual.SimboloMoneda} {( valor /  cuotas ).ToString("N2")}";
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void CambiarMascaraMoneda(string moneda)
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

        private void slueConcepto_EditValueChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(slueConcepto.Text))
            {
                conceptoActual = new  Conceptos(); 
                int pidConcepto = dp.ValidateNumberInt32(slueConcepto.EditValue);
                if (conceptoActual.RecuperaRegistro(pidConcepto))
                {

                }
            }
        }

        private void slueConcepto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValor.Focus();   
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComments.Focus();
            }
        }

        private void txtComments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }
    }
}