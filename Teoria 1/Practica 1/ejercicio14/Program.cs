// Escribir un programa que multiplique por 365 el número entero ingresado por el usuario desde
// la consola. El resultado debe imprimirse en la consola dígito por dígito, separado por un espacio
// comenzando por el dígito menos significativo al más significativo.

using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            int resultado = num * 365;
            while(resultado != 0){
               Console.Write("{0} ",resultado%10);
               resultado = resultado / 10;
            }
        }
    }
}
