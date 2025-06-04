using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaDepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NombreLargo { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetDepartmentById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr["name"].ToString();
                        NombreLargo = dr["complete_name"].ToString();
                        //Note = dr["note"].ToString();
                        //GrupoID = Convert.ToInt32( dr["group_by_id"].ToString());
                        //Grupo =  dr["grupo"].ToString();
                        //CategoriaID = Convert.ToInt32( dr["group_by_id"].ToString());
                        //Categoria =  dr["categoria"].ToString();
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
