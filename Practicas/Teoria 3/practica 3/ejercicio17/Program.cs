// Implementar un programa calculadora que calcule una expresión ingresada por el usuario
// correspondiente a una operación binaria de las cuatro elementales (ejemplo “44.5/456”,
// “456*45”, “549-12”, “54+6” ). Utilizar try/catch para validar los números y controlar
// cualquier tipo de excepción que pudiese ocurrir en la evaluación de la expresión.

using System;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var resultado = 0;
            var o = 0;
        //     Console.WriteLine("Ingrese una cuenta: (numero,operacion,numero)");
        //     string stt = Console.ReadLine();
        //     foreach(char st in stt){
        //         try{
        //               int.Parse(st);
        //          }
        //    }

            try{
                Console.WriteLine("Ingrese un numero: ");
                n = Convert.
                Console.WriteLine("Ingrese una operacion a realizar: ");
                string operacion = Console.ReadLine();
                Console.WriteLine("Ingrese otro numero: ");
                o = Convert.ToInt32(Console.ReadLine());
                if(operacion.Equals("/")){
                        resultado = n/o;
                        Console.WriteLine($"Resultado : {resultado}");
                }
                else if(operacion.Equals("*")){
                        resultado = n*o;
                        Console.WriteLine($"Resultado : {resultado}");
                }
                else if(operacion.Equals("+")){    
                        resultado = n+o;
                        Console.WriteLine($"Resultado : {resultado}");
                    }
                    else if(operacion.Equals("+")){   
                        resultado = n-o;
                        Console.WriteLine($"Resultado : {resultado}");
                    }
                }
                catch (DivideByZeroException){
                    Console.WriteLine("Error division por ceros");
                }
                catch{
                    Console.WriteLine($"Operacion desconocida");
                }
            }
        }
    }
