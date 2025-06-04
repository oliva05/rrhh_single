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
    
    public class Payslip_Run
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int CreateUid { get; set; }
        public DateTime CreateDate { get; set; }
        public int NumberOfDays { get; set; }
        public int PayrollTypeId { get; set; }
        public decimal TotalInTransference { get; set; } // Use decimal for financial values
        public decimal Rate { get; set; } // Use decimal for financial values
        public int CurrencyId { get; set; }
        public string PayslipNumber { get; set; }
        public string Observation { get; set; } // Nullable if it can be null in the database
        public int Anio { get; set; }
        public int Quincena { get; set; }
        public int IdEstado { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string UsuarioName { get; set; }
        public string PayrollTypeName { get; set; }
        public bool Recuperado { get; set; }
        public int LineaNum_orden {  get; set; }

        public Payslip_Run()
        {

        }

        public bool RecuperarRegistro(int idPayslipRun)
        {
            DataOperations dp = new DataOperations();
            Recuperado = false;
            // Create and open a SQL connection
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
            {
                try
                {
                    connection.Open();

                    // Create the command for the stored procedure
                    using (SqlCommand command = new SqlCommand("sp_get_list_planillas_home_by_id", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_payslip_run", idPayslipRun);

                        // Execute the command and retrieve the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Read the first row of the result
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id"));
                                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString(reader.GetOrdinal("name"));
                                State = reader.IsDBNull(reader.GetOrdinal("state")) ? null : reader.GetString(reader.GetOrdinal("state"));

                                if (!reader.IsDBNull(reader.GetOrdinal("date_start")))
                                    DateStart = reader.GetDateTime(reader.GetOrdinal("date_start"));

                                if (!reader.IsDBNull(reader.GetOrdinal("date_end")))
                                    DateEnd = reader.GetDateTime(reader.GetOrdinal("date_end"));

                                if (!reader.IsDBNull(reader.GetOrdinal("create_uid")))
                                    CreateUid = reader.GetInt32(reader.GetOrdinal("create_uid"));

                                if (!reader.IsDBNull(reader.GetOrdinal("create_date")))
                                    CreateDate = reader.GetDateTime(reader.GetOrdinal("create_date"));

                                if (!reader.IsDBNull(reader.GetOrdinal("number_of_days")))
                                    NumberOfDays = reader.GetInt32(reader.GetOrdinal("number_of_days"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payroll_type_id")))
                                    PayrollTypeId = reader.GetInt32(reader.GetOrdinal("payroll_type_id"));

                                if (!reader.IsDBNull(reader.GetOrdinal("total_in_transference")))
                                    TotalInTransference = reader.GetDecimal(reader.GetOrdinal("total_in_transference"));

                                if (!reader.IsDBNull(reader.GetOrdinal("rate")))
                                    Rate = reader.GetDecimal(reader.GetOrdinal("rate"));

                                if (!reader.IsDBNull(reader.GetOrdinal("currency_id")))
                                    CurrencyId = reader.GetInt32(reader.GetOrdinal("currency_id"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payslip_number")))
                                    PayslipNumber = reader.GetString(reader.GetOrdinal("payslip_number"));

                                Observation = reader.IsDBNull(reader.GetOrdinal("observation")) ? null : reader.GetString(reader.GetOrdinal("observation"));

                                if (!reader.IsDBNull(reader.GetOrdinal("anio")))
                                    Anio = reader.GetInt32(reader.GetOrdinal("anio"));

                                if (!reader.IsDBNull(reader.GetOrdinal("quincena")))
                                    Quincena = reader.GetInt32(reader.GetOrdinal("quincena"));

                                if (!reader.IsDBNull(reader.GetOrdinal("id_estado")))
                                    IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));

                                if (!reader.IsDBNull(reader.GetOrdinal("currency_name")))
                                    CurrencyName = reader.GetString(reader.GetOrdinal("currency_name"));

                                if (!reader.IsDBNull(reader.GetOrdinal("currency_symbol")))
                                    CurrencySymbol = reader.GetString(reader.GetOrdinal("currency_symbol"));

                                if (!reader.IsDBNull(reader.GetOrdinal("usuario_name")))
                                    UsuarioName = reader.GetString(reader.GetOrdinal("usuario_name"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payroll_type_name")))
                                    PayrollTypeName = reader.GetString(reader.GetOrdinal("payroll_type_name"));

                                Recuperado = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    CajaDialogo.Error(ex.Message);
                }
            }

            return Recuperado;
        }

        public bool RecuperarRegistroBySlipId(int idSlipId)
        {
            DataOperations dp = new DataOperations();
            Recuperado = false;
            // Create and open a SQL connection
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
            {
                try
                {
                    connection.Open();

                    // Create the command for the stored procedure
                    using (SqlCommand command = new SqlCommand("[sp_get_list_planillas_home_by_slip_id]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@slip_id", idSlipId);

                        // Execute the command and retrieve the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Read the first row of the result
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id"));
                                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString(reader.GetOrdinal("name"));
                                State = reader.IsDBNull(reader.GetOrdinal("state")) ? null : reader.GetString(reader.GetOrdinal("state"));

                                if (!reader.IsDBNull(reader.GetOrdinal("date_start")))
                                    DateStart = reader.GetDateTime(reader.GetOrdinal("date_start"));

                                if (!reader.IsDBNull(reader.GetOrdinal("date_end")))
                                    DateEnd = reader.GetDateTime(reader.GetOrdinal("date_end"));

                                if (!reader.IsDBNull(reader.GetOrdinal("create_uid")))
                                    CreateUid = reader.GetInt32(reader.GetOrdinal("create_uid"));

                                if (!reader.IsDBNull(reader.GetOrdinal("create_date")))
                                    CreateDate = reader.GetDateTime(reader.GetOrdinal("create_date"));

                                if (!reader.IsDBNull(reader.GetOrdinal("number_of_days")))
                                    NumberOfDays = reader.GetInt32(reader.GetOrdinal("number_of_days"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payroll_type_id")))
                                    PayrollTypeId = reader.GetInt32(reader.GetOrdinal("payroll_type_id"));

                                if (!reader.IsDBNull(reader.GetOrdinal("total_in_transference")))
                                    TotalInTransference = reader.GetDecimal(reader.GetOrdinal("total_in_transference"));

                                if (!reader.IsDBNull(reader.GetOrdinal("rate")))
                                    Rate = reader.GetDecimal(reader.GetOrdinal("rate"));

                                if (!reader.IsDBNull(reader.GetOrdinal("currency_id")))
                                    CurrencyId = reader.GetInt32(reader.GetOrdinal("currency_id"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payslip_number")))
                                    PayslipNumber = reader.GetString(reader.GetOrdinal("payslip_number"));

                                Observation = reader.IsDBNull(reader.GetOrdinal("observation")) ? null : reader.GetString(reader.GetOrdinal("observation"));

                                if (!reader.IsDBNull(reader.GetOrdinal("anio")))
                                    Anio = reader.GetInt32(reader.GetOrdinal("anio"));

                                if (!reader.IsDBNull(reader.GetOrdinal("quincena")))
                                    Quincena = reader.GetInt32(reader.GetOrdinal("quincena"));

                                if (!reader.IsDBNull(reader.GetOrdinal("id_estado")))
                                    IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));

                                if (!reader.IsDBNull(reader.GetOrdinal("currency_name")))
                                    CurrencyName = reader.GetString(reader.GetOrdinal("currency_name"));

                                if (!reader.IsDBNull(reader.GetOrdinal("usuario_name")))
                                    UsuarioName = reader.GetString(reader.GetOrdinal("usuario_name"));

                                if (!reader.IsDBNull(reader.GetOrdinal("payroll_type_name")))
                                    PayrollTypeName = reader.GetString(reader.GetOrdinal("payroll_type_name"));

                                Recuperado = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    CajaDialogo.Error(ex.Message);
                }
            }

            return Recuperado;
        }



    }
}
