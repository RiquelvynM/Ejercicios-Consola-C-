using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            // un bucle bastante sencillo, donde inicamos la varaible en 2 y aumentamos 2 en cada vuelta
            for (int i = 2; i < 18; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
