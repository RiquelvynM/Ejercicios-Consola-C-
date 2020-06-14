using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos matriz irregular
            int[][] matriz;

            matriz = new int[5][];

            //Pedimos los datos al usuario
            for (int f = 0; f < matriz.Length; f++)
            {
                //aqui empezamos a sumar una columna por cada vuelta y de la misma manera asignandole un valor
                matriz[f] = new int[f + 1];
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write("Ingrese valor: ");
                    matriz[f][c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //imprimimos de forma comun ya que el bucle anterior se encarga de ordenarlo
            Console.WriteLine();
            for (int f = 0; f < matriz.Length; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write(matriz[f][c] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
