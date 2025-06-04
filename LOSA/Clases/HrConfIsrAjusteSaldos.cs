using System;
using System.Data;
using System.Data.SqlClient;

public class HrConfIsrAjusteSaldos
{
    public int Id { get; set; }
    public int IdEmployee { get; set; }
    public int Anio { get; set; }
    public int Cuotas { get; set; }
    public decimal Monto { get; set; }
    public bool Enable { get; set; }
    public decimal Ingresos { get; set; }
    public decimal MontoAfp { get; set; }
    public bool Recuperado { get; set; }

    // Constructor
    public HrConfIsrAjusteSaldos()
    {
        // Initialize properties with default values if necessary
    }

    // Method to retrieve data using the stored procedure
    public HrConfIsrAjusteSaldos GetHrConfIsrAjusteSaldosById(int id, string connectionString)
    {
        var ajusteSaldos = new HrConfIsrAjusteSaldos();
        Recuperado = false;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("sp_GetHrConfIsrAjusteSaldosById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ajusteSaldos.Id = (int)reader["id"];
                        ajusteSaldos.IdEmployee = (int)reader["id_employee"];
                        ajusteSaldos.Anio = (int)reader["anio"];
                        ajusteSaldos.Cuotas = (int)reader["cuotas"];
                        ajusteSaldos.Monto = (decimal)reader["monto"];
                        ajusteSaldos.Enable = (bool)reader["enable"];
                        ajusteSaldos.Ingresos = (decimal)reader["ingresos"];
                        ajusteSaldos.MontoAfp = (decimal)reader["monto_afp"];
                        ajusteSaldos.Recuperado = true;
                        Recuperado = true;
                    }
                }
            }
        }

        return ajusteSaldos;
    }
}
