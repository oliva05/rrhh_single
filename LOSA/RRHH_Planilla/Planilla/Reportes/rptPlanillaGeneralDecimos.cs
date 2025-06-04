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
    public partial class rptPlanillaGeneralDecimos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPlanillaGeneralDecimos(int payslip_run_id)
        {
            InitializeComponent();
            LoadPlanillaGeneralDecimos(payslip_run_id);

            Payslip_Run payslip_Run = new Payslip_Run();

            payslip_Run.RecuperarRegistro(payslip_run_id);

            lblPayslip.Text = payslip_Run.Name;
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblRango.Text = $"Desde: {payslip_Run.DateStart.ToString("dd/MM/yyyy")} Hasta: {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";

            tcTCAV.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcPRCOOP.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcNET.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcBANC2.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda

            tcgTCAVO.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcgPRCOOP.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcgNET.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcgBANC2.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda

            tctTCAVO.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tctPRCOOP.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tctNET.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tctBANC2.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda

        }

        private void LoadPlanillaGeneralDecimos(int payslip_run)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[usp_rpt_planilla_general_decimos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", payslip_run);

                dsReporte1.rptPlanillaGeneralDecimos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rptPlanillaGeneralDecimos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}
