using ACS.Classes;
using DevExpress.XtraEditors;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
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
    public partial class frmPlanillaPuestoTrabajo : DevExpress.XtraEditors.XtraForm
    {
        PlanillaPuestoTrabajo job = new PlanillaPuestoTrabajo();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        int job_id;
        public frmPlanillaPuestoTrabajo(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
 
            CargarCompania();
            CargarDepartments();
            LoadBandasSalariales();
        }

        public frmPlanillaPuestoTrabajo(TipoTransaccionPlanilla transact, int id_departamento, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            job_id = id_departamento;
            CargarDepartments(); ;
            usuario = user_p;
            CargarCompania();
            LoadBandasSalariales();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

           
            if ( slueDepartment.EditValue==null)
            {
                CajaDialogo.Error("Debe de seleccionar un departamento");
                return;
            }

            if ( slueCompania.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar una compañìa");
                return;
            }

            if (slueBandaSalarial.EditValue == null)
            {
                CajaDialogo.Error("Debe de seleccionar una banda salarial");
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        using (SqlCommand cmd = new SqlCommand("[uspInsertJobV2]", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType= CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name",SqlDbType.VarChar).Value=txtNombre.Text;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value=txtNote.Text;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@department_id", SqlDbType.Int).Value = slueDepartment.EditValue;
                            cmd.Parameters.Add("@id_banda_salarial", SqlDbType.Int).Value = slueBandaSalarial.EditValue;
                            cmd.Parameters.Add("@num_empleados", SqlDbType.Int).Value = txtNumeroEmpleados.Text;

                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Guardados Exitósamente!");
                        this.DialogResult = DialogResult.OK;
                        break;
                    case TipoTransaccionPlanilla.Editar:
                       
                        using (SqlCommand cmd = new SqlCommand("uspUpdateJobV2", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = txtNote.Text;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = slueCompania.EditValue;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@department_id", SqlDbType.Int).Value = slueDepartment.EditValue;
                            cmd.Parameters.Add("@num_empleados", SqlDbType.Int).Value = txtNumeroEmpleados.Text;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = job.ID;
                            cmd.Parameters.Add("@id_banda_salarial", SqlDbType.Int).Value = slueBandaSalarial.EditValue;


                            cmd.ExecuteNonQuery();

                            cnx.Close();

                        }

                        CajaDialogo.Information("Datos Actualizados Exitósamente!");
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
                job= new PlanillaPuestoTrabajo();

                job.RecuperaRegistro(job_id);
                slueCompania.EditValue = 1;

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= job.Name;
                    txtNote.Text= job.Note;
                    slueCompania.EditValue = job.CompanyID;
                    slueDepartment.EditValue = job.DepartmentID;
                    txtNumeroEmpleados.Text = job.NumeroEmpleados.ToString();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarDepartments()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsMantenimientoPlanilla1.hr_deparment.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadDepartment", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.hr_deparment);
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

                dsMantenimientoPlanilla1.Compania.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetCompany", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.Compania);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadBandasSalariales()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_lista_bandas_salariales", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.banda_salarial.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.banda_salarial);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}