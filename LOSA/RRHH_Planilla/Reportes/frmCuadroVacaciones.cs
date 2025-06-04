using ACS.Classes;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using LOSA.RRHH_Planilla.Planilla.Ausencias;
using LOSA.Trazabilidad;
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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.PivotGrid.OLAP.AdoWrappers;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using LOSA.MigracionACS.RRHH.Vacaciones;
using LOSA.Clases.Colaborador;



namespace LOSA.RRHH_Planilla.Reportes
{
    public partial class frmCuadroVacaciones : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        public frmCuadroVacaciones()
        {
            InitializeComponent();
            tggSwitch.IsOn = false;
            CargarEmpleados();
            LoadDepartamentos(1);
            //CargarVacacionesPorDepartamento();

        }

        private void tggSwitch_Toggled(object sender, EventArgs e)
        {
            if (tggSwitch.IsOn)
            {
                lblTipo.Text = "Departmento";
                slueEmployee.Visible = false;
            }
            else
            {
                lblTipo.Text = "Empleados";
                slueEmployee.Visible = true;
            }
        }

        public void CargarEmpleados()
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                dsInasistencias1.hr_employee.Clear();

                using (SqlDataAdapter da = new SqlDataAdapter("dbo.uspLoadEmployeeFromLeaves", cnx))
                {
                    cnx.Open();
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = codigoEmpleado;
                    da.Fill(dsInasistencias1.hr_employee);
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadDepartamentos(int pIdCompany)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("[sp_get_lista_departamentos_rrhh_all]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company_id", pIdCompany);
                dsMaestroEmpleados1.departamentos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsMaestroEmpleados1.departamentos);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            if (tggSwitch.IsOn == false)
            {
                //if (string.IsNullOrEmpty(slueDepartment.Text))
                //{
                //    CajaDialogo.Error("Debe seleccionar un Departamento!");
                //    return;
                //}


                DataTable idTable = new DataTable();
                idTable.Columns.Add("value", typeof(int));

                var items = checkedComboBoxEdit1.Properties.Items;

                foreach (CheckedListBoxItem item in items)
                {
                    if (item.CheckState == CheckState.Checked)
                    {
                        idTable.Rows.Add(item.Value);
                    }
                }

                CargarVacacionesPorDepartamento(idTable);
            }
            else //Empleados
            {
                try
                {
                    string sql = @"";
                    SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    DataTable tabla = new DataTable();
                    SqlDataAdapter adat = new SqlDataAdapter(cmd);
                    adat.Fill(tabla);
                    gridControl1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            
        }

        private void CargarVacacionesPorDepartamento(DataTable data)
        {
            try
            {
                string sql = @"sp_get_cuadro_vacaciones_por_departamento";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@IdDepartment", (int)slueDepartment.EditValue);
                SqlParameter param = cmd.Parameters.AddWithValue("@idList", data);
                DataTable tabla = new DataTable();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);

                //adat.Fill(tabla);
                dsInasistencias1.cuadro_vacaciones.Clear();
                adat.Fill(dsInasistencias1.cuadro_vacaciones);
                //gridControl1.DataSource = tabla;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            //dialog.FilterIndex = 0;

            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    gridControl1.ExportToXlsx(dialog.FileName);
            //}

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;
                dialog.Title = "Guardar archivo Excel";
                dialog.FileName = "Cuadro de Vacaciones.xlsx";

                DataTable data = new DataTable();

                data = dsInasistencias1.cuadro_vacaciones;

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (OfficeOpenXml.ExcelPackage package = new OfficeOpenXml.ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Hoja1");

                        worksheet.Cells["A1"].LoadFromDataTable(data, true);
                        worksheet.Cells["A1"].Value = "Codigo";
                        worksheet.Cells["C1"].Value = "Departamento";
                        worksheet.Cells["D1"].Value = "Fecha Ingreso";
                        worksheet.Cells["E1"].Value = "Dias Acumulados";
                        worksheet.Cells["F1"].Value = "Dias Tomados";
                        worksheet.Cells["G1"].Value = "Dias Pendientes";
                        worksheet.Cells["H1"].Value = "Antiguedad";
                        using (var range = worksheet.Cells["A1:H1"])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.Font.Color.SetColor(Color.Blue); // Color del texto 
                            
                            range.Style.Border.BorderAround(ExcelBorderStyle.Thin); // Bordes finos
                        }

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                        FileInfo fi = new FileInfo(dialog.FileName);
                        package.SaveAs(fi);
                    }
                }
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                //var gridView = (GridView)gridControl1.FocusedView;
                //var row = (dsInasistencias.cuadro_vacacionesRow)gridView.GetDataRow(e.RowHandle);

                string Dias = View.GetRowCellDisplayText(e.RowHandle, View.Columns["pendiente"]);

                decimal DiasNum = Convert.ToDecimal(Dias);

                switch (DiasNum)
                {
                    case decimal n when (n >= 0 && n <= 14):
                        e.Appearance.BackColor = Color.FromArgb(92, 177, 137);
                        break;

                    case decimal n when (n < 0):
                        e.Appearance.BackColor = Color.FromArgb(229, 104, 125);
                        break;

                    case decimal n when (n >= 15):
                        e.Appearance.BackColor = Color.FromArgb(229, 104, 125);
                        break;
                    default:
                        break;
                }
            }
        }

        private void reposDetalle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //Ver detalle
            var row = (dsInasistencias.cuadro_vacacionesRow)gridView1.GetFocusedDataRow();

            HrEmployee emp = new HrEmployee();
            emp.RecuperarDatosPorCodigo(row.codigo);

            frmVacacionesDetalles frm = new frmVacacionesDetalles(emp.Id, row.nombre, row.pendiente.ToString());
            frm.ShowDialog();
        }
    }
}