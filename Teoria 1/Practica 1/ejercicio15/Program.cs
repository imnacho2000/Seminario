// Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si
// es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible
// por 400.

using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un anio: ");
            int n = int.Parse(Console.ReadLine());
            if(n%4 == 0){
                if(n%100 == 0){
                    if(n%400 == 0){
                        Console.WriteLine("El anio es bisiesto");
                    }
                    else{
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else { 
                Console.WriteLine("El anio es bisiesto");
                }    
            }
            else{ 
            Console.WriteLine("El anio no es bisiesto");
            }
        }
    }
}
