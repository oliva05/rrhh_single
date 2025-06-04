﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using ACS.Classes;

namespace LOSA.RecepcionMP
{
    public partial class rptReporteIngresoTarima : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReporteIngresoTarima(int idTarima)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            lblVersion.Text = dp.AssemblyVersion;

            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(idTarima, ""))
            {
                //IdUnidadMedida = dr.GetInt32(1);
                lblCantidad.Text = string.Format("{0:0.00}", tar1.Cantidad);
                //NombreTarima = dr.GetString(2);
                //TipoTarimaDescripcion = dr.GetString(3);
                lblProveedor.Text = tar1.Proveedor;
                lblLote.Text = tar1.LoteMP;
                lblCantidad.Text = tar1.Cantidad.ToString();
                lblNombreProducto.Text = tar1.MateriaPrima;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);
                lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccionMP);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
                
            }

        }

        public rptReporteIngresoTarima(int pid_tarima, decimal punidades, decimal ppeso_kg)
        {
            InitializeComponent();
            DataOperations dp = new DataOperations();
            Tarima tar1 = new Tarima();
            if (tar1.RecuperarRegistro(pid_tarima,""))
            {
                xrLabel1.Text = "SOBRANTE DE TARIMA";
                xrLabel6.Text = "Cantidad";
                lblCantidad.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                lblCantidad.Text = ppeso_kg.ToString() + " Kg";

                lblProveedor.Text = tar1.Proveedor;
                lblLote.Text = tar1.LoteMP;
                lblNombreProducto.Text = tar1.MateriaPrima;
                lblFechaIngreso.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaIngreso);
                lblNumeroIngreso.Text = tar1.NumeroTransaccion.ToString();
                lblFechaProduccion.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaProduccionMP);
                lblFechadeVencimiento.Text = string.Format("{0:dd/MM/yyyy}", tar1.FechaVencimiento);
                txtcodigo.Text = tar1.ItemCode;
                BarCode1.Text = BarCode2.Text = tar1.CodigoBarra;
            }
        }

    }
}
