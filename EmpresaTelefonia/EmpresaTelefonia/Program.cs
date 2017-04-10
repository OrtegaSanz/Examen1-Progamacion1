using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using EmpresaTelefonia.Entities;

namespace EmpresaTelefonia
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = "76407602";
            Evaluacion _eva = new Evaluacion();
            Console.WriteLine("Bienvenido a la Consola de la Empresa Telefonica del Peru");
            //Cargado los Datos
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(1);
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese su DNI: {0}", numero);
            Console.WriteLine("Evaluando");
            //Cargado los Datos
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(1);
            }
            Console.WriteLine();
            _eva.VerificadoBD(numero);
            _eva.VentaCel(numero);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
