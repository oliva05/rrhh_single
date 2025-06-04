using ACS.Classes;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraWaitForm;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2010.Excel;
using LOSA.Calidad.LoteConfConsumo;
using LOSA.Clases;
using LOSA.Clases.Colaborador;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Planilla.ReporteBanco;
using LOSA.RRHH_Planilla.Planilla.Reportes;
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
using static LOSA.RRHH_Planilla.Planilla.frmPayslipRunCRUD;

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frm_hr_slips_employees : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        int PaySlipRunId;
        Payslip_Run PaySlipRunActual;
        DataOperations dp;
        ArrayList ListaNominas;

        ContextMenuStrip contextMenu;

        public frm_hr_slips_employees(UserLogin pUsuario, string pDescripcion, string pEstado, DateTime pdesde, DateTime phasta, int pPaySlipRunId)
        {
            InitializeComponent();
            dp = new DataOperations();
            PaySlipRunActual = new Payslip_Run();
            UsuarioLogeado = pUsuario;
            lblDescripcion.Text = pDescripcion;
            lblEstado.Text = pEstado;
            lblDesde.Text = string.Format("{0:dd-MMM-yyyy}", pdesde);
            lblHasta.Text = string.Format("{0:dd-MMM-yyyy}", phasta);
            PaySlipRunId = pPaySlipRunId;
            if (PaySlipRunActual.RecuperarRegistro(pPaySlipRunId))
            {
                    if (PaySlipRunActual.PayrollTypeId == 3)
                        cmdNavegarPlanilla.Visible = true;
                    else
                        cmdNavegarPlanilla.Visible = false;

                PlanillaTipoPlanilla tipoPlanilla_ = new PlanillaTipoPlanilla();
                if (tipoPlanilla_.RecuperaRegistro(PaySlipRunActual.PayrollTypeId))
                {
                    lblTipoPlanillaName.Text = tipoPlanilla_.Name;
                }
                else
                {
                    lblTipoPlanillaName.Text = "N/D";
                }
                

                LoadDetalleNominas();
                if (PaySlipRunActual.IdEstado == 1)
                    cmdAgregarEmpleado.Visible = true;
                else
                    cmdAgregarEmpleado.Visible = false;

                switch (PaySlipRunActual.IdEstado)
                {
                    case 1://Borrador
                        cmdArchivoBanco.Visible = false;
                        break;
                    case 2://Confirmado
                        //Habilita o deshabilita que el user pueda manipular el menu haciendo clic derecho sobre el header de una columna,
                        //para elegir columnas, ordenar, etc
                        gridView1.OptionsMenu.EnableColumnMenu = false;
                        cmdArchivoBanco.Visible = true;
                        //Permite mostrar o ocultar una columna, se utiliza colocando el string de FieldName que se define desde el dataset
                        gridView1.Columns["delete"].Visible = false; 


                        //Poner todas las columnas como ReadOnly = true
                        foreach (GridColumn column in gridView1.Columns)
                        {
                            switch (column.FieldName)
                            {
                                case "ver":
                                    column.OptionsColumn.ReadOnly = false;
                                    break;
                                case "seleccionar":
                                    column.OptionsColumn.ReadOnly = false;
                                    break;
                                default:
                                    column.OptionsColumn.ReadOnly = true;
                                    break;
                            }
                        }
                        break;
                    case 3://Anulado
                        cmdArchivoBanco.Visible = false;
                        break;
                    default:
                        cmdArchivoBanco.Visible = false;
                        break;
                }
            }
            FuncionMenuContextCopy();
        }

        public void LoadDetalleNominas()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.GetPlanillasEmpleadosListResume", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", PaySlipRunId);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                dsPlanillasTransaccion1.hr_payslip.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.hr_payslip);

                ListaNominas = new ArrayList();
                int i = 1;
                foreach(dsPlanillasTransaccion.hr_payslipRow row in dsPlanillasTransaccion1.hr_payslip)
                {
                    PaySlip run = new PaySlip();
                    run.LineaNum_Orden = i;
                    run.PaySlip_id = row.id;
                    ListaNominas.Add(run);
                    i++;
                }

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Lista de Planillas Emp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    //Customize export options
                    (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
                    XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
                    advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
                    advOptions.SheetName = "Exported from ALOSY";

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

        private void cmdVerDetalles__ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslipRow)gridView.GetFocusedDataRow();
            frm_hr_payslip_lines frm = new frm_hr_payslip_lines(this.UsuarioLogeado, lblDescripcion.Text, row.state, row.date_from, row.date_to,
                                                                row.id, row.barcode, row.name, ListaNominas, row.linea_num, this);
            frm.Show();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblDescripcion.Text);
            //MessageBox.Show("Texto copiado al portapapeles");
        }
        public void FuncionMenuContextCopy()
        {
            // Crear el ContextMenuStrip
            contextMenu = new ContextMenuStrip();
            var copyMenuItem = new ToolStripMenuItem("Copy");

            // Agregar el manejador de eventos para la opción de copiar
            copyMenuItem.Click += CopyMenuItem_Click;

            // Agregar la opción al ContextMenuStrip
            contextMenu.Items.Add(copyMenuItem);

            // Asignar el ContextMenuStrip al label
            lblDescripcion.ContextMenuStrip = contextMenu;

            // Agregar el label al formulario
            this.Controls.Add(lblDescripcion);
        }


        private void cmdAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //frmSearchEmployee frm = new frmSearchEmployee(frmSearchEmployee.TipoBusqueda.Empleados, this.PaySlipRunId);
            frmSearchMultItems frm = new frmSearchMultItems(frmSearchMultItems.TipoBusqueda.Empleados, this.PaySlipRunId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DialogResult r = CajaDialogo.Pregunta("Esta seguro de agregar estos empleados seleccionados a la nomina actual?");
                if (r != DialogResult.Yes)
                    return;

                List<ItemBusqueda> empleadosSeleccionados = new List<ItemBusqueda>();
                empleadosSeleccionados = frm.list;

                foreach (var empleados in empleadosSeleccionados)
                {
                    //CajaDialogo.Information(frm.ItemSeleccionado.ItemName);
                    DetalleContrato ContratoEmployee = new DetalleContrato();
                    if (ContratoEmployee.RecuperarRegistroPorEmpleadoId(empleados.id, 0))
                    {
                        object FechaFinContracto_;
                        if (ContratoEmployee.EndDate == null)
                            FechaFinContracto_ = null;
                        else
                            FechaFinContracto_ = ContratoEmployee.EndDate;


                        if (FechaFinContracto_ == null || Convert.ToDateTime(FechaFinContracto_) >= PaySlipRunActual.DateStart)
                        {
                            PlanillaTipoPlanilla TipoPlanillaActual = new PlanillaTipoPlanilla();
                            Funciones fn = new Funciones();

                            string MesName = fn.GetMonthName(PaySlipRunActual.DateStart, "spanish");

                            if (TipoPlanillaActual.RecuperaRegistro(PaySlipRunActual.PayrollTypeId))
                            {
                                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                                {
                                    connection.Open();

                                    SqlCommand command = connection.CreateCommand();
                                    SqlTransaction transaction;
                                    // Start a local transaction.
                                    transaction = connection.BeginTransaction("SampleTransaction_A");

                                    // Must assign both transaction object and connection
                                    // to Command object for a pending local transaction
                                    command.Connection = connection;
                                    command.Transaction = transaction;

                                    try
                                    {
                                        command.CommandText = "sp_InsertPayslip";
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.Clear();
                                        command.Parameters.AddWithValue("@struct_id", TipoPlanillaActual.Id_Struct_Related);
                                        command.Parameters.AddWithValue("@name", empleados.ItemName);
                                        command.Parameters.AddWithValue("@number", "Nómina salarial de " + empleados.ItemName + " para la " +
                                                                        PaySlipRunActual.Quincena.ToString() + " quincena de " +
                                                                        MesName + " - " + PaySlipRunActual.Anio.ToString());

                                        command.Parameters.AddWithValue("@employee_id", empleados.id);
                                        command.Parameters.AddWithValue("@date_from", PaySlipRunActual.DateStart);
                                        command.Parameters.AddWithValue("@date_to", PaySlipRunActual.DateEnd);
                                        command.Parameters.AddWithValue("@state", PaySlipRunActual.State);

                                        command.Parameters.AddWithValue("@company_id", 1);

                                        command.Parameters.AddWithValue("@paid", 0);
                                        command.Parameters.AddWithValue("@note", DBNull.Value);
                                        command.Parameters.AddWithValue("@contract_id", ContratoEmployee.ID);
                                        command.Parameters.AddWithValue("@payslip_run_id", PaySlipRunActual.Id);
                                        command.Parameters.AddWithValue("@create_uid", this.UsuarioLogeado.Id);
                                        command.Parameters.AddWithValue("@create_date", dp.Now());
                                        command.Parameters.AddWithValue("@desde_for_decimo", PaySlipRunActual.DateStart);
                                        command.Parameters.AddWithValue("@hasta_for_decimo", PaySlipRunActual.DateEnd);

                                        // Ejecutar el stored procedure
                                        command.ExecuteNonQuery();
                                        transaction.Commit();
                                        LoadDetalleNominas();
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
                            }// if (TipoPlanillaActual.RecuperaRegistro(PaySlipRunActual.PayrollTypeId))

                        }
                    }
                }
                
            }
        }

        private void cmdEliminarRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = CajaDialogo.Pregunta("Esta seguro de elminar esta linea?");
            if (result != DialogResult.Yes)
                return;

            var gridView1 = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslipRow)gridView1.GetFocusedDataRow();

            //Eliminar row del grid y la tabla
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[set_hr_paylisp_update_enable]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_payslip", row.id);
                cmd.Parameters.AddWithValue("@enable", 0);
                cmd.Parameters.AddWithValue("@state", "anulated");
                cmd.ExecuteNonQuery();

                con.Close();

                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            
        }

        private void cmdNavegarPlanilla_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslipRow)gridView.GetFocusedDataRow();
            frm_hr_payslip_lines frm = new frm_hr_payslip_lines(this.UsuarioLogeado, lblDescripcion.Text, row.state, row.date_from, row.date_to,
                                                                row.id, row.barcode, row.name, ListaNominas, row.linea_num, this);
            //if(frm.ShowDialog() == DialogResult.OK )
            //{
            //    LoadDetalleNominas();
            //}
            frm.Show();
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            if (PaySlipRunActual == null)
                PaySlipRunActual = new Payslip_Run();

            if (PaySlipRunActual.RecuperarRegistro(this.PaySlipRunId))
            {

                if (PaySlipRunActual.PayrollTypeId == 3)
                    cmdNavegarPlanilla.Visible = true;
                else
                    cmdNavegarPlanilla.Visible = false;


                LoadDetalleNominas();
                if (PaySlipRunActual.IdEstado == 1)
                    cmdAgregarEmpleado.Visible = true;
                else
                    cmdAgregarEmpleado.Visible = false;
            }
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            //Codigo Anterior
            #region Codigo Anterior
            //try
            //{
            //    // Contar las filas donde 'Seleccionar' es true
            //    int countSelection = dsPlanillasTransaccion1.hr_payslip.AsEnumerable()
            //                         .Count(row => row.Field<bool>("seleccionar"));

            //    if (countSelection==0)
            //    {
            //        CajaDialogo.Error("No ha seleccinado ningun empleado!");
            //        return;
            //    }


            //    int contador_vouchers = 0;       
            //    int struct_id = 0;

            //    rptVoucher voucher_main = null;
            //    rptVoucherHE voucher_HE_main = null;

            //    foreach (var item in dsPlanillasTransaccion1.hr_payslip)
            //    {
            //        if (item.seleccionar)
            //        {
            //            struct_id = item.struct_id;
            //            if (contador_vouchers==0)
            //            {
            //                if (item.struct_id==15)//Horas Extras
            //                {
            //                    voucher_HE_main = new rptVoucherHE(lblDescripcion.Text, item.employee_id, item.id);
            //                    voucher_HE_main.CreateDocument();
            //                    contador_vouchers++;
            //                }
            //                else
            //                {
            //                    voucher_main = new rptVoucher(lblDescripcion.Text,item.employee_id,item.id);
            //                    voucher_main.CreateDocument();
            //                    contador_vouchers++;
            //                }
            //            }
            //            else
            //            {
            //                if (item.struct_id == 15)//Horas Extras
            //                {
            //                    rptVoucherHE report_HE = new rptVoucherHE(lblDescripcion.Text, item.employee_id,item.id);
            //                    report_HE.CreateDocument();

            //                    if (voucher_HE_main != null)
            //                    {
            //                        voucher_HE_main.ModifyDocument(x => { x.AddPages(report_HE.Pages); });
            //                    }
            //                }
            //                else
            //                {
            //                    rptVoucher report = new rptVoucher(lblDescripcion.Text, item.employee_id, item.id);
            //                    report.CreateDocument();

            //                    if (voucher_main != null)
            //                    {
            //                        voucher_main.ModifyDocument(x => { x.AddPages(report.Pages); });
            //                    }
            //                }
            //            }

            //        }
            //    }



            //    if (struct_id==15)//HE
            //    {
            //        if (voucher_HE_main != null)
            //        {
            //            voucher_HE_main.ShowPrintMarginsWarning = false;

            //            using (ReportPrintTool printTool = new ReportPrintTool(voucher_HE_main))
            //            {
            //                printTool.ShowPreviewDialog();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (voucher_main != null)
            //        {
            //            voucher_main.ShowPrintMarginsWarning = false;

            //            using (ReportPrintTool printTool = new ReportPrintTool(voucher_main))
            //            {
            //                printTool.ShowPreviewDialog();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);

            //}
            #endregion

            try
            {
                // Contar las filas donde 'Seleccionar' es true
                //int countSelection = dsPlanillasTransaccion1.hr_payslip.AsEnumerable()
                //                     .Count(row => row.Field<bool>("seleccionar"));

                int countSelection = 0;
                foreach(dsPlanillasTransaccion.hr_payslipRow row in dsPlanillasTransaccion1.hr_payslip)
                {
                    if(row.seleccionar)
                    {
                        countSelection++;
                        break;
                    }
                }

                if (countSelection == 0)
                {
                    CajaDialogo.Error("No ha seleccinado ningun empleado!");
                    return;
                }


                int contador_vouchers = 0;
                int struct_id = 0;

                rptVoucher voucher_main = null;
                rptVoucherHE voucher_HE_main = null;
                rptVoucherDecimos voucher_decimos = null;

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

                if (PaySlipRunActual == null)
                {
                    CajaDialogo.Error("No se pudieron generar los vouchers! Por favor contacte a su departamento de IT.");
                    return;
                }

                switch (PaySlipRunActual.PayrollTypeId)
                {
                    case 1://1   Planilla General
                    case 2://2   Planilla Confidencial($)
                        foreach (var item in dsPlanillasTransaccion1.hr_payslip)
                        {
                            if (item.seleccionar)
                            {
                                if (contador_vouchers == 0)
                                {
                                    voucher_main = new rptVoucher(lblDescripcion.Text, item.employee_id, item.id);
                                    voucher_main.CreateDocument();
                                    contador_vouchers++;
                                }
                                else
                                {

                                    rptVoucher report = new rptVoucher(lblDescripcion.Text, item.employee_id, item.id);
                                    report.CreateDocument();

                                    if (voucher_main != null)
                                    {
                                        voucher_main.ModifyDocument(x => { x.AddPages(report.Pages); });
                                    }
                                }
                            }
                        }
                        if (voucher_main != null)
                        {
                            voucher_main.ShowPrintMarginsWarning = false;

                            using (ReportPrintTool printTool = new ReportPrintTool(voucher_main))
                            {
                                printTool.ShowPreviewDialog();
                            }
                        }
                        break;
                    case 3: //3   Planilla Horas Extras
                        foreach (var item in dsPlanillasTransaccion1.hr_payslip)
                        {
                            if (item.seleccionar)
                            {
                                if (contador_vouchers == 0)
                                {
                                    voucher_HE_main = new rptVoucherHE(lblDescripcion.Text, item.employee_id, item.id);
                                    voucher_HE_main.CreateDocument();
                                    contador_vouchers++;
                                }
                                else
                                {

                                    rptVoucherHE report_HE = new rptVoucherHE(lblDescripcion.Text, item.employee_id, item.id);
                                    report_HE.CreateDocument();

                                    if (voucher_HE_main != null)
                                    {
                                        voucher_HE_main.ModifyDocument(x => { x.AddPages(report_HE.Pages); });
                                    }
                                }
                            }
                        }

                        if (voucher_HE_main != null)
                        {
                            voucher_HE_main.ShowPrintMarginsWarning = false;

                            using (ReportPrintTool printTool = new ReportPrintTool(voucher_HE_main))
                            {
                                printTool.ShowPreviewDialog();
                            }
                        }
                        break;
                    default://Decimos
                        foreach (var item in dsPlanillasTransaccion1.hr_payslip)
                        {
                            if (item.seleccionar)
                            {
                                if (contador_vouchers == 0)
                                {
                                    voucher_decimos = new rptVoucherDecimos(lblDescripcion.Text, item.employee_id, item.id);
                                    voucher_decimos.CreateDocument();
                                    contador_vouchers++;
                                }
                                else
                                {

                                    rptVoucherDecimos report = new rptVoucherDecimos(lblDescripcion.Text, item.employee_id, item.id);
                                    report.CreateDocument();

                                    if (voucher_decimos != null)
                                    {
                                        voucher_decimos.ModifyDocument(x => { x.AddPages(report.Pages); });
                                    }
                                }
                            }
                        }
                        if (voucher_decimos != null)
                        {
                            voucher_decimos.ShowPrintMarginsWarning = false;

                            using (ReportPrintTool printTool = new ReportPrintTool(voucher_decimos))
                            {
                                printTool.ShowPreviewDialog();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);

            }
        }

        private void tsSeleccion_Toggled(object sender, EventArgs e)
        {
            if (tsSeleccion.IsOn)
            {
                foreach (var item in dsPlanillasTransaccion1.hr_payslip)
                {
                    item.seleccionar = true;
                }
            }
            else
            {
                foreach (var item in dsPlanillasTransaccion1.hr_payslip)
                {
                    item.seleccionar = false;
                }
            }
        }

        private void cmdArchivoBanco_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.hr_payslipRow)gridView.GetFocusedDataRow();
            if(this.PaySlipRunActual.IdEstado != 2)
            {
                dxErrorProvider1.SetError(cmdArchivoBanco, "Solo se puede generar el archivo de banco de planillas confirmadas!");
                return;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }

            frmArchivoBancoPlanilla frm = new frmArchivoBancoPlanilla(this.UsuarioLogeado, row.payslip_run_id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}