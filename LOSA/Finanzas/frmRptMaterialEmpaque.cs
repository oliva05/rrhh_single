using ACS.Classes;
using DevExpress.XtraEditors;
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
using LOSA.Produccion;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Finanzas
{
    public partial class frmRptMaterialEmpaque : DevExpress.XtraEditors.XtraForm
    {
        public frmRptMaterialEmpaque()
        {
            InitializeComponent();
            cargarData();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringAMS);
                conn.Open();

                string sql = "sp_material_empaque_kardex";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsMaterialEmpaque1.kardex_me.Clear();
                da.Fill(dsMaterialEmpaque1.kardex_me);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reposDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsMaterialEmpaque.kardex_meRow)gridView.GetFocusedDataRow();

            frmDetalleKardex frm = new frmDetalleKardex(row.id_me, row.lote);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarData();
            }
        }
    }
}