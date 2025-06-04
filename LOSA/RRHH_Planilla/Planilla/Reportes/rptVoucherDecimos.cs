using ACS.Classes;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
using LOSA.Logistica;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptVoucherDecimos : DevExpress.XtraReports.UI.XtraReport
    {
        int slipId = 0;

        public rptVoucherDecimos(string descripcion_payslip,int employee_id, int pSlipId)
        {
            InitializeComponent();
            HrEmployee empleadoActual = new HrEmployee();
            Payslip_Run payslip_Run = new Payslip_Run();
            PlanillaTipoPlanilla TipoActual = new PlanillaTipoPlanilla();

            slipId = pSlipId;

            empleadoActual.RecuperarDatosPorId(employee_id);
            if (payslip_Run.RecuperarRegistroBySlipId(pSlipId))
            {
                if (TipoActual.RecuperaRegistro(payslip_Run.PayrollTypeId))
                {
                    lblPayRoll1.Text = lblPayRoll2.Text = TipoActual.Name;
                }
            }



            lblPlanilla1.Text = descripcion_payslip;
            lblIFechaImpresion1.Text = "Impreso el: " + DateTime.Now.ToString("dd/MM/yyyy");
            lblPlanilla2.Text = descripcion_payslip;
            lblIFechaImpresion2.Text = "Impreso el: " + DateTime.Now.ToString("dd/MM/yyyy");

            PaySlip slipActual = new PaySlip();
            if(slipActual.RecuperarRegistro(pSlipId))
            {
                rtColaborador.Html = "<font face='Segoe UI' size='2'>"
                + $"<b>Colaborador:</b> {slipActual.EmployeeName}";

                rtCodigo.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Código:</b> {slipActual.Codigo}";

                rtCargo.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Cargo:</b> {slipActual.Puesto}";

                rtDepartamento.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Departamento:</b> {slipActual.Departamento}";

                rtTurno.Html = "<font face='Segoe UI' size='2'>"
                  + $"<b>Turno:</b> {slipActual.Turno}";

                rtFechaPago.Html = "<font face='Segoe UI' size='2'>"
                  + $"<b>Fecha Pago:</b> {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";


                //COPIA
                rtColaborador2.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Colaborador:</b> {slipActual.EmployeeName}";

                rtCodigo2.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Código:</b> {slipActual.Codigo}";

                rtCargo2.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Cargo:</b> {slipActual.Puesto}";

                rtDepartamento2.Html = "<font face='Segoe UI' size='2'>"
                   + $"<b>Departamento:</b> {slipActual.Puesto}";

                rtTurno2.Html = "<font face='Segoe UI' size='2'>"
                  + $"<b>Turno:</b> {slipActual.Turno}";

                rtFechaPago2.Html = "<font face='Segoe UI' size='2'>"
                  + $"<b>Fecha Pago:</b> {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";
            }
            


        }

        private void LoadDetalleNominasIngresos(int SlipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetPlanillasEmpleadosLineas_Detalle_Ingresos_decimos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);

                dsReporte1.rpt_voucher_detail_ingresos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rpt_voucher_detail_ingresos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleNominasEgresos(int SlipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[GetPlanillasEmpleadosLineas_Detalle_EgresosDecimos_RPT]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);

                dsReporte1.rpt_voucher_detail_egresos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rpt_voucher_detail_egresos);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            LoadDetalleNominasIngresos(slipId);
            LoadDetalleNominasEgresos(slipId);

            xrTableIngresos.Rows.Clear();
            xrTableEgresos.Rows.Clear();

            Font fuenteSinBold = new System.Drawing.Font("Segoe UI", 9);
            Font fuenteConBold = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            // Llenar la tabla de ingresos
            foreach (var ingreso in  dsReporte1.rpt_voucher_detail_ingresos)
            {
                //348.0001
                //DETALLE

                XRTableRow filaIngreso = new XRTableRow();
                
                if (ingreso.code == "GROSS")
                { 
                    filaIngreso.Cells.Add(new XRTableCell { 
                        Text = ingreso.name,
                        Font = fuenteConBold,
                        WidthF = 166,
                    });                
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = ingreso.name,
                        Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }


                    //CANTIDAD
                filaIngreso.Cells.Add(new XRTableCell
                {
                    Text = ingreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,

                });

                //TOTAL
                int widthColumnTotal_ingresos = 120;
                if (ingreso.code == "DLB" || ingreso.code == "DINC" || ingreso.code == "DFT" || ingreso.code == "DVAC" || ingreso.code == "PVAC")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                if (ingreso.code == "GROSS")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }

                xrTableIngresos.Rows.Add(filaIngreso);
            }



            // Llenar la tabla de egresos
            foreach (var engreso in dsReporte1.rpt_voucher_detail_egresos)
            {
                XRTableRow filaIngreso = new XRTableRow();

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteConBold,
                        WidthF = 166,
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }
                //CANTIDAD
                filaIngreso.Cells.Add(new XRTableCell
                {
                    Text = engreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,
                });

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }                    
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }

                xrTableEgresos.Rows.Add(filaIngreso);
            }
        }

        private void PageHeader_BeforePrint(object sender, CancelEventArgs e)
        {
            LoadDetalleNominasIngresos(slipId);
            LoadDetalleNominasEgresos(slipId);

            xrTableIngresos.Rows.Clear();
            xrTableEgresos.Rows.Clear();

            Font fuenteSinBold = new System.Drawing.Font("Segoe UI", 9);
            Font fuenteConBold = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            // Llenar la tabla de ingresos
            foreach (var ingreso in dsReporte1.rpt_voucher_detail_ingresos)
            {
                //348.0001
                //DETALLE

                XRTableRow filaIngreso = new XRTableRow();

                if (ingreso.code == "GROSS")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = ingreso.name,
                        Font = fuenteConBold,
                        WidthF = 166,
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = ingreso.name,
                        Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }


                //CANTIDAD
                filaIngreso.Cells.Add(new XRTableCell
                {
                    Text = ingreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,

                });

                //TOTAL
                int widthColumnTotal_ingresos = 120;
                if (ingreso.code == "DLB" || ingreso.code == "DINC" || ingreso.code == "DFT" || ingreso.code == "DVAC" || ingreso.code == "PVAC")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                if (ingreso.code == "GROSS")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }

                xrTableIngresos.Rows.Add(filaIngreso);
            }



            // Llenar la tabla de egresos
            foreach (var engreso in dsReporte1.rpt_voucher_detail_egresos)
            {
                XRTableRow filaIngreso = new XRTableRow();

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteConBold,
                        WidthF = 166,
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }
                //CANTIDAD
                filaIngreso.Cells.Add(new XRTableCell
                {
                    Text = engreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,
                });

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }
                else
                {
                    filaIngreso.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }

                xrTableEgresos.Rows.Add(filaIngreso);
            }




            //COPIA
            xrTableIngresos2.Rows.Clear();
            xrTableEgresos2.Rows.Clear();


            // Llenar la tabla de ingresos
            foreach (var ingreso in dsReporte1.rpt_voucher_detail_ingresos)
            {
                //348.0001
                //DETALLE

                XRTableRow filaIngreso2 = new XRTableRow();

                if (ingreso.code == "GROSS")
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = ingreso.name,
                        Font = fuenteConBold,
                        WidthF = 166,
                    });
                }
                else
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = ingreso.name,
                        Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }


                //CANTIDAD
                filaIngreso2.Cells.Add(new XRTableCell
                {
                    Text = ingreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,

                });

                //TOTAL
                int widthColumnTotal_ingresos = 120;
                if (ingreso.code == "DLB" || ingreso.code == "DINC" || ingreso.code == "DFT" || ingreso.code == "DVAC" || ingreso.code == "PVAC")
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                if (ingreso.code == "GROSS")
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }
                else
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = $"{ingreso.moneda}{ingreso.amount.ToString("N2")}",
                        Font = Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                        //WidthF = widthColumnTotal_ingresos,
                    });
                }

                xrTableIngresos2.Rows.Add(filaIngreso2);
            }



            // Llenar la tabla de egresos
            foreach (var engreso in dsReporte1.rpt_voucher_detail_egresos)
            {
                XRTableRow filaIngreso2 = new XRTableRow();

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteConBold,
                        WidthF = 166,
                    });
                }
                else
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = engreso.name,
                        Font = Font = fuenteSinBold,
                        WidthF = 166,
                    });
                }
                //CANTIDAD
                filaIngreso2.Cells.Add(new XRTableCell
                {
                    Text = engreso.quantity.ToString("N1"),
                    Font = fuenteSinBold,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                    WidthF = 80,
                });

                if (engreso.code == "TEGRESO" || engreso.code == "NET")
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = Font = fuenteConBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }
                else
                {
                    filaIngreso2.Cells.Add(new XRTableCell
                    {
                        Text = engreso.moneda + engreso.amount.ToString("N2"),
                        Font = fuenteSinBold,
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
                    });
                }

                xrTableEgresos2.Rows.Add(filaIngreso2);
            }
        }
    }
}
