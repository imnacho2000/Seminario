    //La única diferencia entre Console.Write () y Console.WriteLine (), es que Console.Write() se usa para imprimir datos sin saltar a una nueva línea, mientras que Console.WriteLine() se usa para imprimir datos junto con la impresión de la nueva línea.

    // Segun la documentacion de Microsoft el metodo "Console.ReadKey()" obtiene el siguiente carácter o tecla de función presionada por el usuario y la imprime.



    using System;

    namespace ejercicio
    {
        class Program
        {
            static void Main(string[] args)
            { 
                // Ejemplo del write
                Console.Write("El auto es rojo");

                Console.WriteLine("El auto es");
                Console.WriteLine("rojo!");
                
                //programa
                Console.WriteLine("Ingrese un nombre: ");
                String nombre = Console.ReadLine();
                
                Console.ReadKey();
                Console.WriteLine("Hola mundo!");
                
                Console.WriteLine("Ingrese un apellido: ");
                String apellido = Console.ReadLine();

                Console.WriteLine("Hola {0} {1}",nombre, apellido);    
            }
        }
    }
