using System;
namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
    public static void Ejecutar()
    {
        System.Collections.ArrayList lista = new System.Collections.ArrayList() {
            new Persona() {Nombre="Ana María"},
            new Perro() {Nombre="Sultán"},
            new Persona() {Nombre="Ana"},
            new Persona() {Nombre="José Carlos"},
            new Perro() {Nombre="Chopper"}
        };
        lista.Sort(new ComparadorLongitudNombre()); //ordena por longitud de Nombre
        foreach (INombrable n in lista)
        {
            Console.WriteLine($"{n.Nombre.Length}: {n.Nombre}");
        }
    }   
    }

    public interface INombrable{
        string Nombre {get;set;}
    }
    public interface IComercial{
        void Importa();
    }
    public interface IImportante{
        void Importa();
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

    class ComparadorLongitudNombre:System.Collections.IComparer
    {
        public int Compare(Object x, Object y)
        {
            INombrable e1 = x as INombrable;
            INombrable e2 = y as INombrable;
            return e1.Nombre.Length.CompareTo(e2.Nombre.Length);
        }
    }
    class Auto: ISonVendibles, ISonLavables, ISonReciclables,IImportante,IComercial {
        public Auto(){
        }

        public void SeVende(object P){
            Console.WriteLine($"Vendiendo auto a {P.ToString()}");
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

        void IComercial.Importa(){
            Console.WriteLine($"Auto que se vende al exterior");
        }
        void IImportante.Importa(){
            Console.WriteLine($"Auto importante");
        }

        public void Importa(){
            Console.WriteLine($"Metodo Importar() de la clase Auto");
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
    class Persona: ISonAtendibles, IImportante, IComercial, INombrable{
        public string Nombre {get;set;}
        public Persona(){   
        }

        public override string ToString(){
            return ($"{Nombre} es una Persona");
        }
        public void Atender(){
            Console.WriteLine($"Atendiendo a Persona");
        }

        void IImportante.Importa(){
            Console.WriteLine($"Persona importante");
        }

        void IComercial.Importa(){
            Console.WriteLine($"Persona vendiendo al exteorior");
        }

        public void Importa(){
            Console.WriteLine($"Metodo Importar() de la clase Persona");
        }
    }
    class Perro : ISonVendibles, ISonAtendibles, ISonLavables, INombrable{
        
        public string Nombre {get;set;}
        public Perro(){
        }
        public void SeVende(object P){
            Console.WriteLine($"Vendiendo Perro a {P.ToString()}");
        }
        public void Atender(){
            Console.WriteLine($"Atendiendo a Perro");
        }
        public void Lavar(){
            Console.WriteLine($"Lavando Perro");
        }

        public void Secar(){
            Console.WriteLine("Secando Perro");
        }

        public override string ToString(){
            return ($"{Nombre} es un Perro");
        }
    }
    class Pelicula: IAlquilable{
        public Pelicula(){
        }
        public virtual void SeAlquilaA(object p){
            Console.WriteLine($"Alquilando pelicula a {p.ToString()}");
        }

        public virtual void Devolver(object P){
            Console.WriteLine($"Pelicula devuelta por {P.ToString()}");
        }
    }

    class PeliculaClasica: Pelicula,ISonVendibles{
        
        public override void SeAlquilaA(object P){
            Console.WriteLine($"Alquilando pelicula Clasica a {P.ToString()}");
        }
        public override void Devolver(object P){
            Console.WriteLine($"Pelicula clasica devuelta por {P.ToString()}");
        }
        public void SeVende(object P){
            Console.WriteLine($"Vendiendo Pelicula clasica a {P.ToString()}");
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
