using System;
using System.Collections;
namespace piedrapapelotijeras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable miTabla = new Hashtable();
            miTabla.Add(1,"Tijeras");
            miTabla.Add(2,"Papel");
            miTabla.Add(3,"Piedra");

            Console.WriteLine("Piedra, papel o tijeras!");
            string st = Console.ReadLine();
            st = Char.ToUpper(st[0]) + st.Remove(0,1);

            Random rnd = new Random();
            int index = rnd.Next(1,3);
            string seleccionado  = miTabla[index].ToString();
            
            if(st.Equals(seleccionado)){ 
                Console.WriteLine($"Empate! la computadora eligio {seleccionado} y usted {st}!");
                
            }
            else if(((seleccionado == "Tijeras") && (st.Equals("Papel"))) || ((seleccionado == "Papel") && (st.Equals("Tijeras"))) || ((seleccionado == "Piedra") && (st.Equals("Papel"))) || ((seleccionado == "Papel") && (st.Equals("Piedra"))) || ((seleccionado == "Piedra") && (st.Equals("Tijeras"))) || ((seleccionado == "Tijeras") && (st.Equals("Papel")))){
                Console.WriteLine($"La computadora gano, eligio {seleccionado} y usted {st}");
            }
            else{
                Console.WriteLine($"Usted gano la computadora eligio {seleccionado} y usted {st}");
            }
        }
    }
}
