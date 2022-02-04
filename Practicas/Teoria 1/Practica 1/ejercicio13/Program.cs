// Escribir un programa que calcule la suma de dos números reales introducidos por teclado y
// muestre el resultado en la consola (utilizar double.Parse(st) para obtener el valor double a
// partir del string st.

using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1: ");
            String st = Console.ReadLine();
            double num1 = double.Parse(st);
            Console.WriteLine("Ingrese numero 2: ");
            st = Console.ReadLine();
            double num2 = double.Parse(st);
            Console.WriteLine("Resultado = {0}",num1 + num2);
        }
    }
}
