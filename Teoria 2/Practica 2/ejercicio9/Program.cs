// Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
// circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
// un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
// StringBuilder y otro en el que no.


using System;
using System.Text;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st;
            st = new StringBuilder("Hola");
            string ht = "Hola";
            // for (int i = 0; i < 1000; i++){
            //     st.Append(" Juan");
            //     Console.WriteLine(st);
            // }
            //En este caso no se crea una copia de la variable sino que es la misma ya que el stringbuilder muta.
            for (int i = 0; i < 1000; i++){
                ht += " Juan";
                Console.WriteLine(ht);
            }
            // En cambio si utilizamos un string se crea una copia de la variable una y otra vez, afectando al rendimiento, ademas de que no puede mutar.

        }
    }
}
