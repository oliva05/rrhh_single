using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public class PlanillaDepreciacion
    {
        public PlanillaDepreciacion() { }

        DataOperations dp = new DataOperations();
        bool recuperado = false;

        #region Header
        private int idPlanilla;
        private string namePlanilla;
        private decimal tasaCambio;
        private int mes;
        private decimal montoTotal;
        private int idEstado;
        private string estado;
        private int anio;
        private DateTime fechaCreacion;
        private string comentario;
        private string userCreador;

        public int IdPlanilla { get => idPlanilla; set => idPlanilla = value; }
        public string NamePlanilla { get => namePlanilla; set => namePlanilla = value; }
        public decimal TasaCambio { get => tasaCambio; set => tasaCambio = value; }
        public int Mes { get => mes; set => mes = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Anio { get => anio; set => anio = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string Comentario { get => Comentario1; set => Comentario1 = value; }
        public string Comentario1 { get => comentario; set => comentario = value; }
        public string UserCreador { get => userCreador; set => userCreador = value; }

        #endregion


        public bool RecuperarPlanillaHeader(int pIdHeader)
        {
            try
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringRRHH);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_depreciacion_planilla_h_class", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPlanilla", pIdHeader);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    IdPlanilla = reader.GetInt32(reader.GetOrdinal("IdPlanilla"));
                    NamePlanilla = reader.GetString(reader.GetOrdinal("descripcion"));
                    IdEstado = reader.GetInt32(reader.GetOrdinal("id_estado"));
                    Estado = reader.GetString(reader.GetOrdinal("estado"));
                    TasaCambio = (decimal)(reader.IsDBNull(reader.GetOrdinal("tasa_cambio"))? 1 : reader.GetDecimal(reader.GetOrdinal("tasa_cambio")));
                    Mes = reader.GetInt32(reader.GetOrdinal("mes"));
                    Anio = reader.GetInt32(reader.GetOrdinal("anio"));
                    MontoTotal = reader.GetDecimal(reader.GetOrdinal("monto_total"));
                    FechaCreacion = reader.GetDateTime(reader.GetOrdinal("fecha_creacion"));
                    Comentario = reader.IsDBNull(reader.GetOrdinal("comentario")) ? "" : reader.GetString(reader.GetOrdinal("comentario"));
                    UserCreador = reader.GetString(reader.GetOrdinal("user_name"));
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
