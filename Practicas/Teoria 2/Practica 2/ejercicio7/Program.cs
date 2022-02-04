// Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // char c;
            // char? c2;
            // string st;
            // c = ""; // error se espera un caracter no un string
            // c = ''; // no se le puede asginar un caracter vacio
            // c = null; // tira error porque no es un char nulleable
            // c2 = null;
            // c2 = (65 as char?); // el resultado siempre va a ser null porque no se puede convertir un entero en un char 
            // st = "";
            // st = ''; // al ser string se espera una expresion de doble ""
            // st = null;
            // st = (char)65; // no se puede convertir un int a un char, ademas el st es de tipo string
            // st = (string)65; // no se puede convertir el int en string
            // st = 47.89.ToString();
        }
    }
}
