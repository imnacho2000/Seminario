// Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
// expresión (tip: observar qué pasa cuando b = 0):

using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese B: ");
            int b = int.Parse(Console.ReadLine());
            // if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
            // Solcucion
            if ((b != 0) && (a/b > 5)){
                 Console.WriteLine("Resultado: {0}",a/b);
            } 
            // Cuando pongo B = 0 crashea, el error dice que intento divir un numero por 0
            // Al poner un doble AND analiza la primera condicion de manera correcta siendo que si solo hay un and no lo analiza, siendo que si hay un solo and y al ser un operador de bit donde si hay una sola respuesta correcta ya la condicion es valida por lo tanto al ser 0 quiere dividir y aun asi da error y no tendria que dar verdadero ya que una condicion es que sea distindo de dicho numero, en cambio, si ponemos un doble AND al ser un operador LOGICO tiene que tomar ambas condiciones para que logre entrar en caso de que no, obviamente por logica no entra.
        }
    }
}
