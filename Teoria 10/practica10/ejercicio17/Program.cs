using System;
using System.Threading.Tasks; // para poder usar las task, El Modelo de Programación Asincrónica (APM) que es elmodelo heredado (legacy) que usa la interfaz IAsyncResult, El Modelo de Programación Asincrónica (APM) que es el modelo heredado (legacy) que usa la interfaz IAsyncResult, La clase Task representa una tarea que no devuelve ningún valor y que normalmente se ejecutará de forma asincrónica, Task(Action act): act es un delegado que representa el código que se va a ejecutar en la tarea Task(Action<object> act, object obj): act representa el código que se va a ejecutar en la tarea y obj los datos que act va a usar El método RunSynchronously() inicia la tarea sincrónicamente
using System.IO; // para poder interactuar con archivos de texto
namespace ejercicio17
{
    class Program
    {
        static void Main(string [] args)
        {      
            Console.WriteLine($"Ingrese un nombre");
            String s = Console.ReadLine();
            // le asigno el metodo asincronico al task de int
            Task<int> t = PalabrasTotalesAsync(s);
            Console.WriteLine($"La cantidad de palabras contenidas en el archivo es: {t.Result}");
        }

        static async Task<string> ContenidoArchivoAsync(String s){ // segundo
            // se le manda el metodo a ejecutar al task de string
            Task<string> t = new Task<string>(() => LeerContenido(s));  // Para crear e iniciar una tarea en una sola operación suele utilizarse el método estático Task.Run
            // inicia task
            t.Start();
            // espera que termine la ejecucion del task, pausa este metodo y le da el mando al main hasta 
            // que termine
            await t;
            return t.Result; 
        }
        static string LeerContenido(String s) // tercero
        {
            StreamReader l = new StreamReader(s,true);
            string st = l.ReadToEnd(); // lee todo el contenido del archivo y lo guarda
            return st;
        }

        static async Task<int> PalabrasTotalesAsync(String s){ //primero asigno al string el metodo asincronico que devuelve string, El objeto devuelto por un método marcado con async es construido por el compilador. Si el tipo de     retorno es Task no hace ÿalta ninĀuna sentencia return. A lo sumo se puede usar return; sin valor de retorno, como si se tratase de un método void. Cuando un método marcado con async necesita devolver un valor de tipo T a su invocador, se debe especificar el tipo de retorno Task<T>, sin embargo return debe ir acompañada de una expresión de tipo T. La utilización de métodos asincrónicos puede mejorar mucho el rendimiento, sobre todo cuando se utilizan para realizar Entrada / Salida, También podemos crear tareas genéricas Task<T> explícitamente utilizando su constructor que espera un parámetro de tipo Func<T> . Luego será necesario invocar el método Start()
            string t1 = await ContenidoArchivoAsync(s); // La expresión await t espera asincrónicamente la finalización de la tarea t y devuelve el valor retornado por t (en caso que t sea de tipo Task<T>), por lo tanto los siguientes fragmentos de código son equivalentes
            // split es para separar cadenas, funciona como delimitador y se puede marcar
            // simbolos o espacios para eso, los caracteres tomados se los vuelve a hacer un string
            // para obtener las palabras, removeEmptyEntries elimina las entradas vacias como espacios
            string [] vector = t1.Split(" .,;=?'¿¡!:()-_01234689\"\n\r".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            return vector.Length;
        }
    }
}