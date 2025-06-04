using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases.Planilla
{
    public class PlanillaPuestoTrabajo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public int CompanyID { get; set; }
        public int DepartmentID { get; set; }
        public int BandaSalarialId { get; set; }
        public int NumeroEmpleados { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id)
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("uspGetJobsByIdV2", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id",System.Data.SqlDbType.Int).Value= id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ID = id;
                        Name = dr.IsDBNull(dr.GetOrdinal("name")) ? "" : dr["name"].ToString();
                        Note = dr.IsDBNull(dr.GetOrdinal("notas")) ? "" : dr["notas"].ToString();
                        NumeroEmpleados = dr.IsDBNull(dr.GetOrdinal("numero_actual_empleados")) ? 0 :  Convert.ToInt32( dr["numero_actual_empleados"].ToString());
                        CompanyID = dr.IsDBNull(dr.GetOrdinal("id_company")) ? 0 : Convert.ToInt32( dr["id_company"].ToString());
                        DepartmentID = dr.IsDBNull(dr.GetOrdinal("id_departamento")) ? 0 : Convert.ToInt32( dr["id_departamento"].ToString());
                        BandaSalarialId = dr.IsDBNull(dr.GetOrdinal("id_banda_salarial")) ? 0 : Convert.ToInt32( dr["id_banda_salarial"].ToString());
                        CreateDate = Convert.ToDateTime( dr["create_date"].ToString());


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
