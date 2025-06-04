using ACS.Classes;
using DevExpress.CodeParser;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Office2010.Excel;
using Huellas;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.Mantenimientos;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmPayslipRunCRUD : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        Payslip_Run PayslipRunActual;
        PlanillaTipoPlanilla TipoPlanillaActual;
        Currency CurrencyActual;
        DateTime Now_var;
        public enum TipoTransaccionSQL
        {
            Insert = 1, Update = 2
        }

        TipoTransaccionSQL TipoTransaccionActual;
        public frmPayslipRunCRUD(UserLogin pUsuarioLogeado, TipoTransaccionSQL pTipoTransaccion, int pIdPayslipRun)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;   
            dp = new DataOperations();
            TipoPlanillaActual = new PlanillaTipoPlanilla();
            CurrencyActual = new Currency();
            TipoTransaccionActual = pTipoTransaccion;

            LoadEstados();
            LoadTiposPlanillas();
            LoadQuincenas();

            PayslipRunActual = new Payslip_Run();
            DateTime Now_ = dp.Now();

           
            switch (TipoTransaccionActual)
            {
                case TipoTransaccionSQL.Insert:
                    lblTitulo.Text = "Nueva Planilla";
                    gleEstado.EditValue = 1;
                    gleTipoPlanilla.Enabled = true;

                    if (Now_.Year >= 2000)
                        Now_var = Now_;
                    else
                        Now_var = DateTime.Now;

                    if (Now_.Day > 15)
                    {
                        //La del 30
                        DateTime i = new DateTime(Now_.Year, Now_.Month, 16);
                        int SigMes = Now_.Month + 1;
                        
                        DateTime f;
                        if (SigMes > 12)
                        {
                            f = new DateTime(Now_.Year + 1, 1, 1);
                            SigMes = 1;
                        }
                        else
                        {
                            f = new DateTime(Now_.Year, SigMes, 1);
                        }

                        f = f.AddDays(-1);

                        dtDesde.EditValue = i;
                        dtHasta.EditValue = f;
                        gleQuincena.EditValue = 2;
                    }
                    else
                    {
                        //La del 15
                        DateTime i = new DateTime(Now_.Year, Now_.Month, 1);
                        DateTime f = new DateTime(Now_.Year, Now_.Month, 15);

                        dtDesde.EditValue = i;
                        dtHasta.EditValue = f;
                        gleQuincena.EditValue = 1;
                    }
                    break;
                case TipoTransaccionSQL.Update:
                    lblTitulo.Text = "Gestión de Planilla";
                    gleTipoPlanilla.Enabled = false;

                    if (pIdPayslipRun > 0)
                    {
                        if (PayslipRunActual.RecuperarRegistro(pIdPayslipRun))
                        {
                            //Asignar los campos.
                            txtCodigoPlanilla.Text = PayslipRunActual.PayslipNumber;
                            txtDescripcionPaySlipRun.Text = PayslipRunActual.Name;
                            CurrencyActual = new Currency();
                            CurrencyActual.GetCurrencyById(PayslipRunActual.CurrencyId);
                            CurrencyActual.Rate = PayslipRunActual.Rate;    
                            
                            if(PayslipRunActual.IdEstado ==0)
                                gleEstado.EditValue = 1;
                            else
                                gleEstado.EditValue = PayslipRunActual.IdEstado;

                            dtDesde.DateTime = PayslipRunActual.DateStart;
                            dtHasta.DateTime = PayslipRunActual.DateEnd;
                            spinEditCantidadDias.EditValue = PayslipRunActual.NumberOfDays;
                            
                            if(PayslipRunActual.PayrollTypeId>0)
                                gleTipoPlanilla.EditValue = PayslipRunActual.PayrollTypeId;

                            txtMonedaName.Text = PayslipRunActual.CurrencyName;
                            txtTasaDeCambio.Text = string.Format("{0:###,##0.0000}", PayslipRunActual.Rate);

                            if (!string.IsNullOrEmpty(PayslipRunActual.Observation))
                                txtComentarios.Text = PayslipRunActual.Observation;

                            if (PayslipRunActual.TotalInTransference > 0)
                                txtMontoTotal.Text = string.Format("{0:###,##0.0000}", PayslipRunActual.TotalInTransference);

                            LoadDetallePayslips();

                            // Posibles Estados
                            //id  descripcion
                            //1   Borrador
                            //2   Confirmada
                            //3   Cancelada
                            if (PayslipRunActual.IdEstado == 2) //Confirmada, vamos a bloquear ediciones.
                            {
                                //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna,
                                //para elegir columnas, ordenar, etc
                                gridView3.OptionsMenu.EnableColumnMenu = false;

                                //Ocultamos la columna Eliminar para dar un efecto visual de que no se permite la eliminacion de nominas.
                                gridView3.Columns["delete"].Visible = false;
                                foreach (GridColumn column in gridView3.Columns)
                                {
                                    column.OptionsColumn.ReadOnly = true;
                                }

                                cmdGuardar.Visible = false;
                                gleTipoPlanilla.Enabled = false;    
                                txtDescripcionPaySlipRun.Enabled = false;
                                gleEstado.Enabled = false;
                                dtDesde.Enabled = false;
                                dtHasta.Enabled = false;
                                gleQuincena.Enabled = false;
                                spinEditCantidadDias.Enabled = false;
                                txtMonedaName.Enabled = false;
                                txtTasaDeCambio.Enabled = false;
                                txtComentarios.Enabled = false;
                                txtMontoTotal.Enabled = false;

                            }
                        }
                    }
                    break;
            }
            
        }

        private void LoadDetallePayslips()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[get_hr_paylisps_generates]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_payslip_run", PayslipRunActual.Id);
                dsPlanillasTransaccion1.employees_for_payroll_related.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.employees_for_payroll_related);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
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
                dsPlanillasTransaccion1.tipo_planilla_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.tipo_planilla_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadEstados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.sp_get_estados_payslip_run", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsPlanillasTransaccion1.estados_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.estados_list);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadQuincenas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand(@"select 1 as id,
                                                           'Primera' as descripcion
                                                    union all
                                                    select 2 as id,
                                                           'Segunda' as descripcion", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsPlanillasTransaccion1.quincena.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.quincena);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        int pInterval = 0;
        // c# splash screen forms
        void Splash()
        {
            //c# open a splash screen form
            SplashForm frm = new SplashForm(pInterval);
            frm.Font = new Font("Time New Romans", 7);
            //frm.AppName = "Demo";
            //frm.Icon = Properties.Resources.app;//Load icon from resource
            frm.ShowIcon = true;
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionPaySlipRun.Text))
            {
                CajaDialogo.Error("Es necesario una descripcion para crear una nueva planilla!");
                return;
            }

            decimal tasaCambio = dp.ValidateNumberDecimal(txtTasaDeCambio.Text);
            if (tasaCambio<=0)
            {
                CajaDialogo.Error("Es necesario definir una tasa de cambio!");
                return;
            }
            else
            {
                CurrencyActual.Rate = tasaCambio;
            }

            if(CurrencyActual == null)
            {
                CajaDialogo.Error("Es necesario definir una tasa de cambio!");
                return;
            }
            else
            {
                if(CurrencyActual.Id ==0 )
                {
                    CajaDialogo.Error("Es necesario definir una tasa de cambio!");
                    return;
                }
            }

            decimal cant_dias = dp.ValidateNumberDecimal(spinEditCantidadDias.EditValue);
            if (cant_dias <= 0)
            {
                CajaDialogo.Error("Es necesario definir una cantidad de dias!");
                return;
            }

            if (string.IsNullOrEmpty(gleTipoPlanilla.Text))
            {
                CajaDialogo.Error("Es necesario seleccionar el tipo de planilla!");
                return;
            }

            switch (gleTipoPlanilla.EditValue)
            {
                case 1:
                case 2:
                    if (string.IsNullOrEmpty(dtFechaCorteCafe.Text))
                    {
                        CajaDialogo.Error("Debe seleccionar Fecha de Corte de Cafeteria!");
                        dtFechaCorteCafe.Focus();
                        return;
                    }
                    break;

                default:
                    break;
            }

            int id_quincena_mes = dp.ValidateNumberInt32(gleQuincena.EditValue);
            if(id_quincena_mes <= 0)
            {
                CajaDialogo.Error("Es necesario seleccionar la quincena que se va a ingresar en la nomina!");
                return;
            }
            decimal inter = Convert.ToDecimal(0.85 * dsPlanillasTransaccion1.employees_for_payroll_related.Count);

            pInterval = dp.ValidateNumberInt32(inter);

            Thread threadSplash = new Thread(new ThreadStart(Splash));
            threadSplash.Start();

            switch (TipoTransaccionActual)
            {
                case TipoTransaccionSQL.Insert:
                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;

                        // Start a local transaction.
                        transaction = connection.BeginTransaction("SampleTransaction");

                        // Must assign both transaction object and connection
                        // to Command object for a pending local transaction
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            //Header 
                            command.CommandText = "[sp_InsertPayslipRunV2]";
                            command.CommandType = CommandType.StoredProcedure;
                            DateTime Now = dp.Now();

                            command.Parameters.AddWithValue("@name", txtDescripcionPaySlipRun.Text);
                            command.Parameters.AddWithValue("@state", gleEstado.Text);
                            command.Parameters.AddWithValue("@date_start", dtDesde.EditValue);
                            command.Parameters.AddWithValue("@date_end", dtHasta.EditValue);
                            command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@create_date", Now);
                            command.Parameters.AddWithValue("@number_of_days", spinEditCantidadDias.EditValue);
                            
                            int vPayRollType = dp.ValidateNumberInt32(gleTipoPlanilla.EditValue);
                            command.Parameters.AddWithValue("@payroll_type_id", vPayRollType);
                            command.Parameters.AddWithValue("@total_in_transference", 0);
                            command.Parameters.AddWithValue("@rate", CurrencyActual.Rate);
                            command.Parameters.AddWithValue("@currency_id", CurrencyActual.Id);

                            if(string.IsNullOrEmpty(txtComentarios.Text))
                                command.Parameters.AddWithValue("@observation", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@observation", txtComentarios.Text);

                            int quincena_anual = ((dtDesde.DateTime.Month - 1) * 2) + dp.ValidateNumberInt32(gleQuincena.EditValue);

                            command.Parameters.AddWithValue("@anio", Now.Year);
                            command.Parameters.AddWithValue("@quincena", quincena_anual);
                            command.Parameters.AddWithValue("@id_estado", gleEstado.EditValue);
                            command.Parameters.AddWithValue("@quincena_mes", gleQuincena.EditValue);
                            

                            //id name
                            //1   Planilla General
                            //2   Planilla Confidencial($)
                            //3   Planilla Horas Extras
                            //4   Planilla décimo tercero(L.)
                            //5   Planilla décimo tercero($)
                            //6   Planilla décimo cuarto(L.)
                            //7   Planilla décimo cuarto($)
                            //8   Planilla provisiones(L.)
                            //9   Planilla provisiones($)
                            switch (vPayRollType)
                            {
                                case 1:
                                case 2:
                                    command.Parameters.AddWithValue("@fecha_corte_cafeteria", dtFechaCorteCafe.DateTime);
                                    command.Parameters.AddWithValue("@calculation_date_start", DBNull.Value);
                                    command.Parameters.AddWithValue("@calculation_date_end", DBNull.Value);
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                    command.Parameters.AddWithValue("@calculation_date_start", dtDesde_Decimo.DateTime);
                                    command.Parameters.AddWithValue("@calculation_date_end", dtHasta_Decimo.DateTime);
                                    command.Parameters.AddWithValue("@fecha_corte_cafeteria", DBNull.Value);
                                    break;
                                default:
                                    command.Parameters.AddWithValue("@calculation_date_start", DBNull.Value);
                                    command.Parameters.AddWithValue("@calculation_date_end", DBNull.Value);
                                    command.Parameters.AddWithValue("@fecha_corte_cafeteria", DBNull.Value);
                                    break;

                            }
                            

                            // Ejecutar el stored procedure
                            int IdPayslipRun = dp.ValidateNumberInt32(command.ExecuteScalar());
                            Funciones fn = new Funciones();

                            string MesName = fn.GetMonthName(Now, "spanish");

                            //Nomina por empleado
                            foreach (dsPlanillasTransaccion.employees_for_payroll_relatedRow row in dsPlanillasTransaccion1.employees_for_payroll_related)
                            {
                                if (row.seleccionado && row.employee_id > 0 && row.id_contrato > 0)
                                {
                                    object FechaFinContracto_;
                                    if (row.Isfecha_finNull())
                                        FechaFinContracto_ = null;
                                    else
                                        FechaFinContracto_ = row.fecha_fin;


                                    if (FechaFinContracto_ == null || Convert.ToDateTime(FechaFinContracto_) >= dtDesde.DateTime)
                                    {
                                        command.CommandText = "sp_InsertPayslip";
                                        command.Parameters.Clear();
                                        command.Parameters.AddWithValue("@struct_id", TipoPlanillaActual.Id_Struct_Related);
                                        command.Parameters.AddWithValue("@name", row.employeeName);
                                        command.Parameters.AddWithValue("@number", "Nómina salarial de " + row.employeeName + " para la " +
                                                                         gleQuincena.Text + " quincena de " + MesName + " - " + Now.Year.ToString());

                                        command.Parameters.AddWithValue("@employee_id", row.employee_id);
                                        command.Parameters.AddWithValue("@date_from", dtDesde.DateTime);
                                        command.Parameters.AddWithValue("@date_to", dtHasta.DateTime);
                                        command.Parameters.AddWithValue("@state", gleEstado.Text);

                                        if (row.company_id == 0)
                                            command.Parameters.AddWithValue("@company_id", DBNull.Value);
                                        else
                                            command.Parameters.AddWithValue("@company_id", row.company_id);

                                        command.Parameters.AddWithValue("@paid", 0);
                                        command.Parameters.AddWithValue("@note", DBNull.Value);
                                        command.Parameters.AddWithValue("@contract_id", row.id_contrato);
                                        command.Parameters.AddWithValue("@payslip_run_id", IdPayslipRun);
                                        command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                                        command.Parameters.AddWithValue("@create_date", Now);

                                        //Validamos el tipo de planilla para definir algunos valores
                                        int IdTipoPlanilla = dp.ValidateNumberInt32(gleTipoPlanilla.EditValue);
                                        switch (IdTipoPlanilla)
                                        {
                                            case 4://4 Decimo 13vo L
                                            case 5://5 Decimo 13vo USD
                                            case 6://6 Decimo 14vo L
                                            case 7://7 Decimo 14vo USD
                                                command.Parameters.AddWithValue("@desde_for_decimo", dtDesde_Decimo.DateTime);
                                                command.Parameters.AddWithValue("@hasta_for_decimo", dtHasta_Decimo.DateTime);
                                                break;
                                            default:
                                                command.Parameters.AddWithValue("@desde_for_decimo", DBNull.Value);
                                                command.Parameters.AddWithValue("@hasta_for_decimo", DBNull.Value);
                                                break;
                                        }


                                        // Ejecutar el stored procedure
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Attempt to commit the transaction.
                            transaction.Commit();

                            //CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                                CajaDialogo.Error(" Error 1: " + ex.Message);
                            }
                            catch (Exception ex2)
                            {
                                CajaDialogo.Error(ex2.Message + " Error 1: " + ex.Message);
                            }
                        }
                    }
                    break;
                case TipoTransaccionSQL.Update:
                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                    {
                        connection.Open();

                        SqlCommand command = connection.CreateCommand();
                        SqlTransaction transaction;

                        // Start a local transaction.
                        transaction = connection.BeginTransaction("SampleTransaction");

                        // Must assign both transaction object and connection
                        // to Command object for a pending local transaction
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            //Header 
                            command.CommandText = "[dbo].[sp_UpdatePayslipRun]";
                            command.CommandType = CommandType.StoredProcedure;
                            DateTime Now = dp.Now();

                            command.Parameters.AddWithValue("@payslip_run_id", PayslipRunActual.Id);
                            command.Parameters.AddWithValue("@name", txtDescripcionPaySlipRun.Text);
                            command.Parameters.AddWithValue("@state", gleEstado.Text);
                            command.Parameters.AddWithValue("@date_start", dtDesde.EditValue);
                            command.Parameters.AddWithValue("@date_end", dtHasta.EditValue);
                            command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                            command.Parameters.AddWithValue("@create_date", Now);
                            command.Parameters.AddWithValue("@number_of_days", spinEditCantidadDias.EditValue);
                            command.Parameters.AddWithValue("@payroll_type_id", gleTipoPlanilla.EditValue);
                            command.Parameters.AddWithValue("@total_in_transference", 0);
                            command.Parameters.AddWithValue("@rate", CurrencyActual.Rate);
                            command.Parameters.AddWithValue("@currency_id", CurrencyActual.Id);

                            if (string.IsNullOrEmpty(txtComentarios.Text))
                                command.Parameters.AddWithValue("@observation", DBNull.Value);
                            else
                                command.Parameters.AddWithValue("@observation", txtComentarios.Text);

                            int quincena_anual = ((dtDesde.DateTime.Month - 1) * 2) + dp.ValidateNumberInt32(gleQuincena.EditValue);

                            command.Parameters.AddWithValue("@anio", Now.Year);
                            command.Parameters.AddWithValue("@quincena", quincena_anual);
                            command.Parameters.AddWithValue("@id_estado", gleEstado.EditValue);
                            command.Parameters.AddWithValue("@quincena_mes", gleQuincena.EditValue);

                            // Ejecutar el stored procedure
                            int IdPayslipRun = PayslipRunActual.Id;
                            command.ExecuteNonQuery();
                            Funciones fn = new Funciones();

                            //string MesName = fn.GetMonthName(Now, "spanish");

                            //Nomina por empleado
                            //foreach (dsPlanillasTransaccion.employees_for_payroll_relatedRow row in dsPlanillasTransaccion1.employees_for_payroll_related)
                            //{
                            //    if (row.employee_id > 0)
                            //    {
                            //        command.CommandText = "sp_InsertPayslip";
                            //        command.Parameters.Clear();
                            //        command.Parameters.AddWithValue("@struct_id", TipoPlanillaActual.Id_Struct_Related);
                            //        command.Parameters.AddWithValue("@name", row.employeeName);
                            //        command.Parameters.AddWithValue("@number", "Nómina salarial de " + row.employeeName + " para la " +
                            //                                         gleQuincena.Text + " quincena de " + MesName + " - " + Now.Year.ToString());

                            //        command.Parameters.AddWithValue("@employee_id", row.employee_id);
                            //        command.Parameters.AddWithValue("@date_from", dtDesde.DateTime);
                            //        command.Parameters.AddWithValue("@date_to", dtHasta.DateTime);
                            //        command.Parameters.AddWithValue("@state", gleEstado.Text);

                            //        if (row.company_id == 0)
                            //            command.Parameters.AddWithValue("@company_id", DBNull.Value);
                            //        else
                            //            command.Parameters.AddWithValue("@company_id", row.company_id);

                            //        command.Parameters.AddWithValue("@paid", 0);
                            //        command.Parameters.AddWithValue("@note", DBNull.Value);
                            //        command.Parameters.AddWithValue("@contract_id", row.id_contrato);
                            //        command.Parameters.AddWithValue("@payslip_run_id", IdPayslipRun);
                            //        command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                            //        command.Parameters.AddWithValue("@create_date", Now);

                            //        // Ejecutar el stored procedure
                            //        command.ExecuteNonQuery();
                            //    }
                            //}


                            // Attempt to commit the transaction.
                            transaction.Commit();

                            //CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // Attempt to roll back the transaction.
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                CajaDialogo.Error(ex2.Message + " Error 1: " + ex.Message);
                            }
                        }
                    }
                    break;
            }
            //Thread.Sleep(TiempoP);
            //frmProceso.Close();
            threadSplash.Join();
        }

        private void gleTipoPlanilla_EditValueChanged(object sender, EventArgs e)
        {
            switch (TipoTransaccionActual)
            {
                case TipoTransaccionSQL.Insert:
                    PlanillaTipoPlanilla tipoPlanillaObject = new PlanillaTipoPlanilla();
                    int IdTipoPlanilla = dp.ValidateNumberInt32(gleTipoPlanilla.EditValue);
                    if (IdTipoPlanilla > 0)
                    {
                        if (tipoPlanillaObject.RecuperaRegistro(IdTipoPlanilla))
                        {
                            TipoPlanillaActual = tipoPlanillaObject;
                            txtMonedaName.Text = tipoPlanillaObject.CurrencyName;
                            CurrencyActual.GetCurrencyById(tipoPlanillaObject.CurrencyID);
                            LoadEmpleadosSegunPlanillaSeleccionada(tipoPlanillaObject.ID);

                            if (TipoPlanillaActual.CurrencyID == 44)
                            {
                                txtTasaDeCambio.Text = "1.00";
                            }
                            else
                            {
                                switch (TipoPlanillaActual.CurrencyID)
                                {
                                    case 2:
                                        decimal TasaCambio = GetTasaCambioUSD(Now_var);
                                        txtTasaDeCambio.Text = string.Format("{0:#,##0.0000}", TasaCambio);
                                        break;
                                    default:
                                        txtTasaDeCambio.Text = "0.00";
                                    break;
                                }
                            }
                            switch(IdTipoPlanilla)
                            {
                                case 1://Planilla General
                                case 2://Planilla Confidencial $
                                    lblDescripcionDecimo.Text = "Fecha de Corte Cafeteria";
                                    lbl_dt_desde_decimo.Text = "Hasta:";
                                    lblDescripcionDecimo.Visible = true;
                                    lbl_dt_hasta_decimo.Visible = true;
                                    dtFechaCorteCafe.Visible = true;
                                    dtFechaCorteCafe.DateTime = dp.Now();
                                    lbl_dt_desde_decimo.Visible = true;
                                    lbl_dt_hasta_decimo.Visible = false; 
                                    dtHasta_Decimo.Visible = false;
                                    break;
                                    
                                case 4://4 Decimo 13vo L
                                case 5://5 Decimo 13vo USD
                                case 6://6 Decimo 14vo L
                                case 7://7 Decimo 14vo USD
                                    spinEditCantidadDias.Value = 360;
                                    dtDesde.EditValueChanged -= new EventHandler(dtDesde_EditValueChanged);
                                    dtFechaCorteCafe.Visible = false;
                                    lblDescripcionDecimo.Visible = true;
                                    lblDescripcionDecimo.Text = "Rango de Fechas para el cálculo de salario promedio";
                                    lbl_dt_desde_decimo.Visible = lbl_dt_hasta_decimo.Visible = true;
                                    dtDesde_Decimo.Visible = dtHasta_Decimo.Visible = true;
                                    lbl_dt_desde_decimo.Text = "Desde:"; 
                                    break;
                                default:
                                    TimeSpan diferencia = dtHasta.DateTime.AddDays(1) - dtDesde.DateTime;
                                    dtDesde.EditValueChanged += new EventHandler(dtDesde_EditValueChanged);

                                    // Obtener la diferencia en días
                                    spinEditCantidadDias.Value = (int)diferencia.TotalDays;

                                    lblDescripcionDecimo.Visible = false;
                                    lbl_dt_desde_decimo.Visible = lbl_dt_hasta_decimo.Visible = false;
                                    dtDesde_Decimo.Visible = dtHasta_Decimo.Visible = false;
                                    dtFechaCorteCafe.Visible = false;
                                    break;
                            }
                        }
                    }
                    break;
                case TipoTransaccionSQL.Update:

                    break;
            }
                    
        }

        private decimal GetTasaCambioUSD(DateTime Now)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.GetTasaCambioUSD_byDay", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", Now);
                valor = Convert.ToDecimal(cmd.ExecuteScalar()); 
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }

        private void LoadEmpleadosSegunPlanillaSeleccionada(int iD)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[get_employee_from_hr_payroll_type_rel_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo_planilla_id", iD);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                dsPlanillasTransaccion1.employees_for_payroll_related.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.employees_for_payroll_related);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = CajaDialogo.Pregunta("Esta seguro de elminar esta linea?");
            if (result != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.employees_for_payroll_relatedRow)gridView1.GetFocusedDataRow();
            switch (TipoTransaccionActual)
            {
                case TipoTransaccionSQL.Insert:
                    //Eliminar row del grid
                    try
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        dsPlanillasTransaccion1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
                case TipoTransaccionSQL.Update:
                    //Eliminar row del grid y la tabla
                    //try
                    //{
                    //    DataOperations dp = new DataOperations();
                    //    SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                    //    con.Open();

                    //    SqlCommand cmd = new SqlCommand("[dbo].[set_hr_paylisp_update_enable]", con);
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.Parameters.AddWithValue("@id_payslip", row.id_payslip);
                    //    cmd.Parameters.AddWithValue("@enable", 0);
                    //    cmd.Parameters.AddWithValue("@state", "anulated");
                    //    cmd.ExecuteNonQuery();  

                    //    con.Close();

                    //    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    //}
                    //catch (Exception ec)
                    //{
                    //    CajaDialogo.Error(ec.Message);
                    //}

                    //Eliminar row del grid y la tabla
                    try
                    {
                        DataOperations dp = new DataOperations();
                        SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("[dbo].[set_hr_paylisp_update_enable]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_payslip", row.id_payslip);
                        cmd.Parameters.AddWithValue("@enable", 0);
                        cmd.Parameters.AddWithValue("@state", "anulated");
                        cmd.ExecuteNonQuery();

                        con.Close();

                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        dsPlanillasTransaccion1.AcceptChanges();
                    }
                    catch (Exception ec)
                    {
                        CajaDialogo.Error(ec.Message);
                    }
                    break;
            }
        }

        private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach(dsPlanillasTransaccion.employees_for_payroll_relatedRow row in dsPlanillasTransaccion1.employees_for_payroll_related)
            {
                row.seleccionado = chkSeleccionarTodos.Checked;
            }
        }

        private void dtDesde_EditValueChanged(object sender, EventArgs e)
        {
            int IdTipoPlanilla = dp.ValidateNumberInt32(gleTipoPlanilla.EditValue);
            if (IdTipoPlanilla < 4)
            {
                dtDesde.EditValueChanged -= new EventHandler(dtDesde_EditValueChanged);
                DateTime Now_ = dtDesde.DateTime;
                if (Now_.Day > 15)
                {
                    //La del 30
                    DateTime i = new DateTime(Now_.Year, Now_.Month, 16);
                    int SigMes = Now_.Month + 1;
                    int anio = Now_.Year;
                    if(SigMes > 12)
                    {
                        SigMes = 1;
                        anio += 1;

                    }
                    DateTime f = new DateTime(anio, SigMes, 1);
                    f = f.AddDays(-1);

                    //dtDesde.EditValue = i;
                    dtHasta.EditValue = f;
                    gleQuincena.EditValue = 2;
                }
                else
                {
                    //La del 15
                    DateTime i = new DateTime(Now_.Year, Now_.Month, 1);
                    DateTime f = new DateTime(Now_.Year, Now_.Month, 15);

                    //dtDesde.EditValue = i;
                    dtHasta.EditValue = f;
                    gleQuincena.EditValue = 1;
                }
                dtDesde.EditValueChanged += new EventHandler(dtDesde_EditValueChanged);
            }
        }

        private void dtHasta_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTasaDeCambio_EditValueChanged(object sender, EventArgs e)
        {
            if(CurrencyActual!= null)
            {
                CurrencyActual.Rate = dp.ValidateNumberDecimal( txtTasaDeCambio.EditValue);
            }
        }

        private void dtDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtHasta.Focus();
            }
        }

        private void dtHasta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gleQuincena.Focus();
            }
        }

        private void gleQuincena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditCantidadDias.Focus();
            }
        }

        private void spinEditCantidadDias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // gleTipoPlanilla.Focus();
               txtMonedaName.Focus();
            }
        }

        private void gleTipoPlanilla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtMonedaName.Focus();
               txtDescripcionPaySlipRun.Focus();
            }
        }

        private void txtMonedaName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTasaDeCambio.Focus();
            }
        }

        private void txtTasaDeCambio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComentarios.Focus();
            }
        }

        private void txtComentarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdGuardar.Focus();
            }
        }
    }
}