using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class TipoPago
    {
        List<string> _TipoPago = new List<string>() {"Efectivo", "Credito" };
        public string selPago;
        public TipoPago(int opc)
        {
            selPago = _TipoPago[opc];
        }
    }
}
