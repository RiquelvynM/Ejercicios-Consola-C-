using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos los vectores a utilizar:
            string[] pais;
            int[,] tempmen;
            int[] temptri;

            pais = new String[4];
            tempmen = new int[4, 3];

            //pedimos los datos al usuario
            for (int f = 0; f < pais.Length; f++)
            {
                Console.Write("Ingrese nombre del pais :");
                pais[f] = Console.ReadLine();
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write("Ingrese temperatura mensual " + (c + 1) + ": ");
                    tempmen[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //en este bucle se compara con el indice principal y ordena de de forma numerica
            for (int f = 0; f < pais.Length; f++)
            {
                Console.Write("Provincia:" + pais[f] + ":");
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    Console.Write(tempmen[f, c] + " ");
                }
                Console.WriteLine();
            }

            temptri = new int[4];
            for (int f = 0; f < tempmen.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < tempmen.GetLength(1); c++)
                {
                    suma = suma + tempmen[f, c];
                }
                temptri[f] = suma / 3;
            }

            //imprime de manera ordenada
            Console.WriteLine("Temperaturas trimestrales.");
            for (int f = 0; f < pais.Length; f++)
            {
                Console.WriteLine(pais[f] + " " + temptri[f]);
            }

            int may = temptri[0];
            string nom = pais[0];
            for (int f = 0; f < pais.Length; f++)
            {
                if (temptri[f] > may)
                {
                    may = temptri[f];
                    nom = pais[f];
                }
            }

            Console.WriteLine("pais con temperatura trimestral mayor es " + nom + " que tiene una temperatura de " + may);
            Console.ReadKey();

        }
    }
}
