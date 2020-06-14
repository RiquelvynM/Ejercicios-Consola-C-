using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos los dos vectores
            string[] paises;
            int[] habitantes;

            paises = new string[5];
            habitantes = new int[5];

            //solicitamos datos al usuario
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write("Ingese el nombre del pais:");
                paises[f] = Console.ReadLine();
                Console.Write("Ingrese cantidad de habitantes:");
                habitantes[f] = Convert.ToInt32(Console.ReadLine());

            }

            //hacemos la comparacion en los dos vectores al mismo tiempo, comparando la fila cero con la segunda y asi adelantando de posicion al numero mas alto o a la vocal mas cercana
            for (int k = 0; k < habitantes.Length; k++)
            {
                for (int f = 0; f < habitantes.Length - 1 - k; f++)
                {
                    if (habitantes[f] < habitantes[f + 1])
                    {
                        int auxhabitantes;
                        auxhabitantes = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxhabitantes;
                        string auxpaises;
                        auxpaises = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxpaises;
                    }
                }
            }

            //el bucle anterior aparte de comparar los vectores tambien los ordena, por lo tanto simplemente seria imprimir
            for (int f = 0; f < habitantes.Length; f++)
            {
                Console.WriteLine(paises[f] + " - " + habitantes[f]);
            }
            Console.ReadKey();
        }
    }
}
