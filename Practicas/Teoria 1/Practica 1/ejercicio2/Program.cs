// El \n produce un salto de linea
// El \t produce una tabulacion horizontal
// El \r produce un retorno, es decir produce un Enter en el texto (return)

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo
            Console.Write("- Hola, maria como estas?, mucho gusto me presento mi nombre es 'Manuel'\n+ Hola manuel!, bien y tu?, el gusto es mio! :), bienvenido a Maze Bank tu lugar de confianza, me prestarias tus datos?, me dirias tu ID y tu, por favor");
            Console.Write("\r\n- Claro mi identificacion es: 43405723 ");
            Console.Write("\nDisculpe usted esta seguro que su nombre es \"manuel\"");
        }
    }
}
