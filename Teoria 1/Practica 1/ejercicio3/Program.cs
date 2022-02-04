// El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente
// fragmento de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para
// que el programa siga funcionando de igual manera

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLCUIONAR ESTO: String st= @"c:\windows\system";
            String st= "c:\\windows\\system";
            Console.Write(st);
        }
    }
}
