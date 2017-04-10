using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class Contrato
    {
        List<string> _Contratos = new List<string>() { "1 año","3 año","5 año" };
        int opc;
        public Contrato(int opc)
        {
            this.opc = opc;
        }
        public string selCon()
        {
            return _Contratos[opc];
        }
    }
}
