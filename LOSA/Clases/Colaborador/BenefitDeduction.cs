using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Colaborador
{
    public class BenefitDeduction
    {
    
        public int ID { get; set; }
        public int ContractID { get; set; }
        public int ConceptID { get; set; }
        public int TypeID { get; set; }
        public int Cuotas { get; set; }
        public string Name { get; set; }
        public DateTime AplicableDate { get; set; }
        public string Comments { get; set; }
        public decimal Valor { get; set; }
        
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int id) {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetBenefitDeductionById", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Name = dr["name"].ToString();
                        AplicableDate = Convert.ToDateTime(dr["applicable_date"].ToString());
                        ContractID = Convert.ToInt32( dr["contract_id"].ToString());
                        ConceptID = Convert.ToInt32( dr["concept_id"].ToString());
                        TypeID = Convert.ToInt32( dr["id_type"].ToString());
                        Cuotas = Convert.ToInt32( dr["month_deductions"].ToString());
                        Valor = Convert.ToDecimal(dr["value"].ToString());
                        Comments =  dr["comments"].ToString();
                        //PagoPlanificado = dr["schedule_pay"].ToString();
                        //PlanificacionTrabajo = dr["calendar"].ToString();
                        //Estado = dr["estado"].ToString();
                        //Nota = dr["notes"].ToString();
                        //AniosAntiguedad = Convert.ToInt32(dr["anios_antiguedad"].ToString());
                        //MesesAntiguedad = Convert.ToInt32(dr["meses_antiguedad"].ToString());
                        //ID = Convert.ToInt32 (dr["id"].ToString());

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
