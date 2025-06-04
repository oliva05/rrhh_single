using ACS.Classes;
using DevExpress.XtraReports.UI;
using LOSA.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public partial class rptDepreciacion : DevExpress.XtraReports.UI.XtraReport
    {
        int IdPlanilla;
        Funciones func = new Funciones();
        DataOperations dp = new DataOperations();
        public rptDepreciacion(int idPlanilla)
        {
            InitializeComponent();
            IdPlanilla = idPlanilla;

            PlanillaDepreciacion dep = new PlanillaDepreciacion();
            if (dep.RecuperarPlanillaHeader(IdPlanilla))
            {
                lblDescripcion.Text = dep.NamePlanilla;
                lblAnio.Text = dep.Anio.ToString();
                lblMes.Text = func.GetMonthNameForInt(dep.Mes);
                lblTasaCambio.Text = dep.TasaCambio.ToString();
                lblFecha.Text = dep.FechaCreacion.ToString("dd-MM-yyyy");
                lblEstado.Text = dep.Estado;
                lblCreador.Text = dep.UserCreador;
                LoadDetalle();
            }
        }

        private void LoadDetalle()
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[sp_depreciacion_get_detalle_planilla_rpt]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPlanilla", IdPlanilla);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsDepreciacion1.detalle_planilla.Clear();
                adat.Fill(dsDepreciacion1.detalle_planilla);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
