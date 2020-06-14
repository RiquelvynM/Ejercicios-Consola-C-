using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos la varibales a utilizar
            int num;
            int result = 0;

            //Solicitamos numero al usuario
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            //realizamos la comprobacion y si el numero es menor a cero multiplicamos por menos uno
            result = num < 0 ? num *= -1 : num;

            Console.WriteLine("resultado es {0}", result);
            Console.ReadKey();
        }
    }
}
