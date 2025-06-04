using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class Conceptos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public int CategoriaID { get; set; }
        public string Categoria { get; set; }
        public int GrupoID { get; set; }
        public string Grupo { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetConceptoById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr.IsDBNull(dr.GetOrdinal("name")) ? "" : dr["name"].ToString();
                        Code = dr.IsDBNull(dr.GetOrdinal("code")) ? "" : dr["code"].ToString();
                        Note = dr.IsDBNull(dr.GetOrdinal("note")) ? "" : dr["note"].ToString();
                        GrupoID = dr.IsDBNull(dr.GetOrdinal("group_by_id")) ? 0 : Convert.ToInt32( dr["group_by_id"].ToString());
                        Grupo = dr.IsDBNull(dr.GetOrdinal("grupo")) ? "" : dr["grupo"].ToString();
                        CategoriaID = dr.IsDBNull(dr.GetOrdinal("category_id")) ? 0 : Convert.ToInt32( dr["category_id"].ToString());
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
