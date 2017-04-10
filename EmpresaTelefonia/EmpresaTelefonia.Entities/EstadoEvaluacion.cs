using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class EstadoEvaluacion
    {
        //Lista de numeros que estan en buen estado.
        string[] hab = { "76407602", "80102033", "30011132" };
        bool bien = false;
        public EstadoEvaluacion(string numero)
        {
            for (int i = 0; i < hab.Count(); i++)
            {
                if (hab[i] == numero)
                    bien = true;
            }
        }
        public bool Bien { get { return bien; } set { bien = value; } }
    }
}
