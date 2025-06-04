using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PaySlip
    {
        public int PaySlip_id { get; set; }
        public int LineaNum_Orden { get; set; }

        public int StructId { get; set; }           // A.[struct_id]
        public int EmployeeId { get; set; }         // A.[employee_id]
        public string EmployeeCode { get; set; }    // B.[barcode] as [employee_code]
        public string EmployeeName { get; set; }    // A.[name] as [employee_name]
        public DateTime DateFrom { get; set; }      // A.[date_from]
        public DateTime DateTo { get; set; }        // A.[date_to]
        public string State { get; set; }           // A.[state]
        public int PayslipRunId { get; set; }       // A.[payslip_run_id]
        public bool Enable { get; set; }            // A.[enable]
        public string Codigo { get; set; }          // A.[codigo] del empleado
        public string Departamento { get; set; }    // A.[departamento]
        public string Puesto { get; set; }          // A.[puesto]
        public string Turno { get; set; }           // A.[turno]
        public bool Recuperado { get; set; }

        public PaySlip() { }


        public bool RecuperarRegistro(int pPaySlipID) 
        {
            Recuperado = false;
            DataOperations dp = new DataOperations();
            try
            {
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringRRHH))
                using (SqlCommand command = new SqlCommand("dbo.spGetClasePaySlip_By_Id", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idPaySlip", pPaySlipID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            StructId = reader.GetInt32(reader.GetOrdinal("struct_id"));
                            EmployeeId = reader.GetInt32(reader.GetOrdinal("employee_id"));
                            EmployeeCode = reader.GetString(reader.GetOrdinal("employee_code"));
                            EmployeeName = reader.GetString(reader.GetOrdinal("employee_name"));
                            DateFrom = reader.GetDateTime(reader.GetOrdinal("date_from"));
                            DateTo = reader.GetDateTime(reader.GetOrdinal("date_to"));
                            State = reader.GetString(reader.GetOrdinal("state"));
                            PayslipRunId = reader.GetInt32(reader.GetOrdinal("payslip_run_id"));
                            Enable = reader.GetBoolean(reader.GetOrdinal("enable"));
                            Codigo = reader.GetString(reader.GetOrdinal("codigo"));
                            Departamento = reader.GetString(reader.GetOrdinal("departamento"));
                            Puesto = reader.GetString(reader.GetOrdinal("puesto"));
                            Turno = reader.GetString(reader.GetOrdinal("turno"));
                            Recuperado = true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado; 
        }
    }
}
