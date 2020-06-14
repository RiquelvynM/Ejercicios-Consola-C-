using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable iniciada en cero 
            int num = 1;

            //se imprime el valor de num y por cada vuelta aumenta el valor
            while (num <= 10)
            {
                Console.WriteLine(num);

                num++;

            }

            Console.ReadKey();
        }
    }
}
