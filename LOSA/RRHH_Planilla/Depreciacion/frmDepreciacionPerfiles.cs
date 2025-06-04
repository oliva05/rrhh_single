using ACS.Classes;
using AMS.Compras.ControlInv;
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
    public partial class frmDepreciacionPerfiles : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;

        public frmDepreciacionPerfiles(UserLogin pUserlogin)
        {
            InitializeComponent();
            tggActivos.IsOn = true;
            UsuarioLogeado = pUserlogin;
            LoadData();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cmdNuevaP_Click(object sender, EventArgs e)
        {
            frmDepreciacionPerfilesCRUD frm = new frmDepreciacionPerfilesCRUD(frmDepreciacionPerfilesCRUD.TipoOperacion.Nuevo, UsuarioLogeado, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_depreciacion_get_perfiles", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@activo",tggActivos.IsOn);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.perfiles.Clear();
                adat.Fill(dsDepreciacion1.perfiles);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)grdPerfiles.FocusedView;
            var row = (dsDepreciacion.perfilesRow)gridview.GetFocusedDataRow();

            frmDepreciacionPerfilesCRUD frm = new frmDepreciacionPerfilesCRUD(frmDepreciacionPerfilesCRUD.TipoOperacion.Editar, UsuarioLogeado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tggActivos_Toggled(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}