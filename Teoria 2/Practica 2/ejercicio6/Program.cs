using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola {0}!", args[0]);
        }
        // Al no pasar argumentos por linea de consola produce un error ya que no hay nada en este vector de string, se proudce un error de fuera de rango
    }
}
