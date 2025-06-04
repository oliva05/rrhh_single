using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Clases
{
    public class PlantillaDeduccionesBeneficios
    {
        public string CodigoEmpleado { get; set; }
        public string FechaEfectiva { get; set; }
        public string ConceptoDeduccionBeneficio { get; set; }
        public string Nombre { get; set; }
        public string Cuotas { get; set; }
        public string Tipo { get; set; }
        public string CuotasRestantes { get; set; }
        public string Valor { get; set; }
        public string MesesDeduccionBeneficio { get; set; }
    }
}
