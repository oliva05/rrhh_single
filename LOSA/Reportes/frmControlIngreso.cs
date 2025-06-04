﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;

namespace LOSA.Reportes
{
    public partial class frmControlIngreso : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_mp;
        int Default_Value = 0;
        public frmControlIngreso()
        {
            InitializeComponent();
            LoadMateriasPrimas();
            id_mp = Default_Value;
        }
        public void LoadMateriasPrimas()
        {
            string query = @"sp_load_mp_to_seleccion";
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dsMantenimientoC.mp.Clear();
                sqlDataAdapter.Fill(dsMantenimientoC.mp);
                connection.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void LoadInventarioSoloBodegas()
        {
            string query = @"sp_get_inventario_by_mp_bodegas";
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_mp", id_mp);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dsReportesInventario.CantidadBodega.Clear();
                sqlDataAdapter.Fill(dsReportesInventario.CantidadBodega);
                connection.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        public void LoadInventarioPorBodegaproveedor()
        {
            string query = @"sp_get_inventario_por_bodega_proveedor_by_id_mp";
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_mp", id_mp);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dsReportesInventario.BodegasProveedor.Clear();
                sqlDataAdapter.Fill(dsReportesInventario.BodegasProveedor);
                connection.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }

        public void LoadResumenInventario()
        {
            string query = @"sp_get_resumen_ingresos";
            SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_mp", id_mp);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                dsReportesInventario.reporteIngresos.Clear();
                sqlDataAdapter.Fill(dsReportesInventario.reporteIngresos);
                connection.Close();

            }
            catch (Exception ex)
            {

                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetIdMp()
        {
            id_mp = Convert.ToInt32(SeleccionMp.EditValue);
        }
        private void SeleccionMp_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SetIdMp();
                LoadInventarioPorBodegaproveedor();
                LoadInventarioSoloBodegas();
                LoadResumenInventario();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            if (dsReportesInventario.reporteIngresos.Rows.Count != 0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel File (.xlsx)|*.xlsx";
                dialog.FilterIndex = 0;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    grdResumenIngreso.ExportToXlsx(dialog.FileName);
                }
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar una Materia Prima para exportar el reporte");
                SeleccionMp.ShowPopup();
                return;
            }
        }
    }
}