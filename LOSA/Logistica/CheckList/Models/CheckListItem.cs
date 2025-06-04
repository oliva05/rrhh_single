using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Logistica.CheckList.Models
{
    public class CheckListItem
    {       
            public int Id { get; set; }
            public string NombreCorto { get; set; }
            public string NombreLargo { get; set; }
            public string Barcode { get; set; }
            public string Modelo { get; set; }
            public int IdTipo { get; set; }
            public int IdSubtipo { get; set; }
            public string OemBase { get; set; }
            public int IdTipoMantenimiento { get; set; }
            public string Codigo { get; set; }
            public int IdUsuarioCreado { get; set; }
            public int IdIndicador { get; set; }
            public decimal MontoMantenimientoPreventivo { get; set; }
            public int IdZona { get; set; }
            public decimal Valor { get; set; }
            public bool Enable { get; set; }
            public bool Recuperado { get; set; }

            public bool RecuperarRegistroPorId(int id_item)
            {
                try
                {

                    DataOperations dp = new DataOperations();

                    using (SqlConnection connection = new SqlConnection(dp.ConnectionStringLOSA))
                    {
                        SqlCommand command = new SqlCommand("uspGetChecklistItemById", connection);

                    command.CommandType = CommandType.StoredProcedure;
                    // Agregar el parámetro de entrada
                    command.Parameters.AddWithValue("@Id", id_item);

                    connection.Open();
                    // Ejecutar el comando y leer los resultados
                    SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            Id = id_item;
                            NombreCorto = reader.IsDBNull(reader.GetOrdinal("nombre_corto")) ? "" : reader["nombre_corto"].ToString();
                            NombreLargo = reader.IsDBNull(reader.GetOrdinal("nombre_largo")) ? "" : reader["nombre_largo"].ToString();
                            Barcode = reader.IsDBNull(reader.GetOrdinal("barcode")) ? "" : reader["barcode"].ToString();
                            Modelo = reader.IsDBNull(reader.GetOrdinal("modelo")) ? "" : reader["modelo"].ToString();
                            IdTipo = reader.IsDBNull(reader.GetOrdinal("id_tipo")) ? 0 : Convert.ToInt32(reader["id_tipo"].ToString());
                            IdSubtipo = reader.IsDBNull(reader.GetOrdinal("id_subtipo")) ? 0 : Convert.ToInt32(reader["id_subtipo"].ToString());
                            OemBase = reader.IsDBNull(reader.GetOrdinal("oem_base")) ? "" : reader["oem_base"].ToString();
                            IdTipoMantenimiento = reader.IsDBNull(reader.GetOrdinal("id_tipo_mantenimiento")) ? 0 : Convert.ToInt32(reader["id_tipo_mantenimiento"].ToString());
                            Codigo = reader.IsDBNull(reader.GetOrdinal("codigo")) ? "" : reader["codigo"].ToString();
                            IdUsuarioCreado = reader.IsDBNull(reader.GetOrdinal("id_usuario_creado")) ? 0 : Convert.ToInt32(reader["id_usuario_creado"].ToString());
                            IdIndicador = reader.IsDBNull(reader.GetOrdinal("id_indicador")) ? 0 : Convert.ToInt32(reader["id_indicador"].ToString());
                            MontoMantenimientoPreventivo = reader.IsDBNull(reader.GetOrdinal("monto_mantenimiento_preventivo")) ? 0 : Convert.ToDecimal(reader["monto_mantenimiento_preventivo"].ToString());
                            IdZona = reader.IsDBNull(reader.GetOrdinal("id_zona")) ? 0 : Convert.ToInt32(reader["id_zona"].ToString());
                            Valor = reader.IsDBNull(reader.GetOrdinal("valor")) ? 0 : Convert.ToDecimal(reader["valor"].ToString());
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
