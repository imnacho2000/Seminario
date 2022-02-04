// Utilizar System.Console.ReadLine() para leer líneas de texto (secuencia de caracteres que
// finaliza al presionar <ENTER>) por la consola. Por cada línea leída se debe imprimir la cantidad
// de caracteres de la misma. El programa termina al ingresar la cadena vacía. (si st es una
// variable de tipo string, entonces st.Length devuelve la cantidad de caracteres del string).


using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese caracteres: ");
            string st = Console.ReadLine();
            Console.WriteLine("La cantidad de caracteres de la palabra es: {0} (Contnado los espcacios en blanco)", st.Length);
        }
}
}
