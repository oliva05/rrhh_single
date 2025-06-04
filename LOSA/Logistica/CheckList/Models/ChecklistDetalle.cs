using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.Logistica.CheckList.Models
{
    // Clase para representar los detalles del checklist
    class ChecklistDetalle
    {
        public int IdCaracteristicaDetalle { get; set; }
        public bool Conforme { get; set; }
        public bool NoConforme { get; set; }
        public bool NoAplica { get; set; }
        public string Observaciones { get; set; }
    }
}
