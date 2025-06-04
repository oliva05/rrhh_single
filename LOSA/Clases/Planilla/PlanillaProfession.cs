using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaProfession
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime WriteDate { get; set; }
        public int CreateUID { get; set; }
        public int WriteUID { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetProfesionById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr["name"].ToString();
                        CreateDate = Convert.ToDateTime( dr["create_date"].ToString());
                        //Code = dr["code"].ToString();
                        //GroupID = Convert.ToInt32( dr["group_id"].ToString());
                        //CompanyID = Convert.ToInt32( dr["company_id"].ToString());
                        //MonedaID = Convert.ToInt32( dr["currency_id"].ToString());
                        
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
