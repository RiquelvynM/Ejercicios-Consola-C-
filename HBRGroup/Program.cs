using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBRGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaré las variables a utilizar
            int num1;
            int num2;
            int result;

            //Pido al usuario los dos números y los almaceno en su respectiva variable
            Console.Write("Ingrese primer numero :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese segundo numero :");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Realizo la operación y la almaceno en la variable correspondiente
            result = num1 / num2;

            //Un espacio entre los datos y el resultado acontinuación
            Console.WriteLine();


            //Imprimo el resultado de la division y el modulo de los dos números
            Console.WriteLine("La division de estos dos numeros es: {0}", result);
            Console.WriteLine("Mientras que el modulo es: {0}", num1 % num2);

            Console.ReadKey();
        }
    }
}
