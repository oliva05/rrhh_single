using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaSalaryRule
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Nombre { get; set; }
        public string Note { get; set; }
        public string Categoria { get; set; }
        public int CategoriaID { get; set; }
        public int Secuencia { get; set; }
        public int Cantidad { get; set; }
        public bool ApareceEnNomina { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetSalaryRulesById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "" : dr["nombre"].ToString();
                        Code = dr.IsDBNull(dr.GetOrdinal("code")) ? "" : dr["code"].ToString();
                        Note = dr.IsDBNull(dr.GetOrdinal("nota")) ? "" :  dr["nota"].ToString();
                        CategoriaID = dr.IsDBNull(dr.GetOrdinal("category_id")) ? 0 : Convert.ToInt32(dr["category_id"].ToString());
                        Cantidad= dr.IsDBNull(dr.GetOrdinal("quantity")) ? 0 : Convert.ToInt32(dr["quantity"].ToString());
                        Secuencia= dr.IsDBNull(dr.GetOrdinal("sequence")) ? 0 : Convert.ToInt32(dr["sequence"].ToString());
                        ApareceEnNomina= dr.IsDBNull(dr.GetOrdinal("appears_on_payslip")) ? false :  Convert.ToBoolean(dr["appears_on_payslip"].ToString());
                        Categoria = dr.IsDBNull(dr.GetOrdinal("categoria")) ? "" : dr["categoria"].ToString();
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
