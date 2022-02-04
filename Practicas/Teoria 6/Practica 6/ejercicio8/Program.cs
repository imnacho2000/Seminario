// Crear un programa para gestionar empleados en una empresa. Los empleados deben tener las
// propiedades públicas de sólo lectura Nombre, DNI, FechaDeIngreso, SalarioBase y Salario. Los
// valores de estas propiedades (a excepción de Salario que es una propiedad calculada) deben
// establecerse por medio de un constructor adecuado.
// Existen dos tipos de empleados: Administrativo y Vendedor. No se podrán crear objetos de la
// clase padre Empleado, pero sí de sus clases hijas (Administrativo y Vendedor). Aparte de las
// propiedades de solo lectura mencionadas, el administrativo tiene otra propiedad pública de
// lectura/escritura llamada Premio y el vendedor tiene otra propiedad pública de lectura/escritura
// llamada Comision.
// La propiedad de solo lectura Salario, se calcula como el salario base más la comisión o el premio
// según corresponda.
// Las clases tendrán además un método público llamado AumentarSalario() que tendrá una
// implementación distinta en cada clase. En el caso del administrativo se incrementará el salario base
// en un 1% por cada año de antigüedad que posea en la empresa, en el caso del vendedor se
// incrementará el salario base en un 5% si su antigüedad es inferior a 10 años o en un 10% en caso
// contrario.
// El siguiente código (ejecutado el día 26/4/2020) debería mostrar en la consola el resultado indicado:


// Recomendaciones: Observar que el método AumentarSalario() y la propiedad de solo lectura
// Salario en la clase Empleado pueden declararse como abstractos. Intentar no utilizar campos sino
// propiedades auto-implementadas todas las veces que sea posible. Además sería deseable que la
// propiedad SalarioBase definida en Empleado sea pública para la lectura y protegida para la
// escritura, para que pueda establecerse desde las subclases Administrativo y Vendedor.

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[] {
                new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
                new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
                new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
            };
            foreach (Empleado e in empleados)
            {
                Console.WriteLine(e);
                e.AumentarSalario();
                Console.WriteLine(e);
            }
        }
    }
    
    abstract class Empleado{
        public string _nombre{get;}
        public int _dni{get;}
        public DateTime _FechaDeIngreso{get;}
        public double _salarioBase;

        public static double s_salarioB;
        public abstract double _salario{get;}
        public double SalarioBase{
            get => _salarioBase;
            protected set => _salarioBase = value;
        }
        
        public int calcularAntiguedad(){
            DateTime _FechaUtilizada =  new DateTime(2020,4,26);
            return (_FechaUtilizada.Month < _FechaDeIngreso.Month) ||  ((_FechaUtilizada.Month == _FechaDeIngreso.Month) && (_FechaUtilizada.Day < _FechaDeIngreso.Day)) ? (_FechaUtilizada.Year - _FechaDeIngreso.Year) - 1: _FechaUtilizada.Year - _FechaDeIngreso.Year; 
        }
        
        public Empleado(string nombre,int dni,DateTime fechaI,double salarioB)
        {
            this._nombre = nombre;
            this._dni = dni;
            this._FechaDeIngreso = fechaI;
            this._salarioBase = salarioB;
            s_salarioB = salarioB;
        }

        abstract public void AumentarSalario();
        
        public override string ToString(){
            return($" Nombre: {this._nombre}, DNI: {this._dni} Antiguedad: {this.calcularAntiguedad()}\nSalario Base: {this._salarioBase},");
        }
    }

    class Administrativo:Empleado{
        public double Premio{get;set;}
        public override double _salario{get;}
        public  double Salario{
            get{
               return this.SalarioBase + this.Premio;
            }
        }
        public Administrativo(string nombre,int dni,DateTime fechaI,double salarioB):base(nombre,dni,fechaI,salarioB){}
        public override void AumentarSalario(){
            for(int i=0;i < this.calcularAntiguedad(); i++){  
                this.SalarioBase = this.SalarioBase + ( s_salarioB * 0.01);
            }
        }

        public override string ToString(){
            return($"Administrativo" + base.ToString() + " Salario: " + Salario);
        }
    }

    class Vendedor:Empleado{
        public double Comision{get;set;}

        public override double _salario {get;}
        public double Salario{
            get{
               return this.SalarioBase + this.Comision;
            }
        }
        public Vendedor(string nombre,int dni,DateTime fechaI,double salarioB):base(nombre,dni,fechaI,salarioB){}
        public override void AumentarSalario(){
            this.SalarioBase = this.calcularAntiguedad() < 10 ? this.SalarioBase + (this.SalarioBase * 0.05): this.SalarioBase + (this.SalarioBase * 0.10);
        }
        public override string ToString(){
            return($"Vendedor" + base.ToString() + " Salario: " + Salario);
        }
    }
}
