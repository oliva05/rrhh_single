using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaSalaryRuleCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public bool Provisional { get; set; }
        public bool Deducible { get; set; }
        public bool Patronal { get; set; }
        public bool Recuperado { get; set; }


        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetSalaryRuleCategory", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr["name"].ToString();
                        Code = dr["code"].ToString();
                        Note = dr["note"].ToString();
                        Deducible = Convert.ToBoolean( dr["isrdeductible"].ToString());
                        Patronal = Convert.ToBoolean( dr["patronal"].ToString());
                        Provisional = Convert.ToBoolean( dr["provision"].ToString());
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
