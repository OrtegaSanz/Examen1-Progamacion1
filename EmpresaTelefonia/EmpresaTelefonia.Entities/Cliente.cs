using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    public class Cliente
    {
        private string nom, ape, dni;
        public Cliente(string nom, string ape, string dni)
        {
            this.ape = ape;
            this.nom = nom;
            this.dni = dni;
        }
        public string Nombre { get { return nom; } set { nom = value; } }
        public string Apellido { get { return ape; } set { ape = value; } }
        public string Dni { get { return dni; } set { dni = value; } }
    }
}
