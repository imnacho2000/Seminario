using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] vector = new Persona[4];
            for (int i = 0; i < 4 ; i++){
                //pido datos
                Console.WriteLine($"Escriba su nombre");
                string st = Console.ReadLine();
                Console.WriteLine($"Escriba su dni");
                int dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Escriba su edad");
                int edad = Convert.ToInt32(Console.ReadLine());
                //creo la Persona con los respectivos datos ingresados.
                Persona p = new Persona(st,edad,dni);
                //las agrego en el vector
                vector[i] = p;
            }
            Console.WriteLine("Nro)\tNombre\tEdad\tDni");
            for(int i = 0; i < 4 ; i++){
                Console.WriteLine("{0}) \t {1}",(i + 1),vector[i].imprimir());
            }
        }
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

        public int GetDni(){
            return this.dni;
        }

        public string GetNombre(){
            return this.nombre;
        }

        public int GetEdad(){
            return this.edad;
        }

        public void SetDni(int dni){
            this.dni = dni;
        }

        public void SetNombre(string nombre){
            this.nombre = nombre;
        }

        public void SetEdad(int edad){
            this.edad = edad;
        }

        public string toString(){
            return (this.GetNombre() + "\t" + this.GetEdad() + "\t" + this.GetDni() + " ");
        }   

        public string imprimir(){
            return (this.GetNombre() + "\t" + this.GetEdad() + "\t" + this.GetDni() + " "); 
        }
}