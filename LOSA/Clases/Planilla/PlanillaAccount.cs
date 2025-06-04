using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaAccount
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? GroupID { get; set; }
        public int? CompanyID { get; set; }
        public int? MonedaID { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetAccountById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr.IsDBNull(dr.GetOrdinal("name")) ? "" : dr["name"].ToString();
                        Note = dr.IsDBNull(dr.GetOrdinal("note")) ? "" : dr["note"].ToString();
                        Code = dr.IsDBNull(dr.GetOrdinal("code")) ? "" : dr["code"].ToString();
                        GroupID = dr.IsDBNull(dr.GetOrdinal("group_id")) ? 0 : Convert.ToInt32( dr["group_id"].ToString());
                        CompanyID = dr.IsDBNull(dr.GetOrdinal("company_id")) ? 0 : Convert.ToInt32( dr["company_id"].ToString());
                        MonedaID = dr.IsDBNull(dr.GetOrdinal("currency_id")) ? 0 : Convert.ToInt32( dr["currency_id"].ToString());
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
