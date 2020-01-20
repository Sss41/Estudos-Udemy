using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class ConversorMoeda
    {
        public static double IOF = 6.0;

        public static double DolarReal(double quantidade, double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
