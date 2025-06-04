using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using LOSA.Clases.Planilla;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using LOSA.RRHH_Planilla.Planilla.Reportes;
using System;
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

namespace LOSA.RRHH_Planilla.Planilla
{
    public partial class frmHomePlanillas : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmHomePlanillas(UserLogin pUsuarioLogeado)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuarioLogeado;
            DataOperations dp = new DataOperations();
            dtDesde.EditValue = dp.Now().AddDays(-16);
            dtHasta.EditValue = dp.Now();
            LoadDatos();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void LoadDatos()
        {
            if (dtDesde.EditValue == null || dtHasta.EditValue == null)
                return;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[get_paylisp_run_list_v2]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                cmd.Parameters.AddWithValue("@ver_canceladas", tggMostrarCanceladas.IsOn);
                dsPlanillasTransaccion1.payslip_run.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsPlanillasTransaccion1.payslip_run);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Nueva version
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                string path = "Lista de Planillas";

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

        private void cmdNuevaPlanilla_Click(object sender, EventArgs e)
        {
            frmPayslipRunCRUD frm = new frmPayslipRunCRUD(this.UsuarioLogeado, frmPayslipRunCRUD.TipoTransaccionSQL.Insert, 0);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdVerPlanillasEmployees_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.payslip_runRow)gridView.GetFocusedDataRow();
            frm_hr_slips_employees frm = new frm_hr_slips_employees(this.UsuarioLogeado, row.name, row.state, row.date_start, row.date_end, row.id);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadDatos();
            //}
            frm.MdiParent = this.MdiParent;
            frm.Show();   
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdOpcioensPlanilla_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.payslip_runRow)gridView.GetFocusedDataRow();
            Payslip_Run payslip_Run = new Payslip_Run();

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    
                    //Validamos el estado
                    
                    if (payslip_Run.RecuperarRegistro(row.id))
                    {
                        if(payslip_Run.IdEstado == 2)//Confirmado
                        {
                            CajaDialogo.Error("No se puede modificar una Planilla que ya ha sido confimada!");
                            return;
                        }
                        else
                        {
                            frmCambiarEstadoPlanillas frm = new frmCambiarEstadoPlanillas(this.UsuarioLogeado, row.id_estado, row.id);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                row.id_estado = frm.IdEstadoNew;
                                row.state = frm.EstadoNameNew;
                                LoadDatos();
                            }
                        }
                    }
                    break;
                case 5://Depth Without Delta
                    break;
                default:
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(108))
                {

                    if (payslip_Run.RecuperarRegistro(row.id))
                    {
                        if (payslip_Run.IdEstado == 2)//Confirmado
                        {
                            CajaDialogo.Error("No se puede modificar una Planilla que ya ha sido confimada!");
                            return;
                        }
                        else
                        {
                            frmCambiarEstadoPlanillas frm = new frmCambiarEstadoPlanillas(this.UsuarioLogeado, row.id_estado, row.id);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                row.id_estado = frm.IdEstadoNew;
                                row.state = frm.EstadoNameNew;
                                LoadDatos();
                            }
                        }
                    }
                }
                else
                {
                    CajaDialogo.Error("No tiene privilegios para esta función! Permiso Requerido #108");
                }
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //frmPayslipRunCRUD
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillasTransaccion.payslip_runRow)gridView.GetFocusedDataRow();
            frmPayslipRunCRUD frm = new frmPayslipRunCRUD(this.UsuarioLogeado, frmPayslipRunCRUD.TipoTransaccionSQL.Update, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdAddPlanilla_Click(object sender, EventArgs e)
        {
            frmPayslipRunCRUD frm = new frmPayslipRunCRUD(this.UsuarioLogeado, frmPayslipRunCRUD.TipoTransaccionSQL.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDatos();
            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private void btnPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsPlanillasTransaccion.payslip_runRow)gridView1.GetFocusedDataRow();

                if (row.payroll_type_id == 3)//HE
                {
                    rptInformePlanillaGeneralHE report = new rptInformePlanillaGeneralHE(row.id);

                    using (ReportPrintTool printTool = new ReportPrintTool(report))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
                else
                if (row.payroll_type_id == 4)//Decimos
                {
                    rptPlanillaGeneralDecimos report2 = new rptPlanillaGeneralDecimos(row.id);

                    using (ReportPrintTool printTool = new ReportPrintTool(report2))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
                else
                {
                    rptInformePlanillaGeneral report3 = new rptInformePlanillaGeneral(row.id);

                    using (ReportPrintTool printTool = new ReportPrintTool(report3))
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

        private void btnExcel_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsPlanillasTransaccion.payslip_runRow)gridView1.GetFocusedDataRow();

                frmInformePlanilla frm = new frmInformePlanilla(row.id);

                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}