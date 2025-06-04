using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using LOSA.Clases.Planilla;

namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptInformePlanillaGeneralHE : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInformePlanillaGeneralHE(int id_payslip_run)
        {
            InitializeComponent();
            LoadPlanillaGeneralHE(id_payslip_run);

            Payslip_Run payslip_Run = new Payslip_Run();

            payslip_Run.RecuperarRegistro(id_payslip_run);

            lblPayslip.Text = payslip_Run.Name;
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblRango.Text = $"Desde: {payslip_Run.DateStart.ToString("dd/MM/yyyy")} Hasta: {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";


            tcTHE.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTHEGroup.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xeTHET.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcBASE.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
        }

        private void LoadPlanillaGeneralHE(int payslip_run)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[usp_rpt_planilla_general_HE]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", payslip_run);

                dsReporte1.rptPlanillaGeneralHE.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rptPlanillaGeneralHE);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}
