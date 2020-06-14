using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int num = 1;

            //imprimimos valor de num, y luego aumentamos valor hasta ser menor o igual a 10
            do
            {
                Console.WriteLine(num);
                num++;

            } while (num <= 10);

            Console.ReadKey();
        }
    }
}
