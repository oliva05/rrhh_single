using ACS.Classes;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
using LOSA.RecepcionMP;
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

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();

        public frmDepreciacionConfiguracion(UserLogin userLogin)
        {
            InitializeComponent();
            UsuarioLogeado = userLogin;
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDepreciacionCRUD frm = new frmDepreciacionCRUD(UsuarioLogeado, frmDepreciacionCRUD.TipoOperacion.Nuevo, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_depreciacion_prestamos_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cancelado",tggMostrarCanceladas.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.lista_prestamos.Clear();
                adat.Fill(dsDepreciacion1.lista_prestamos);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepreciacion.lista_prestamosRow)gridview.GetFocusedDataRow();

            frmDepreciacionCRUD frm = new frmDepreciacionCRUD(UsuarioLogeado, frmDepreciacionCRUD.TipoOperacion.Editar, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tggMostrarCanceladas_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}