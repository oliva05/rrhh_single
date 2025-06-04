﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ACS.Classes;
using System.Data.SqlClient;

namespace LOSA.Reportes
{
    public partial class frnReporteingreso : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        
        public frnReporteingreso()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            string Query = @"sp_obtener_year_tarimas";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsReportes.year.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.year);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }
        public void load_report()
        {
            string Query = @"sp_load_reporte_de_ingreso_por_lm";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dateanio", grdYEAR.EditValue);
                dsReportes.ingreso_lm.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsReportes.ingreso_lm);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }


        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdYEAR_EditValueChanged(object sender, EventArgs e)
        {
            load_report();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dsReportes.ingreso_lm.Rows.Count != 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grd_data.ExportToXlsx(dialog.FileName);
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar un año para exportar el reporte.");
                grdYEAR.ShowPopup();
                return;
            }
          
        }
    }
}