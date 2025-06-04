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
using DevExpress.XtraGrid.Views.Grid;
using LOSA.RecuentoInventario;

namespace LOSA.Logistica
{
    public partial class frmCierreMensual_Detalle : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_header;
        public frmCierreMensual_Detalle(int pid_header)
        {
            InitializeComponent();
            id_header = pid_header;
            load_data();
        }

        public frmCierreMensual_Detalle(int pid_header, Boolean boolContabilizacion)
        {
            InitializeComponent();
            id_header = pid_header;
            load_data();
        }


        public void load_data()
        {
            string query = @"sp_get_inventario_final_detalle";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@id_header", id_header);
                dsCierreMes1.recuentos_d.Clear();
                da.Fill(dsCierreMes1.recuentos_d);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data_d.ExportToXlsx(dialog.FileName);
            }
        }

        private void repositoryItemEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)grd_data_d.FocusedView;
            var row = (dsCierreMes.recuentos_dRow)gv.GetDataRow(gv.FocusedRowHandle);

            if (row.contabilizado)
            {
                CajaDialogo.Error("No se puede editar este detalle de recuento, ya fue contabilizado!");
            }
            else
            {
                frmEdtiarDetalleRecuento frm = new frmEdtiarDetalleRecuento(row.id ,row.materia_prima, row.bodega, row.existencia_aprox , row.existencia_fisica, row.diferencia_peso);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                }
            }
        }
    }
}