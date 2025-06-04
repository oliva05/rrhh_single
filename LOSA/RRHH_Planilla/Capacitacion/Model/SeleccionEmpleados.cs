using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Capacitacion.Model
{
    public class SeleccionEmpleados
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int JobId { get; set; }
        public string JobTitle { get; set; }
    }
}
