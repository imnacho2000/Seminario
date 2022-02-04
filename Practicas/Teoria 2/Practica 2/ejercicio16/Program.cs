using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ingresar numero a factorizar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("El resultado del factorial de {0} es: {1}", n, Fac(n).ToString());
            
            Console.WriteLine("El resultado del factorial recursivo de {0} es: {1}", n, FavR(n).ToString());
           
            int Factorial(int n) =>n > 1? n * Factorial(n-1): n;
            Console.WriteLine("El resultado del factorial bodied de {0} es: {1}", n, Factorial(n).ToString());

        }
        static int Fac(int n){
           int  resultado  = 1;
           while(n !=0){
              resultado *= n;
              n--;
           }
           return resultado;
        }
        static int FavR(int n){
        if(n > 1){
            n = n * FavR(n-1); 
        }
        return n;
        }

    }
}
