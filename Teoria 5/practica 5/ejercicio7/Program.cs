
using System;
using System.Collections;
namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p[0] = "Ignacio"; 
            p[1] = 'M'; 
            p[2] = 43057013; 
            p[3] = new DateTime(2000,12,30); 
            string nombre = (string)p[0];
            char genero = (char)p[1];
            int dni = (int)p[2];
            DateTime nacimiento = (DateTime) p[3];
            int edad = (int)p[4];
            Console.WriteLine($"Nombre: {nombre} Edad: {edad} Sexo: {genero} DNI:{dni} Fecha de nacimiento: {nacimiento}");

        }
    }
    class Persona{
        private string _nombre {get;set;}
        private char _sexo {get;set;}
        private int _dni{get;set;}
        private DateTime _FechaNacimiento{get;set;} 
        public int Edad {
             get {
               DateTime _FechaActual = DateTime.Now;
               return (_FechaActual.Month < _FechaNacimiento.Month) ||  ((_FechaActual.Month == _FechaNacimiento.Month) && (_FechaActual.Day < _FechaNacimiento.Day)) ? (_FechaActual.Year - _FechaNacimiento.Year) - 1: _FechaActual.Year - _FechaNacimiento.Year; 
             }
        }

        public Persona(){
        }
        public Object this[int index]{
            get{
                if(index == 0) return _nombre;
                else if(index == 1) return _sexo;
                else if(index == 2) return _dni;
                else if(index == 3) return _FechaNacimiento;
                else if(index == 4) return Edad; 
                else return null;
            }
            set{
                if(index == 0) _nombre = (string)value;
                else if(index == 1) _sexo = (char)value;
                else if(index == 2) _dni = Convert.ToInt32(value);
                else if(index == 3) _FechaNacimiento = (DateTime) value;
            }
        }
    }
}
