// Codificar la clase Hora de tal forma que el siguiente código produzca la salida por consola que se
// observa.

using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hora h = new Hora(23, 30, 15);
            Console.Write(h.imprimir());
        }
    }
    class Hora{
        private int hora;
        private int minutos;
        private int segundos;
        public Hora(int H,int M,int S){
            this.hora = H;
            this.minutos = M;
            this.segundos = S;
        }

        public Hora(){
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

        public int getHora(){
            return this.hora;
        }
        public int getMinutos(){
            return this.minutos;
        }
        public int getSegundos(){
            return this.segundos;
        }

        public String imprimir(){
            return ($"{this.getHora()} Horas, {this.getMinutos()} minutos y {this.getSegundos()} segundos.");
        }

    }
}
