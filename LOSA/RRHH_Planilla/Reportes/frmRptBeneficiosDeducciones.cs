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

namespace LOSA.RRHH_Planilla.Reportes
{
    public partial class frmRptBeneficiosDeducciones : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmRptBeneficiosDeducciones(UserLogin pUserLog)
        {
            InitializeComponent();
            UsuarioLogeado = pUserLog;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_rpt_get_hr_benefits_deductions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("",);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPlanillaReportes1.beneficiosydeducciones.Clear();
                adat.Fill(dsPlanillaReportes1.beneficiosydeducciones);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reposVerContrato_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsPlanillaReportes.beneficiosydeduccionesRow)gridview.GetFocusedDataRow();

            frmContratoColaborador frm = new frmContratoColaborador(row.id_empleado, UsuarioLogeado, row.id_contrato, row.barcode);
            frm.ShowDialog();
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