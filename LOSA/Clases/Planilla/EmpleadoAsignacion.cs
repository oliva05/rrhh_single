using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class EmpleadoAsignacion
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int Cantidad { get; set; }
        public int TipoAsignacionId { get; set; }
        public string Talla { get; set; }
        public DateTime FechaCreacion { get; set; }
  
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetAsignacionById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id;
                        Talla = dr.IsDBNull(dr.GetOrdinal("talla")) ? "" : dr["talla"].ToString();
                        Cantidad = dr.IsDBNull(dr.GetOrdinal("cantidad")) ? 0 : Convert.ToInt32( dr["cantidad"].ToString());
                        TipoAsignacionId = dr.IsDBNull(dr.GetOrdinal("id_asignacion_tipo")) ? 0 : Convert.ToInt32(dr["id_asignacion_tipo"].ToString());
                        EmpleadoId = dr.IsDBNull(dr.GetOrdinal("id_employee")) ? 0 : Convert.ToInt32(dr["id_employee"].ToString());
 
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
