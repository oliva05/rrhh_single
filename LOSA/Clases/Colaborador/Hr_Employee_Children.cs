using ACS.Classes;
using DocumentFormat.OpenXml.Office2010.Excel;
 
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
    public class Hr_Employee_Children
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Edad { get; set; }

        public bool Recuperado { get; set; }

        public bool RecuperaRegistro(int id_hijo) 
        {
            try
            {
                DataOperations dp = new DataOperations();

                SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH);

                using (SqlCommand cmd = new SqlCommand("GetEmployee_children_By_Id", cnx))
                {
                    cnx.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id_hijo;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Genero = dr.IsDBNull(dr.GetOrdinal("genero")) ? "" : dr["genero"].ToString();
                        FechaNacimiento = dr["fecha_nacimiento"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_nacimiento"].ToString());                        
                        Edad = dr.IsDBNull(dr.GetOrdinal("edad")) ? "" : dr["edad"].ToString();                         

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
