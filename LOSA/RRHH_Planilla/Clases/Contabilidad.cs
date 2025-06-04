using LOSA.Clases.Planilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Clases
{
    public class Contabilidad
    {
        public int IdReglaSalarial { get; set; }
        public string ReglaSalarialName { get; set; }
        public string Move { get; set; }
        public int IdConcept { get; set; }
        public string ConceptName { get; set; }
        public int IdAccount { get; set; } 
        public string AccountName { get; set; }
        public bool Prov { get; set; }   
        public bool Patr { get; set; }
        public string AccountTypeAnalytic { get; set; }
    }
}
