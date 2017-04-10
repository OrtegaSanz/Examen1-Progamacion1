using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class Plan
    {
        
        public Plan()
        {

        }
        public string planCap(int plan)
        {
            TipoPlan _TipPlan = new TipoPlan(plan);
            return _TipPlan.getPlan();
        }
    }
}
