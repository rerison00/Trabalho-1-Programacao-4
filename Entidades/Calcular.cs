using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Entidades
{
    internal class Calcular
    {

        public double Somar(string valor1, string valor2)
        {
            return Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
        }
        public double Subtrair(string valor1, string valor2)
        {
            return Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
        }
        public double Divisao(string valor1, string valor2)
        { 
            return Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
        }
        public double Multiplicacao(string valor1, string valor2)
        {
            return Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
        }

    }
}
