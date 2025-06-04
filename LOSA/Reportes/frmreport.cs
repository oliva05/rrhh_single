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
using LOSA.Logistica;
using LOSA.Produccion;
using LOSA.TransaccionesMP;
using LOSA.Clases;

namespace LOSA.Reportes
{
    public partial class frmreport : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmreport(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cmdHome_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegistroLote_Click(object sender, EventArgs e)
        {
            frmtarimasporbodega frm = new frmtarimasporbodega();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLotesXMP_Click(object sender, EventArgs e)
        {
            frmLotesXMP frm = new frmLotesXMP();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnCantidadMP_Click(object sender, EventArgs e)
        {
            frmCantidadMP frm = new frmCantidadMP();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLotes frm = new frmLotes();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnTrazabilidad_Click(object sender, EventArgs e)
        {
            frmTrazabilidadLote frm = new frmTrazabilidadLote();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnLotesPorProveedor_Click(object sender, EventArgs e)
        {
            frmLotesXProveedor frm = new frmLotesXProveedor();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmdSalidasMP_Click(object sender, EventArgs e)
        {
            frm_SalidasMP frm = new frm_SalidasMP();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;

            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnImprimirTm_Click(object sender, EventArgs e)
        {
            frmprint__tarimas frm = new frmprint__tarimas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void btn_rptubicaciones_Click(object sender, EventArgs e)
        {
            rptUbicaciones frm = new rptUbicaciones();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmexistenciaPT frm = new frmexistenciaPT();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmreporteLotePT frm = new frmreporteLotePT();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnreportIngreso_Click(object sender, EventArgs e)
        {
            //frnReporteingreso frm = new frnReporteingreso();
            //frm.Show();

            frmReporteIngreso_v2 frm = new frmReporteIngreso_v2();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmrpt_lote_mp frm = new frmrpt_lote_mp();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_print_TM_PT frm = new frm_print_TM_PT();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmrpt_productoterminado frm = new frmrpt_productoterminado();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnReporteRetenido_Click(object sender, EventArgs e)
        {
            frmReporteTMRetenidas frm = new frmReporteTMRetenidas();
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmReporteKardexGeneralVencimiento frm = new frmReporteKardexGeneralVencimiento(this.UsuarioLogeado);
            if (this.MdiParent != null)
                frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void frmTmVirtuales_Click(object sender, EventArgs e)
        {

        }
    }
}