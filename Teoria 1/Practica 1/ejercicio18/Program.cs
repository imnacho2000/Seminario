// ¿Cuál es la salida por consola del siguiente código?


using System;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i <= 4; i++)
            {
            string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
            Console.WriteLine(st);
            // Salida por consola:
            // < 1
            // uno
            // dos
            // tres
            // > 3
            // Se declara un for de 0 a menor o igula a 4, donde se declara un ternario que empieza con la codicion del i < 3, luego sigue la condicion de si i es igual a 2, en caso que sea i<3 y i igual a 2 se imprime "dos" sino si i es igual a 1 se imprimo 1 y sino "< 1" y sino si i< 4 se imprime "Tres" y sino ">3"
            //Sabiendo esto previamente se puede llegar a la conclusion de que :
            // Cuadno entra el 0 como ser menor que 3 y no es igual a dos y no es 1 se imprime <1
            // Cuando entra el 1 imprime directamente el uno porque al ser menor que tres y no ser igual a dos y ser igual a uno imprime "uno"
            // Cuando entra el dos al no ser menor que tres y ser igual a dos imprime "dos" 
            // Cuando entra el tres al ser "menor" que tres y no ser igual a dos, ni a uno pero si menor que 4 imprime "tres"
            // Cuando entra el cuatro al ser mayor que tres y no ser igual a dos ni a uno pero si "menor" que 4 imprime ">3"

            }
         }
    }
}
