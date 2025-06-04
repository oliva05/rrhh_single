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
using System.Data.SqlClient;
using ACS.Classes;
using LOSA.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace LOSA.Produccion
{
    public partial class frmAlimentacionPanelMicro_i : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();

        public frmAlimentacionPanelMicro_i()
        {
            InitializeComponent();
            timertick.Enabled = true;
            Load_data();
        }
         public void Load_data()
        {

            string Query = @"sp_obtener_tarimas_alimentacion";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsProduccion.panelalimentacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProduccion.panelalimentacion);
                cn.Close();

                timertick.Enabled = true;

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea marcar como consumida la tarima?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsProduccion.panelalimentacionRow)gridView.GetFocusedDataRow();

                    string query = @"sp_update_tarimas_alimentacion";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_tarima", row.id);
                    cmd.ExecuteNonQuery();
                    Load_data();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
        }

        private void timertick_Tick(object sender, EventArgs e)
        {
            int Nuevo = 0;
            if (timertick.Enabled)
            {
                string Query = @"sp_count_alimentacion_tarima";
                try
                {
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Nuevo = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Nuevo > 0)
                    {
                        Load_data();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                    timertick.Enabled = false;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Load_data();
        }

        private void cmdEntregarA_Micros_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}