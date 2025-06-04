using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Globalization;
using LOSA.Clases.Planilla;

namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptNominaEmpleado : DevExpress.XtraReports.UI.XtraReport
    {
        PaySlip SlipActual;
        public rptNominaEmpleado(string pDescripcion, string pEstado,
                                    DateTime pdesde, DateTime phasta, int pSlipId, string pcodigo, string pname)
        {
            InitializeComponent();

            lblDescripcion.Text = pDescripcion;
            lblCodigo.Text = pcodigo;
            lblDesde.Text = pdesde.ToString("dd-MM-yyyy");
            lblHasta.Text = phasta.ToString("dd-MM-yyyy");
            lblNombre.Text = pname;
            lblEstado.Text = pEstado;
            SlipActual = new PaySlip();

            LoadDetalleNominas(pSlipId);
            // Configuración de cultura en español
            // Configuración de cultura en español
            //CultureInfo culturaEspañol = new CultureInfo("es-ES");

            // Asignar el formato de la fecha
            //xrPageInfo1.TextFormatString = "{0:dddd, dd 'de' MMMM 'del' yyyy}";

            // Establecer el formato de cultura para asegurar que se use en español
            //System.Threading.Thread.CurrentThread.CurrentCulture = culturaEspañol;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = culturaEspañol;

        }

        private void LoadDetalleNominas(int slipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                string Query = @"dbo.GetPlanillasEmpleadosLineas_Detalle";

                if (SlipActual.RecuperarRegistro(slipId))
                {
                    Payslip_Run RunObjectHeader = new Payslip_Run();
                    if(RunObjectHeader.RecuperarRegistro(SlipActual.PayslipRunId))
                    {
                        switch (RunObjectHeader.PayrollTypeId)
                        {
                            case 3://Horas Extras
                            Query = @"[dbo].[GetPlanillasEmpleadosLineas_Detalle_HE]";
                                break;
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                                Query = @"[dbo].[GetPlanillasEmpleadosLineas_Detalle_Decimo]";
                                break;
                            default:
                                Query = @"dbo.GetPlanillasEmpleadosLineas_Detalle";
                                break;
                        }
                    }                    
                }

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", slipId);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsReporte1.hr_payslip_lines.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.hr_payslip_lines);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

    }
}
