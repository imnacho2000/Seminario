// Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
// consola. Para obtener el entero desde un string st utilizar int.Parse(st).

using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {      
             Console.WriteLine("Ingrese un numero entero para obtener todos sus divisores!: ");
             String cs = Console.ReadLine();
             int n = int.Parse(cs);
             for (int j = 1; j <= n; j++){
                if(n%j==0){
                    Console.WriteLine("{0} es divisor de {1}", j, n);
               }
            }
            
            string st = "hola";

            Console.WriteLine();
            void imprimir(string st) => Console.WriteLine(st);
            imprimir(st); 
        }
    }
}
