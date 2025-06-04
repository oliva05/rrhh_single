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
    public partial class rptInformePlanillaGeneral : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInformePlanillaGeneral(int id_payslip_run)
        {
            InitializeComponent();
            LoadPlanillaGeneral(id_payslip_run);

            Payslip_Run payslip_Run = new Payslip_Run();

            payslip_Run.RecuperarRegistro(id_payslip_run);

            lblPayslip.Text = payslip_Run.Name;
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblRango.Text = $"Desde: {payslip_Run.DateStart.ToString("dd/MM/yyyy")} Hasta: {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";

            //tcTotalIngreso.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcSalarioBase.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcOtrosIngresos.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcVacaciones.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcTransporte.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tc8.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc9.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc10.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc11.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc12.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc13.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc14.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc15.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc16.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc17.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc18.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc19.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc20.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tc21.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda

            //Summay Group
            //tcG1.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG2.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG3.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG4.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG5.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG6.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG7.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG8.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG9.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG10.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG11.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG12.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG13.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG14.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG15.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG16.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG17.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG18.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            //tcG19.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda


            //Summay Group
            //tcT1.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT2.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT3.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT4.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT5.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT6.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT7.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT8.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT9.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT10.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT11.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT12.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT13.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT14.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT15.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT16.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT17.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT18.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell93.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda


        }

        private void LoadPlanillaGeneral(int payslip_run)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[usp_rpt_PlanillGeneral]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", payslip_run);

                dsReporte1.rptPlanillaGeneral_v2.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rptPlanillaGeneral_v2);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
