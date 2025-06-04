using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Mantenimientos.Modelos;
using LOSA.RecepcionMP;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LOSA.Mantenimientos
{
    public partial class frmTipoPresentacion : Form
    {
        DataOperations dp = new DataOperations();
       public frmTipoPresentacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        void CargarDatos()
        {
            try
            {
                using (SqlConnection conexionLOSA = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    dsMantenimiento1.TiposPresentacionesDataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("exec spObtenerTiposPresentaciones", conexionLOSA);
                    adapter.Fill(dsMantenimiento1.TiposPresentacionesDataTable);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(new TipoPresentacion());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var gridview = (GridView)gcTiposPresentaciones.FocusedView;
            var row = (dsMantenimiento.TiposPresentacionesDataTableRow)gridview.GetFocusedDataRow();

            TipoPresentacion tipoPresentacion = new TipoPresentacion
            {
                Id = Convert.ToInt32(row.id),
                Descripcion = row.descripcion,
                Enable = row.enable,
                Factor = Convert.ToDecimal(row.factor)
            };

            frmTipoPresentacionCRUD frm = new frmTipoPresentacionCRUD(tipoPresentacion);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
