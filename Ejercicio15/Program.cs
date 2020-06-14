using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {

            //varibales a utilizar 
            int[] vector;
            int numMenor;

            //pedimos cantidad de filas del vector
            Console.WriteLine("cantidad de numeros que desea almancenar:");
            vector = new int[Convert.ToInt32(Console.ReadLine())];


            //asignamos valores a nuestro vector
            for (int v = 0; v < vector.Length; v++)
            {
                Console.WriteLine("Ingrese valor");
                vector[v] = Convert.ToInt32(Console.ReadLine());

            }

            /*creamos variable para almacenar el primer valor del vector y comparar con los demas.
            *al final en la variable se almacenara el numero que sea menor de todos*/
            numMenor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < numMenor)
                {
                    numMenor = vector[i];
                }
            }
            //Damos salida a la impresion del menor numero
            Console.WriteLine("El numero menor es: {0}", numMenor);

            //creamos variable con el fin de almacenar nuevamente el primer valor del vector, y en base al numero menor comparamos con los demas numeros, almacenando asi el numero que se repite
            int menorRepeat = 0;
            for (int r = 1; r < vector.Length; r++)
            {
                if (numMenor == vector[r])
                {
                    menorRepeat = vector[r];
                }
            }

            //si el numero es mayor que cero es porque se repite el numero, pero si continua en cero es porque no se repite dentro del vector
            if (menorRepeat > 0)
            {
                Console.WriteLine("Se repite el numero{0}: ", menorRepeat);
            }
            else
            {
                Console.WriteLine("El menor no se repite");
            }
            Console.ReadKey();
        }
    }
}
