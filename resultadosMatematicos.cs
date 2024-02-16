using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class resultadosMatematicos
    {
        private double resultado;
        private double parametroUno, parametroDos;

        public double Resultado { get => resultado; set => resultado = value; }
        public double ParametroUno { get => parametroUno; set => parametroUno = value; }
        public double ParametroDos { get => parametroDos; set => parametroDos = value; }

        public  double multiplicacion(double valorUno, double valorDos)
        {
            resultado = valorUno * valorDos;

            return resultado;

        }

        public double multiplicacion()
        {
            this.Resultado = this.ParametroUno * ParametroDos;

            return this.Resultado;
        }
       
      
            
            
       



           
    }
}
