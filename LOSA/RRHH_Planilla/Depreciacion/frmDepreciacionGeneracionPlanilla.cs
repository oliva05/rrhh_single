using ACS.Classes;
using AMS.Compras.ControlInv;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Commands.Internal;
using LOSA.Clases;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Planilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionGeneracionPlanilla : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        public frmDepreciacionGeneracionPlanilla(UserLogin user)
        {
            InitializeComponent();
            UsuarioLogeado = user;
            dtDesde.DateTime = dp.Now().AddDays(-15);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = @"sp_depreciacion_get_planilla_h";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                cmd.Parameters.AddWithValue("@ver_canceladas", tggMostrarCanceladas.IsOn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.deprecacion_planilla_h.Clear();
                adat.Fill(dsDepreciacion1.deprecacion_planilla_h);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdNuevaPlanilla_Click(object sender, EventArgs e)
        {
            bool PlanillaEnBorrador = false;
            foreach (dsDepreciacion.deprecacion_planilla_hRow item in dsDepreciacion1.deprecacion_planilla_h)
            {
                if (item.id_estado == 1)//Borrador
                {
                    PlanillaEnBorrador = true;
                }
            }

            if (!PlanillaEnBorrador)
            {
                frmDepreciacionGeneracionPlanillaCRUD frm = new frmDepreciacionGeneracionPlanillaCRUD(frmDepreciacionGeneracionPlanillaCRUD.TipoOperacion.Nuevo, UsuarioLogeado, 0);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                CajaDialogo.Error("Existe una Planilla en Borrador.\nCancelar o Confirmar para Continuar.");
                return;
            }

           
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepreciacion.deprecacion_planilla_hRow)gridview.GetFocusedDataRow();

            frmDepreciacionGeneracionPlanillaCRUD frm = new frmDepreciacionGeneracionPlanillaCRUD(frmDepreciacionGeneracionPlanillaCRUD.TipoOperacion.Editar, UsuarioLogeado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cmdVerPlanillasEmployees_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepreciacion.deprecacion_planilla_hRow)gridview.GetFocusedDataRow();

            frmDepreciacionGeneracionPlanillaDetalleLinea frm = new frmDepreciacionGeneracionPlanillaDetalleLinea(UsuarioLogeado, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void cmdOpcioensPlanilla_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepreciacion.deprecacion_planilla_hRow)gridview.GetFocusedDataRow();


            bool Proceder = false;
            switch (row.id_estado)
            {
                case 1://Borrador
                    Proceder = true;
                    break;
                case 2://Confirmada
                    Proceder = false;
                    break;
                case 3:
                    Proceder = false;
                    break;
                default:
                    break;
            }

            if (Proceder)
            {
                frmCambiarEstadoPlanilla frm = new frmCambiarEstadoPlanilla(UsuarioLogeado, row.id_estado, row.id);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    LoadData();
                }
            }
            else
            {
                CajaDialogo.Error("La Planilla de Depreciacion esta: " + row.estado);
                return;
            }

           
        }
    }
}