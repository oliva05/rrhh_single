﻿using ACS.Classes;
using DevExpress.XtraGrid.Views.Grid;
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

namespace LOSA.RecepcionMP
{
    public partial class frmMP : Form
    {
        public string idProveedor,MateriaPrima,NombreProveedor,ItemCode;
        public int id_mp;
        public frmMP()
        {
            InitializeComponent();
            cargarDatos();
        }
        DataOperations dp = new DataOperations();

        private void btnSeleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Seleccion del lote
            //bib
            var gridView = (GridView)gcMP.FocusedView;
            var row = (dsRecepcionMPx.Materia_PrimaRow)gridView.GetFocusedDataRow();

            //this.idProveedor = row.carcode;
            //this.NombreProveedor = row.cardname;
           
            this.MateriaPrima = row.itemdescrip;
            this.ItemCode = row.itemcode;
            this.id_mp = row.id_mp;

            //this.lote = row.lote_materia_prima;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void cargarDatos()
        {
            try
            {

                SqlConnection cn = new SqlConnection(dp.ConnectionStringLOSA);
                string SQL = @"sp_get_MP";
                SqlCommand cmd = new SqlCommand(SQL, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsRecepcionMPx.Materia_Prima.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(SQL, cn);

                adat.Fill(dsRecepcionMPx.Materia_Prima);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void GvMP_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Seleccion del lote
                //bib
                var gridView = (GridView)gcMP.FocusedView;
                var row = (dsRecepcionMPx.Materia_PrimaRow)gridView.GetFocusedDataRow();

                //this.idProveedor = row.carcode;
                //this.NombreProveedor = row.cardname;
                this.MateriaPrima = row.itemdescrip;
                this.ItemCode = row.itemcode;
                this.id_mp = row.id_mp;
                //this.lote = row.lote_materia_prima;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
