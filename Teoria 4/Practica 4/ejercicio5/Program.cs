// Codificar la clase Hora de tal forma que el siguiente código produzca la salida por consola que se
// observa.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           new Hora(23,30,15).imprimir();
        }
    }
    class Hora{
        private int hora;
        private int minutos;
        private double segundos;
        public Hora(int H,int M,int S){
            this.hora = H;
            this.minutos = M;
            this.segundos = S;
        }

        public Hora(double hora){
            this.hora = (int)hora;
            //me quedo con la parte decimal
            double parteDecimal = hora - Math.Truncate(hora);
            // lo multiplico por 0,6
            double resultadoM = parteDecimal * 0.6;
            //lo multiplico por 100 para que me quede, por ejemplo 25,8
            resultadoM *= 100;
            //lo guardo en forma entera para perder la coma xd, osa 25
            this.minutos = (int)resultadoM;
            
            parteDecimal = hora - Math.Truncate(hora);
            resultadoM = parteDecimal  * 0.6;
            resultadoM *= 100; 
            resultadoM = resultadoM - Math.Truncate(resultadoM);
            resultadoM *= 100;
            resultadoM *= 0.6f;
            int seg = (int)resultadoM;
            if(seg >= 60){
                this.minutos += 1; 
                this.segundos = 0;
            }
            else{
                this.segundos = resultadoM;
            }
        }

        public void setHora(int H){
            this.hora = H;
        }
        public void setMinutos(int M){
            this.minutos = M;
        }

        public void setSegundos(int S){
            this.segundos = S;
        }

        public double getHora(){
            return this.hora;
        }
        public double getMinutos(){
            return this.minutos;
        }
        public double getSegundos(){
            return this.segundos;
        }

        public void imprimir(){
            Console.WriteLine($"{this.getHora()} Horas, {this.getMinutos()} minutos y {this.getSegundos():0.000} segundos.");
        }
    }
}
