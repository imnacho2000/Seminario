// Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
// nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María”
// debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso,
// debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha
// ingresado una línea vacía.

// a) utilizando if ... else if
// b) utilizando switch

using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese un nombre: ");
           String nombre = Console.ReadLine();
            switch(nombre) {
                case "Juan":
                     Console.WriteLine("Hola Amigo!");
                break;
                case "Maria":
                     Console.WriteLine("Buen día señora");
                break;
                case "Alberto":
                     Console.WriteLine("Hola {0}",nombre);
                break;
                case "":
                      Console.WriteLine("Buen dia mundo!");
                break;
                default:
                    Console.WriteLine("Hola {0}",nombre);
                break;
            }
            Console.ReadKey();
        }
    }
}
