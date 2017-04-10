using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class TipoEvaluacion
    {
        private string tipoEva;
        public TipoEvaluacion(bool bien)
        {
            if (bien == true)
                tipoEva = "Esta en optimas condiciones para comprar";
            else
                tipoEva = "No puede";
        }
        public string TipEva()
        {
            return tipoEva;
        }
        
    }
}
