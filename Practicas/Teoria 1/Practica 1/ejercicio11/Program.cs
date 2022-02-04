using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10/3 = " + 10 / 3);
            Console.WriteLine("10.0/3 = " + 10.0 / 3);
            Console.WriteLine("10/3.0 = " + 10 / 3.0);
            int a = 10, b = 3;
            Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
            Console.WriteLine("entonces a/b = " + a / b);
            double c = 3;
            Console.WriteLine("Si c es una variable double, c=3");
            Console.WriteLine("entonces a/c = " + a / c);   

            //Respecto a la / se puede concluir que tanto en caso de ser ambos del mismo tipo demuestra su respectivo resultado, es decir en caso de ser ambos enteros muestra su parte entera mientras que en caso de uno sea de un tipo double (por ejemplo) llega a un resultado Racional.
            //El + en un console.write  lo concatena convirtiendolo en un string
        }
    }
}
