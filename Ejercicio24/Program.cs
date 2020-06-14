using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz  y variables
            int[,] matriz;
            int filas;
            int columnas;

            //solicitamos datos al usuario
            Console.Write("Ingrese fiilas:");
            filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Imgrese columnas:");
            columnas = Convert.ToInt32(Console.ReadLine());

            matriz = new int[filas, columnas];

            //creamos for para pedir datos y almacenar
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese valor:");
                    matriz[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Imprimo los vertices con el uso de GetLength
            Console.WriteLine("Vértice superior izquierdo: {0}", matriz[0, 0]);
            Console.WriteLine("Vértice superior derecho: {0}", matriz[0, matriz.GetLength(1) - 1]);
            Console.WriteLine("Vértice inferior izquierdo: {0}", matriz[matriz.GetLength(0) - 1, 0]);
            Console.WriteLine("Vértice inferior derecho: {0}", matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1]);
            Console.ReadKey();
        }
    }
}
