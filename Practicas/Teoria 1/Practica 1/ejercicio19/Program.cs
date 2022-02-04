// Para cada una de las siguientes líneas de código verificar cuáles son permitidas por el
// compilador y en tal caso en qué estado quedan las variables involucradas en la declaración al
// ejecutarse:

using System;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a, b, c; //las tres variables se declaron como Integer
            // int a; int b; int c, d; // variables A, B, C y D son declaradas como integer
            // int a = 1; int b = 2; int c = 3; // A, B, C se le asignan valores
            // int b; int c; int a = b = c = 1; //Las tres varaibles se le asignan el valor 1
            // int c; int a, b = c = 1; // Variable A solo esta declarada pero nunca se usa, B se le asignca C que vale 1
            // int c; int a = 2, b = c = 1; // Varaibles C u B se le asigna el 1 u a la variable A un 2
            // int a = 2, b, c, d = 2 * a; // Variables B y C no estan asignadas, A y D tiene valor, A 2 y D 4
            // // int a = 2, int b = 3, int c = 4; // al no estar separados por ; b y c no estan declarados por lo tanto no se pueden utilizar ni compilar, A si se puede ya que esta declarada y asignada. 
            // int a = 2; b = 3; c = 4; // C y B como no al especificar por lo tanto no existen en cambio A al especificar si existe y tiene el valor 2;
            // int a; int c = a; // Como la variable A no tiene un valor asignado por lo tanto falla.
            // char c = 'A', string st = "Hola"; // La variable C se declara y asigna y la variable st no se puede declarar ni usar porque como el identificador es una "," no se puede realizar dicha opearcion y por lo tanto no compila.
            // char c = 'A'; string st = "Hola"; // ambas variables estan bien creadas, identificadas y asignadas.
            // char c = 'A', st = "Hola"; // La variable C se declara y asigna y la variable st no se puede declarar ni usar porque como el identificador es una "," no se puede realizar dicha opearcion y por lo tanto no compila, ademas que no esta especificada.
        }
    }
}
