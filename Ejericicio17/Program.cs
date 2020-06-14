using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //nuevamente creamos vector
            string[] paises;
            paises = new string[5];

            //Pedimos datos al usuario
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Digite nombre del pais");
                paises[i] = Console.ReadLine();
            }

            //Comparamos y sustituimos segun la letra inicial
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        String aux;
                        aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;

                    }
                }
            }

            //Imprimimos 
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

            Console.ReadKey();
        }
    }
}
