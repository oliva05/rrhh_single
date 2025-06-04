using ACS.Classes;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DocumentFormat.OpenXml.Office2010.Excel;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Planilla.ReporteBanco
{
    public partial class frmArchivoBancoPlanilla : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int IdPayslipRun;
        Payslip_Run PaySlipActual;
        public frmArchivoBancoPlanilla(UserLogin pUsuarioLogeado, int pIdPayslipRun)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            IdPayslipRun = pIdPayslipRun;
            PaySlipActual = new Payslip_Run();
            if (PaySlipActual.RecuperarRegistro(pIdPayslipRun))
            {
                LoadDetalleEmpleadosNominaGeneral();
                ////id name
                ////1   Planilla General
                ////2   Planilla Confidencial($)
                ////3   Planilla Horas Extras
                ////4   Planilla décimo tercero(L.)
                ////5   Planilla décimo tercero($)
                ////6   Planilla décimo cuarto(L.)
                ////7   Planilla décimo cuarto($)
                ////8   Planilla provisiones(L.)
                ////9   Planilla provisiones($)
                //switch (PaySlipActual.PayrollTypeId)
                //{
                //    case 1:
                //    case 2:
                //    case 3:
                //    case 4:
                //    case 5:
                //    case 6:
                //    case 7:
                //    case 8:
                //    case 9:
                        
                //        break;
                //    default:

                //    break;
                //}
            }
        }

        void LoadDetalleEmpleadosNominaGeneral() 
        {
            if(PaySlipActual==null)
            {
                return;
            }

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[GetPlanillasEmpleadosListResume_ArchivoBanco]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", PaySlipActual.Id);
                dsReportesBancoPlanilla1.detalle_reporte_banco.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReportesBancoPlanilla1.detalle_reporte_banco);

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

        private void cmdExportar_Click(object sender, EventArgs e)
        {

            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Inventario PT Ovejita";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from Ovejita";

                    gridControl1.ExportToXlsx(path, advOptions);
                    // Open the created XLSX file with the default application.
                    Process.Start(path);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}