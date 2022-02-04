using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Imprimir();
            cuenta = new Cuenta(30222111);
            cuenta.Imprimir();
            cuenta = new Cuenta("José Perez");
            cuenta.Imprimir();
            cuenta = new Cuenta("Maria Diaz", 20287544);
            cuenta.Imprimir();
            cuenta.Depositar(200);
            cuenta.Imprimir();
            cuenta.Extraer(150);
            cuenta.Imprimir();
            cuenta.Extraer(1500);
        }
    }
    class Cuenta{
        private double _monto;
        private int _titularDNI;
        private string _titularNobre;

        public Cuenta(){
            this._monto = getMonto();
            this._titularDNI = getDni();
            this._titularNobre = getNombre();
        }

        public Cuenta(int dni):this(){
            this. _titularDNI = dni;
        }

        public Cuenta(string nombre):this(){
            this._titularNobre = nombre;
        }
        public Cuenta(double monto):this(){
            this._monto = monto;
        }
        public Cuenta(string nombre,int dni):this(){
            this._titularDNI = dni;
            this._titularNobre = nombre;
        }


        public double getMonto(){
            return this._monto;
        }
        public int getDni(){
            return this._titularDNI;
        }
        public string getNombre(){
            return this._titularNobre;
        }

        public void setDni(int dni){
            this._titularDNI = dni;
        }

        public void setMonto(double monto){
            this._monto = monto;
        }

        public void setNombre(string nombre){
            this._titularNobre = nombre;
        }

        public void Depositar(double montoADepositar){
            double monto = this.getMonto()  + montoADepositar;
            this.setMonto(monto);
        }

        public void Extraer(double montoAExtraer){
            if(this.getMonto() > montoAExtraer){
                this._monto -= montoAExtraer;
            }
            else{
                Console.WriteLine($"Operacion cancelada, monto insuficiente");  
            }
        }

        public void Imprimir(){
            if((this.getNombre() == null) && (this.getDni().ToString().Equals(""))){
                Console.WriteLine ($"Nombre: Sin especificar, Dni: Sin especificar, Monto: {this.getMonto()}");
            }
            else if((this.getNombre() == null) && (!this.getDni().ToString().Equals(""))){
                Console.WriteLine  ($"Nombre: Sin especificar, Dni: {this.getDni()}, Monto: {this.getMonto()}");
            }
            else{
                Console.WriteLine  ($"Nombre {this.getNombre()} Dni: {this.getDni() } Monto: {this.getMonto()}");
            }
        }
    }
}

