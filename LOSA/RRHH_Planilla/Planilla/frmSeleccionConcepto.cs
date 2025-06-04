using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.RRHH_Planilla.Mantenimientos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmSeleccionConcepto : DevExpress.XtraEditors.XtraForm
    {
        public int concept_id =0;
        public int tipo_planilla_id =0;
        public int tipo_id =0;
        public frmSeleccionConcepto()
        {
            InitializeComponent();
            CargarDatosConcepts();
            LoadTiposPlanillas();
            CargarDatosBenefitsDeductionsTipo();

        }

        public void CargarDatosConcepts()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsCargasPlantillas1.Concepts.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadConcept", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@active", SqlDbType.Bit).Value = true;
                    da.Fill(dsCargasPlantillas1.Concepts);
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

                dsImportacionPlanilla.benefits_deductions_tipo.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadBenefisDeductionsTipo", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsImportacionPlanilla.benefits_deductions_tipo);
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

                if (gleTipoPlanilla.EditValue==null)
                {
                    CajaDialogo.Error("Debe de seleccionar un tipo de planilla");
                    return;
                }

                if (slueConcepto.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar un concepto");
                    return;
                }

                if (slueTipo.EditValue == null)
                {
                    CajaDialogo.Error("Debe de seleccionar un tipo");
                    return;
                }

                this.concept_id = (int)slueConcepto.EditValue;
                this.tipo_planilla_id = (int)gleTipoPlanilla.EditValue;
                this.tipo_id = (int)slueTipo.EditValue;

                this.DialogResult = DialogResult.OK;
           
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

         
        private void LoadTiposPlanillas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_tipos_payslip_run", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsCargasPlantillas1.tipo_planilla_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCargasPlantillas1.tipo_planilla_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}