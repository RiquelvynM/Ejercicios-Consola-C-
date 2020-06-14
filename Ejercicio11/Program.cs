using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*creamos variables inicada en 28 ya que se va imprimir en orden ascendente
             * y otra variable para almacenar los numeros par*/
            int num = 26;
            int par;

            //mientras que en el ciclo restamos dos al numero inical y asi obtnemos nuestro numero par, que luego dividimos entre dos.
            do
            {

                par = num / 2;
                Console.WriteLine(par);
                num -= 2;

            } while (num > 10);

            Console.ReadKey();
        }
    }
}
