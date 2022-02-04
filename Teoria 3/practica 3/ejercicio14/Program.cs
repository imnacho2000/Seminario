using System;
using System.Threading.Tasks;
using System.Collections;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso por teclado un numero
            Console.WriteLine("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Stack pila = new Stack();
            string binario = "";
            while(n > 0){
                int resto = n % 2;
                pila.Push(resto);  //Aniado el elemento a la pila.
                n = n / 2; // Vuelvo a dividir el numero para poder iterar y avanzar.
            }
            while(pila.Count > 0){ //Mientras el contado de pila sea mayor a 0, saco el elemento de la pila y lo paso a una variable de tipo string para poder informar correctamente
                binario += pila.Pop();
            }
            Console.WriteLine($"El numero en binario es: {binario}");
        }
    }
}
