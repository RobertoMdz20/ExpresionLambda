using System;
using System.Collections.Generic;

namespace ExpresionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de lista.
            List<int> datos = new List<int>();
            datos.AddRange(new int[] { 93, 32, 44, 87, 20, 64, 43, 75, 28, 69, 4, 17 });

            //Expresión lambda.
            List<int> pares = datos.FindAll(num => (num % 2) == 0);

            //Texto.
            Console.WriteLine("Los números pares del listado son:");

            //Mediante le foreach realizamos la iteración de los números pares.
            foreach (int numpares in pares)

                //Mostramos por pantalla los datos.
                Console.WriteLine(numpares);
        }
    }
}

