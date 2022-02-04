using System;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string st,st1,st2,st3,st4;
            st = "";
            st1 = null;
            st2 = "Mundo";
            st3 = "Hola";
            st4 = null;
           
            st = st1 ?? st2 ?? st3;
            st4 ??= "Valor por defecto";
            Console.WriteLine(st); 
            Console.WriteLine(st4); 


        //     st = st1 ?? st2 ?? st3 : st2;
        //     if (st1 == null)
        //     {
        //         if (st2 == null)
        //         {
        //             st = st3;
        //         }
        //         else
        //         {
        //             st = st2;
        //         }
        //         }
        //         else
        //         {
        //             st = st1;
        //         }
        //         if (st4 == null)
        //         {
        //             st4 = "valor por defecto";
        //         }
        }
    }
}
