using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaTipoContrato
    {
        public int ID { get; set; }
        public string Name { get; set; }
        

        public int ConfVacaciones { get; set; }
        public int HorarioVacacionesTrabajo { get; set; }
        public int HorarioTrabajo { get; set; }
        public int Secuencia { get; set; }
        public int FormatoContratoId { get; set; }
        public string PagoProgramado { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("dbo.uspGetTipoContratoById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name =dr.IsDBNull(dr.GetOrdinal("nombre")) ? "" : dr.GetString(dr.GetOrdinal("nombre"));
                        PagoProgramado = dr.IsDBNull(dr.GetOrdinal("pago_programado")) ? "" : dr.GetString( dr.GetOrdinal("pago_programado"));
                        Secuencia = dr.IsDBNull(dr.GetOrdinal("secuencia"))  ? 0 : Convert.ToInt32( dr["secuencia"].ToString());
                        ConfVacaciones = dr.IsDBNull(dr.GetOrdinal("configuracion_vacaciones")) ? 0 : Convert.ToInt32( dr["configuracion_vacaciones"].ToString());
                        HorarioTrabajo = dr.IsDBNull(dr.GetOrdinal("horario_trabajo")) ? 0 : Convert.ToInt32( dr["horario_trabajo"].ToString());
                        HorarioVacacionesTrabajo = dr.IsDBNull(dr.GetOrdinal("horario_vacaciones_trabajo")) ? 0 : Convert.ToInt32( dr["horario_vacaciones_trabajo"].ToString());
                        FormatoContratoId = dr.IsDBNull(dr.GetOrdinal("formato_contrato")) ? 0 : dr.GetInt32(dr.GetOrdinal("formato_contrato"));
                        CreateDate = dr.IsDBNull(dr.GetOrdinal("fecha_creacion")) ? DateTime.Now : Convert.ToDateTime( dr["fecha_creacion"].ToString());
    

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
