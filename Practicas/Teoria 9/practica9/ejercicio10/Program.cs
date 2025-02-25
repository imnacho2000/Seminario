﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);

            String strAux1,strAux2;
            Console.WriteLine("Ingrese nombre del archivo1");        
            strAux1=Console.ReadLine();
            Console.WriteLine("Ingrese nombre del archivo2");
            strAux2=Console.ReadLine();

                StreamReader sr1 = null;
                StreamReader sr2 = null;
                List<String> lista1;
                List<String> lista2;

                try
                {
                    sr1=new StreamReader(strAux1+".txt");
                    sr2=new StreamReader(strAux2+".txt");

                    lista1= StringsToListaOrdenada(sr1);//Devuelve una lista ordena de las palabras de cada texto
                    lista2= StringsToListaOrdenada(sr2);
                  
                    var listaFinal =lista1.Intersect(lista2);//Lleno la nueva lista con los valores sin repetir de ambas listas


                    List<String> listaStrings=new List<string>();//Almaceno los valores del ienumerable
                    
                    foreach(string aux in listaFinal)
                    {
                        listaStrings.Add(aux);
                        Console.Write($" {aux} -");
                    }
                  
                    Console.WriteLine();
                    
                    StreamReadersActuales.List_sr.Add(sr1);//Agrega a la lista de Streams el streamer
                    StreamReadersActuales.List_sr.Add(sr2);
                    
                    List<PalabraPosiciones> listaPalabraPosiciones = listaStrings.ConvertAll(
                        new Converter<string,PalabraPosiciones>(StringToPalabraPosiciones));//Hago la conversion y la almaceno en la lista

                    foreach(PalabraPosiciones aux in listaPalabraPosiciones)
                    {
                        Console.WriteLine($"Palabra: {aux.Palabra}");
                        int n=0;
                        foreach(List<int> listaDeListasAux in aux.Posiciones)
                        {
                            Console.Write($"   |Posiciones en Texto{++n}:--> ");
                            foreach(int i in listaDeListasAux)
                            {
                                Console.Write($" {i} ");
                            }
                            Console.WriteLine();
                        }
                    }
                   
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if(sr1==null)
                    {
                        sr1.Dispose();
                    }
                    if(sr2==null)
                    {
                        sr2.Dispose();
                    }
                }
        }   

        public static List<string> StringsToListaOrdenada(StreamReader sr)
        {
            List<string> lista = new List<string>();
            string strAux;
            string[] vectorStrings;
            //voy leyendo lineas del archivo y cada linea la divido en palabras y las agrego a una lista
             while((strAux=sr.ReadLine()) != null)
                    {
                        vectorStrings=strAux.Split(' ');
                        foreach(string aux in vectorStrings)
                        {
                            if(aux!= "")
                            {
                                lista.Add(aux);
                            }
                            
                        }
                       
                    }

                     lista.Sort(); //ordeno la lista alfabéticamente
            return lista;
        }

        
        
      
        
        public static PalabraPosiciones StringToPalabraPosiciones(string palabra)
        {
            List<StreamReader> listaReaders = StreamReadersActuales.List_sr;

            PalabraPosiciones palabraPosicionesAux = new PalabraPosiciones(palabra);

            foreach (StreamReader sr in listaReaders) //busco coincidencias en todos los archivos actuales
            {
                //reseteo el StreamReader actual
                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                 //lista para guardar las posiciones en las que aparece "palabra"
                List<int> posiciones = new List<int>();
        
                string strAux;
                int posicionAux=0;
                while((strAux = sr.ReadLine())!= null) //recorro el archivo y si encuentro la palabra agrego su posicion a la lista
                {
                    if(strAux.IndexOf(palabra) != -1) //si la palabra aparece
                    {
                        posiciones.Add(strAux.IndexOf(palabra)+posicionAux); //agrego su posicion a la lista
                    }
                    posicionAux= posicionAux + strAux.Length;
                }
                palabraPosicionesAux.Posiciones.Add(posiciones);
            }
            return palabraPosicionesAux;
        }
    }

    public class PalabraPosiciones
    {
        public string Palabra { private set; get; }
        public List<List<int>> Posiciones { private set; get; } = new List<List<int>>();

        public  PalabraPosiciones(string palabra)
        {
            this.Palabra = palabra;
        }
    }

    //en esta clase la uso para guardar Streams Readers para poder acceder desde el método StringToPalabraPosiciones
    public class StreamReadersActuales 
        {
            private static List<StreamReader> _List_sr=new List<StreamReader>();
            public static List<StreamReader> List_sr
            {
                get
                {
                    return _List_sr;
                }
            }

 
    }
}
