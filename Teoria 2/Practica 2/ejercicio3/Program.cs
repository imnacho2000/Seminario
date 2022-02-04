// Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
// ¿Qué hace realmente?


using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10);
            {
                sum += i++;
            }
            Console.WriteLine(sum);

            // El erro presentado es la ;, lo que hace es dar una instruccion vacia erronea.
        }
    }
}
