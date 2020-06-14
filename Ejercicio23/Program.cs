using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui la matriz y variables a utilizar
            int[,] datos;
            int filas;
            int columnas;

            //solicito al usuario los datos y almacenos en las variables correspondientes
            Console.WriteLine("Cuantas filas ?");
            filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantas columnas ?");
            columnas = Convert.ToInt32(Console.ReadLine());

            datos = new int[filas, columnas];

            /*en el for acontinuacion, inverti la forma en como se estaba haciendo antes, lo que hice fue ponerlo alrevez
              basicamente, donde la fila y la columna se le asigna el mismo valor que el usuario decide y el for almacena de atras para delante*/
            for (int f = filas; f > 0; f--)
            {
                for (int c = columnas; c > 0; c--)
                {
                    Console.WriteLine("Asigne un valor");
                    datos[f - 1, c - 1] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("Resultado: ");

            //este for es sencillo, solo tiene que  imprimir por default lo que antes  ya se organizó
            for (int i = 0; i < filas; i++)
            {
                for (int n = 0; n < columnas; n++)
                {
                    Console.Write(datos[i, n] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
