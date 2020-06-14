using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos matriz
            int[,] numeros;
            numeros = new int[2, 5];

            //pedimos datos al usuario
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese numero: ");
                    numeros[f, c] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //ordenamos al revez
            for (int f = 0; f < 2; f++)
            {
                Console.Write("");
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("{0}", numeros[f, c] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
