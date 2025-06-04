using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.Xls;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Compras.Reportes
{
    public partial class frmReportesMain : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        DataTable dtDatos;

        public frmReportesMain(UserLogin userLogin)
        {
            InitializeComponent();
            dtFechaDesde.DateTime = dp.Now().AddDays(-30);
            dtFechaHasta.DateTime = dp.Now().AddDays(1);
            LoadData();
            grdReportes.EditValue = 1;
        }

        private void LoadData()
        {
            string query = "sp_cm_get_rpt_main";
            SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adat = new SqlDataAdapter(cmd);
            adat.Fill(dsComprasRptsMain1.rpts_main);
            conn.Close();

        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(grdReportes.Text))
            {
                CajaDialogo.Error("Debe seleccionar un Reporte.");
                return;
            }

            string query = string.Empty;

            switch (grdReportes.EditValue)
            {
                case 1:
                    query = "sp_cm_oc_validacion_exoneracion";
                    break;

                //case 2:
                //    query = "sp_cm_oc_validacion_exoneracion";
                //    break;

                default:
                    //query = "sp_cm_oc_validacion_exoneracion";
                    break;
            }

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@finicial", dtFechaDesde.DateTime);
                cmd.Parameters.AddWithValue("@ffinal",dtFechaHasta.DateTime);
                dtDatos = new DataTable();
                dtDatos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dtDatos);

                grdOCExonerada.DataSource = dtDatos;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnExcelAuto_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            switch (grdReportes.EditValue)
            {
                case 1:
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        grdOCExonerada.ExportToXlsx(dialog.FileName);
                    }
                    break;
                default:
                    break;
            }

            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdReportes_EditValueChanged(object sender, EventArgs e)
        {
            switch (grdReportes.EditValue)
            {
                case 1://Ordenes de Compra Exonerada
                    navigationFrame1.SelectedPageIndex = 0;
                    break;

                case 2://Ordenes de Compra Exentas
                    navigationFrame1.SelectedPageIndex = 1;
                    break;

                default:
                    break;
            }
        }
    }
}