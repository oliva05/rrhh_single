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
    public partial class frmPlanillaCurrency : DevExpress.XtraEditors.XtraForm
    {
        PlanillaDepartment departamento = new PlanillaDepartment();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int departamento_id;
        public frmPlanillaCurrency(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCategoria();
            CargarDatosGrupo();
            CargarCompania();
        }

        public frmPlanillaCurrency(TipoTransaccionPlanilla transact, int id_departamento, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            departamento_id = id_departamento;
            CargarDatosCategoria();
            CargarDatosGrupo();
            usuario = user_p;
            CargarCompania();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //if (Convert.ToInt32( slueCategoria.EditValue.ToString())==0)
            //{
            //    CajaDialogo.Error("Debe se seleccionar una categoria");
            //    return;
            //}

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            //if (string.IsNullOrEmpty(txtNombreLargo.Text))
            //{
            //    CajaDialogo.Error("Debe de ingresar un nombre largo");
            //    return;
            //}

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[uspInsertDepartment]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            //cmd.Parameters.Add("@complete_name", SqlDbType.VarChar).Value=txtNombreLargo.Text;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            //cmd.Parameters.Add("@group_by_id", SqlDbType.Int).Value=slueGrupo.EditValue==null?DBNull.Value: slueGrupo.EditValue;
                            //cmd.Parameters.Add("@category_id", SqlDbType.Int).Value=slueCategoria.EditValue;


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateDepartment", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = departamento.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            //cmd.Parameters.Add("@complete_name", SqlDbType.VarChar).Value = txtNombreLargo.Text; 
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;


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
                departamento=new PlanillaDepartment();

                departamento.RecuperaRegistro(departamento_id);
                slueCompania.EditValue = 1;

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= departamento.Name;
                    //txtNombreLargo.Text= departamento.NombreLargo;
      
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
    }
}