using System;
using System.IO;
using System.Collections.Generic;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("Ingrese nombre del archivo");
            String strAux;
            strAux=Console.ReadLine();

            StreamReader sw = null;

                try
                {
                    sw=new StreamReader(strAux);

                    SortedDictionary<string,int> Diccionario = new SortedDictionary<string,int>();

                    while((strAux=sw.ReadLine()) != null)
                    {
                        string[] vectorStrings=strAux.Split(' ');
                       
                            foreach(string aux in vectorStrings)
                            {
                                if(aux!=""){
                                    if(!Diccionario.ContainsKey(aux))
                                    {
                                        Diccionario.Add(aux,1);
                                    }
                                    else
                                    {
                                        Diccionario[aux]++;
                                    }
                                }
                                
                                
                            }  
                    }

                    foreach (KeyValuePair<string,int> aux in Diccionario)
                    {
                            Console.WriteLine($"{aux.Key} : {aux.Value}");
                    }

                    
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if(sw!=null)
                    {
                        sw.Dispose();
                    }
                }
        }  
    }
}
