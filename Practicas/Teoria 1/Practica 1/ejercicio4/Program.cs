// //Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
// saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
// línea en blanco. Para ingresar un string desde el teclado utilizar
// System.Console.ReadLine()
using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Ingrese su nombre: ");
            String st = Console.ReadLine();
            if(st.Equals(""))
            {
                Console.WriteLine("Hola mundo");
            } else {
                Console.WriteLine("Saludos {0}",st);
            }

            // for(int i=0; i<st.Length; i++){
            //     if(st[i].Equals(" ")){
            //        Console.WriteLine(st[i]);
            //     }
            // }
            // Console.WriteLine(st);
        }
    }
}
