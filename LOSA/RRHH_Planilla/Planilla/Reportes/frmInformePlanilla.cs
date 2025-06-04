using ACS.Classes;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using LOSA.Clases.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    public partial class frmInformePlanilla : DevExpress.XtraEditors.XtraForm
    {
        string moneda = null;
        Payslip_Run payslip_Run = new Payslip_Run();

        public frmInformePlanilla()
        {
            InitializeComponent();
            LoadNomina();
            //LoadPlanillaGeneral(null);
            lblCodigo.Text = "";
            lblDesde.Text = "";
            lblHasta.Text = "";
            lblEstado.Text = "";
        }

        public frmInformePlanilla(int payslip_run_id)
        {
            InitializeComponent();
            LoadNomina();
 
           if ( payslip_Run.RecuperarRegistro(payslip_run_id))
            {
                lblCodigo.Text = payslip_Run.PayslipNumber;
                lblDesde.Text = payslip_Run.DateStart.ToString("dd/MM/yyyy");
                lblHasta.Text = payslip_Run.DateEnd.ToString("dd/MM/yyyy");
                lblEstado.Text = payslip_Run.State;

                slueNomina.EditValue = payslip_run_id;
            }

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

                dsReporte1.rptPlanillaGeneral.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rptPlanillaGeneral);

                con.Close();

               
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
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


        private void LoadNomina()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[uspGetPayslip_run_from_report]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@payslip_run_id", payslip_run);

                dsReporte1.payslip_lookup.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.payslip_lookup);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void slueNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (slueNomina.EditValue==null)
                {
                    CajaDialogo.Error("Debe seleccionar una planilla");
                    return;
                }
                else
                {

                    payslip_Run = new Payslip_Run();

                    payslip_Run.RecuperarRegistro((int)slueNomina.EditValue);

                    lblDesde.Text=payslip_Run.DateStart.ToString("dd/MM/yyyy");
                    lblHasta.Text=payslip_Run.DateEnd.ToString("dd/MM/yyyy");
                    lblEstado.Text = payslip_Run.State;
                    lblCodigo.Text = payslip_Run.PayslipNumber;
                    moneda = payslip_Run.CurrencyName;


                    if (payslip_Run.PayrollTypeId == 3)//HE
                    {
                        tpPlanillaGeneral.PageVisible = false;
                        tpDecimoTercero.PageVisible = false;
                        tpPlanillaHE.PageVisible = true;
                        LoadPlanillaGeneralHE((int)slueNomina.EditValue);

                        //Columnas
                        CambiarFormatoMonedaColumna(colsaldo_TPHE, payslip_Run.CurrencyName);

                        //SummaryGroup
                        CambiarFormatoMonedaGrouSummary(bgvHE.GroupSummary[2], payslip_Run.CurrencyName);


                    }
                    else
                    if (payslip_Run.PayrollTypeId == 4)//Decimo Tercero
                    {
                        tpDecimoTercero.PageVisible = true;
                        tpPlanillaHE.PageVisible = false;
                        tpPlanillaGeneral.PageVisible = false;
                        LoadPlanillaGeneralDecimos((int)slueNomina.EditValue);

                        //Columnas
                        CambiarFormatoMonedaColumna(colBANC2, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colNET, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colPRCOOP3, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colTCAVO, payslip_Run.CurrencyName);

                        //SummaryGroup
                        CambiarFormatoMonedaGrouSummary(gvDecimoTercero.GroupSummary[1], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvDecimoTercero.GroupSummary[2], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvDecimoTercero.GroupSummary[3], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvDecimoTercero.GroupSummary[4], payslip_Run.CurrencyName);
                    }
                    else
                    {
                        LoadPlanillaGeneral((int)slueNomina.EditValue);
                        tpPlanillaGeneral.PageVisible = true;
                        tpPlanillaHE.PageVisible = false;
                        tpDecimoTercero.PageVisible = false;


                        //ConfigurarFormatoGroupFooter();


                        CambiarFormatoMonedaColumna(colSalarioBase, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colvacaciones, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colOtrosIngresos, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colINCAPACIDADES, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colISR, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colPlanDental, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colPrestamoCoop, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colTotalEgresos, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colUSULA, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(coltransporte, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colBancos, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colIHSS, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colTotalIngresos, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colAhorroFijoCoop, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colCafeteria, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colAhorroRetCoop, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colOtrasDeduccionesCoop, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colSeguroMedico, payslip_Run.CurrencyName);
                        CambiarFormatoMonedaColumna(colTotalPagar, payslip_Run.CurrencyName);

                        //Group Summary
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[2], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[3], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[4], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[5], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[6], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[7], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[8], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[9], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[10], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[11], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[12], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[13], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[14], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[15], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[16], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[17], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[18], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[19], payslip_Run.CurrencyName);
                        CambiarFormatoMonedaGrouSummary(gvPlanilla.GroupSummary[20], payslip_Run.CurrencyName);

                    }
                   
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                if (payslip_Run.PayrollTypeId == 3)//HR
                {
                    if (bgvHE.RowCount < 1)
                    {
                        CajaDialogo.Error("Debe de generar el reporte primero.");
                        return;
                    }
                }
                else
                 if (payslip_Run.PayrollTypeId == 4)//Decimo Tercero
                {
                    if (gvDecimoTercero.RowCount < 1)
                    {
                        CajaDialogo.Error("Debe de generar el reporte primero.");
                        return;
                    }
                }
                else
                {
                    if (gvPlanilla.RowCount < 1)
                    {
                        CajaDialogo.Error("Debe de generar el reporte primero.");
                        return;
                    }
                }
                

                saveFileDialog1.Filter = "Excel File (.xlsx)|*.xlsx";
                saveFileDialog1.FilterIndex = 0;

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (payslip_Run.PayrollTypeId==3)//HR
                    {
                        bgvHE.ExportToXlsx(saveFileDialog1.FileName);
                    }
                    if (payslip_Run.PayrollTypeId == 4)//Decimo Tercero
                    {
                        gvDecimoTercero.ExportToXlsx(saveFileDialog1.FileName);
                    }
                    else
                    {
                        gvPlanilla.ExportToXlsx(saveFileDialog1.FileName);
                    }

                    // Verificar si el archivo fue creado
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        // Preguntar al usuario si desea abrir el archivo
                        var resultado = MessageBox.Show("¿Desea abrir el archivo exportado?", "Exportación exitosa",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el usuario elige "Sí", abrir el archivo
                        if (resultado == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo(saveFileDialog1.FileName) { UseShellExecute = true });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el archivo exportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (slueNomina.EditValue == null)
                {
                    CajaDialogo.Error("Debe seleccionar una planilla");
                    return;
                }

                if (payslip_Run.PayrollTypeId == 3)//HE
                {
                    rptInformePlanillaGeneralHE report = new rptInformePlanillaGeneralHE((int)slueNomina.EditValue);

                    // Deshabilitar la advertencia de márgenes
                    report.ShowPrintMarginsWarning = false;

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
                else if (payslip_Run.PayrollTypeId == 4)//Decimo tercero
                {
                    rptPlanillaGeneralDecimos report = new rptPlanillaGeneralDecimos((int)slueNomina.EditValue);

                    // Deshabilitar la advertencia de márgenes
                    report.ShowPrintMarginsWarning = false;

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
                else
                {
                    rptInformePlanillaGeneral report2 = new rptInformePlanillaGeneral((int)slueNomina.EditValue);
                    // Deshabilitar la advertencia de márgenes
                    report2.ShowPrintMarginsWarning = false;

                    using (ReportPrintTool printTool = new ReportPrintTool(report2))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CambiarFormatoMonedaColumna(GridColumn columna, string moneda)
        {
           
            columna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            columna.DisplayFormat.FormatString = payslip_Run.CurrencySymbol + "{0:N2}";
            columna.SummaryItem.DisplayFormat = payslip_Run.CurrencySymbol + "{0:N2}";
       
        }


        private void CambiarFormatoMonedaGrouSummary(GridSummaryItem Summary, string moneda)
        {

            Summary.DisplayFormat = payslip_Run.CurrencySymbol + "{0:N2}";

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

        //private void ConfigurarFormatoGroupFooter()
        //{
        //    gvPlanilla.CustomDrawFooterCell += gvPlanilla_CustomDrawFooterCell;
        //}


        //private void gvPlanilla_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        //{
        //    if (e.Column.FieldName == "SalarioBase") // Asegúrate de usar el nombre correcto de la columna
        //    {
        //        //// Supongamos que tienes un resumen que incluye información de moneda
        //        //string moneda = "USD"; // Ajusta según tu lógica para obtener la moneda

        //        // Verifica que el valor sea un decimal
        //        if (decimal.TryParse(e.Info.Value?.ToString(), out decimal monto))
        //        {
        //            // Aplica el formato basado en la moneda
        //            if (moneda == "USD")
        //            {
        //                e.Info.DisplayText = monto.ToString("C2", new CultureInfo("en-US")); // Formato para USD
        //                //e.Appearance.ForeColor = Color.DarkBlue; // Estilo opcional para USD
        //            }
        //            else if (moneda == "HNL")
        //            {
        //                e.Info.DisplayText = monto.ToString("C2", new CultureInfo("es-HN")); // Formato para HNL
        //                //e.Appearance.ForeColor = Color.DarkGreen; // Estilo opcional para HNL
        //            }

        //            //// Cambiar la fuente opcionalmente
        //            //e.Appearance.Font = new Font("Arial", 10, FontStyle.Bold);
        //        }
        //    }



        //}



    }
}