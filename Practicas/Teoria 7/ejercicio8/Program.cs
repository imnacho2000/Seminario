using System;
using System.Collections;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable rango = Rango(6, 30, 3);
            IEnumerable potencias = Potencias(2, 10);
            IEnumerable divisibles = DivisiblesPor(rango,6);
            foreach (int i in rango)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in potencias)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in divisibles)
            {
                Console.Write(i + " ");
            }
        }

        static IEnumerable Rango (int i,int j,int p){
            for (i = 6; i <= j;){
               yield return i;
               i+=3;
            }
        }
        static IEnumerable Potencias(int b,int k){
            for (int i = 1; i <= k; i++){
                yield return (int)Math.Pow(b,i);
            }
        }
        static IEnumerable DivisiblesPor(IEnumerable e,int i){
            foreach (int num in e){
                if(num%i == 0){
                    yield return num;
                }
            }
        }
    }
}
