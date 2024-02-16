using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            resultadosMatematicos objOp = new resultadosMatematicos();
            Console.WriteLine("12.8 * 8.4 = " + objOp.multiplicacion(14.8, 22.44));

            Console.Write("Introduce algun numero: ");
            objOp.ParametroUno = Double.Parse(Console.ReadLine());
            Console.Write("Escribe un numero");
            objOp.ParametroDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Su resultado es: " + objOp.multiplicacion());

            Console.ReadLine();


        }
    }


    
}


