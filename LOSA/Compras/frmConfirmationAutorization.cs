﻿using ACS.Classes;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.Compras
{
    public partial class frmConfirmationAutorization : Form
    {
        CMOrdenCompraH OrdenActual;
        public bool IsApproved;
        DataOperations dp = new DataOperations();
        public frmConfirmationAutorization(CMOrdenCompraH pOrdenActual)
        {
            InitializeComponent();
            IsApproved = false;
            OrdenActual = pOrdenActual; 
            txtUsuarioSolicita.Text = pOrdenActual.UsuarioName;
            txtEstado.Text = pOrdenActual.EstadoName;
            
            if(pOrdenActual.DocNum == 0)
                txtNumDoc.Text = pOrdenActual.Id.ToString();
            else
                txtNumDoc.Text = pOrdenActual.DocNum.ToString();

            txtComentarios.Text =   pOrdenActual.Comments;
            CMRuta_Aprobacion RutaActual = new CMRuta_Aprobacion();
            if (RutaActual.RecuperarRegistro(OrdenActual.idRutaAprobacion))
                txtRutaAprobacion.Text = RutaActual.Descripcion;
            else
                txtRutaAprobacion.Text = "N/D";

            txtFechaDocumento.Text = string.Format("{0:dd/MM/yyyy}", OrdenActual.TaxDate);

            if(string.IsNullOrEmpty( OrdenActual.U_AquaExoneracion))
                txtTipoOrden.Text = "Normal (con ISV)";
            else
                txtTipoOrden.Text = "Exonerada";

            txtCardName.Text = OrdenActual.CardName;
            txtCardCode.Text = OrdenActual.CardCode;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdRechazar_Click(object sender, EventArgs e)
        {
            IsApproved = false;
            txtDecisionCase.Text = "Rechazado";
        }

        private void cmdAprobar_Click(object sender, EventArgs e)
        {
            IsApproved = true;
            txtDecisionCase.Text = "Autorizado";
        }

        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            if (txtDecisionCase.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                CajaDialogo.Error("Debe seleccionar Aprobar/Rechazar");
                return;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumDoc.Text.Trim()))
            {
                frmOrdenesCompraMain frm = new frmOrdenesCompraMain(frmOrdenesCompraMain.TipoOperacion.View, Convert.ToInt32(txtNumDoc.Text.Trim()));
                frm.ShowDialog();   
            }
            

        }
    }
}
