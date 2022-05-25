using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class BurbujaSort
    {
        public static int[] Burbuja(int[] arreglo)
        {
            for(int i = 0; i < arreglo.Length - 1; i++)
            {
                int a = 0, b = 1, c;
                for(int j = 0; j < arreglo.Length - 1; j++)
                {
                    if(arreglo[b] > arreglo[a])
                    {
                        c = arreglo[a];
                        arreglo[a] = arreglo[b];
                        arreglo[b] = c;
                    }

                    a++;
                    b++;
                }
            }

            Console.WriteLine("El orden del arreglo es: \n");

            for (int i = 0; i < arreglo.Length; i++)
            {               
                Console.WriteLine(arreglo[i]);
            }

            return arreglo;
        }
    }
}
