﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

namespace LOSA.MigracionACS.Produccion.Reports
{
    public partial class frmIntakeFullReport : Form
    {
        public frmIntakeFullReport()
        {
            InitializeComponent();
        }



        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdFiltro.SelectedIndex == 0)
            {
                txtNumeroOrden.Enabled = true;
                dtHasta.Enabled = dtDesde.Enabled = false;
            }
            else
            {
                txtNumeroOrden.Enabled = false;
                dtHasta.Enabled = dtDesde.Enabled = true;
            }
        }

        private void rdVisualizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringAPMS);
                con.Open();
                if (rdFiltro.SelectedIndex == 1)//por fechas
                {
                    if (rdVisualizacion.SelectedIndex == 0)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_resumen_intake_batch", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@start_date", dtDesde.EditValue);
                        cmd.Parameters.AddWithValue("@end_date", dtHasta.EditValue);
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adat.Fill(table);
                        var gridView = (GridView)grDetalle.FocusedView;
                        gridView.Columns.Clear();
                        this.grDetalle.DataSource = table;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_resumen_by_mp_intake_batch", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@start_date", dtDesde.EditValue);
                        cmd.Parameters.AddWithValue("@end_date", dtHasta.EditValue);
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        DataTable table2 = new DataTable();
                        adat.Fill(table2);
                        var gridView = (GridView)grDetalle.FocusedView;
                        gridView.Columns.Clear();
                        this.grDetalle.DataSource = table2;
                    }
                }
                else
                {
                    //filtrar por orden de produccion

                    string orderCode = "PP-";

                    // Amigo, este switch de abajo pudo ser así tambien: 
                    // orderCode += txt_OrderCode.Text.Trim().PadLeft(7, '0');
                    switch (txtNumeroOrden.Text.Length)
                    {
                        case 0:
                            orderCode += "0000000";
                            break;
                        case 1:
                            orderCode += "000000" + txtNumeroOrden.Text;
                            break;
                        case 2:
                            orderCode += "00000" + txtNumeroOrden.Text;
                            break;
                        case 3:
                            orderCode += "0000" + txtNumeroOrden.Text;
                            break;
                        case 4:
                            orderCode += "000" + txtNumeroOrden.Text;
                            break;
                        case 5:
                            orderCode += "00" + txtNumeroOrden.Text;
                            break;
                        case 6:
                            orderCode += "0" + txtNumeroOrden.Text;
                            break;
                        case 7:
                            orderCode += txtNumeroOrden.Text;
                            break;
                        default:
                            orderCode += txtNumeroOrden.Text;
                            break;
                    }

                    if (rdVisualizacion.SelectedIndex == 0)
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_resumen_intake_batch_by_ordercode", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@start_date", dtDesde.EditValue);
                        //cmd.Parameters.AddWithValue("@end_date", dtHasta.EditValue);

                        cmd.Parameters.AddWithValue("@order_number", int.Parse(txtNumeroOrden.Text.ToString()));

                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adat.Fill(table);
                        var gridView = (GridView)grDetalle.FocusedView;
                        gridView.Columns.Clear();
                        this.grDetalle.DataSource = table;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_get_resumen_by_mp_intake_batch_by_ordernumber", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@start_date", dtDesde.EditValue);
                        //cmd.Parameters.AddWithValue("@end_date", dtHasta.EditValue);
                        cmd.Parameters.AddWithValue("@order_number", int.Parse(txtNumeroOrden.Text.ToString()));
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        DataTable table2 = new DataTable();
                        adat.Fill(table2);
                        var gridView = (GridView)grDetalle.FocusedView;
                        gridView.Columns.Clear();
                        this.grDetalle.DataSource = table2;
                    }
                }
                
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
            
        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            //GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            //if (info.Column.Name == "colproduction_order")
            //{
            //    info.GroupText = "Ship country starts with " + info.GroupValueText;
            //}
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grDetalle.ExportToXlsx(dialog.FileName);
                //Impresion().ExportToXlsx(dialog.FileName);
            }
        }
    }
}
