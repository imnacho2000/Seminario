// Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>,
// y determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
// Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
// devuelve el último carácter de st.

using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese dos palabras: ");
           String st = Console.ReadLine();
           bool ok = true;
           String [] arreglo = st.Split(" ");
           int j = arreglo[0].Length-1;
           
           if((arreglo.Length == 2) && (arreglo[0].Length == arreglo[1].Length)){
               for(int i = 0; i < arreglo.Length; i++){
                   if(arreglo[0][i] != arreglo[1][j]){
                       ok = false;
                       break;
                   }
                   j--;
               }
           }
           if(ok == true){ 
               Console.WriteLine("Son simetricas las palabras {0} y {1}", arreglo[0], arreglo[1]);
           }
           else{
                Console.WriteLine("No son simetricas las palabras {0} y {1}", arreglo[0], arreglo[1]);
           }
        }
    }
}
