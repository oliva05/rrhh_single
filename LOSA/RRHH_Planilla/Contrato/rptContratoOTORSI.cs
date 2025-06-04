using DevExpress.XtraReports.UI;
using LOSA.Clases.Colaborador;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace LOSA.RRHH_Planilla.Contrato
{
    public partial class rptContratoOTORSI : DevExpress.XtraReports.UI.XtraReport
    {
        public rptContratoOTORSI(int contrato_id)
        {
            InitializeComponent();

            DetalleContrato contratoActual = new DetalleContrato();
            HrEmployee empleadoActual = new HrEmployee();


            contratoActual.RecuperarRegistroPorId(contrato_id);
            empleadoActual.RecuperarDatosPorId(contratoActual.EmployeeId);

            // Obtener el TextInfo de la cultura en español (es-ES)
            TextInfo textInfo = new CultureInfo("es-ES", false).TextInfo;


            BuscarYReemplazarTextoEnHeader("(NOMBRECOLABORADOR)", empleadoActual.Name.ToUpper());
            BuscarYReemplazarTextoEnContenido("(NOMBRECOLABORADOR)", textInfo.ToTitleCase(empleadoActual.Name.ToLower()));
            BuscarYReemplazarTextoEnContenido("(PUESTO)", empleadoActual.Puesto.ToUpper());
            BuscarYReemplazarTextoEnContenido("(DIRECCION)", empleadoActual.DireccionPersonal);
            BuscarYReemplazarTextoEnContenido("(INICIOCONTRATO)", Convert.ToDateTime(contratoActual.StartDate).ToString("d 'de' MMMM 'del' yyyy", new CultureInfo("es-ES")));
            BuscarYReemplazarTextoEnContenido("(DIA)", DateTime.Now.ToString("dd"));
            BuscarYReemplazarTextoEnContenido("(MES)", DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")));
            BuscarYReemplazarTextoEnContenido("(ANIO)", DateTime.Now.Year.ToString());

            xrNombreColaborador.Text = empleadoActual.Name.ToUpper();
            xrIdentidad.Text = $"ID. {empleadoActual.IdentificationId}";
        }


        public void BuscarYReemplazarTextoEnContenido(string textoBuscar, string textoReemplazo)
        {

            // Suponiendo que `xrRichText1` es tu control XRRRichText
            string originalRtf = xrRichText2.Rtf;

            //// Define el texto que deseas reemplazar y el nuevo texto
            //string textoViejo = "(NOMBRE DEL EMPLEADO)";
            //string textoNuevo = employee.Name.ToUpper();

            // Realiza la sustitución del texto en el contenido RTF
            string nuevoRtf = originalRtf.Replace(textoBuscar, textoReemplazo);

            // Asigna el contenido RTF modificado de vuelta al control
            xrRichText2.Rtf = nuevoRtf;

        }

        

        public void BuscarYReemplazarTextoEnHeader(string textoBuscar, string textoReemplazo)
        {

            // Suponiendo que `xrRichText1` es tu control XRRRichText
            string originalRtf = xrRichText1.Rtf;

            //// Define el texto que deseas reemplazar y el nuevo texto
            //string textoViejo = "(NOMBRE DEL EMPLEADO)";
            //string textoNuevo = employee.Name.ToUpper();

            // Realiza la sustitución del texto en el contenido RTF
            string nuevoRtf = originalRtf.Replace(textoBuscar, textoReemplazo);

            // Asigna el contenido RTF modificado de vuelta al control
            xrRichText1.Rtf = nuevoRtf;

        }

    }
}
