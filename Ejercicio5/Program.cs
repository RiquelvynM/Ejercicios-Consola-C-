using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable a utilizar
            string letra;

            //Pedimos al usuario una letra
            Console.WriteLine("Ingrese una letra");
            letra = Console.ReadLine();

            //Con el switch verificamos si es una vocal, de lo contrario dara un resultado por default
            switch (letra)
            {
                case "a":
                    Console.WriteLine("Es una vocal");
                    break;
                case "e":
                    Console.WriteLine("Es una vocal");
                    break;
                case "i":
                    Console.WriteLine("Es una vocal");
                    break;
                case "o":
                    Console.WriteLine("Es una vocal");
                    break;
                case "u":
                    Console.WriteLine("Es una vocal");
                    break;
                default:
                    Console.WriteLine("No es una vocal");
                    break;

            }

            Console.ReadKey();
        }
    }
}
