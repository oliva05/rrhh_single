using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.ReportServer.Printing.RemoteDocumentSource;

namespace LOSA.Clases.Colaborador
{
    public class Hr_BenefitDeduction
    {
        public int Id { get; set; }
        public decimal Cuotas { get; set; }
        public int ConceptoId { get; set; }
        public int TipoId { get; set; }
        public int ContratoId { get; set; }
        public int PeriocidadId { get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorRestante { get; set; }
        public decimal MontoOriginal { get; set; }
        public string Comentarios { get; set; }
        public bool Recuperado { get; set; }
        public DateTime? ApplicableDate { get; set; }
        public bool RecuperarRegistroPorId(int id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetBenefitDeductionClass", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Id = id;
                        ApplicableDate = dr["applicable_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["applicable_date"].ToString());
                        Cuotas = dr.IsDBNull(dr.GetOrdinal("amount")) ? 0 : Convert.ToDecimal(dr["amount"].ToString());
                        TipoId = dr.IsDBNull(dr.GetOrdinal("id_tipo")) ? 0 : Convert.ToInt32(dr["id_tipo"].ToString());
                        PeriocidadId = dr.IsDBNull(dr.GetOrdinal("id_type")) ? 0 : Convert.ToInt32(dr["id_type"].ToString());
                        ContratoId = dr.IsDBNull(dr.GetOrdinal("contract_id")) ? 0 : Convert.ToInt32(dr["contract_id"].ToString());
                        ConceptoId = dr.IsDBNull(dr.GetOrdinal("concept_id")) ? 0 : Convert.ToInt32(dr["concept_id"].ToString());
                        Valor = dr.IsDBNull(dr.GetOrdinal("value")) ? 0 : Convert.ToDecimal(dr["value"].ToString());
                        RemainingAmount = dr.IsDBNull(dr.GetOrdinal("remaining_amount")) ? 0 : Convert.ToDecimal(dr["remaining_amount"].ToString());
                        MontoOriginal = dr.IsDBNull(dr.GetOrdinal("valor_original")) ? 0 : Convert.ToDecimal(dr["valor_original"].ToString());
                        Comentarios = dr.IsDBNull(dr.GetOrdinal("comments")) ? "" : dr["comments"].ToString();
                        
                        
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
