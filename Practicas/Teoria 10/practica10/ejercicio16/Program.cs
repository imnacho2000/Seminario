using System;
using System.Threading.Tasks; // para poder usar las task
using System.IO; // para poder interactuar con archivos de texto
using System.Text; // para poder usatr string builder
namespace ejercicio16
{
    class Program
    {
       static void Main(string [] args)
        {      
            StreamReader s = new StreamReader("listaAutos.txt",true);
            // guardo el metodo asincronico en una variable task de string
            Task<string> t = ContenidoArchivoAsync(s); 
            Console.WriteLine("Contenido del archivo");
            Console.WriteLine(t.Result); // al poner t.result no avanza hasta que se retorne el valor
        }

        static async Task<string> ContenidoArchivoAsync(StreamReader s){
            Task<string> t = new Task<string>(() => LeerContenido(s));
            t.Start(); //comienza la ejecucion
            await t; // espera que termine el metodo LeerContenido y le da el mando al main
            return t.Result; // devuelve el task de string cuando finalice t
        }

        static string LeerContenido(StreamReader s)
        {
            string st = s.ReadToEnd(); // lee todo el texto y lo guarda
            return st;
        }
    }
}
