using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.AlmacenesExterno
{
    public partial class frmvertodasMPinbodega : DevExpress.XtraEditors.XtraForm
    {
        public string bodega = "";
        public string CodigoBodega = "";
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogueado;
        public frmvertodasMPinbodega(string pBodega, string pCodigo, UserLogin userLogin)
        {
            InitializeComponent();
            bodega = pBodega;
            UsuarioLogueado = userLogin;
            CodigoBodega = pCodigo;
            txtBodega.Text = CodigoBodega;
            txtbodegaName.Text = bodega;
            load_data_con_parametro();
        }
        public void load_data_con_parametro()
        {
            
            string query = @"sp_load_lotes_bodega_externa";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bodega", CodigoBodega);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReporteAlmacenExterno.controlBodegaExterna.Clear();
                da.Fill(dsReporteAlmacenExterno.controlBodegaExterna);
                cn.Close();
            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void reposAjustarNegativos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsReporteAlmacenExterno.controlBodegaExternaRow)gridView.GetFocusedDataRow();

            if (row.totalkg < 0)
            {
                decimal TotalKg = Math.Abs(row.totalkg);
                decimal TotalUd = Math.Abs((decimal)row.udtotal);

                try
                {
                    SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_ajuste_bodega_externa_positivo", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@entrada", TotalKg /*row.totalkg*/);
                    cmd.Parameters.AddWithValue("@id_lote_externo",row.id_lote_externo);
                    cmd.Parameters.AddWithValue("@lote",row.lote);
                    cmd.Parameters.AddWithValue("@id_mp",row.id_mp);
                    cmd.Parameters.AddWithValue("@itemcode",row.codigoMp);
                    cmd.Parameters.AddWithValue("@id_bodega", row.id_bodega);
                    cmd.Parameters.AddWithValue("@userid",UsuarioLogueado.Id);
                    cmd.Parameters.AddWithValue("@udtotal", TotalUd /*row.udtotal*/);
                    cmd.Parameters.AddWithValue("@id_presentacion", row.id_presentacion);
                    cmd.ExecuteNonQuery();

                    load_data_con_parametro();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }

            }
            else
            {
                CajaDialogo.Error("Esta Opcion es para ajustar negativos!");
            }
        }
    }
}