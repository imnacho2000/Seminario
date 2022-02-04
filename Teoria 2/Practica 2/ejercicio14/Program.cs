using System.Text.RegularExpressions;
// Implementar un programa que muestre todos los números primos entre 1 y un número natural
// dado (pasado al programa como argumento por la línea de comandos). Definir el método
// static bool esPrimo(int n) que devuelve true sólo si n es primo. Esta función debe
// comprobar si n es divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota:
// Math.sqrt(d) devuelve la raíz cuadrada de d)


using System;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);

            Console.WriteLine(esPrimo(n)==true ? "Es primo":"No es primo");
        }
        static bool esPrimo(int n){
            int resultado = (int)Math.Sqrt(n);
            for(int E = 2; E < resultado; E++){
                if(n%E==0){
                    return false;
                }
            }
            return true;
        }
    }
}
