using ACS.Classes;
using DevExpress.Charts.Native;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Logistica.CheckList.Models
{
    internal class CheckList_Header
    {
        public long Id { get; set; }
        public string NumeroInspeccion { get; set; }
        public string Operador { get; set; }
        public string Equipo { get; set; }
        public string Modelo { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal HorometroInicial { get; set; }
        public decimal HorometroFinal { get; set; }
        public decimal HorometroUltimoMantenimiento { get; set; }
        public decimal HorometroProximoMantenimiento { get; set; }
        public int SemanaIspeccion { get; set; }
  
        public bool Recuperado { get; set; }

        public bool RecuperarRegistroPorId(long id_item)
        {
            try
            {

                DataOperations dp = new DataOperations();

                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                {
                    SqlCommand command = new SqlCommand("uspGetChecklist_header_by_id", connection);

                    command.CommandType = CommandType.StoredProcedure;
                    // Agregar el parámetro de entrada
                    command.Parameters.AddWithValue("@Id", id_item);

                    connection.Open();
                    // Ejecutar el comando y leer los resultados
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        Id = id_item;
                        Operador = reader.IsDBNull(reader.GetOrdinal("operador")) ? "" : reader["operador"].ToString();
                        Equipo = reader.IsDBNull(reader.GetOrdinal("equipo")) ? "" : reader["equipo"].ToString();
                        Modelo = reader.IsDBNull(reader.GetOrdinal("modelo")) ? "" : reader["modelo"].ToString();
                        NumeroInspeccion = reader.IsDBNull(reader.GetOrdinal("numero_inspeccion")) ? "" : reader["numero_inspeccion"].ToString();
                        SemanaIspeccion = reader.IsDBNull(reader.GetOrdinal("semana_inspeccion")) ? 0 : Convert.ToInt32(reader["semana_inspeccion"].ToString());
                        HorometroInicial = reader.IsDBNull(reader.GetOrdinal("horometro_inicial")) ? 0 : Convert.ToDecimal(reader["horometro_inicial"].ToString());
                        HorometroFinal = reader.IsDBNull(reader.GetOrdinal("horometro_final")) ? 0 : Convert.ToDecimal(reader["horometro_final"].ToString());
                        HorometroUltimoMantenimiento = reader.IsDBNull(reader.GetOrdinal("horometro_ultimo_mantenimiento")) ? 0 : Convert.ToDecimal(reader["horometro_ultimo_mantenimiento"].ToString());
                        HorometroProximoMantenimiento = reader.IsDBNull(reader.GetOrdinal("horometro_proximo_mantenimiento")) ? 0 : Convert.ToDecimal(reader["horometro_proximo_mantenimiento"].ToString());
                        Fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? (DateTime?)null : Convert.ToDateTime( reader["fecha"].ToString());
                        Observaciones = reader.IsDBNull(reader.GetOrdinal("observaciones")) ? "" : reader["observaciones"].ToString();

                        //IdSubtipo = reader.IsDBNull(reader.GetOrdinal("id_subtipo")) ? 0 : Convert.ToInt32(reader["id_subtipo"].ToString());
                        //IdTipoMantenimiento = reader.IsDBNull(reader.GetOrdinal("id_tipo_mantenimiento")) ? 0 : Convert.ToInt32(reader["id_tipo_mantenimiento"].ToString());
                        //Codigo = reader.IsDBNull(reader.GetOrdinal("codigo")) ? "" : reader["codigo"].ToString();
                        //IdUsuarioCreado = reader.IsDBNull(reader.GetOrdinal("id_usuario_creado")) ? 0 : Convert.ToInt32(reader["id_usuario_creado"].ToString());
                        //IdIndicador = reader.IsDBNull(reader.GetOrdinal("id_indicador")) ? 0 : Convert.ToInt32(reader["id_indicador"].ToString());
                        //IdZona = reader.IsDBNull(reader.GetOrdinal("id_zona")) ? 0 : Convert.ToInt32(reader["id_zona"].ToString());
                        //Valor = reader.IsDBNull(reader.GetOrdinal("valor")) ? 0 : Convert.ToDecimal(reader["valor"].ToString());
                        Recuperado = true;
                    }
                    connection.Close();
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
