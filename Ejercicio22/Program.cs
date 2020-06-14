using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos matrices a utilizar
            string[] nombres;
            int[][] dias;
            int faltas;

            nombres = new string[3];
            dias = new int[3][];

            //Pedimos los datos al usuario y creamos una fila segun cuantas dios haya faltado, que luego le solicita llenar al usuario
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                nombres[f] = Console.ReadLine();
                Console.Write("Cuantas días faltó el empleado:");
                faltas = Convert.ToInt32(Console.ReadLine());
                dias[f] = new int[faltas];
                for (int c = 0; c < dias[f].Length; c++)
                {
                    Console.Write("Ingrese nro de día:");
                    dias[f][c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //espacio entre resultado
            Console.WriteLine();

            //con este for imprimos de manera ordenada el resultado ya antes almacenado
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.WriteLine(nombres[f] + " faltó " + dias[f].Length + " días");
            }

            //y en este ultimo for calculamos quien tuvo menos falta e imprimimos tambien
            faltas = dias[0].Length;
            string nom = nombres[0];
            for (int f = 1; f < dias.Length; f++)
            {
                if (dias[f].Length < faltas)
                {
                    faltas = dias[f].Length;
                    nom = nombres[f];
                }
            }
            Console.WriteLine("El empleado que faltó menos es " + nom + " con " + faltas + " faltas.");
            Console.ReadKey();
        }
    }
}
