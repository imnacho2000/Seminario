// Implementar un programa que permita al usuario ingresar números por la consola. Debe
// ingresarse un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía.
// A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma
// acumulada de los mismos. Utilizar la instrucción try/catch para validar que la entrada
// ingresada sea un número válido, en caso contrario advertir con un mensaje al usuario y
// proseguir con el ingreso de datos.


using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un numero, finaliza con una linea vacia: ");
            string st = Console.ReadLine();
            while(!st.Equals("")){
                    try{
                        n = int.Parse(st);
                    }
                    catch{
                        Console.WriteLine($"Peligro! Ingreso un numero invalido");
                    }
                    finally{
                        numero += n;
                        Console.WriteLine($"Sumatoria: {numero}");
                    } 
                Console.WriteLine("Ingrese un numero, finaliza con una linea vacia: ");
                st = Console.ReadLine();
            }
        }
    }
}
