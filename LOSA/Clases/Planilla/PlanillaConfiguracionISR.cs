using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LOSA.Clases.Planilla
{
    public class PlanillaConfiguracionISR
    {
        public int _id;
        public int _anio;
        public string _descripcion;
        public decimal _salarioMinimo;
        public decimal _gastosMedicos;
        public bool _recuperado;

        public int ID { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Anio { get => _anio; set => _anio = value; }
        public decimal SalarioMinimo { get => _salarioMinimo; set => _salarioMinimo = value; }
        public decimal GastosMedicos { get => _gastosMedicos; set => _gastosMedicos = value; }
        public bool Recuperado { get => _recuperado; set => _recuperado = value; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetConf_ISR_H_ByID", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Anio = dr.IsDBNull(dr.GetOrdinal("anio")) ? 0 : Convert.ToInt32 ( dr["anio"].ToString());
                        Descripcion = dr.IsDBNull(dr.GetOrdinal("descripcion")) ? "" : dr["descripcion"].ToString();
                        SalarioMinimo = dr.IsDBNull(dr.GetOrdinal("salario_minimo")) ? 0 : Convert.ToDecimal( dr["salario_minimo"].ToString());
                        if (!dr.IsDBNull(dr.GetOrdinal("gastos_medicos")))
                            GastosMedicos = dr.GetDecimal(11); 

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
