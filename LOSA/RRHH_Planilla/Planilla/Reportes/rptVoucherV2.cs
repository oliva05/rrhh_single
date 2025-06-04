using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace LOSA.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptVoucherV2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptVoucherV2(int slipId)
        {
            InitializeComponent();
            LoadDetalleNominas(slipId);
        }

        private void LoadDetalleNominas(int SlipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringRRHH);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[usp_rpt_planillas_empleados_lineas_detalle]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", 5067);
                //cmd.Parameters.AddWithValue("@slip_id", SlipId);

                dsReporte1.rpt_voucher_detail_ingresos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rpt_voucher_detail);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
