using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    class CentroAtencion
    {
        private string dni;
        string[] dni_registro = { "76407602", "80102033", "30011132" };
        string[] lugares_Atencion = { "Telefonica1", "Telefonica2" , "Telefonica3" };
        public string localizado;
        public CentroAtencion(string numero)
        {
            dni = numero;
            for (int i = 0; i < dni_registro.Count(); i++)
            {
                if (dni_registro[i] == dni)
                    localizado = lugares_Atencion[i];
            }
        }
        public void direccion()
        {
            Direccion _dir = new Direccion(localizado);
        }
    }
}
