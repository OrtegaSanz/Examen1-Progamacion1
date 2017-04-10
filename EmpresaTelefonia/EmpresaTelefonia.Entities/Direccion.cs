using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class Direccion
    {
        string[] _Dir = { "Av. El Polo", "Av. Estados Unidos", "Av. Peru" };
        string[] lugares_Atencion = { "Telefonica1", "Telefonica2", "Telefonica3" };
        private string direccion_localizada;
        public Direccion(string localizado)
        {
            for (int i = 0; i < _Dir.Count(); i++)
            {
                if (lugares_Atencion[i] == localizado)
                    direccion_localizada = _Dir[i];
            }
        }
        public void ubigeo()
        {
            Ubigueo _ubi = new Ubigueo(direccion_localizada);
        }
    }
}
