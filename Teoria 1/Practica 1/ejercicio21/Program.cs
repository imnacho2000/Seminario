
// Analizar el siguiente código. ¿Cuál es la salida por consola?
// Salida por consola
// cero
// cero
// 1

//Se declara una variable I con valor 1, cuando se hace la condicion del primer if el i se le resta -1 quedando en 0 es decir entra a ese if y imprime cero, luego de ello se hace otra condicion de un if donde el i++ al ser un postcrecimiento el resultado se vera reflejado luego de analizar la condicion por eso imprime 0 y cuando llega al ultimo imprimir imprime 1.

using System;

namespace ejercicio21
{
    class Program
    {
    public static void Main(string[] args)
  {
        int i = 1;
        if (--i == 0){
            Console.WriteLine("cero");
        } 
        Console.WriteLine("I antes de entrar al segundo if {0}",i);
        Console.WriteLine(i++);
        if (i++ == 0){
            Console.WriteLine("cero");
        }
        Console.WriteLine(i);
        }
        
    }
}
