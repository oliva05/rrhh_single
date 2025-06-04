﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using LOSA.Clases;
using LOSA.ACS;
using ACS.Classes;
using System.Data.SqlClient;
using LOSA.Compras;
using DevExpress.CodeParser;

namespace LOSA.Compras
{
    public partial class rptOrdenCompra : DevExpress.XtraReports.UI.XtraReport
    {
        int IdOrdenH;

        public rptOrdenCompra(int pIdOrdenH)
        {
            InitializeComponent();

            IdOrdenH = pIdOrdenH;
            CMOrdenCompraH oc = new CMOrdenCompraH();
            oc.RecuperarRegistro(IdOrdenH);
            lblDocNum.Text = "NO#:" + oc.DocNum.ToString();
            lblCliente.Text = oc.CardName;

            Proveedor prov = new Proveedor();
            prov.RecuperarRegistroWithRTN(oc.CardCode);
            lblRTN.Text = prov.RTN;
            lblDireccion.Text = oc.Address;
            lblTelefono.Text = prov.Telefono1;
            lblContacto.Text = prov.ContactName;
            lblFechaOrden.Text = string.Format("{0:d}", oc.DocDate); //oc.DocDate.ToString();
            lblFechaVencimiento.Text = string.Format("{0:d}", oc.DocDueDate);
            lblTerminoPago.Text = prov.TerminoPago;
            lblEncargado.Text = oc.UsuarioName;
            lblMoneda.Text = oc.DocCur;
            lblReferencia.Text = oc.NumAtCard;
            lblComentario.Text = oc.Comments;
            lblIncoterm.Text = oc.U_incoterm;

            switch (oc.IdEstado)
            {
                case 1://Pendiente de Aprobacion
                    lblEstado.Visible = true;
                    lblEstado.Text = "OC Pendiente de Aprobacion\nBORRADOR";

                    break;

                case 2: //Autorizado
                    lblEstado.Visible = false;
                    //lblEstado.Text = "OC Pendiente de Aprobacion";
                    break;

                case 3: //Rechazado
                    lblEstado.Visible = true;
                    lblEstado.Text = "OC Rechazada\nBORRADOR";
                    break;
                default:
                    break;
            }

            string SimboloMoneda = "L.";
            switch (oc.DocCur.TrimEnd())
            {
                case "LPS":
                    SimboloMoneda = "L.";
                    break;

                case "USD":
                    SimboloMoneda = "$";
                    break;

                default:
                    break;
            }

            //lblTotal.Text = (SimboloMoneda + string.Format("{0:###,##0.00}", oc.DocTotal));
            CargarDetalleOrdenCompra();

            decimal subTotal = 0;
            foreach (dsCompras.oc_detalle_rptRow item in dsCompras1.oc_detalle_rpt)
            {
                subTotal += item.total;
            }
            lblDescuento.Text = (SimboloMoneda + string.Format("{0:#,###,##0.00}", (oc.PorcentajeDescuento * subTotal)/ 100).ToString());
            lblTotal.Text = (SimboloMoneda + string.Format("{0:#,###,##0.00}", oc.DocTotal));
            lblIsv15.Text = (SimboloMoneda + string.Format("{0:#,###,##0.00}", oc.ISV)).ToString();
            lblGastosAdicionales.Text = (SimboloMoneda + string.Format("{0:#,###,##0.00}", oc.GastosAdicionales)).ToString();
            lblSub.Text = (SimboloMoneda + string.Format("{0:#,###,##0.00}", subTotal)).ToString();
            

            
            ConversorNumALetras conNum = new ConversorNumALetras(oc.DocTotal, oc.DocCur);
            
            lblAPagarLetras.Text = conNum.NumeroEnLetras;
        }

        private void CargarDetalleOrdenCompra()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringLOSA);
                SqlCommand cmd = new SqlCommand("sp_CM_rpt_orden_compra_detalle", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrdenH", IdOrdenH);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsCompras1.oc_detalle_rpt.Clear();
                adat.Fill(dsCompras1.oc_detalle_rpt);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
