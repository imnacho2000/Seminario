using System;
using System.Text;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
        
           string[] saludos = new string[] {"Buen dia", "Saludos", "Exitos en el dia de hoy"};
           
           string[] nombres = {"Juan","Domingo","Peron"};
           saludar(nombres,saludos);
           saludarV2(nombres,saludos);
        }
        static void saludar(string[] nombres, params string[] saludos){
            for (int i = 0; i < nombres.Length; i++){
                Random aletaorio = new Random();
                int index = aletaorio.Next(saludos.Length);
                Console.WriteLine("{0} {1}",nombres[i], saludos[index]); 
            }
        }



         static void saludarV2(string[] nombres, params string[] saludos){
            foreach(string st in nombres){
                Random aletaorio = new Random();
                int index = aletaorio.Next(saludos.Length);
                Console.WriteLine("{0} {1}",st, saludos[index]);
            }
            }
        }

        

}
