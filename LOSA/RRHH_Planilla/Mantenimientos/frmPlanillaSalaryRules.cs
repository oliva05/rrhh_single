using ACS.Classes;
using DevExpress.CodeParser;
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
    public partial class frmPlanillaSalaryRules : DevExpress.XtraEditors.XtraForm
    {
        PlanillaSalaryRule salary_rule = new PlanillaSalaryRule();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int salaryRule_id;
        public frmPlanillaSalaryRules(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCategoria();

        }

        public frmPlanillaSalaryRules(TipoTransaccionPlanilla transact, int id_salaryRule, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            salaryRule_id = id_salaryRule;
            CargarDatosCategoria();

            usuario = user_p;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (txtCantidad.EditValue==null)
            {
                CajaDialogo.Error("Debe de ingresar una cantidad");
                return;
            }
            else
            {
                if (Convert.ToInt32( txtCantidad.EditValue)<=0)
                {
                    CajaDialogo.Error("La cantidad debe ser mayor que 0");
                    return;
                }
            }

            if (txtSecuencia.EditValue == null)
            {
                CajaDialogo.Error("Debe de ingresar una secuencia");
                return;
            }
            else
            {
                if (Convert.ToInt32(txtSecuencia.EditValue) <= 0)
                {
                    CajaDialogo.Error("La secuencia debe ser mayor que 0");
                    return;
                }
            }

            if (TipoTransaccionPlanilla.Nuevo== transaccion_tipo)
            {
                
                if (ValidarCodigo())
                {
                    CajaDialogo.Error("Este Código ya existe");
                    txtCode.Focus();

                    return;
                }
            }
            

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("dbo.[uspInsertSalaryRule]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = slueCat.EditValue;
                            cmd.Parameters.Add("@sequence", SqlDbType.Int).Value = txtSecuencia.EditValue;
                            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtCantidad.EditValue;
                            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.EditValue;
                            cmd.Parameters.Add("@appears_on_payslip", SqlDbType.Bit).Value = ceAppear.EditValue;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = txtNote.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
 
                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("dbo.uspUpdateSalaryRule", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = slueCat.EditValue;
                            cmd.Parameters.Add("@sequence", SqlDbType.Int).Value = txtSecuencia.EditValue;
                            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtCantidad.EditValue;
                            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.EditValue;
                            cmd.Parameters.Add("@appears_on_payslip", SqlDbType.Bit).Value = ceAppear.EditValue;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = txtNote.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = salaryRule_id;

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
                salary_rule = new PlanillaSalaryRule();

                salary_rule.RecuperaRegistro(salaryRule_id);
                
                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= salary_rule.Nombre ;
                    slueCat.EditValue = salary_rule.CategoriaID;
                    txtCode.Text = salary_rule.Code;
                    txtCantidad.Text= salary_rule.Cantidad.ToString();
                    txtSecuencia.EditValue = salary_rule.Secuencia;
                    ceAppear.EditValue = salary_rule.ApareceEnNomina;
                    txtNote.Text= salary_rule.Note;
                    txtCode.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosCategoria()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Categoria.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSalaryRuleCategory", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Categoria);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

       public bool ValidarCodigo()
        {
            DataOperations dp = new DataOperations();
            SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
            bool existe=false;
            using (SqlCommand cmd = new SqlCommand("dbo.[uspValidateSalaryRuleCode]", cnx))
            {
                cnx.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCode.EditValue;
                

                existe=(bool) cmd.ExecuteScalar();

                cnx.Close();
            }

            return existe;
        }
               
    }
}