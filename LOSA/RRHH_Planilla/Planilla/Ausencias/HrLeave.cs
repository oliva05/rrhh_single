using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOSA.Clases;

namespace LOSA.RRHH_Planilla.Planilla.Ausencias
{
    public class HrLeave
    {
        
        private bool recuperado;

        private bool aplicado;

        public HrLeave() { }
        public Int64 Id { get; set; } // Mapea la columna [id]
        public string State { get; set; } // Mapea la columna [state]
        public bool PayslipStatus { get; set; } // Mapea la columna [payslip_status]
        public int? HolidayStatusId { get; set; } // Mapea la columna [holiday_status_id]
        public int? EmployeeId { get; set; } // Mapea la columna [employee_id]
        public int? DepartmentId { get; set; } // Mapea la columna [department_id]
        public string Notes { get; set; } // Mapea la columna [notes]
        public DateTime? DateFrom { get; set; } // Mapea la columna [date_from]
        public DateTime? DateTo { get; set; } // Mapea la columna [date_to]
        public DateTime? DateReturn { get; set; } // Mapea la columna [date_return]
        public int NumberOfDays { get; set; } // Mapea la columna [number_of_days]
        public string HolidayType { get; set; } // Mapea la columna [holiday_type]
        public int IdEstado { get; set; } // Mapea la columna [id_estado]
        public int? CategoriaId { get; set; } // Mapea la columna [categoria_id]
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public bool Aplicado { get => aplicado; set => aplicado = value; }
        
        public bool RecuperarDetalleAusencias(int pId)
        {

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_get_rrhh_leave_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", pId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id"));
                    State = reader.GetString(reader.GetOrdinal("state"));
                    PayslipStatus = reader.GetBoolean(reader.GetOrdinal("payslip_status"));
                    HolidayStatusId = reader.GetInt32(reader.GetOrdinal("holiday_status_id"));
                    EmployeeId =reader.GetInt32(reader.GetOrdinal("employee_id"));
                    DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id"));
                    Notes = reader.GetString(reader.GetOrdinal("notes"));
                    DateFrom = reader.GetDateTime(reader.GetOrdinal("date_from"));
                    DateTo = reader.GetDateTime(reader.GetOrdinal("date_to"));
                    DateReturn = reader["date_return"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["date_return"].ToString());
                    HolidayType = reader.GetString(reader.GetOrdinal("holiday_type"));
                    NumberOfDays = reader.GetInt32(reader.GetOrdinal("number_of_days"));
                    
                    IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));
                    CategoriaId = reader.IsDBNull(reader.GetOrdinal("categoria_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("categoria_id"));
                    Aplicado = reader.GetBoolean(reader.GetOrdinal("aplicado"));
                    reader.Close();
                    Recuperado = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                Recuperado = false;
            }

            return Recuperado;
        }

    }
}
