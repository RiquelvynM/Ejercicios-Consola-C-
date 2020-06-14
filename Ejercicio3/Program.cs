using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos las variables a utilizar
            int Num1, Num2, Result;

            //Pedimos el primer numero al usuario
            Console.WriteLine("Ingrese primer numero");
            Num1 = Convert.ToInt32(Console.ReadLine());

            //confirmamos que el primer numero no se cero
            if (Num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            // de lo contrario pedimos el otro numero y realizamos la operacion.Damos impresion de resultado
            else
            {
                Console.WriteLine("Ingrese segundo numero");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Result = Num1 * Num2;

                Console.WriteLine("El resultado de la multiplicacion es: {0}", Result);
            }

            Console.ReadKey();


        }
    }
}
