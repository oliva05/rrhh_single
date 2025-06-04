using ACS.Classes;
using DocumentFormat.OpenXml.Drawing.Charts;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LOSA.RRHH_Planilla.Capacitacion.Model
{
    public class CapacitacionPresupuestoClass
    {
        public int Id { get; set; }
        public int Anio { get; set; }
        public string Descripcion { get; set; }
        public decimal Presupuesto { get; set; }
        public decimal MontoCambio { get; set; }
        public int CurrencyID { get; set; }
        public string Moneda { get; set; }
        public string Simbolo { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistrosById(int id_presupuesto)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("uspGet_ppto_capacitacion_by_id_class", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_presupuesto", id_presupuesto);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id_presupuesto;
                        Presupuesto = dr.IsDBNull(dr.GetOrdinal("presupuesto_asignado")) ? 0 : Convert.ToDecimal(dr["presupuesto_asignado"].ToString());
                        MontoCambio = dr.IsDBNull(dr.GetOrdinal("monto_cambio")) ? 0 : Convert.ToDecimal(dr["monto_cambio"].ToString());
                        Anio = dr.IsDBNull(dr.GetOrdinal("anio")) ? 0 : Convert.ToInt32(dr["anio"].ToString());
                        Descripcion = dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" : dr["descripcion"].ToString();
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? "" : dr["moneda"].ToString();
                        Simbolo = dr.IsDBNull(dr.GetOrdinal("symbol")) ? "" : dr["symbol"].ToString();
                        CurrencyID= dr.IsDBNull(dr.GetOrdinal("currency_id")) ? 0 : Convert.ToInt32(dr["currency_id"].ToString());
                        Recuperado = true;
                    }
                    cnx.Close();

                }

                //CapacitadoresDT = RecuperarCapacitadores(id_capacitacion);

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}
