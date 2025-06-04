using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Capacitacion.Model
{
    public class SeleccionAusenciaEmpleados
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int JobId { get; set; }
        public int TipoAusenciaId { get; set; }
        public string TipoAusencia { get; set; }
        public string JobTitle { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRegreso { get; set; }
        public int DiasSolicitadosVacaciones { get; set; }
        public bool AplicadoPlanilla { get; set; }
        public string Notas { get; set; }
    }
}
