using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos varibales y asignamos un valor al mismo tiempo, para que el IDE no nos de error al utilizarlo en el IF sin ningun valor
            double Num1 = 0, Num2 = 0, Result = 0;

            //Pedimos los datos al usuario
            Console.WriteLine("Ingrese primer valor");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero");
            Num2 = Convert.ToDouble(Console.ReadLine());

            //Aqui verificamos que que el segundo numero sea cero para dar el error, y si es lo contrario el programa continuara.
            if (Num2 == 0)
            {
                Console.WriteLine("No se puede multiplicar por cero");
            }
            else
            {
                Result = Num1 * Num2;

                Console.WriteLine("El resultado de la multiplicacion es: {0}", Result);
            }

            Console.ReadKey();

        }
    }
}
