using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las variables segun los requiitos, entre 26 y 10
            int num1 = 28;
            int num2 = 10;


            //creamos bucle donde el primer numero no reste menos de 10, el limite es 10
            while (num1 > num2)
            {
                num1 -= 2;

                Console.WriteLine(num1);
            }

            Console.ReadKey();
            
        }
    }
}
