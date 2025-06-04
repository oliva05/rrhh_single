using ACS.Classes;
using LOSA.Clases;
using LOSA.Mantenimientos;
using LOSA.RecepcionMP;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Depreciacion
{
    public class Depreciacion
    {
        public Depreciacion() 
        { }

        #region Miembros Perfil
        private bool recuperado;
        private int id_Empledo;
        private int idPerfil;
        private string codeEmpleado;
        private string nombre;
        private string marca;
        private string modelo;
        private string placa;
        private decimal km;
        private bool pagaPeaje;
        private bool pagaMantenimiento;
        private bool activo;
        private decimal montoFijoPago;

        //Prestamo
        private int idPrestamo;
        private decimal importaTotal;
        private DateTime fechaInicio;
        private int idEstado;
        private decimal kmDistancia;
        private decimal mantenimiento;
        private int tipoDeduccion;
        private decimal montoDeduccion;
        private int moneda;
        private decimal tasaInteresAnual;
        private decimal tasa_cambio_fija;


        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public string CodeEmpleado { get => codeEmpleado; set => codeEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public decimal Km { get => km; set => km = value; }
        public bool PagaPeaje { get => pagaPeaje; set => pagaPeaje = value; }
        public bool PagaMantenimiento { get => pagaMantenimiento; set => pagaMantenimiento = value; }
        public int Id_Empledo { get => id_Empledo; set => id_Empledo = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public decimal ImportaTotal { get => importaTotal; set => importaTotal = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public decimal KmDistancia { get => kmDistancia; set => kmDistancia = value; }
        public decimal Mantenimiento { get => mantenimiento; set => mantenimiento = value; }
        public decimal MontoDeduccion { get => montoDeduccion; set => montoDeduccion = value; }
        public int TipoDeduccion { get => tipoDeduccion; set => tipoDeduccion = value; }
        public int Moneda { get => moneda; set => moneda = value; }
        public decimal MontoFijoPago { get => montoFijoPago; set => montoFijoPago = value; }
        public decimal TasaInteresAnual { get => tasaInteresAnual; set => tasaInteresAnual = value; }
        public decimal Tasa_cambio_fija { get => tasa_cambio_fija; set => tasa_cambio_fija = value; }


        #endregion

        public bool RecuperarPerfil(int pIdPerfil, int pIdEmpleado)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("[sp_depreciacion_get_perfil_class]", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPerfil", pIdPerfil);
                    cmd.Parameters.AddWithValue("@idEmpleado", pIdEmpleado);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        IdPerfil = dr.GetInt32(0);
                        Id_Empledo = dr.GetInt32(1);
                        CodeEmpleado = dr.GetString(2);
                        Nombre = dr.GetString(3);
                        Marca  = dr.GetString(4);
                        Modelo = dr.GetString(5);
                        Placa = dr.GetString(6);
                        Km = dr.GetDecimal(7);
                        PagaPeaje = dr.GetBoolean(8);
                        PagaMantenimiento = dr.GetBoolean(9);
                        Activo = dr.GetBoolean(10);
                        Moneda = dr.IsDBNull(dr.GetOrdinal("moneda")) ? 0 : dr.GetInt32(dr.GetOrdinal("moneda"));
                        MontoFijoPago = dr.GetDecimal(dr.GetOrdinal("monto_fijo_pago"));

                        Recuperado = true;
                    }
                    dr.Close();
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }


        public bool RecuperarPrestamo(int pIdHeader)
        {
            Recuperado = false;
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection cnx = new SqlConnection(dp.ConnectionStringRRHH))
                {
                    cnx.Open();

                    SqlCommand cmd = new SqlCommand("sp_depreciacion_prestamos_class", cnx);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHeader", pIdHeader);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        IdPrestamo = dr.GetInt32(0);
                        Id_Empledo = dr.GetInt32(1);
                        ImportaTotal = dr.GetDecimal(2);
                        FechaInicio = dr.GetDateTime(3);
                        IdEstado = dr.GetInt32(4);
                        KmDistancia = dr.GetDecimal(5);
                        Mantenimiento = dr.GetDecimal(6);
                        TipoDeduccion = dr.GetInt32(7);
                        MontoDeduccion = dr.GetDecimal(8);
                        Moneda = dr.IsDBNull(dr.GetOrdinal("id_moneda")) ? 0 : dr.GetInt32(dr.GetOrdinal("id_moneda"));
                        TasaInteresAnual = dr.IsDBNull(dr.GetOrdinal("tasa_interes_anual")) ? 0 : dr.GetDecimal(dr.GetOrdinal("tasa_interes_anual"));
                        Tasa_cambio_fija = dr.GetDecimal(dr.GetOrdinal("tasa_cambio_fija"));
                        Recuperado = true;
                    }
                    dr.Close();
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            return Recuperado;
        }

    }
}
