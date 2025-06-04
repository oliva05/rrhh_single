﻿using ACS.Classes;
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

namespace LOSA.Logistica
{
    public partial class frmLotesXProveedor : Form
    {
        DataOperations dp = new DataOperations();
        public frmLotesXProveedor()
        {
            InitializeComponent();
            cargarDatosProveedor();
        }

        void cargarDatosProveedor()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_providersv2";
              

                dsLogistica.Proveedores.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsLogistica.Proveedores);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GlueProveedor_EditValueChanged(object sender, EventArgs e)
        {
            cargarMateriaPrimaXProveedor(gvProveedores.GetFocusedRowCellValue(gvProveedores.Columns[0]).ToString());
           // cargarDatosTarimas(gvProveedores.GetFocusedRowCellValue(gvProveedores.Columns[0]).ToString());
            
        }

        private void cargarDatosTarimas(string pIdProveedor)
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                cn.Open();
                //string SQL = @"exec sp_get_tarimas_from_idProveedor @id_proveedor";
                SqlCommand cmd = new SqlCommand("sp_get_tarimas_from_idProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", pIdProveedor);
                cmd.Parameters.AddWithValue("@id_mp", cbMateriaPrima.EditValue.ToString());

                dsLogistica.LotesXProveedor.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsLogistica.LotesXProveedor);
                cn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cargarMateriaPrimaXProveedor(string pIdProveedor)
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"exec sp_get_materia_prima_por_proveedor @id_proveedor";

                dsLogistica.Materia_prima.Clear();
                dsLogistica.LotesXProveedor.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.SelectCommand.Parameters.AddWithValue("@id_proveedor", pIdProveedor);

                adat.Fill(dsLogistica.Materia_prima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void FrmLotesXProveedor_Load(object sender, EventArgs e)
        {
            gvLotes.Columns[1].GroupIndex = 1;
            //gvLotes.Columns["materia_prima"].GroupIndex = 2;
        }

        private void CbMateriaPrima_EditValueChanged(object sender, EventArgs e)
        {
            //gvLotes.ActiveFilterString = "[itemcode] = '" + cbMateriaPrima.EditValue + "'";
            cargarDatosTarimas(glueProveedor.EditValue.ToString());
        }
    }
}
