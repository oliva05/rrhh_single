using ACS.Classes;
using DevExpress.XtraRichEdit.Model;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.ReportServer.Printing.RemoteDocumentSource;

namespace LOSA.Clases.Contrato
{
    public class ContratoAumento
    {

        public long Id { get; set; }
        public decimal Amount { get; set; }
        public int TipoAumento { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? Fecha { get; set; }
        public bool Recuperado { get; set; }
        public bool RecuperarRegistro(long id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGet_payment_history_by_id", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id;
                        Fecha = dr["date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["date"].ToString());
                        TipoAumento = dr.IsDBNull(dr.GetOrdinal("id_tipo_aumento")) ? 0 : Convert.ToInt32(dr["id_tipo_aumento"].ToString());
                        Amount = dr.IsDBNull(dr.GetOrdinal("amount")) ? 0 : Convert.ToDecimal(dr["amount"].ToString());
                        EmployeeId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());
                        //EndDate = dr["date_end"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["date_end"];
                        //PagoPlanificado = dr.IsDBNull(dr.GetOrdinal("schedule_pay")) ? "" : dr["schedule_pay"].ToString();
                        //PlanificacionTrabajo = dr.IsDBNull(dr.GetOrdinal("calendar")) ? "" : dr["calendar"].ToString();
                        //Estado = dr.IsDBNull(dr.GetOrdinal("estado")) ? "" : dr["estado"].ToString();
                        //Nota = dr.IsDBNull(dr.GetOrdinal("notes")) ? "" : dr["notes"].ToString();
                        //MesesAntiguedad = dr.IsDBNull(dr.GetOrdinal("meses_antiguedad")) ? 0 : Convert.ToInt32(dr["meses_antiguedad"].ToString());
                        //Wage = dr.IsDBNull(dr.GetOrdinal("wage")) ? 0 : Convert.ToDecimal(dr["wage"].ToString());
                        //ID = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : Convert.ToInt32(dr["id"].ToString());
                        //ID = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : Convert.ToInt32(dr["id"].ToString());
                        //ContractTypeId = dr.IsDBNull(dr.GetOrdinal("type_id")) ? 0 : Convert.ToInt32(dr["type_id"].ToString());
                        //StudyPermit = dr.IsDBNull(dr.GetOrdinal("study_permit")) ? false : Convert.ToBoolean(dr["study_permit"].ToString());
                        //PermitNumberOfDays = dr.IsDBNull(dr.GetOrdinal("permit_number_of_days")) ? 0 : Convert.ToInt32(dr["permit_number_of_days"].ToString());

                        //Si todas las propiedades se asignan carrectamente, en envía true para aprobar el proceso.
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
