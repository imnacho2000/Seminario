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
            if(nombre.Equals("Juan")) {
                Console.WriteLine("Hola Amigo!");
            }
            else if(nombre.Equals("Maria")){
                Console.WriteLine("Buen día señora");
            }
            else if(nombre.Equals("Alberto")){
                 Console.WriteLine("Hola {0}",nombre);
            }
            else if(nombre.Equals("")){
                 Console.WriteLine("Buen dia mundo!");
            }
            else{
                Console.WriteLine("Hola {0}",nombre);
            }
        }
    }
}
