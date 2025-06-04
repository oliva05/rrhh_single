﻿using LOSA.Calidad;
using LOSA.Clases;
using LOSA.Logistica;
using LOSA.RecepcionMP;
using LOSA.TransaccionesPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSA.TransaccionesMP
{
    public partial class frmOptionMontaCarga : Form
    {
        UserLogin UsuarioLogeado;
        int TipoUso;
        public frmOptionMontaCarga(UserLogin pUser, int pTipoUsoVentana)
        {
            InitializeComponent();
            TipoUso = pTipoUsoVentana;
            switch(TipoUso)
            {
                case 1:
                    tabOpciones.SelectedTabPageIndex = 0;
                    tabOpciones.TabPages[0].PageVisible = true;
                    //tabOpciones.TabPages[1].PageVisible = false;
                    break;
                case 2:
                    tabOpciones.SelectedTabPageIndex = 1;
                    tabOpciones.TabPages[1].PageVisible = true;
                    break;
            }
            UsuarioLogeado = pUser;
        }

        private void cmdEntradaMP_Click(object sender, EventArgs e)
        {
            frmEntradaMP_new frm = new frmEntradaMP_new(UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnCambiarUbicacion_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarima frm = new frmCambiarUbicacionTarima();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //frmMantenimiento frm = new frmMantenimiento();
            //frm.Show();
            frmValidacionTarimas frm = new frmValidacionTarimas(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRequisiciones_Click(object sender, EventArgs e)
        {
            frmEntregaMontaCarga frm = new frmEntregaMontaCarga(this.UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdIngresoPT_Click(object sender, EventArgs e)
        {
            frmEntradaPT frm = new frmEntradaPT(this.UsuarioLogeado);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdCambiarUbicacionPT_Click(object sender, EventArgs e)
        {
            frmCambiarUbicacionTarimaPT frm = new frmCambiarUbicacionTarimaPT();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmDevolucionKardex frm = new frmDevolucionKardex(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdOrdenesCargaPT_Click(object sender, EventArgs e)
        {
            SelectorFor path = new SelectorFor(1);
            if (path.Camino == 1)
            {
                LOSA.Despachos.frm_despachos frm = new Despachos.frm_despachos();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                if (path.Camino == 2)
                {
                    LOSA.Despachos.frm_despacho_v2 FRM = new Despachos.frm_despacho_v2();
                    FRM.MdiParent = this.MdiParent;
                    FRM.Show();
                }
                else
                {
                    LOSA.Despachos.frm_despacho_v3 frm = new Despachos.frm_despacho_v3();//Camino activo desde Montacargas
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }

          
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            LOSA.Reportes.frmreporteUbicacion frm = new LOSA.Reportes.frmreporteUbicacion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdTarimasPT_Click(object sender, EventArgs e)
        {
            frmactivacionPT frm = new frmactivacionPT(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_saco_dañado frm = new frm_saco_dañado();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_reporte_produccion frm = new frm_reporte_produccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmRevisionDeActivaciondeTm frm = new frmRevisionDeActivaciondeTm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btntarimasactivadasPT_Click(object sender, EventArgs e)
        {
            frm_rpt_productoT frm = new frm_rpt_productoT();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frmDevolucionMicros frm = new frmDevolucionMicros(UsuarioLogeado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
