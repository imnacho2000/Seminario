// Escribir un programa que imprima en la consola todos los números que sean múltiplos de 17 o
// de 29 comprendidos entre 1 y 1000

using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese rango");
            int rango = Convert.ToInt32((Console.ReadLine()));
            for (int i = 0; i < rango; i++){
                if((i%17 ==0) | (i%29 == 0)){
                     Console.WriteLine(i);
                }
            }
        }
    }
}
