using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaTipoPlanilla
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool WorkedDay { get; set; }
        public bool HolidayDays { get; set; }
        public bool Historical { get; set; }
        public int SchedulePayId { get; set; }
        public string SchedulePay { get; set; }
        public string ComputeType { get; set; }
        public int CurrencyID { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string CurrencyName { get; set; }
        public bool Recuperado { get; set; }
        public int Id_Struct_Related { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetTipoPlanillaById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        if (!dr.IsDBNull(dr.GetOrdinal("name")))
                            Name = dr["name"].ToString();

                        if (!dr.IsDBNull(dr.GetOrdinal("worked_days")))
                            WorkedDay = Convert.ToBoolean(dr["worked_days"].ToString());

                        if (!dr.IsDBNull(dr.GetOrdinal("holiday_days")))
                            HolidayDays = Convert.ToBoolean(dr["holiday_days"].ToString());

                        if (!dr.IsDBNull(dr.GetOrdinal("historical")))
                            Historical = Convert.ToBoolean(( dr["historical"].ToString()));

                        if (!dr.IsDBNull(dr.GetOrdinal("schedule_pay")))
                            SchedulePay =   dr["schedule_pay"].ToString() ;

                        if (!dr.IsDBNull(dr.GetOrdinal("compute_type")))
                            ComputeType =  dr["compute_type"].ToString();

                        if (!dr.IsDBNull(dr.GetOrdinal("currency_id")))
                            CurrencyID = Convert.ToInt32( dr["currency_id"].ToString());


                        DateStart = Convert.ToDateTime(dr["date_start"].ToString());
                        DateEnd = Convert.ToDateTime(dr["date_end"].ToString());

                        if (!dr.IsDBNull(dr.GetOrdinal("currency_name")))
                            CurrencyName = dr["currency_name"].ToString();

                        SchedulePayId = dr.IsDBNull(dr.GetOrdinal("id_schedule_pay")) ? 0 : Convert.ToInt32(dr["id_schedule_pay"].ToString());

                        Id_Struct_Related = dr.IsDBNull(dr.GetOrdinal("hr_payroll_structure_id")) ? 0 : Convert.ToInt32(dr["hr_payroll_structure_id"].ToString());

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
