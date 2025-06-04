using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Gestiones.Models
{
    public class ProcesoDisciplinarioAdjuntoClass
    {
        public int Id { get; set; }
        public int ProcesoDisciplinarioId { get; set; }
        public int Path { get; set; }
        public int FileName { get; set; }
        public int FileNameOriginal { get; set; }
    }
}
