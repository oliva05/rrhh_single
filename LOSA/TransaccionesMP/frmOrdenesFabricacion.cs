﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
using LOSA.Clases;
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

namespace LOSA.TransaccionesMP
{
    public partial class frmOrdenesFabricacion : Form
    {
        UserLogin UsuarioLogeado;
        public frmOrdenesFabricacion(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_orders_fabrication", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsTransaccionesMP1.ordenes_fabricacion_h.Clear();
                adat.Fill(dsTransaccionesMP1.ordenes_fabricacion_h);
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnVer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //boton ver
            var gridView = (GridView)grOrdenFabricacion.FocusedView;
            var row = (dsTransaccionesMP.ordenes_fabricacion_hRow)gridView.GetFocusedDataRow();

            string comment = "";
            try
            {
                comment = row.Comments;
            }
            catch {}

            frmOrdenFabricacionDetalle frm = new frmOrdenFabricacionDetalle(row.DocEntry, this.UsuarioLogeado, comment, row.Lote);
            frm.WindowState = FormWindowState.Maximized;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
