using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTelefonia.Entities
{
    public class Evaluacion
    {
        List<Cliente> obj = new List<Cliente>();
        public void VerificadoBD(string numero)
        {
            obj.Add(new Cliente("Carlos", "Ortega", "76407602"));
            foreach(Cliente n in obj)
            {
                if (n.Dni == numero)
                {
                    Console.WriteLine("Su nombre es: {0}", n.Nombre);
                    Console.WriteLine("Su apellido es: {0}", n.Apellido);
                }
            }
        }
        public void VentaCel(string numero)
        {
            Console.WriteLine("Venta de Producto a {0} \nVerificando Productos", numero);
            EstadoEvaluacion obj = new EstadoEvaluacion(numero);
            int com = 1;
            int tp = 0;
            int con = 1;
            if(obj.Bien == true)
            {
                TipoEvaluacion tipEva = new TipoEvaluacion(obj.Bien);
                Console.WriteLine(tipEva.TipEva());
                Venta _ven = new Venta(com);
                Console.WriteLine("Usted eligio: {0}", _ven.ProdVen());
                Console.WriteLine("Usted eligio tipo de pago: {0}", _ven.tipPago(tp));
                Console.WriteLine("Usted eligio el contrato: {0}", _ven.contrato(con));
                Console.WriteLine("Centro de Compra: {0}", _ven.CenAtn(numero));
            }
            else
            {
                Console.WriteLine("No puede comprar.");
            }
        }
    }
}
