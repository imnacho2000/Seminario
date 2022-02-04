// Codificar el método Imprimir para que el siguiente código produzca la salida por consola que
// se observa. Considerar que el usuario del método imprimir podría querer más adelante
// imprimir otros datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros
// cada vez que invoque el método.
// Tip: usar params


using System;

namespace ejercicio19
{
    enum diaDeSemana {
        Lunes,Martes,Miercoles,Jueves,Viernes,Sabado,Domingo
    }
    class Program
    {
        static void Main(string[] args)
        {
           imprimir(1,"Casa",'A',3.4,diaDeSemana.Sabado);
           imprimir(1,2,"tres");
           imprimir();
           imprimir("---------");
        }
        static void imprimir(params object[] vector){
            foreach(object st in vector){
                Console.Write("{0} ",st);
            }
            Console.Write("\n");
        }

    }
}
