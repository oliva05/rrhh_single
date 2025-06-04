using ACS.Classes;
using DocumentFormat.OpenXml.Drawing.Charts;
using LOSA.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LOSA.RRHH_Planilla.Gestiones.Models
{
    public class ProcesoDisciplinarioClass
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int SancionId { get; set; }
        public int EmpleadoId { get; set; }
        public string Descripcion { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistrosPorId(int id_proceso)
        {
            try
            {
                DataOperations dp = new DataOperations();

                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("uspGetProcesosDisciplinariosById", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_proceso", id_proceso);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id_proceso;
                        Fecha = dr["fecha_sancion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_sancion"].ToString());                        
                        EmpleadoId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());
                        SancionId = dr.IsDBNull(dr.GetOrdinal("id_sancion")) ? 0 : Convert.ToInt32(dr["id_sancion"].ToString());
                        Descripcion = dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" : dr["descripcion"].ToString();                  

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
