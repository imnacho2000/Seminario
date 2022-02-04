// ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
// las palabras (una por línea) de una frase ingresada por el usuario.

using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //El metodo split sirve para  seprar una cadena de texto mediante un patron asignado por parametro y guardandolo en un vector de tipo string.
            Console.WriteLine("Ingrese textos");
            string st = Console.ReadLine();
            string [] texto = st.Split(" ");
            Console.WriteLine("Texto separado por espacios en blanco: ");
            foreach (string textos in texto){
                Console.WriteLine(textos);
            }
        }
    }
}
