using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class EstructuraSalarial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int MonedaId { get; set; }
        public int CompaniaId { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("usp_Get_estructura_salarial_by_id_class", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id;
                        Nombre = dr.IsDBNull(dr.GetOrdinal("name")) ? "" : dr["name"].ToString();
                        Codigo = dr.IsDBNull(dr.GetOrdinal("code")) ? "" : dr["code"].ToString();
                        MonedaId = dr.IsDBNull(dr.GetOrdinal("currency_id")) ? 0: Convert.ToInt32( dr["currency_id"].ToString());
                        CompaniaId = dr.IsDBNull(dr.GetOrdinal("company_id")) ? 0 : Convert.ToInt32(dr["company_id"].ToString());
                    
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
