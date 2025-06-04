using ACS.Classes;
using LOSA.Presupuesto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Clases
{
    public class Funciones
    {
        public Funciones()
        {
        }

        public decimal GetDifHorasforDecimal(DateTime desde, DateTime hasta)
        {
            decimal val = 0;
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;
                double valm = (hasta - desde).TotalMinutes;
                decimal difh = (Convert.ToDecimal( valm) / 60);
                //decimal h = Math.Truncate(difh);
                //decimal m = difh - h;
                val = difh;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }


        public string GetDifHorasforString(DateTime desde, DateTime hasta)
        {
            string res = "";
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;

                double difh = (hasta - desde).TotalMinutes / 60;
                decimal h = Math.Truncate(Convert.ToDecimal(difh));
                decimal m = Convert.ToDecimal(difh) - h;


                string hora = h.ToString();
                string Min = m.ToString();
                if (hora.Length <= 1)
                    hora = "0" + h.ToString();

                Min =  Math.Round((h*60),2).ToString();
                res = hora + ":" + Min;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }

        public string GetDifHorasforStringFromDecimal(decimal valor)
        {
            string res = "";
            try
            {
                //int horai = desde.Hour;
                //int horaf = hasta.Hour;

                //int mini = desde.Minute;
                //int minf = hasta.Minute;

                decimal difh = valor / 60;
                decimal h = Math.Truncate(difh);
                decimal m = difh - h;


                string hora = h.ToString();
                string Min = m.ToString();
                if (hora.Length <= 1)
                    hora = "0" + h.ToString();

                Min = Math.Round((h * 60), 2).ToString();
                res = hora + ":" + Min;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return res;
        }

        public decimal GetHoras_acumuladasLinea(int pidH, int pLinea)
        {
            decimal valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_horas_lote_prb_eficiencia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idh", pidH);
                cmd.Parameters.AddWithValue("@idlinea", pLinea);
                valor = Convert.ToDecimal(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }
        public int GetRutaAjustesInventario()
        {
           int valor = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringLOSA);
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_get_ruta_para_ajuste_inventario_alosy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idh", pidH);
                //cmd.Parameters.AddWithValue("@idlinea", pLinea);
                valor = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return valor;
        }




        /// <summary>
        /// Devuelve el nombre del mes en el idioma especificado.
        /// </summary>
        /// <param name="date">La fecha de la cual se obtendrá el mes.</param>
        /// <param name="language">El idioma ('spanish' o 'english').</param>
        /// <returns>El nombre del mes en el idioma especificado.</returns>
        public string GetMonthName(DateTime date, string language)
        {
            string monthName;

            // Configurar el idioma basado en el parámetro de entrada
            switch (language.ToLower())
            {
                case "spanish":
                    monthName = date.ToString("MMMM", new CultureInfo("es-ES"));
                    break;
                case "english":
                    monthName = date.ToString("MMMM", new CultureInfo("en-US"));
                    break;
                default:
                    throw new ArgumentException("Idioma no soportado. Utiliza 'spanish' o 'english'.");
            }

            // Retornar el nombre del mes con la primera letra en mayúscula
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName);
        }



        public string GetMonthNameForInt(int intVal) 
        {
        
            string monthName;

            switch (intVal)
            {
                case 1:
                    monthName = "Enero";
                    break;
                case 2: 
                    monthName = "Febrero";
                    break;
                case 3: 
                    monthName = "Marzo";
                    break;
                case 4:
                    monthName = "Abril";
                    break;
                case 5:
                    monthName = "Mayo";
                    break;
                case 6:
                    monthName = "Junio";
                    break;
                case 7:
                    monthName = "Julio";
                    break;
                case 8:
                    monthName = "Agosto";
                    break;
                 case 9:
                    monthName = "Septiembre";
                    break;
                case 10:
                    monthName = "Octubre";
                    break;
                case 11:
                    monthName = "Noviembre";
                    break;
                case 12:
                    monthName = "Diciembre";
                    break;
                default:
                    monthName = null;
                    break;
            }

            return monthName;
        }
        
        public double GetTasaCambioSAP_ByDate(DateTime pDate)
        {
            double result = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionSAP_OnlySELECT);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.spGetTasaCambioSAP_byDate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", pDate);
                result = Convert.ToDouble(cmd.ExecuteScalar());

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return result;
        }


    }
}
