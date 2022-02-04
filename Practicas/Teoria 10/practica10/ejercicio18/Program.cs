using System;
using System.Threading.Tasks; // para poder usar las task
using System.IO; // para poder interactuar con archivos de texto
using System.Text; // para poder usatr string builder
using System.Collections.Generic; // para poder interactuar con las colecciones
namespace ejercicio18
{
    class Program
    {
         static void Main(string[] args)
        {
            string[] strVector = {"listaautos.txt", "listaautos2.txt", "listaautos3.txt"}; // Creo un vector de strings donde tengo los nobmres de los archivos
            Task<int[]> t = cantPalabras(strVector); // creo una tarea de tipo entero t, donde le asigno cantPalabras(strVector).
            
            int i=0; // variable indice para indicar que num de archivo es
            foreach(int aux in t.Result) // imprimo en un foreach la cant que tiene t.Result 
            {
                Console.WriteLine($"en el archivo {i++} se encontraron {aux} palabras");
            }
        }
        static async Task<int[]> cantPalabras(params string[] aux)
        {
            int[] v = new int[aux.Length]; // creo una tarea asincronica y creo un vector de entero con la longitud que tiene el vector de strings
            List<Task<int>> l = new List<Task<int>>(); // creo una lista que tiene una tarea de tipo entera
            for(int i=0; i<aux.Length; i++) // hago un for hasta la longitud del vector de string llegado por parametro
            {
                l.Add(leerArchivoAsync(aux[i])); // anadio en la lista los procesos generados para aux en la posicion [i]
            }

            await Task.WhenAll(l); // espero a que terminen todos los procesos generados por el for

            int k=0; // creo una variable entera que la utilizo como indice
            foreach(Task<int> z in l)
            {
                v[k++]= z.Result; // le asigno al vector creado anteriormente, de forma local, el resultado que tiene los valores guardados en la lista
            }

            return v; // retorno el vector
        }

       static async Task<int> leerArchivoAsync (string nombre)
       {
           Task<string> t = new Task<string>(()=> leerArchivo(nombre)); // creo una tareia asincronica y la instancio pasandole el nombre, escrito por el usuario, por parametro 
           t.Start(); // la inicio
           await t; // espero a su finalizacion
           return t.Result.Split().Length; // retorno 
       }

       static string leerArchivo(string nombre)
       {
           StreamReader st=null;
           StringBuilder str = new StringBuilder(""); // creo un string builder para poder "evolucionar" el string y asi poder cocatenar
           try{ // realizo un try y en caso de generar excepcion lo genero y finalmente la variable st se borra para liberar memoria.    
               st = new StreamReader(nombre);

               while(!st.EndOfStream) // mientras no se acabe el archivo (Obtiene un valor que indica si la posición actual de la transmisión se encuentra al final de la transmisión).
               {
                   str.Append(st.ReadLine() + '\n'); // Agrego la representación de cadena de un objeto especificado a esta instancia.
               }
           }
           catch(Exception e){
               Console.WriteLine(e.Message);
           }
           finally{
              st.Dispose();// Elimino el st con dispose para liberar memoria
           }

           return str.ToString(); // retorno el str 
       }
    }
}
