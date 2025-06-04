using LOSA.Clases.Planilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOSA.RRHH_Planilla.Clases
{
    public class ReglasSalarialesDepartment
    {
        public int Conceptos_id { get; set; }
        public bool Provision { get; set; }
        public bool Patronal { get; set; }
        public int AccountId { get; set; }
        public string SalaryRuleId { get; set; }
        public int CounterpartId { get; set; }
        public string Move {get; set; }
        public int DepartmentId { get; set; }
        public string AnalyticType { get; set; }

    }
}
