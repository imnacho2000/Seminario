using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta();
            c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
            Cuenta c2 = new Cuenta();
            c2.Depositar(200).Depositar(800);
            new Cuenta().Depositar(20).Extraer(20);
            c2.Extraer(1000).Extraer(1);
            Console.WriteLine("\nDETALLE");
            Cuenta.ImprimirDetalle();
        }
    }
    class Cuenta{
        private  double _monto;
        private static int s_id = 0;
        private int _id;
        private static int s_depositos = 0;
        private static int s_extracciones = 0;
        private static int s_extraccionesD = 0;

        private static double s_depositado;
        private static double s_extraido;
        private static double s_monto;
        
        public Cuenta(){
            s_id += 1;
            _id = s_id;
            Console.WriteLine($"Se creo la cuenta id={(_id)}");
        }

        public double Monto{
            get => _monto;
            set => _monto = value;
        }

        public Cuenta Depositar(double monto){
            this.Monto += monto;
            s_monto += monto; 
            s_depositado += monto;
            s_depositos++;
            Console.WriteLine ($"Se deposito {monto} en la cuenta {_id} (Saldo = {this.Monto})");
            return this;
        }

        public Cuenta Extraer(double monto){
            if(this.Monto >= monto){
                this.Monto -= monto;
                s_monto -= monto;
                s_extraido += monto;
                s_extracciones++;
                Console.WriteLine($"Se extrajo {monto} de la cuenta {_id} (saldo = {this.Monto})");
                return this;
            }
            else{
                Console.WriteLine("Operacion denegada - Saldo insuficiente");
                s_extraccionesD++;
                return this;
            }
        }

        public static void ImprimirDetalle(){
            Console.WriteLine($"CUENTAS CREADAS: {s_id} \nDEPOSITOS: \t {s_depositos} \t - Total depositado: {s_depositado} \nEXTRACCIONES: \t {s_extracciones} \t - Total extraido: {s_extraido}\n \t\t\t - Saldo: {s_monto}");
            Console.WriteLine($"*Se denegaron {s_extraccionesD} extracciones por falta de fondos"); 
        }
    }
}
