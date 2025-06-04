using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace LOSA.Reportes.ConsumosMateriaPrima
{
    public partial class xrptUnificadoConsumos : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptUnificadoConsumos(DateTime Desde, DateTime Hasta, decimal pMezcla,decimal pPost_Pellet, decimal pTeorico, decimal pConsumo)
        {
            InitializeComponent();
            lblDesde.Text = string.Format("{0:d}",Desde).ToString();
            lblHasta.Text = string.Format("{0:d}",Hasta).ToString();

            lblMezcla.Text = string.Format("{0:N2}", pMezcla);
            lblPost.Text = string.Format("{0:N2}", pPost_Pellet);
            lblTeorico.Text = string.Format("{0:N2}", pTeorico);
            lblConsumo.Text = string.Format("{0:N2}", pConsumo);
        }

    }
}
