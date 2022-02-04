// Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado en un parámetro de salida
// static void Fac(int n, out int f)

using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para factorizar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int resultado;
            int resultado2;
            fac(n,out resultado);
            Console.WriteLine("El resultado de factorizar el numero {0} es: {1}", n,  resultado);
            FavR(n,out resultado2);
            Console.WriteLine("El resultado de factorizar recursivamente el numero {0} es: {1}", n,  resultado2);
        }

        static void fac(int n,out int f){
            int resultado = 1;
            while(n > 1){
                resultado *= n;
                n--;
            }
            f = resultado;
        }

        static int FavR(int n,out int f){
        if(n > 1){
             n = n * FavR(n-1,out f); 
        }
        return f = n;
        }
    }
}
