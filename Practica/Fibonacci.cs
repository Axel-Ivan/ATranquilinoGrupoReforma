using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Fibonacci
    {
        public static void serieFibonacci(int longitud)
        {
            int[] resultSerie = new int[longitud];
            if (longitud == 0)
            {
                Console.WriteLine("0");
            }
            else if(longitud <= 0)
            {
                Console.WriteLine("Ingrese un número positivo");
            }
            else
            {
                int a = 0;
                int b = 1;
                int c = a + b;
                resultSerie[0] = a;
                Console.WriteLine(resultSerie[0]);
                resultSerie[1] = b;
                Console.WriteLine(resultSerie[1]);

                for (int i = 2; i < longitud; i++)
                {
                    resultSerie[i] = c;
                    Console.WriteLine(resultSerie[i]);
                    a = b;
                    b = c;
                    c = a + b;
                }
            }
        }
    }
}
