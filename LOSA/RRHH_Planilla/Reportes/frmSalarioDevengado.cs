using ACS.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpellChecker.Parser;
using LOSA.RecepcionMP;
using LOSA.RRHH_Planilla.Depreciacion;
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
    public partial class frmSalarioDevengado : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmSalarioDevengado()
        {
            InitializeComponent();
            tggMostrarCanceladas.IsOn = false;
            dtDesde.DateTime = dp.Now().AddDays(-30);
            dtHasta.DateTime = dp.Now().AddDays(1);
            LoadReglasSalariales();

        }

        private void LoadReglasSalariales()
        {
            try
            {
                string query = @"sp_get_salary_rule";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPlanillaReportes1.salary_rules.Clear();
                adat.Fill(dsPlanillaReportes1.salary_rules);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdRefreshDisponibles_Click(object sender, EventArgs e)
        {
            DataTable idTable = new DataTable();
            idTable.Columns.Add("value", typeof(int));

            var items = checkComboReglasSalariales.Properties.Items;

            foreach (CheckedListBoxItem item in items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    idTable.Rows.Add(item.Value);
                }
            }


            try
            {
                string query = @"sp_get_rpt_salario_devengado";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
                //cmd.Parameters.AddWithValue("@Inactivos", tggMostrarCanceladas.IsOn);
                //SqlParameter param = cmd.Parameters.AddWithValue("@IdList", idTable);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPlanillaReportes1.salario_devengados.Clear();
                adat.Fill(dsPlanillaReportes1.salario_devengados);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            //try
            //{
            //    string query = @"sp_get_salario_devengado";
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@desde", dtDesde.DateTime);
            //    cmd.Parameters.AddWithValue("@hasta", dtHasta.DateTime);
            //    cmd.Parameters.AddWithValue("@Inactivos", tggMostrarCanceladas.IsOn);
            //    SqlParameter param = cmd.Parameters.AddWithValue("@IdList", idTable);
                
            //    SqlDataAdapter adat = new SqlDataAdapter(cmd);
            //    dsPlanillaReportes1.salary_earned.Clear();
            //    adat.Fill(dsPlanillaReportes1.salary_earned);
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error(ex.Message);
            //}
        }

        private void frmSalarioDevengado_Load(object sender, EventArgs e)
        {

        }

        private void tggMostrarCanceladas_Toggled(object sender, EventArgs e)
        {
            cmdRefreshDisponibles_Click(sender, e);
        }


        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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