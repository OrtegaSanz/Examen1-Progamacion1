using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class Ubigueo
    {
        Distrito _dis = new Distrito();
        Provincia _Pro = new Provincia();
        Departamento _Dep = new Departamento();
        private string localizado;
        public Ubigueo(string localizado)
        {
            this.localizado = localizado;
        }
    }
}
