using System;
using System.Collections;
namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona n = new Persona("Martin",43057013,'M');
            Persona e = new Persona("Leandro",43111111,'M');
            Persona m = new Persona("Juan",42222222,'M');
            Persona t = new Persona("Lucas",43333333,'M');
            ListaDePersonas p = new ListaDePersonas();
            
            p.Agregar(n);
            p.Agregar(e);
            p.Agregar(m);
            p.Agregar(t);

            Persona dni = p[43333333];
            if(dni !=null){ 
                Console.WriteLine($"Dni: {dni.DNI}, Nombre: {dni.nombre}, Sexo: {dni.sexo}");
            }
            else{
                Console.WriteLine($"null, la persona con dni 422222224 no existe");
            }

            string[] arreglo = p['L'];

            string aux = "";
            foreach (string nombres in arreglo){
                aux +=nombres + ". ";    
            }

            Console.WriteLine($"Nombres: {aux}");

        }
    }
    class Persona{
        private int _dni;
        private string _nombre;
        private char _sexo;
        public Persona(string nombre,int dni,char sexo){
            _nombre = nombre;
            _dni = dni;
            _sexo = sexo;
        }

        public int DNI{
            get => _dni;
            set => _dni = value;
        }
        public string nombre{
            get => _nombre;
            set => _nombre = value;
        }
         public char sexo{
            get => _sexo;
            set => _sexo = value;
        }
    }
    class ListaDePersonas
    {
        private Hashtable ht = new Hashtable();
        public void Agregar(Persona p)
        {
            ht[p.DNI] = p;
        }
        public Persona this[int i]
        {
            get{
                return (this.ht.ContainsKey(i))? (Persona)ht[i] : null;
            }
        }
        public string[] this[char i]
        {
            get{
                ArrayList arreglo1 = new ArrayList();
                Persona valo;
                foreach(DictionaryEntry valor in ht){
                    valo = (Persona)valor.Value;
                    if(valo.nombre[0] == i){
                        arreglo1.Add(valo.nombre);
                    }
                }
                string[] stringArray = arreglo1.ToArray(typeof(string)) as string[];
                return stringArray;
            }
        }
    }
}
