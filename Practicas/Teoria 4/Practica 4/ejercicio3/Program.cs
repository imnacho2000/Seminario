// Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la
// persona que recibe el mensaje tiene más edad que la persona enviada como parámetro. Utilizarlo
// para realizar un programa que devuelva la persona más joven de la lista.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] vector = new Persona[4];
            Persona d;
            for (int i = 0; i < 4 ; i++){
                Console.WriteLine($"Escriba su nombre");
                string st = Console.ReadLine();
                Console.WriteLine($"Escriba su dni");
                int dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Escriba su edad");
                int edad = Convert.ToInt32(Console.ReadLine());
                
                d = new Persona(st,edad,dni); 
                vector[i] = d;
            }
            Console.WriteLine($"Nro) Nombre\tEdad\tDni");
            for(int j = 0; j < vector.Length; j++)
            {
                Console.WriteLine($"{j+1}) \t {vector[j].Imprimir()}");
            }

            Persona e = new Persona("Juan",20,43333987);
            Persona r = new Persona("Juan",21,43333987);
            Console.WriteLine($"Resultado: {r.EsMayorQue(e)}");

            Persona max = vector[0];
            for(int k = 1; k < vector.Length; k++)
            {   
                if(vector[k].EsMayorQue(max)){
                    max = vector[k];
                }      
            }
            Console.WriteLine($"Edad maxima {max.getEdad()}");
        }     
    }
    
    class Persona{
        private int dni;
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad, int dni){
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }
        public Persona(){
        }

        public int getDni(){
            return this.dni;
        }

         public int getEdad(){
            return this.edad;
        }

        public string getNombre(){
            return this.nombre;
        }

        public void setDni(int dni){
            this.dni = dni;
        }
        public void setNombre (string nombre){
            this.nombre = nombre;
        }

        public void setEdad(int edad){
            this.edad = edad;
        }

        public bool EsMayorQue(Persona persona){
            return persona.getEdad() < this.getEdad();
        }

        public string Imprimir(){
            return ($"{this.getNombre()} \t {this.getEdad()} \t {this.getDni()}");
        }
    }
}
