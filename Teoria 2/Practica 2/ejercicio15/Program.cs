// Escribir una función (método static int Fib(int n)) que calcule el término n de la
// serie de Fibonacci.
// Fib(n) = 1, si n <=2
// Fib(n) = Fib(n-1) + Fib(n-2), si n > 2

using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            fib(n);
        }
        static void fib(int n){
            int x =1, y=0;
            int resultado = 0;
            Console.WriteLine(x);
            for(int i = 0; i <= n; i++){
               //1,1,2,3,5
               resultado = x + y;
               Console.WriteLine(resultado);
               y = x;
               x = resultado;
            }
        }
    }
}
