using ACS.Classes;
using DevExpress.DashboardCommon.Native;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraSpreadsheet.Forms;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.MigracionACS.RRHH.RelojFace;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Clases;
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
    public partial class frmPlanillaDepartment : DevExpress.XtraEditors.XtraForm
    {
        PlanillaDepartment departamento = new PlanillaDepartment();

        public enum TipoTransaccionPlanilla
        {
            Nuevo=1,
            Editar=2
        }

        TipoTransaccionPlanilla transaccion_tipo;

        UserLogin usuario = new UserLogin();
        DataOperations dp = new DataOperations();
        int departamento_id;
        public frmPlanillaDepartment(TipoTransaccionPlanilla transact,UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo= transact;
            usuario=user_p;
            CargarDatosCategoria();
            CargarDatosGrupo();
            CargarCompania();
            CargarCuenta();
            CargarEmpleadosActivos();
            CargarDepartamentos();
        }

        public frmPlanillaDepartment(TipoTransaccionPlanilla transact, int id_departamento, UserLogin user_p)
        {
            InitializeComponent();
            transaccion_tipo = transact;
            departamento_id = id_departamento;
            CargarDatosCategoria();
            CargarDatosGrupo();
            usuario = user_p;
            CargarCompania();
            CargarCuenta();
            CargarEmpleadosActivos();
            CargarDepartamentos();
            CargarCuentasAnaliticas();

            switch (transaccion_tipo)
            {
                case TipoTransaccionPlanilla.Nuevo:
                    break;
                case TipoTransaccionPlanilla.Editar:

                    Departamento departamento = new Departamento();
                    departamento.RecuperarDetalleReglasSalariales(departamento_id);
                    txtNombre.Text = departamento.Name;
                    txtNombreLargo.Text = departamento.CompleteName;
                    slueResponsable.EditValue = departamento.ManagerId;
                    slueDepart.EditValue = departamento.ParentId;
                    slueCuenta.EditValue = departamento.PaymentAccountId;
                    slueAnalyticAccount.EditValue = departamento.AnalyticDepartmentAccountId;

                    LoadDetalleReglas(departamento_id);

                    break;
                default:
                    break;
            }

        }

        private void LoadDetalleReglas(int departamento_id)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                string query = @"sp_get_account_combination_for_deparment_id";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmentId", departamento_id);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.hr_department_accounting.Clear();
                adat.Fill(dsMantenimientoPlanilla1.hr_department_accounting);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarDepartamentos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                string query = @"[uspLoadDepartment]";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.hr_deparment.Clear();
                adat.Fill(dsMantenimientoPlanilla1.hr_deparment);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarEmpleadosActivos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                string query = @"get_employe_active";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.hr_employee_responsable.Clear();
                adat.Fill(dsMantenimientoPlanilla1.hr_employee_responsable);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void CargarCuentasAnaliticas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                string query = @"sp_get_analytic_account_active";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.hr_analytic_account_active.Clear();
                adat.Fill(dsMantenimientoPlanilla1.hr_analytic_account_active);
                cnx.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtNombreLargo.Text))
            {
                CajaDialogo.Error("Debe de ingresar un nombre largo");
                return;
            }

            if (string.IsNullOrEmpty(slueCuenta.Text))
            {
                CajaDialogo.Error("Debe de seleccionar una cuenta");
                return;
            }

            try
            {

                DataOperations dp = new DataOperations();
                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:


                        SqlTransaction transaction = null;
                        
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                        bool Guardar = false;

                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");

                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "[uspInsertDepartmentV2]";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@complete_name", SqlDbType.VarChar).Value = txtNombreLargo.Text;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = 1;//slueCompania.EditValue;
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@payment_account_id", SqlDbType.Int).Value = slueCuenta.EditValue;
                            cmd.Parameters.AddWithValue("@parentId", slueDepart.EditValue);
                            cmd.Parameters.AddWithValue("@analytic_department_account_id", slueAnalyticAccount.EditValue);
                            cmd.Parameters.AddWithValue("@manager_id", slueResponsable.EditValue);

                            int id_department = Convert.ToInt32(cmd.ExecuteScalar());

                            foreach (dsMantenimientoPlanilla.hr_department_accountingRow row in dsMantenimientoPlanilla1.hr_department_accounting.Rows)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_hr_insert_accounting";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@provision", row.provision);
                                cmd.Parameters.AddWithValue("@patronal", row.patronal);
                                if (row.concept_id == 0)
                                    cmd.Parameters.AddWithValue("@concept_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@concept_id", row.concept_id);
                                if (row.salary_rule_id == 0)
                                    cmd.Parameters.AddWithValue("@salary_rule_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@salary_rule_id", row.salary_rule_id);
                                if (row.account_id == 0)
                                    cmd.Parameters.AddWithValue("@account_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@account_id", row.account_id);
                                if (row.counterpart_id == 0)
                                    cmd.Parameters.AddWithValue("@counterpart_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@counterpart_id", row.counterpart_id);

                                cmd.Parameters.AddWithValue("@move", row.move);
                                cmd.Parameters.AddWithValue("@department_id", id_department);
                                cmd.Parameters.AddWithValue("@analytic_type", row.analytic_type);
                                //cmd.Parameters.AddWithValue("@supplier_id",);
                                cmd.Parameters.AddWithValue("@create_uid", usuario.UserId);
                                cmd.Parameters.AddWithValue("@create_date", dp.Now());
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            Guardar = true;

                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        catch (Exception ec)
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(ec.Message);
                            Guardar = false;
                        }

                        CajaDialogo.Information("Datos Guardados");
                        this.DialogResult = DialogResult.OK;

                        break;
                    case TipoTransaccionPlanilla.Editar:

                        SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);
                        using (SqlCommand cmd = new SqlCommand("uspUpdateDepartment", cnx))
                        {
                            cnx.Open();
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = departamento.ID;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                            cmd.Parameters.Add("@complete_name", SqlDbType.VarChar).Value = txtNombreLargo.Text; 
                            cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario.Id;
                            cmd.Parameters.Add("@company_id", SqlDbType.Int).Value = 1;//slueCompania.EditValue;
                            cmd.Parameters.Add("@payment_account_id", SqlDbType.Int).Value = slueCuenta.EditValue;
                            cmd.Parameters.AddWithValue("@parentId", slueDepart.EditValue);
                            cmd.Parameters.AddWithValue("@analytic_department_account_id", slueAnalyticAccount.EditValue);
                            cmd.Parameters.AddWithValue("@manager_id", slueResponsable.EditValue);

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

                if (TipoTransaccionPlanilla.Editar==transaccion_tipo)
                {
                    txtNombre.Text= departamento.Name;
                    txtNombreLargo.Text= departamento.NombreLargo;
      
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

                dsMantenimientoPlanilla1.Groups.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspGetGroups", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.Groups);
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
                
                dsMantenimientoPlanilla1.Categoria.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadSalaryRuleCategory", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    da.Fill(dsMantenimientoPlanilla1.Categoria);
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

        public void CargarCuenta()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                SqlCommand cmd = new SqlCommand("uspLoadAccount",cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@active", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMantenimientoPlanilla1.account.Clear();
                da.Fill(dsMantenimientoPlanilla1.account);
                cnx.Close();
                //using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadAccount", cnx))
                //{
                //    cnx.Open();
                //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    

                //    da.Fill(dsMantenimientoPlanilla1.account);
                //    cnx.Close();
                //}
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void slueCuenta_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPlanillaDepartmentDetail frm = new frmPlanillaDepartmentDetail(frmPlanillaDepartmentDetail.TipoOperacion.New, departamento_id, usuario);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                bool Guardar = false;

                //Aqui vamos a Guardar!!
                switch (transaccion_tipo)
                {
                    case TipoTransaccionPlanilla.Nuevo:

                        DataRow dr = dsMantenimientoPlanilla1.hr_department_accounting.NewRow();
                        dr[0] = 0;
                        dr[1] = frm.Prov;
                        dr[2] = frm.Patro;
                        dr[3] = frm.ConceptId;
                        dr[4] = frm.ConceptName;
                        dr[5] = frm.SalaryRuleId;
                        dr[6] = frm.SalaryRuleName;
                        dr[7] = frm.AccountId;
                        dr[8] = frm.AccountName;
                        dr[9] = frm.Move;
                        dr[10] = frm.IdDepartment;
                        dr[11] = frm.AnalyticType;
                        dr[12] = frm.AccountName;
                        dr[13] = frm.CounterPartId;
                        dsMantenimientoPlanilla1.hr_department_accounting.Rows.Add(dr);
                        dsMantenimientoPlanilla1.hr_department_accounting.AcceptChanges();

                        break;
                    case TipoTransaccionPlanilla.Editar:

                        try
                        {
                            SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_hr_insert_accounting", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@provision", frm.Prov);
                            cmd.Parameters.AddWithValue("@patronal", frm.Patro);
                            if (frm.ConceptId == 0)
                                cmd.Parameters.AddWithValue("@concept_id", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@concept_id", frm.ConceptId);
                            if (frm.SalaryRuleId == 0)
                                cmd.Parameters.AddWithValue("@salary_rule_id", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@salary_rule_id", frm.SalaryRuleId);
                            if (frm.AccountId == 0)
                                cmd.Parameters.AddWithValue("@account_id", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@account_id", frm.AccountId);
                            if (frm.CounterPartId == 0)
                                cmd.Parameters.AddWithValue("@counterpart_id", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@counterpart_id", frm.CounterPartId);
                            cmd.Parameters.AddWithValue("@move", frm.Move);
                            cmd.Parameters.AddWithValue("@department_id", frm.IdDepartment);
                            cmd.Parameters.AddWithValue("@analytic_type", frm.AnalyticType);
                            cmd.Parameters.AddWithValue("@create_uid", usuario.UserId);
                            cmd.Parameters.AddWithValue("@create_date", dp.Now());
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Guardar = true;
                        }
                        catch (Exception EX)
                        {
                            Guardar = false;
                            CajaDialogo.Error(EX.Message);
                        }

                        if (Guardar)
                        {
                            LoadDetalleReglas(departamento_id);
                        }

                        break;
                    default:
                        break;
                }

        

               


                
            }
        }

        private void reposDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea eliminar este combinacion?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            var gridview = (GridView)gcReglas.FocusedView;
            var row = (dsMantenimientoPlanilla.hr_department_accountingRow)gridview.GetFocusedDataRow();

            bool Guardar = false;
            switch (transaccion_tipo)
            {
                case TipoTransaccionPlanilla.Nuevo:

                    try
                    {
                        gridview.DeleteRow(gridview.FocusedRowHandle);
                        dsMantenimientoPlanilla1.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }


                    break;
                case TipoTransaccionPlanilla.Editar:

                    try
                    {
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_delete_hr_accounting", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idDetalle", row.id);
                        cmd.Parameters.AddWithValue("@idDepartment", row.department_id);
                        cmd.ExecuteNonQuery();
                        Guardar = true;
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }

                    if (Guardar)
                    {
                        CajaDialogo.Information("Eliminado con Exito!");
                        LoadDetalleReglas(row.department_id);
                    }

                    break;
                default:
                    break;
            }
        }

        private void reposEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gcReglas.FocusedView;
            var row = (dsMantenimientoPlanilla.hr_department_accountingRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                
                if (row.Issalary_name_ruleNull())
                    row.salary_name_rule = "";

                if (row.Isaccount_idNull())
                    row.account_id = 0;

                if (row.Isconcept_idNull())
                    row.concept_id = 0;

                if (row.Issalary_rule_idNull())
                    row.salary_rule_id = 0;

                if (row.Isanalytic_typeNull())
                    row.analytic_type = "";

                frmPlanillaDepartmentDetail frm = new frmPlanillaDepartmentDetail(frmPlanillaDepartmentDetail.TipoOperacion.Update,
                    row.id, departamento_id, row.salary_rule_id, row.account_id, row.move, row.provision, row.patronal, row.analytic_type, usuario, row.concept_id, row.counterpart_id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool Guardar = false;

                    switch (transaccion_tipo)
                    {
                        case TipoTransaccionPlanilla.Nuevo:

                            DataRow dr = dsMantenimientoPlanilla1.hr_department_accounting.NewRow();
                            dr[0] = frm.IdDetalle;
                            dr[1] = frm.Prov;
                            dr[2] = frm.Patro;
                            dr[3] = frm.ConceptId;
                            dr[4] = frm.ConceptName;
                            dr[5] = frm.SalaryRuleId;
                            dr[6] = frm.SalaryRuleName;
                            dr[7] = frm.AccountId;
                            dr[8] = frm.AccountName;
                            dr[9] = frm.Move;
                            dr[10] = frm.IdDepartment;
                            dr[11] = frm.AnalyticType;
                            dr[12] = frm.AccountName;
                            dr[13] = frm.CounterPartId;
                            dsMantenimientoPlanilla1.hr_department_accounting.Rows.Add(dr);
                            dsMantenimientoPlanilla1.hr_department_accounting.AcceptChanges();

                            break;
                        case TipoTransaccionPlanilla.Editar:

                            try
                            {
                                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("spUpdateHrSalaryRuleCombination", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@provision", frm.Prov);
                                cmd.Parameters.AddWithValue("@patronal", frm.Patro);
                                if (frm.ConceptId == 0)
                                    cmd.Parameters.AddWithValue("@concept_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@concept_id", frm.ConceptId);
                                if (frm.SalaryRuleId == 0)
                                    cmd.Parameters.AddWithValue("@salary_rule_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@salary_rule_id", frm.SalaryRuleId);

                                if (frm.AccountId == 0)
                                    cmd.Parameters.AddWithValue("@account_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@account_id", frm.AccountId);
                                if (frm.CounterPartId == 0)
                                    cmd.Parameters.AddWithValue("@counterpart_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@counterpart_id", frm.CounterPartId);
                                cmd.Parameters.AddWithValue("@move", frm.Move);
                                cmd.Parameters.AddWithValue("@department_id", frm.IdDepartment);
                                cmd.Parameters.AddWithValue("@analytic_type", frm.AnalyticType);
                                //cmd.Parameters.AddWithValue("@supplier_id",);
                                cmd.Parameters.AddWithValue("@create_uid", usuario.UserId);
                                cmd.Parameters.AddWithValue("@create_date", dp.Now());
                                cmd.Parameters.AddWithValue("@IdDetalle", row.id);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Guardar = true;

                                if (Guardar)
                                {
                                    row.provision = frm.Prov;
                                    row.patronal = frm.Patro;
                                    row.concept_id = frm.ConceptId;
                                    row.concept_name = frm.ConceptName;
                                    row.salary_rule_id = frm.SalaryRuleId;
                                    row.salary_name_rule = frm.SalaryRuleName;
                                    row.account_id = frm.AccountId;
                                    row.account_name_code = frm.AccountName;
                                    row.move = frm.Move;
                                    row.department_id = frm.IdDepartment;
                                    row.analytic_type = frm.AnalyticType;
                                    row.counterpart_id = frm.CounterPartId;
                                }
                            }
                            catch (Exception EX)
                            {
                                Guardar = false;
                                CajaDialogo.Error(EX.Message);
                            }
                            break;
                        default:
                            break;
                    }

                    
                    
                }
            }
        }

        private void gvDetalleReglas_DoubleClick(object sender, EventArgs e)
        {
            var gridview = (GridView)gcReglas.FocusedView;
            var row = (dsMantenimientoPlanilla.hr_department_accountingRow)gridview.GetFocusedDataRow();

            if (row != null)
            {

                if (row.Issalary_name_ruleNull())
                    row.salary_name_rule = "";

                if (row.Isaccount_idNull())
                    row.account_id = 0;

                if (row.Isconcept_idNull())
                    row.concept_id = 0;

                if (row.Issalary_rule_idNull())
                    row.salary_rule_id = 0;

                if (row.Isanalytic_typeNull())
                    row.analytic_type = "";

                frmPlanillaDepartmentDetail frm = new frmPlanillaDepartmentDetail(frmPlanillaDepartmentDetail.TipoOperacion.Update,
                    row.id, departamento_id, row.salary_rule_id, row.account_id, row.move, row.provision, row.patronal, row.analytic_type, usuario, row.concept_id, row.counterpart_id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bool Guardar = false;

                    switch (transaccion_tipo)
                    {
                        case TipoTransaccionPlanilla.Nuevo:

                            DataRow dr = dsMantenimientoPlanilla1.hr_department_accounting.NewRow();
                            dr[0] = frm.IdDetalle;
                            dr[1] = frm.Prov;
                            dr[2] = frm.Patro;
                            dr[3] = frm.ConceptId;
                            dr[4] = frm.ConceptName;
                            dr[5] = frm.SalaryRuleId;
                            dr[6] = frm.SalaryRuleName;
                            dr[7] = frm.AccountId;
                            dr[8] = frm.AccountName;
                            dr[9] = frm.Move;
                            dr[10] = frm.IdDepartment;
                            dr[11] = frm.AnalyticType;
                            dr[12] = frm.AccountName;
                            dr[13] = frm.CounterPartId;
                            dsMantenimientoPlanilla1.hr_department_accounting.Rows.Add(dr);
                            dsMantenimientoPlanilla1.hr_department_accounting.AcceptChanges();
                           

                            break;
                        case TipoTransaccionPlanilla.Editar:

                            try
                            {
                                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("spUpdateHrSalaryRuleCombination", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@provision", frm.Prov);
                                cmd.Parameters.AddWithValue("@patronal", frm.Patro);
                                if (frm.ConceptId == 0)
                                    cmd.Parameters.AddWithValue("@concept_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@concept_id", frm.ConceptId);
                                if (frm.SalaryRuleId == 0)
                                    cmd.Parameters.AddWithValue("@salary_rule_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@salary_rule_id", frm.SalaryRuleId);

                                if (frm.AccountId == 0)
                                    cmd.Parameters.AddWithValue("@account_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@account_id", frm.AccountId);

                                if (frm.CounterPartId == 0)
                                    cmd.Parameters.AddWithValue("@counterpart_id", DBNull.Value);
                                else
                                    cmd.Parameters.AddWithValue("@counterpart_id", frm.CounterPartId);
                                cmd.Parameters.AddWithValue("@move", frm.Move);
                                cmd.Parameters.AddWithValue("@department_id", frm.IdDepartment);
                                cmd.Parameters.AddWithValue("@analytic_type", frm.AnalyticType);
                                //cmd.Parameters.AddWithValue("@supplier_id",);
                                cmd.Parameters.AddWithValue("@create_uid", usuario.UserId);
                                cmd.Parameters.AddWithValue("@create_date", dp.Now());
                                cmd.Parameters.AddWithValue("@IdDetalle", row.id);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Guardar = true;

                                if (Guardar)
                                {
                                    row.provision = frm.Prov;
                                    row.patronal = frm.Patro;
                                    row.concept_id = frm.ConceptId;
                                    row.concept_name = frm.ConceptName;
                                    row.salary_rule_id = frm.SalaryRuleId;
                                    row.salary_name_rule = frm.SalaryRuleName;
                                    row.account_id = frm.AccountId;
                                    row.account_name_code = frm.AccountName;
                                    row.move = frm.Move;
                                    row.department_id = frm.IdDepartment;
                                    row.analytic_type = frm.AnalyticType;
                                    row.counterpart_id = frm.CounterPartId;
                                }
                            }
                            catch (Exception EX)
                            {
                                Guardar = false;
                                CajaDialogo.Error(EX.Message);
                            }
                            break;
                        default:
                            break;


                    }

                    //if (Guardar)
                    //{
                    //    LoadDetalleReglas(departamento_id);
                    //}

                }
            }
        }
    }
}