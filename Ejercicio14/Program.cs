using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos variable a utilizar
            int oper;

            //creamos bucle inicado en 3 y que auumenta en uno, mientras el if solo imprime los numeros que se pueden dividir en tres
            for (int i = 3; i <= 50; i++)
            {
                oper = i % 3;

                if (oper == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
