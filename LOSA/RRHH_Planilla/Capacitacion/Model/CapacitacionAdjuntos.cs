using ACS.Classes;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Capacitacion
{
    public class CapacitacionAdjuntos
    {
        public int ID { get; set; }
        public int TipoId { get; set; }
        public string Tipo { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string FileNameOriginal { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Recuperado { get; set; }

        public bool RecuperarRegistro(int id)
        {

            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //ID = id;
                        //Path = dr["nombre"].ToString();
                        //Code = dr["code"].ToString();
                        //Note = dr["nota"].ToString();
                        //CategoriaID = Convert.ToInt32(dr["category_id"].ToString());
                        //Cantidad = Convert.ToInt32(dr["quantity"].ToString());
                        //Secuencia = Convert.ToInt32(dr["sequence"].ToString());
                        //ApareceEnNomina = Convert.ToBoolean(dr["appears_on_payslip"].ToString());
                        //Categoria = dr["categoria"].ToString();
                        //Recuperado = true;
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
