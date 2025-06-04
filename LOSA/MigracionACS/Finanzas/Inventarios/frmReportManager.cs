using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LOSA.Clases;
using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DocumentFormat.OpenXml.Wordprocessing;
using DevExpress.XtraSplashScreen;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.MigracionACS.Finanzas.Inventarios
{
    public partial class frmReportManager : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp = new DataOperations();
        string query = "";
 
        public frmReportManager(UserLogin pUserLogin )
        {
            InitializeComponent();
            UsuarioLogueado = pUserLogin;

            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            cargar_reportes();
            
        }

        private void cargar_reportes()
        {
            string query = @"sp_load_lista_report_manager";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dSRPT1.report_manager.Clear();
                adat.Fill(dSRPT1.report_manager);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
             
            
            if (grdSelectReport.EditValue == null)
            {
                CajaDialogo.Error("Seleccione un Reporte!");
                return;
            }


            if (Convert.ToInt32(grdSelectReport.EditValue) == 1003)
            {
                dtDesde.EditValue = "2018-01-01";
            }

            if (string.IsNullOrEmpty(dtDesde.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha");
                dtDesde.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dtHasta.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una Fecha");
                dtHasta.Focus();
                return;
            }
            
            switch (grdSelectReport.EditValue)
            {
                case 1:

                    query = @"sp_report_manager_reporte_dmc";

                    break;
                case 2:

                    query = @"sp_report_manager_oc_detalle_rubros_capitulos";
    
                    break;
                case 3:

                    query = @"[sp_reporte_de_gastos_integraciones]";
                    break;

                case 1003:
                    query = @"sp_get_inventario_por_stocks";

                    break;

                case 2003:
                    query = @"[sp_report_manager_reporte_dmcV2]";

                    break;

                default:
                    break;
            }

            try
            {
                DataTable tabla = new DataTable();

                SplashScreenManager.ShowForm(this, typeof(WaitFormEmployee), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Procesando");
                SplashScreenManager.Default.SetWaitFormDescription("Cargando informacion..");

                SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
                //tabla.Clear();
                tabla.Columns.Clear();
                cmd.CommandTimeout = 500000;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(tabla);
                GridView gridview = grdReporte.MainView as GridView;
                if (gridview != null)
                {
                    gridview.Columns.Clear(); 
                }
                grdReporte.DataSource = tabla;
                conn.Close();

                grid_autoajustar();

                SplashScreenManager.CloseForm();
               
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


            ////pnl_barra.Visible = true; 

            //BackgroundWorker bw = new BackgroundWorker();
            //bw.DoWork += bw_DoWork;
            //bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            //bw.RunWorkerAsync();

            //grdReporte.DataSource = null;
            ////grdv_data.Columns.Clear();
            
        }
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //pnl_barra.Visible = false;
            //btnGenerar.Enabled = btnExcel.Enabled = true;
            //grdReporte.DataSource = tabla;
            //grid_autoajustar();

            //generar_totales_grid();
            //GridViewOptionsBehavior.ReadOnly 
        }

        //void bw_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    cargar_grid();
        //    //Thread.Sleep(10000);
        //}

        //private void cargar_grid()
        //{
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
        //        cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);
        //        if (tabla == null)
        //            tabla = new DataTable();
        //        tabla.Clear();
        //        cmd.CommandTimeout = 500000;
        //        SqlDataAdapter adat = new SqlDataAdapter(cmd);
        //        adat.Fill(tabla);
        //        grdReporte.DataSource = tabla;
        //        conn.Close();

        //        grid_autoajustar();
        //        pnl_barra.Visible = false;

        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error(ex.Message);
        //    }
        //}

        void grid_autoajustar()
        {
            grdv_data.OptionsView.ColumnAutoWidth = false;
            grdv_data.BestFitColumns();
            GridViewInfo viewInfo = grdv_data.GetViewInfo() as GridViewInfo;
            if (viewInfo.ViewRects.ColumnTotalWidth < viewInfo.ViewRects.ColumnPanelWidth)
                grdv_data.OptionsView.ColumnAutoWidth = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdReporte.ExportToXlsx(dialog.FileName);
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
            switch (grdSelectReport.EditValue)
            {
                case 1: //Reporte DMC

                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    grdSelectReport.Text = null;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    dtDesde.DateTime = dtHasta.DateTime.AddDays(-30);

                    break;

                case 2: //Reporte de Ordenes de Compra por Detalle de Rubro y Capitulo
                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    grdSelectReport.Text = null;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    break;

                case 3: //Reporte de Gastos - Integraciones
                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;



                        default:
                            break;

                           
                    }

                    break;

                case 1003: //Reporte de Informe de Auditoria de Stocks MP y PT
                    labelControl1.Visible = true;
                    labelControl3.Visible = false;
                    dtDesde.Visible = false;
                    dtHasta.Visible = true;
                    break;

                case 2003:
                    switch (UsuarioLogueado.GrupoUsuario.GrupoUsuarioActivo)
                    {
                        case GrupoUser.GrupoUsuario.Logistica:
                            int idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 2://Basic No Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 3://Medium Autorization
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                                case 4://Depth With Delta
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }

                            break;
                        case GrupoUser.GrupoUsuario.Administradores:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                case 2://Basic No Autorization
                                case 3://Medium Autorization
                                case 4://Depth With Delta
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        case GrupoUser.GrupoUsuario.Contabilidad:
                            idnivel = UsuarioLogueado.idNivelAcceso(UsuarioLogueado.Id, 7);

                            switch (idnivel)
                            {
                                case 1://Basic View
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 2://Basic No Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 3://Medium Autorization
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 4://Depth With Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                case 5://Depth Without Delta
                                    labelControl1.Visible = true;
                                    labelControl3.Visible = true;
                                    dtDesde.Visible = true;
                                    dtHasta.Visible = true;
                                    break;
                                default:
                                    CajaDialogo.Error("No tiene permiso de Usar este Reporte.");
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    dtDesde.DateTime = dtHasta.DateTime.AddDays(-30);

                    break;
                default:
                    break;
            }

            
        }

        private void bar_BarraProgreso_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}