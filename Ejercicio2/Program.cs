using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables a utilizar
            int num1;
            int num2;
            int result;

            //Solicitamos los datos al usuario
            Console.WriteLine("Ingrese primer valor");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Realizamos operacion
            result = num1 % num2;

            //Confirmamos si es multiplo y de la misma manera imprimimos
            if (result == 0)
            {
                Console.WriteLine("E l numero {0} es multiplo", result);
            }
            else
            {
                Console.WriteLine(" El numero {0} no es multiplo", result);
            }
            Console.ReadKey();
        }
    }
}
