using System;
using System.Collections;
using System.IO;

namespace ejercicio10
{
    class Program
    {
        static ArrayList listaAutos = new ArrayList();
        static void Main(string[] args)
        {
            Console.WriteLine($"Menú de opciones\n================\n \t1. Ingresar autos desde la consola\n \t2. Cargar lista de autos desde el disco\n \t3. Guardar lista de autos en el disco\n \t4. Listar por consola\n \t5. Salir\n Ingrese su opción: ");
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case '1': 
                        Agregar();
                        break;
                    case '2': 
                        cargarLista();
                        break; 
                    case '3': 
                        guardarLista();
                        break;
                    case '4': 
                        imprimir();
                        break; 
                }
            } while (tecla.KeyChar != '5');
        }

        private static void Agregar(){
            Console.WriteLine($"Ingrese marca: ");
            string marca = Console.ReadLine();
            while(!marca.Equals("")){
                Console.WriteLine($"Ingrese modelo");
                string modelo = Console.ReadLine();
                Autos c_auto = new Autos(marca,modelo);
                listaAutos.Add(c_auto);
                Console.WriteLine($"Ingrese marca: ");
                marca = Console.ReadLine();
            }
        }
        private static void cargarLista(){
            Console.WriteLine($"Cargando lista..");
            listaAutos = new ArrayList();
            using(StreamReader sr = new StreamReader("listaAutos.txt"))
                {
                    while(!sr.EndOfStream)
                    {
                        listaAutos.Add(new Autos(sr.ReadLine(),sr.ReadLine()));
                    }
                }
            Console.WriteLine($"Aqui esta el archivo impreso:\n================");
            foreach (Autos line in listaAutos){
                Console.Write($"Marca:{line._marca}\nModelo:{line._modelo}\n");
            }
            Console.WriteLine($"================");
            Console.WriteLine($"\tListo!");
        }

         public static void guardarLista(){
            Console.WriteLine($"Guardando lista..");
            using (StreamWriter sw = new StreamWriter("listaAutos.txt"))
            {
                foreach (Autos A in listaAutos)
                {
                    sw.WriteLine(A._marca);
                    sw.WriteLine(A._modelo);
                }
            }
            Console.WriteLine($"Listo!");
        }

        private static void imprimir(){
            Console.WriteLine($"Aqui esta la lista impresa:\n================");
            foreach(Autos a in listaAutos){
                Console.WriteLine($"Marca: {a._marca}");
                Console.WriteLine($"Modelo: {a._modelo}");
            }
            Console.WriteLine($"================");
        } 

    }
    class Autos
    {
        public string _marca {get;set;}
        public string _modelo {get;set;}

        ArrayList lista = new ArrayList();
        public Autos(string marca, string modelo){
            this._marca = marca;
            this._modelo = modelo;
        }       
    }
}
