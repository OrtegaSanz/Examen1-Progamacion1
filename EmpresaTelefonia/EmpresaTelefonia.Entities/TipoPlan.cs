using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class TipoPlan
    {
        string[] _planes = { "Prepago","Pospago" };
        private string planElegido;
        public TipoPlan(int tipoPlan)
        {
            for (int i = 0; i < _planes.Count(); i++)
            {
                planElegido = _planes[i];
            }
        }
        public string getPlan() { return planElegido; }
    }
}
