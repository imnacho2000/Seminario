using System;

using System.Collections.Generic;

namespace ejercicio12

{

    class Program

    {

        static void Main(string[] args)

        {

            Queue<int> claveRepetitiva = new Queue<int>();

            string[] tabla = new string[]{"A","B","C", "D", "E", "F", "G", "H", "I", "J", "K", "L","M","N" ,"Ñ", "O", "P", "Q","R", "S", "T", "U", "V", "W", "X", "Y", "Z","sp"};
  
            claveRepetitiva.Enqueue(5);
            claveRepetitiva.Enqueue(3);
            claveRepetitiva.Enqueue(9);
            claveRepetitiva.Enqueue(7);

            Console.WriteLine("Ingrese un texto: ");

            string st = Console.ReadLine();
            string aux = "";
            int claveActual;

            foreach (char c in st){
                int index = buscarEnTabla(tabla, c);
                if(index != -1){
                    claveActual = claveRepetitiva.Dequeue();
                    int resultado = index;
                    for(int i = claveActual; i > 0; i--){
                        if(resultado < 27){
                            resultado++;
                        }else{
                             resultado = 0;
                        }

                    }
                    aux += tabla[resultado];
                    claveRepetitiva.Enqueue(claveActual);
                }else{
                    Console.WriteLine("Se ingreso un char que no existe en la tabla");
                }
            }
            Console.WriteLine($"Resultado: {aux}");

            Console.WriteLine("Ingrese un texto a descifrar: ");
            st = Console.ReadLine();
            claveRepetitiva.Clear();
            claveRepetitiva.Enqueue(5);
            claveRepetitiva.Enqueue(3);
            claveRepetitiva.Enqueue(9);
            claveRepetitiva.Enqueue(7);
            Console.WriteLine($"Texto descifrado: {descifrar(st,claveRepetitiva,tabla)}");
        }      

        static int buscarEnTabla(string[] tabla, char c){
            if(c == ' ') return 27;
            for(int i=0; i < tabla.Length-1; i++){
                if(tabla[i].Equals(c.ToString())){
                  return i;
                }
            }
            return -1;
        }   

        static string descifrar(string aux, Queue<int> claveRepetitiva,string [] tabla){
            string resultados="";
            int claveActual;
            foreach(char c in aux){
                int index = buscarEnTabla(tabla,c);
                if(index != -1){     
                    claveActual = claveRepetitiva.Dequeue();
                    int resultado = index;
                    for(int i= claveActual; i > 0; i--){
                        if(resultado > 0){
                            resultado--;    
                        }
                        else{
                            resultado = 27;
                        }   
                    }
                    if(resultado == 27){
                        resultados +=" ";
                    } 
                    else{
                        resultados += tabla[resultado];                                   
                    } 
                    claveRepetitiva.Enqueue(claveActual);
                }else{
                    Console.WriteLine("Se ingreso un char que no existe en la tabla");
                    return "ERROR se ingreso un char que no esta en la tabla.";
                }
            }
            return resultados;
        }
    }
}