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
using ACS.Classes;
using LOSA.Classes;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Compras
{
    public partial class frmKardexSaldosDisponible : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public enum TipoVista
        {
            Compras = 1,
            Contabilidad = 2
        }

        TipoVista tpVista;

        public frmKardexSaldosDisponible(TipoVista ptpVista)
        {
            InitializeComponent();
            this.tpVista = ptpVista;

            CargarResoluciones();
            load_data();


            switch (tpVista)
            {
                case TipoVista.Compras:

                    gridView1.Columns["reposDetalle"].Visible = true;
                    break;
                case TipoVista.Contabilidad:

                    gridView1.Columns["reposDetalle"].Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void load_data()
        {
            //string query = @"sp_cm_get_saldo_disponible";
            string query = @"[sp_cm_get_saldo_disponible_by_id]";
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_exoneracion", grdExoneracion.EditValue);
                dsCompras1.kardex.Clear();
                adat.Fill(dsCompras1.kardex);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void reposDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsCompras.kardexRow)gridview.GetFocusedDataRow();

            frmKardexDetalle frm = new frmKardexDetalle(row.capitulo, row.partida_arancelaria, frmKardexDetalle.TipoOperacion.DetalleKardex,Convert.ToInt32(grdExoneracion.EditValue));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                load_data();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void CargarResoluciones()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_lsita_resoluciones", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.lista_exoneracion.Clear();
                adat.Fill(dsCompras1.lista_exoneracion);
                conn.Close();

                if (dsCompras1.lista_exoneracion.Count == 1)
                {
                    foreach (dsCompras.lista_exoneracionRow item in dsCompras1.lista_exoneracion)
                    {
                        grdExoneracion.EditValue = item.id;
                    }

                    grdExoneracion.Enabled = false;
                }
                else
                {
                    grdExoneracion.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void reposDetalleKardex_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}