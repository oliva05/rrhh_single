using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Capacitacion.Model
{
    public class CapacitacionTipoAdjunto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Boolean Recuperado { get; set; }

        public Boolean RecuperarDatosPorId(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("uspGetTipoAdjunto_capacitacion_class", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Id = id;
                        Descripcion= dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" : dr["descripcion"].ToString();
                    }
                    cnx.Close();
                    Recuperado = true;
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
