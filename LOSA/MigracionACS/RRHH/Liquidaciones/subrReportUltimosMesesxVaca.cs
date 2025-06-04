using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using ACS.Classes;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.PostgreSql;
using LOSA.Classes;

namespace LOSA.MigracionACS.RRHH.Liquidaciones
{
    public partial class subrReportUltimosMesesxVaca : DevExpress.XtraReports.UI.XtraReport
    {
        int Id_Empleado, anio, IdContrato;
        decimal diasTomados;
        string Moneda = "L";

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            
        }

        private void xrTableCell1_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void xrTableCell1_EvaluateBinding(object sender, BindingEventArgs e)
        {
            string val = e.Value.ToString();
            switch (val)
            {
                case "Total":
                    xrTable1.Rows[xrTableCell1.Index].BackColor = Color.Gainsboro;
                    xrTableCell1.BackColor = Color.Gainsboro;
                    break;
                case "Promedio":
                    xrTable1.Rows[xrTableCell1.Index].BackColor = Color.Gainsboro;
                    xrTableCell1.BackColor = Color.Gainsboro;
                    break;
                default:
                       xrTableCell1.BackColor = Color.White;
                    break;
            } 
        }

        public subrReportUltimosMesesxVaca(int pId_Empleado, int panio, Decimal pdiasTomados)
        {
            InitializeComponent();

            Id_Empleado = pId_Empleado;
            pp_anios.Value = anio = panio;
            pp_dias_tomados.Value = diasTomados = pdiasTomados;

            Liquidacion liqui = new Liquidacion();
            liqui.RecuperarHeaderLiquidacionForEmpleado(Id_Empleado);
            lblSalarioPrMensual.Text = Convert.ToString(liqui.salario_pro_mensual);

            //LoadVacaciones();
            //foreach (dsRRHH_.LiquiUltimosMesesRow row in dsRRHH_1.LiquiUltimosMeses)
            //{
            //    string.Format("{0:0.00}", row.sueldo_recibido);
            //    string.Format("{0:0.00}", row.bono);
            //    string.Format("{0:0.00}", row.comisiones);
            //    string.Format("{0:0.00}", row.horas_extra);
            //    string.Format("{0:0.00}", row.incentivo);
            //    string.Format("{0:0.00}", row.total);
            //}
        }

        public subrReportUltimosMesesxVaca(int pId_Empleado, int panio, Decimal pdiasTomados,int pIdContrato)
        {
            InitializeComponent();

            Id_Empleado = pId_Empleado;
            pp_anios.Value = anio = panio;
            pp_dias_tomados.Value = diasTomados = pdiasTomados;
            IdContrato = pIdContrato;
            int IdLiqLocal = 0;
            try
            {
                DataOperations dp = new DataOperations();
                string query = @"sp_get_RRHH_liquidacion_header_datos";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empleado", Id_Empleado);
                cmd.Parameters.AddWithValue("@id_contrato", IdContrato);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    IdLiqLocal = DR.GetInt32(0);
                }
                DR.Close();
                conn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            Liquidacion liqui = new Liquidacion();
            //liqui.RecuperarHeaderLiquidacionForEmpleado(Id_Empleado);

            liqui.RecuperarHeaderLiquidacion(IdLiqLocal);
            lblSalarioPrMensual.Text = Convert.ToString(liqui.salario_pro_mensual);

            if (liqui.IdCatEmpleado == 2)
            {
                xrTableCell2.TextFormatString = "{0:$ ##,###,##0.00}";
                xrTableCell3.TextFormatString = "{0:$ ##,###,##0.00}";
                xrTableCell4.TextFormatString = "{0:$ ##,###,##0.00}";
                xrTableCell5.TextFormatString = "{0:$ ##,###,##0.00}";
                xrTableCell6.TextFormatString = "{0:$ ##,###,##0.00}";
                xrTableCell7.TextFormatString = "{0:$ ##,###,##0.00}";
                lblSalarioPrMensual.TextFormatString = "{0:$ ##,###,##0.00}";
            }
            else
            {
                xrTableCell2.TextFormatString = "{0:L ##,###,##0.00}";
                xrTableCell3.TextFormatString = "{0:L ##,###,##0.00}";
                xrTableCell4.TextFormatString = "{0:L ##,###,##0.00}";
                xrTableCell5.TextFormatString = "{0:L ##,###,##0.00}";
                xrTableCell6.TextFormatString = "{0:L ##,###,##0.00}";
                xrTableCell7.TextFormatString = "{0:L ##,###,##0.00}";
                lblSalarioPrMensual.TextFormatString = "{0:L ##,###,##0.00}";
            }

        }
    }
}
