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
using LOSA.TransaccionesPT;

namespace LOSA.Reportes
{
    public partial class frmReporteGeneralProductoTermnado : DevExpress.XtraEditors.XtraForm
    {
       
        int Especie;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        public frmReporteGeneralProductoTermnado(UserLogin pUserLogin)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLogin;

            Especie = 2;
            get_inventario();
            dtDesde.DateTime = dp.Now().AddDays(-7);
            dtHasta.DateTime = dp.Now().AddDays(1);

            switch (pUserLogin.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Montacarga:
                    break;
                case GrupoUser.GrupoUsuario.Logistica:

                    switch (pUserLogin.idNivelAcceso(pUserLogin.Id,7))
                    {
                        case 1://Basic View
                            cmdAjuste.Visible = false;
                            break;
                        case 2://Basic No Autorization
                        case 3://Medium Autorization
                        case 4://Depth With Delta
                        case 5://Depth Without Delta
                            cmdAjuste.Visible = true;
                            break;
                        default:
                            cmdAjuste.Visible = false;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Calidad:
                    switch (pUserLogin.idNivelAcceso(pUserLogin.Id, 7))
                    {
                        case 1://Basic View                            
                        case 2://Basic No Autorization                           
                        case 3://Medium Autorization
                        case 4://Depth With Delta
                        case 5://Depth Without Delta
                        default:
                            cmdAjuste.Visible = false;
                            break;
                    }
                    break;
                case GrupoUser.GrupoUsuario.Administradores:
                    cmdAjuste.Visible = true;
                    break;
                default:
                    cmdAjuste.Visible = false;
                    break;
            }

        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void get_inventario()
        {
            try
            {
                string query = @"sp_get_kardex_pt_by_especieV2";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Especie", Especie);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario1.inventario_kardex.Clear();
                da.Fill(dsReportesInventario1.inventario_kardex);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void get_inventario_tarimas()
        {
            try
            {
                string query = @"[sp_get_inventario_tarimas_pt]";
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Especie", Especie);
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@all", tsAll.IsOn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportesInventario1.inventario_tarimas_pt.Clear();
                da.Fill(dsReportesInventario1.inventario_tarimas_pt);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0) // Camaron
            {
                Especie = 2;
            }
            if (tabPane1.SelectedPageIndex == 1)
            {
                Especie = 1;
            }
            if (tabPane1.SelectedPageIndex == 2)
            {

            }

            get_inventario();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (tabPane1.SelectedPageIndex)
                    {
                        case 0:
                            gridControl1.ExportToXls(dialog.FileName);
                            break;
                        case 1:
                            grd_inventario_Tilapia.ExportToXlsx(dialog.FileName);

                            break;
                        case 2:
                            grdPT.ExportToXlsx(dialog.FileName);

                            break;

                        default:
                            break;
                    }

                    //if (Especie == 2)
                    //{
                    //    gridControl1.ExportToXlsx(dialog.FileName);
                    //}
                    //else
                    //{
                    //    grd_inventario_Tilapia.ExportToXlsx(dialog.FileName);
                    //}
                   
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAjuste_Click(object sender, EventArgs e)
        {
            frmAjusteIKardexPT frm = new frmAjusteIKardexPT(UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Especie = 2;
                get_inventario();
            }
        }

        private void cmdRecargar_Click(object sender, EventArgs e)
        {
            get_inventario();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            get_inventario_tarimas();
        }
    }
}