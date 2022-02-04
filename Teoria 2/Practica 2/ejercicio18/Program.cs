// Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio
// debe apreciarse en el método invocador.

using System;

namespace ejercicio18
{   
    class Program
    {
        static void Main(string[] args)
        {
         int  a=5, b=10;            
         Console.WriteLine("Antes del cambio: A {0} y B {1}",a,b);
         intercambio(ref a,ref b);
         Console.WriteLine("Despues del cambio: A {0} y B {1}",a,b);
        }
        static void intercambio( ref int a, ref int b){
            int aux = b;
            b = a;
            a = aux;
        }
    }
}
