using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
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
    public partial class frmPlanillaDepartmentDetail : DevExpress.XtraEditors.XtraForm
    {
        public int IdDepartment;
        public int IdDetalle = 0;
        public int SalaryRuleId;
        public string SalaryRuleName;
        public int AccountId;
        public string AccountName;
        public string Move;
        public bool Prov;
        public bool Patro;
        public string AnalyticType;
        public int ConceptId;
        public string ConceptName;
        public int CounterPartId;

        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();

        public enum TipoOperacion
        {
            New = 1,
            Update =  2,
            View = 3
        }

        TipoOperacion tipoOP;

        public frmPlanillaDepartmentDetail(frmPlanillaDepartmentDetail.TipoOperacion OptIpo, int pIdDetalle, int pIdDepartment, int pSalaryId, 
            int pAccountId, string pmove, bool pprov, bool ppatro, string panalytic_type, UserLogin pUserLogin, int pConceptId, int pCounterPartId)
        {
            InitializeComponent();

            tipoOP = OptIpo;
            UsuarioLogueado = pUserLogin;
            CargarCuenta();
            CargarSalaryRule();
            CargarConcepts();

            IdDetalle = pIdDetalle;
            IdDepartment = pIdDepartment;
            gcReglas.EditValue = pSalaryId;
            gcCuenta.EditValue = pAccountId;
            boxMove.Text = pmove;
            boxAnalytic.Text = panalytic_type;
            chkPatronal.Checked = ppatro;
            chkProvision.Checked = pprov;   
            gcConceptos.EditValue = ConceptId = pConceptId;
            gcContraPartida.EditValue = pCounterPartId;

            switch (tipoOP)
            {
                case TipoOperacion.Update:
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                    gcReglas.Enabled = true;
                    gcCuenta.Enabled = true;   
                    boxAnalytic.Enabled = true; 
                    boxMove.Enabled = true;
                    chkPatronal.Enabled = true; 
                    chkProvision.Enabled = true;

                  
                    break;
                case TipoOperacion.View:
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    gcReglas.Enabled = false;
                    gcCuenta.Enabled = false;
                    boxAnalytic.Enabled = false;
                    boxMove.Enabled = false;
                    chkPatronal.Enabled = false;
                    chkProvision.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        public frmPlanillaDepartmentDetail(frmPlanillaDepartmentDetail.TipoOperacion OptIpo, int pIdDepartment, UserLogin pUserLogin)
        {
            InitializeComponent();
            tipoOP = OptIpo;
            IdDepartment = pIdDepartment;
            UsuarioLogueado = pUserLogin;
            CargarCuenta();
            CargarSalaryRule();
            CargarConcepts();

            
        }

        private void CargarConcepts()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                SqlCommand cmd = new SqlCommand("[uspLoadConceptForDepartment]", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //cmd.Parameters.AddWithValue("@DepartmentId", IdDepartment);
                dsMantenimientoPlanilla1.ConceptsForDepartment.Clear();
                da.Fill(dsMantenimientoPlanilla1.ConceptsForDepartment);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       

        private void CargarSalaryRule()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                SqlCommand cmd = new SqlCommand("uspGetSalaryRulesForDepartment", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //cmd.Parameters.AddWithValue("@DepartmentId", IdDepartment);
                dsMantenimientoPlanilla1.hr_salary_ryule.Clear();
                da.Fill(dsMantenimientoPlanilla1.hr_salary_ryule);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarCuenta()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                SqlCommand cmd = new SqlCommand("uspLoadAccount", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@active", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.account.Clear();
                da.Fill(dsMantenimientoPlanilla1.account);
                cnx.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este combinacion?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            bool Guardar = false;
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_delete_hr_accounting", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", IdDetalle);
                cmd.Parameters.AddWithValue("@idDepartment", IdDepartment);
                cmd.ExecuteNonQuery();
                Guardar = true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            if (Guardar)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Si tiene Regla, no necesariamente debe tener Concepto y Viceversa!
            if (string.IsNullOrEmpty(gcReglas.Text))
            {
                if(string.IsNullOrEmpty(gcConceptos.EditValue.ToString()))
                {
                    CajaDialogo.Error("Debe adicionar la Regla o el Concepto");
                    return;
                }
                
            }

            if (string.IsNullOrEmpty(boxMove.Text))
            {
                CajaDialogo.Error("Debe Seleccionar el Tipo de Movimiento.");
                return;
            }

            if (string.IsNullOrEmpty(gcCuenta.Text))
            {
                CajaDialogo.Error("Debe Seleccionar el Tipo de Cuenta.");
                return;
            }

            try
            {
                SalaryRuleId = Convert.ToInt32(gcReglas.EditValue);
                SalaryRuleName = gcReglas.Text;
                Move = boxMove.Text;
                ConceptId = Convert.ToInt32(gcConceptos.EditValue);
                ConceptName = gcConceptos.Text;
                AccountId = Convert.ToInt32(gcCuenta.EditValue);
                AccountName = gcCuenta.Text;
                Prov = chkProvision.Checked;
                Patro = chkPatronal.Checked;
                AnalyticType = boxAnalytic.Text;
                CounterPartId = Convert.ToInt32(gcContraPartida.EditValue);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boxAnalytic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}