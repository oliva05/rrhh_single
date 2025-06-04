using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Capacitacion.Model
{
    public class CapacitacionClass
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string   Asunto { get; set; }
        public string   Ubicacion { get; set; }
        public string   Proveedor { get; set; }
        public string   Estado { get; set; }
        public string   Descripcion { get; set; }
        public int   EstadoId { get; set; }
        public int   MonedaId { get; set; }
        public DateTime?   FechaProgramada { get; set; }
        public DateTime?   FechaEjecucion { get; set; }
        public decimal   Costo { get; set; }
        public decimal   Duracion { get; set; }
        public decimal   TotalHours { get; set; }
        public Boolean Recuperado { get; set; }
        public DataTable CapacitadoresDT { get; set; }
        public DataTable EmpleadosDT { get; set; }
        public string   Moneda { get; set; }
        public string   Simbolo { get; set; }
        public CapacitacionClass()
        {
            //Llenar el DataTable para @empleados
            CapacitadoresDT = new DataTable();
            EmpleadosDT = new DataTable();

            EmpleadosDT.Columns.Add("id_employee", typeof(int));

            CapacitadoresDT.Columns.Add("id", typeof(int));
            CapacitadoresDT.Columns.Add("nombre", typeof(string));
            CapacitadoresDT.Columns.Add("contacto", typeof(string));
        }

        public bool RecuperaRegistrosByCapacitacionId(int id_capacitacion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                 using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("uspGetCapacitaciones_by_Id_header_Class", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_capacitacion", id_capacitacion);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id_capacitacion;
                        FechaProgramada = dr["fecha_programada"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_programada"].ToString());
                        FechaEjecucion = dr["fecha_ejecucion"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_ejecucion"].ToString());
                        Duracion = dr.IsDBNull(dr.GetOrdinal("duration_hours")) ? 0 : Convert.ToDecimal(dr["duration_hours"].ToString());
                        Costo = dr.IsDBNull(dr.GetOrdinal("costo")) ? 0 : Convert.ToDecimal(dr["costo"].ToString());
                        Nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? "" :  dr["nombre"].ToString();
                        EstadoId = dr.IsDBNull(dr.GetOrdinal("id_estado")) ? 0 : Convert.ToInt32(dr["id_estado"].ToString());
                        Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" :  dr["estado"].ToString();
                        Asunto = dr.IsDBNull(dr.GetOrdinal("asunto")) ? "" :  dr["asunto"].ToString();
                        Descripcion = dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" :  dr["descripcion"].ToString();
                        Proveedor = dr.IsDBNull(dr.GetOrdinal("proveedor")) ? "" :  dr["proveedor"].ToString();
                        Ubicacion = dr.IsDBNull(dr.GetOrdinal("ubicacion")) ? "" : dr["ubicacion"].ToString();
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? "" : dr["moneda"].ToString();
                        Simbolo = dr.IsDBNull(dr.GetOrdinal("simbolo")) ? "" : dr["simbolo"].ToString();
                        MonedaId = dr.IsDBNull(dr.GetOrdinal("currency_id")) ? 0 : Convert.ToInt32(dr["currency_id"].ToString());
                        TotalHours = dr.IsDBNull(dr.GetOrdinal("total_hours")) ? 0 : Convert.ToDecimal(dr["total_hours"].ToString());

                        Recuperado = true;
                    }
                    cnx.Close();

                }

                //CapacitadoresDT = RecuperarCapacitadores(id_capacitacion);

                return Recuperado;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
         
        public string CambiarMonedaCostoCapacitacion(int id_capacitacion,int id_moneda)
        {
            DataOperations dp = new DataOperations();
            string messageRsult = "";

            if (id_moneda==0)
            {
                id_moneda = 2;
            }

            using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("uspExchangeCurrency_capacitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@current_currency_id", id_moneda);
                cmd.Parameters.AddWithValue("@id_capacitacion", id_capacitacion);

                messageRsult = cmd.ExecuteScalar().ToString();
                cnx.Close();
            }

            //RecuperaRegistrosByCapacitacionId(id_capacitacion);

            return messageRsult;
        }

    }

    public class Capacitadores
    {
        public string Nombre { get; set; }
        public string Contacto { get; set; }
    }

    public class Empleados
    {
        public int EmpleadoId { get; set; }
    }
}
