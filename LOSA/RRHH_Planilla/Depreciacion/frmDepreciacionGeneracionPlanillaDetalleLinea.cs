using DevExpress.XtraEditors;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOSA.Classes;
using ACS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecepcionMP;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using LOSA.RRHH_Planilla.Planilla.Reportes;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class frmDepreciacionGeneracionPlanillaDetalleLinea : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp = new DataOperations();
        int IdHeader;

        public frmDepreciacionGeneracionPlanillaDetalleLinea(UserLogin pUser, int PidH)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            IdHeader = PidH;
            PlanillaDepreciacion dep = new PlanillaDepreciacion();
            if (dep.RecuperarPlanillaHeader(IdHeader))
            {
                lblDescripcion.Text = dep.NamePlanilla;
                lblAnio.Text = dep.Anio.ToString();
                Funciones func = new Funciones();
                lblMes.Text = func.GetMonthNameForInt(dep.Mes);
                lblTasa.Text = dep.TasaCambio.ToString();
                lblEstado.Text = dep.Estado;

                switch (dep.IdEstado)
                {
                    case 1: //Borrador
                        btnPrint.Visible = false;
                        btnAgregar.Visible = true;
                        break;
                    case 2://Confirmada
                        btnPrint.Visible = true;
                        btnAgregar.Visible = false;
                        gridView1.OptionsMenu.EnableColumnMenu = false;
                        gridView1.Columns["eliminar"].Visible = false;

                        break;
                    case 3://Cancelada
                        btnPrint.Visible = true;
                        //btnAgregar.Visible = false;
                        gridView1.OptionsMenu.EnableColumnMenu = false;
                        gridView1.Columns["eliminar"].Visible = false;
                        break;
                    default:
                        break;
                }

                LoadData();

            }    

        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_depreciacion_get_detalle_planilla]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlanilla", IdHeader);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.detalle_planilla.Clear();
                adat.Fill(dsDepreciacion1.detalle_planilla);
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

        private void cmdDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsDepreciacion.detalle_planillaRow)gridview.GetFocusedDataRow();

            DialogResult r = CajaDialogo.Pregunta("Se va eliminar el Empleado de la Planilla\nEsta seguro?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_depreciacion_eliminar_detlale_planilla", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalle_linea", row.id);
                cmd.Parameters.AddWithValue("@id_detalle", row.id_d);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm_DepreciacionGeneracionPlanillaAddPrestamo frm = new frm_DepreciacionGeneracionPlanillaAddPrestamo(UsuarioLogeado, IdHeader);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptDepreciacion report = new rptDepreciacion(IdHeader);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Send the report to the default printer.
                printTool.ShowPreviewDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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