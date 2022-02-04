// Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
// implementados en el ejercicio anterior.

using System;
using System.Text;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st;
            st = new StringBuilder("Hola");
            string ht = "Hola";
            for (int i = 0; i < 10; i++){
                st.Append(" Juan");
                Console.WriteLine(st);
            }
             // obtengo el tiempo real
            String finali = String.Format($"{(DateTime.Now.Millisecond)}\n");
            Console.WriteLine("Primer for finalizado en {0}", finali);
             for (int i = 0; i < 30; i++){
                ht += " Juan";
                Console.WriteLine(ht);
            }
            String finali2 = String.Format($"{(DateTime.Now.Millisecond)}\n");
            Console.WriteLine("Segundo for finalizado en {0}", finali2);
        }
    }
}
