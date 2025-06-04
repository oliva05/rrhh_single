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
    public partial class frmPlanillaAccount : DevExpress.XtraEditors.XtraForm
    {
        PlanillaAccount account = new PlanillaAccount();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int account_id;
        public frmPlanillaAccount(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCurrency();
            CargarDatosGrupo();
            CargarCompania();
        }

        public frmPlanillaAccount(TipoTransaccionPlanilla transact, int id_account, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            account_id = id_account;
            CargarDatosCurrency();
            CargarDatosGrupo();
            usuario = user_p;
            CargarCompania();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                 

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                CajaDialogo.Error("Debe de ingresar un codigo");
                return;
            }

            if (slueMoneda.EditValue==null)
            {
                CajaDialogo.Error("Debe de seleccionar una moneda");
                return;
            }

            if (slueGrupo.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar un grupo");
                return;
            }

            if (transaccion_tipo == TipoTransaccionPlanilla.Nuevo)
            {

                if (ValidarCodigoCuenta())
                {
                    CajaDialogo.Error("El código ingresado ya existe");
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

                        using (SqlCommand cmd = new SqlCommand("[uspInsertAccount]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value=txtCodigo.Text;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value= string.IsNullOrEmpty( txtNote.Text) ? (object)DBNull.Value: txtNote.Text;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@group_id", SqlDbType.Int).Value = string.IsNullOrEmpty(slueGrupo.Text) ? (object)DBNull.Value : slueGrupo.EditValue;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = string.IsNullOrEmpty(slueMoneda.Text) ? (object)DBNull.Value : slueMoneda.EditValue;


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateAccountV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = account.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCodigo.Text; 
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;
                            cmd.Parameters.Add("@currency_id", SqlDbType.Int).Value = string.IsNullOrEmpty(slueMoneda.Text) ? (object)DBNull.Value : slueMoneda.EditValue;
                            cmd.Parameters.Add("@group_id", SqlDbType.Int).Value = string.IsNullOrEmpty(slueGrupo.Text) ? (object)DBNull.Value : slueGrupo.EditValue;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = string.IsNullOrEmpty(txtNote.Text) ? (object)DBNull.Value : txtNote.Text;


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
                account=new PlanillaAccount();

                account.RecuperaRegistro(account_id);
                slueCompania.EditValue = 1;

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= account.Name;
                    txtCodigo.Text= account.Code;
                    txtNote.Text= account.Note;
                    slueCompania.EditValue= account.CompanyID;
                    slueGrupo.EditValue= account.GroupID;
                    slueMoneda.EditValue= account.MonedaID;
                    txtCodigo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDatosGrupo()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Groups.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetGroups", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Groups);
                    cnx.Close();
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

        public void CargarCompania()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla.Compania.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetCompany", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla.Compania);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool ValidarCodigoCuenta() {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                bool existeCodigo=false;

                using (SqlCommand cmd = new SqlCommand("[uspValidarAccount]", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = txtCodigo.Text;

                    existeCodigo= Convert.ToBoolean( cmd.ExecuteScalar());
                    cnx.Close();
                }

                return existeCodigo;
             }
            catch (Exception)
            {

                throw;
            }

            return true;
        
        }
    }
}