using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACS.Classes;

namespace LOSA.Clases.Planilla
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Active { get; set; }
        public decimal Rate { get; set; }

        public Currency() { }   

        public Currency GetCurrencyById(int id)
        {
            var currency = new Currency();
            DataOperations dp = new DataOperations();
            using (var connection = new SqlConnection(dp.ConnectionStringRRHH))
            {
                connection.Open();
                var query = "SELECT [id], [name], [symbol], [active] FROM [RRHH].[dbo].[res_currency] WHERE [id] = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            // Directly set properties, avoiding null values
                            this.Id = currency.Id = !reader.IsDBNull(reader.GetOrdinal("id")) ? reader.GetInt32(reader.GetOrdinal("id")) : default;
                            this.Name = currency.Name = !reader.IsDBNull(reader.GetOrdinal("name")) ? reader.GetString(reader.GetOrdinal("name")) : string.Empty;
                            this.Symbol = currency.Symbol = !reader.IsDBNull(reader.GetOrdinal("symbol")) ? reader.GetString(reader.GetOrdinal("symbol")) : string.Empty;
                            this.Active = currency.Active = !reader.IsDBNull(reader.GetOrdinal("active")) && reader.GetBoolean(reader.GetOrdinal("active"));
                        }
                    }
                }
            }

            return currency;
        }


    }



        
    
}
