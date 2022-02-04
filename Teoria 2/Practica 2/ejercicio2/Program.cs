using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = "A";
            object o2 = o1;
            o2 = "Z";
            Console.WriteLine(o1 + " " + o2);
        }
        // El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
        // variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
        // consola no sea “Z Z”?
        
        //RTA:
        //  Esto pasa porque la variable Object o2 es una nueva instancia a la cual se le asigna el valor de o1 que es A, lo que sucede aca es que 
   }
}
