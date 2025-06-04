using DevExpress.XtraReports.UI;
using LOSA.Clases.Colaborador;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace LOSA.RRHH_Planilla.Contrato
{
    public partial class rptContrato : DevExpress.XtraReports.UI.XtraReport
    {
        public rptContrato(int contrato_id)
        {
            InitializeComponent();

            DetalleContrato contratoActual = new DetalleContrato();
            HrEmployee empleadoActual = new HrEmployee();


            contratoActual.RecuperarRegistroPorId(contrato_id);
            empleadoActual.RecuperarDatosPorId(contratoActual.EmployeeId);


            BuscarYReemplazarTextoEnXRRichText("(NOMBRE DEL EMPLEADO)", empleadoActual.Name.ToUpper());
            BuscarYReemplazarTextoEnXRRichText("(DIRECCION)", empleadoActual.DireccionPersonal.ToUpper());
            BuscarYReemplazarTextoEnXRRichText("(IDENTIDAD EMPLEADO)", empleadoActual.IdentificationId);
            BuscarYReemplazarTextoEnXRRichText("(PUESTO O CARGO QUE OCUPA)", empleadoActual.Puesto.ToUpper());
            BuscarYReemplazarTextoEnXRRichText("(INICIO CONTRATO)", Convert.ToDateTime( contratoActual.StartDate).ToString("d 'de' MMMM 'del' yyyy", new CultureInfo("es-ES")).ToUpper());
            BuscarYReemplazarTextoEnXRRichText("(XSALARIOX)", $"{contratoActual.SimboloMoneda}{contratoActual.Wage.ToString("N2")}" );
            BuscarYReemplazarTextoEnXRRichText("(HORARIOTRABAJO)", empleadoActual.HorarioTrabajoParaImprimirContrato);
            BuscarYReemplazarTextoEnXRRichText("(DIA)", DateTime.Now.ToString("dd"));
            BuscarYReemplazarTextoEnXRRichText("(MES)", DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")));
            BuscarYReemplazarTextoEnXRRichText("(ANIO)", DateTime.Now.Year.ToString());

        }

        public void BuscarYReemplazarTextoEnXRRichText( string textoBuscar, string textoReemplazo)
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
