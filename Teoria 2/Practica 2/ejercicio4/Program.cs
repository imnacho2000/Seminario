// ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(args == null);
            System.Console.WriteLine(args.Length);
        }
        // En caso de no pasarse argumentos por linea de consola el programa imprime, en caso de que los argumentos sean nulos imprime true o false dependiendo de que haya en el args y como no tiene nada de longitud el arreglo es 0
    }
}
