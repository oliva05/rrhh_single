using ACS.Classes;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Huellas;
using LOSA.Clases;
using LOSA.Presupuesto;
using LOSA.RRHH_Planilla.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado
{
    public partial class frm_Hr_Employee_List : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        public frm_Hr_Employee_List(UserLogin pUsuario)
        {
            InitializeComponent();
            UsuarioLogeado = pUsuario;
            dp = new DataOperations();
            LoadEmpleados();
        }

        private void LoadEmpleados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.get_home_hr_employee_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ver_inactivos", tggVerInactivos.IsOn);
                dsMaestroEmpleados1.empleados_list.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.empleados_list);

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

        int pInterval = 0;
        void Splash()
        {
            //c# open a splash screen form
            SplashForm frm = new SplashForm(pInterval);
            frm.Font = new Font("Time New Romans", 7);
            //frm.AppName = "Demo";
            //frm.Icon = Properties.Resources.app;//Load icon from resource
            frm.ShowIcon = true;
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }

        private void cmdVerEmpleado_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Ver empleado 
            var gridView = (GridView)gridControl1.FocusedView;
            var row = (dsMaestroEmpleados.empleados_listRow)gridView.GetFocusedDataRow();
            frmHr_EmployeeCRUD.TipoTransaccion TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;

            bool accesoprevio = false;

            //splashScreenManager1.ShowWaitForm();
            //Thread.Sleep(2000);
            decimal inter = Convert.ToDecimal(1);//Segundos

            pInterval = dp.ValidateNumberInt32(inter);

            Thread threadSplash = new Thread(new ThreadStart(Splash));
            threadSplash.Start();

            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
                    frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
                        //splashScreenManager1.CloseWaitForm();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmpleados();
                    }
                    break;
                case 5://Depth Without Delta
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
                default:
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(106))//Acceso privilegiado para la edicion de datos confidenciales de RRHH
                {
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
                    frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
                        //splashScreenManager1.CloseWaitForm();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmpleados();
                    }
                }
                else
                {
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                }
            }
            threadSplash.Abort();

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //Ver empleado 
            //var gridView = (GridView)gridControl1.FocusedView;
            //var row = (dsMaestroEmpleados.empleados_listRow)gridView.GetFocusedDataRow();
            frmHr_EmployeeCRUD.TipoTransaccion TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;

            bool accesoprevio = false;
            int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            switch (idNivel)
            {
                case 1://Basic View
                case 2://Basic No Autorization
                case 3://Medium Autorization
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
                case 4://Depth With Delta
                    accesoprevio = true;
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Insert;
                    frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, string.Empty, TipoTransaccionSet);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmpleados();
                    }
                    break;
                case 5://Depth Without Delta
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
                default:
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    break;
            }

            if (!accesoprevio)
            {
                if (UsuarioLogeado.ValidarNivelPermisos(106))//Acceso privilegiado para la edicion de datos confidenciales de RRHH
                {
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Insert;
                    frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, string.Empty, TipoTransaccionSet);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmpleados();
                    }
                }
                else
                {
                    TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                }
            }

            //frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadEmpleados();
            //}
        }

        private void tggVerInactivos_Toggled(object sender, EventArgs e)
        {
            LoadEmpleados();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    var row = (dsMaestroEmpleados.empleados_listRow)gridView1.GetFocusedDataRow();

            //    if (row != null)
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}


            // Verificar si el clic fue doble
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                try
                {
                    decimal inter = Convert.ToDecimal(0.6);//Segundos

                    pInterval = dp.ValidateNumberInt32(inter);

                    Thread threadSplash = new Thread(new ThreadStart(Splash));
                    threadSplash.Start();


                    //Ver empleado 
                    var gridView = (GridView)gridControl1.FocusedView;
                    var row = (dsMaestroEmpleados.empleados_listRow)gridView.GetFocusedDataRow();
                    frmHr_EmployeeCRUD.TipoTransaccion TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                    //splashScreenManager1.ShowWaitForm();
                    //Thread.Sleep(1000);

                    bool accesoprevio = false;
                    int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
                    switch (idNivel)
                    {
                        case 1://Basic View
                        case 2://Basic No Autorization
                        case 3://Medium Autorization
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                            break;
                        case 4://Depth With Delta
                            accesoprevio = true;
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
                            frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
                            //splashScreenManager1.CloseWaitForm();
                            //bool transaccion_finalizada = false;
                            //splashScreenManager1.ShowWaitForm();
                            //Thread.Sleep(5000);

                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadEmpleados();
                            }
                            break;
                        case 5://Depth Without Delta
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                            break;
                        default:
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                            break;
                    }

                    if (!accesoprevio)
                    {
                        if (UsuarioLogeado.ValidarNivelPermisos(106))//Acceso privilegiado para la edicion de datos confidenciales de RRHH
                        {
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
                            //splashScreenManager1.ShowWaitForm();
                            //Thread.Sleep(5000);
                            frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
                            //splashScreenManager1.CloseWaitForm();

                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadEmpleados();
                            }
                        }
                        else
                        {
                            TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
                        }
                    }

                    threadSplash.Abort();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //try
            //{
            //    decimal inter = Convert.ToDecimal(0.6);//Segundos

            //    pInterval = dp.ValidateNumberInt32(inter);

            //    Thread threadSplash = new Thread(new ThreadStart(Splash));
            //    threadSplash.Start();

            //    // Verificar si el clic fue doble
            //    if (e.Clicks == 2 && e.Button == MouseButtons.Left)
            //    {
            //        //Ver empleado 
            //        var gridView = (GridView)gridControl1.FocusedView;
            //        var row = (dsMaestroEmpleados.empleados_listRow)gridView.GetFocusedDataRow();
            //        frmHr_EmployeeCRUD.TipoTransaccion TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
            //        //splashScreenManager1.ShowWaitForm();
            //        //Thread.Sleep(1000);

            //        bool accesoprevio = false;
            //        int idNivel = UsuarioLogeado.idNivelAcceso(UsuarioLogeado.UserId, 7);//7 = ALOSY
            //        switch (idNivel)
            //        {
            //            case 1://Basic View
            //            case 2://Basic No Autorization
            //            case 3://Medium Autorization
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
            //                break;
            //            case 4://Depth With Delta
            //                accesoprevio = true;
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
            //                frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
            //                //splashScreenManager1.CloseWaitForm();
            //                //bool transaccion_finalizada = false;
            //                //splashScreenManager1.ShowWaitForm();
            //                //Thread.Sleep(5000);

            //                if (frm.ShowDialog() == DialogResult.OK)
            //                {
            //                    LoadEmpleados();
            //                }
            //                break;
            //            case 5://Depth Without Delta
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
            //                break;
            //            default:
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
            //                break;
            //        }

            //        if (!accesoprevio)
            //        {
            //            if (UsuarioLogeado.ValidarNivelPermisos(106))//Acceso privilegiado para la edicion de datos confidenciales de RRHH
            //            {
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.Update;
            //                //splashScreenManager1.ShowWaitForm();
            //                //Thread.Sleep(5000);
            //                frmHr_EmployeeCRUD frm = new frmHr_EmployeeCRUD(this.UsuarioLogeado, row.barcode, TipoTransaccionSet);
            //                //splashScreenManager1.CloseWaitForm();

            //                if (frm.ShowDialog() == DialogResult.OK)
            //                {
            //                    LoadEmpleados();
            //                }
            //            }
            //            else
            //            {
            //                TipoTransaccionSet = frmHr_EmployeeCRUD.TipoTransaccion.View;
            //            }
            //        }
            //    }
            //    threadSplash.Abort();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
            
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }
    }
}