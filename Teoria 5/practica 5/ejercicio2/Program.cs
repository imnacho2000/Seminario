using System;
using System.Collections;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Cuenta();
            new Cuenta();
            ArrayList cuentas = Cuenta.GetCuentas();
            // se recuperó la lista de cuentas creadas
            (cuentas[0] as Cuenta).Depositar(50);
            // se depositó 50 en la primera cuenta de la lista devuelta
            cuentas.RemoveAt(0);
            Console.WriteLine(cuentas.Count);
            // se borró un elemento de la lista devuelta
            // pero la clase Cuenta sigue manteniendo todos
            // los datos "La cuenta id: 1 tiene 50 de saldo"
            cuentas = Cuenta.GetCuentas();
            Console.WriteLine(cuentas.Count);
            // se recupera nuevamente la lista de cuentas
            (cuentas[0] as Cuenta).Extraer(30);
            //se extrae 25 de la cuenta id: 1 que tenía 50 de saldo
        }
    }
    class Cuenta{
        private  double _monto;
        private int _id;
        private static int s_id = 0;
        private static int s_depositos = 0;
        private static int s_extracciones = 0;
        private static int s_extraccionesD = 0;
        private static double s_depositado;
        private static double s_extraido;
        private static double s_monto;
        private static ArrayList s_cuentas = new ArrayList();
        
        public Cuenta(){
            s_id += 1;
            _id = s_id;
            Console.WriteLine($"Se creo la cuenta id={(_id)}");
            Cuenta.s_cuentas.Add(this); // me guardo las dos cuentas
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

        public static ArrayList GetCuentas(){
            return new ArrayList(Cuenta.s_cuentas);
        }
        public static void ImprimirDetalle(){
            Console.WriteLine($"CUENTAS CREADAS: {s_id} \nDEPOSITOS: \t {s_depositos} \t - Total depositado: {s_depositado} \nEXTRACCIONES: \t {s_extracciones} \t - Total extraido: {s_extraido}\n \t\t\t - Saldo: {s_monto}");
            Console.WriteLine($"*Se denegaron {s_extraccionesD} extracciones por falta de fondos"); 
        }
    }
}
