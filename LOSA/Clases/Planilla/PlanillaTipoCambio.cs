using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaTipoCambio
    {
        public int ID { get; set; }
        public string MonedaProcedencia { get; set; }
        public int MonedaProcedenciaID { get; set; }
        public string MonedaDestino { get; set; }
        public int MonedaDestinoID { get; set; }
        public DateTime FechaTC { get; set; }
        public Decimal Monto { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetTipoCambioById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        MonedaProcedencia = dr["MonedaProcedencia"].ToString();
                        MonedaDestino = dr["MonedaDestino"].ToString();
                        MonedaProcedenciaID = Convert.ToInt32(dr["id_moneda_procedencia"].ToString());
                        MonedaDestinoID = Convert.ToInt32(dr["id_moneda_destino"].ToString());
                        Monto = Convert.ToDecimal(dr["MontoTipoCambio"].ToString());
                        FechaTC = Convert.ToDateTime(dr["FechaTipoCambio"].ToString());
                        

                        Recuperado = true;
                    }
                    cnx.Close();

                }

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
