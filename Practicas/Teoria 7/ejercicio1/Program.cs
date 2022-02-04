using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        public static void Ejecutar()
        {
            Auto auto = new Auto();
            Libro libro = new Libro();
            Persona persona = new Persona();
            Perro perro = new Perro();
            Pelicula pelicula = new Pelicula();
            Procesador.Alquilar(pelicula, persona);
            Procesador.Alquilar(libro, persona);
            Procesador.Atender(persona);
            Procesador.Atender(perro);
            Procesador.Devolever(pelicula, persona);
            Procesador.Devolever(libro, persona);
            Procesador.Lavar(auto);
            Procesador.Reciclar(libro);
            Procesador.Reciclar(auto);
            Procesador.Secar(auto);
            Procesador.Vender(auto, persona);
            Procesador.Vender(perro, persona);
        }
    }
    public interface IAlquilable
    {   
        void SeAlquilaA(object p);
        void Devolver(object p);
    }

    public interface ISonVendibles{
        void SeVende(object P);
    }

    public interface ISonLavables{

        void Lavar();
        void Secar();
    }

    public interface ISonReciclables{
        void Reciclar();
    }

    public interface ISonAtendibles{
        void Atender();
    }
    class Auto: ISonVendibles, ISonLavables, ISonReciclables {
        public Auto(){
        }

        public void SeVende(object P){
            Console.WriteLine($"Vendiendo auto");
        }

        public void Lavar(){
            Console.WriteLine($"Lavando Auto");
        }

        public void Secar(){
            Console.WriteLine("Secando Auto");
        }

        public void Reciclar(){
            Console.WriteLine($"Reciclando Auto");
        }
    }

    class Libro: IAlquilable, ISonReciclables{
        public Libro(){
        }

        public void SeAlquilaA(object p){
            Console.WriteLine($"Alquilando Libro a {p.ToString()}");
        }

        public void Reciclar(){
            Console.WriteLine($"Reciclando Libro");
        }

        public void Devolver(object P){
            Console.WriteLine($"Libro devuelto por {P.ToString()}");
        }
    }
    class Persona: ISonAtendibles{
        public Persona(){   
        }

        public override string ToString(){
            return ($"Persona");
        }
        public void Atender(){
            Console.WriteLine($"Atendiendo a Persona");
        }
    }
    class Perro: ISonVendibles,ISonAtendibles{
        public Perro(){
        }
        public void SeVende(object P){
            Console.WriteLine($"Vendiendo Perro a {P.ToString()}");
        }
        public void Atender(){
            Console.WriteLine($"Atendiendo a Perro");
        }
    }
    class Pelicula: IAlquilable{
        public Pelicula(){
        }
        public void SeAlquilaA(object p){
            Console.WriteLine($"Alquilando pelicula a {p.ToString()}");
        }

        public void Devolver(object P){
            Console.WriteLine($"Pelicula devuelta por {P.ToString()}");
        }
    }
    static class Procesador
    {
        public static void Alquilar(IAlquilable x, Persona p) => x.SeAlquilaA(p);
        public static void Vender(ISonVendibles x, Persona p) => x.SeVende(p);
        public static void Atender(ISonAtendibles x) => x.Atender();
        public static void Devolver(ISonAtendibles x) => x.Atender();
        public static void Lavar(ISonLavables x) => x.Lavar();
        public static void Devolever(IAlquilable x,Persona p) => x.Devolver(p);
        public static void Reciclar(ISonReciclables x) => x.Reciclar();
        public static void Secar(ISonLavables x) => x.Secar();
    }
}
