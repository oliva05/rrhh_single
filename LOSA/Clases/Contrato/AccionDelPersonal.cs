using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Contrato
{
    public class AccionDelPersonal
    {
        public int IdAccion { get; set; }
        public DateTime? FechaEfectiva { get; set; }
        public int TipoAccionId { get; set; }
        public int EstadoAccionId { get; set; }
        public int ContratoId { get; set; }
        public decimal SalarioAnterior { get; set; }
        public decimal SalarioNuevo { get; set; }
        public int PuestoAnteriorId { get; set; }
        public int PuestoNuevoId { get; set; }
        public string PuestoAnterior { get; set; }
        public string PuestoNuevo { get; set; }

        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int idAccion)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGet_accion_de_personal_by_id", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",   idAccion);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        IdAccion = idAccion;
                        FechaEfectiva = dr["FechaEfectiva"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FechaEfectiva"].ToString());
                        TipoAccionId = dr.IsDBNull(dr.GetOrdinal("id_tipo_accion")) ? 0 : Convert.ToInt32(dr["id_tipo_accion"].ToString());
                        EstadoAccionId = dr.IsDBNull(dr.GetOrdinal("id_estado")) ? 0 : Convert.ToInt32(dr["id_estado"].ToString());
                        ContratoId = dr.IsDBNull(dr.GetOrdinal("contrato_id")) ? 0 : Convert.ToInt32(dr["contrato_id"].ToString());
                        SalarioAnterior = dr.IsDBNull(dr.GetOrdinal("salario_anterior")) ? 0 : Convert.ToDecimal(dr["salario_anterior"].ToString());
                        SalarioNuevo = dr.IsDBNull(dr.GetOrdinal("salario_nuevo")) ? 0 : Convert.ToDecimal(dr["salario_nuevo"].ToString());
                        PuestoAnteriorId= dr.IsDBNull(dr.GetOrdinal("job_id_anterior")) ? 0 : Convert.ToInt32(dr["job_id_anterior"].ToString());
                        PuestoNuevoId= dr.IsDBNull(dr.GetOrdinal("job_id_nuevo")) ? 0 : Convert.ToInt32(dr["job_id_nuevo"].ToString());
                        //EmployeeId = dr.IsDBNull(dr.GetOrdinal("employee_id")) ? 0 : Convert.ToInt32(dr["employee_id"].ToString());

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
