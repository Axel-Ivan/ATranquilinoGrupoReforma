using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Factorial
    {
        public static int getFactorial(int factorial)
        {
            if (factorial > 0)
            {
                int valor = factorial * getFactorial(factorial - 1);
                return valor;
            }

            else
                return 1;
        }
    }
}
