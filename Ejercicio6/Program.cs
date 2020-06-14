using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las variables a utilizar
            int Num1, Num2;

            Console.WriteLine("Ingrese primer valor");
            Num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese segundo valor");
            Num2 = Convert.ToInt32(Console.ReadLine());

            /*Verificamos que los numeros ingreasos sean mayor a 0, para darnos cuenta que son positivo, y dentro del mismo verificamos que el otro numero sea mayor a cero, de lo contrario
            es negativo*/
            if (Num1 > 0)
            {
                if (Num2 > 0)
                {
                    Console.WriteLine("Los dos numeros son positivos");
                }
                else
                {
                    Console.WriteLine("Uno de los numeros es positivo");
                }
            }
            if (Num1 < 0)
            {
                if (Num2 < 0)
                {
                    Console.WriteLine("Ninguno de los numeros es positivo");
                }
                else
                {
                    Console.WriteLine("Uno de los numeros es positivo");
                }
            }

            Console.ReadKey();
        }
    }
}
