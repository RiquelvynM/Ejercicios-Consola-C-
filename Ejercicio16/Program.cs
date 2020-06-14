using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos vector
            int[] sueldos = new int[5];


            //solicitamos los datos al usuario 
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Ingrese Sueldo:");
                sueldos[i] = Convert.ToInt32(Console.ReadLine());
            }


            /*Creamo bucle donde */
            for (int c = 0; c < 4; c++)
            {
                for (int f = 0; f < 4 - c; f++)
                {
                    if (sueldos[f] > sueldos[f + 1])
                    {
                        int orden;
                        orden = sueldos[f];
                        sueldos[f] = sueldos[f + 1];
                        sueldos[f + 1] = orden;
                    }
                }
            }

            //imprimimos de menor a mayor
            Console.WriteLine(" ");
            Console.WriteLine("Sueldos ordenados");

            for (int n = 0; n < sueldos.Length; n++)
            {
                Console.WriteLine(sueldos[n] + "  ");
            }

            Console.ReadKey();
        }
    }
}
