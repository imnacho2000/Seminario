using System;

namespace ejercicio6
{
    delegate int FuncionEntera(int n);
    delegate bool Predicado(int n);
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 1, 2, 3, 4, 5 };
            vector.Print("Valores iniciales: ");
            vector.Where(n => n % 2 == 0).Print("Pares: ");
            vector.Where(n => n % 2 == 1).Select(n => n * n).Print("Impares al cuadrado: ");
        }
    }
    static class VectorDeEnterosExtension
    {
        public static void Print(this int[] vector, string leyenda)
        {
            string st = leyenda;
            if (vector.Length > 0) // en caso que la longitud del vector sea 0 no entra
            {
                foreach (int n in vector) st += n + ", "; // Recorro el vector con un foreach y por cada elemento en el vector, le concateno a la variable st el valor N + " , " 
                st = st.Substring(0, st.Length - 2); // Recorta la cadena del string desde el index 0 hasta la longitud del string - 2
            }
            Console.WriteLine(st); // Imprimo la cadena
        }
        public static int[] Select(this int[] v,FuncionEntera n)
        {
            for (int i = 0; i < v.Length; i++){
                v[i]=n(v[i]); // al vector le cargo en la posicion de [i] los valores que retorne "n" en la posicion de [i];
            }
            return v; // Retorno el vector
        }
        public static int[] Where(this int[] v,Predicado n){
            int[] result = new int[v.Length]; // Creo un vector donde le doy la longitud del vector recibido por parametro
            int cant = 0; // creo una variable contadora de elementos para darle longitud al nuevo vector que se esta por crear
            int pos = 0; // creo un indicie para el nuevo vector, lo hago para, mas que nada, para anadir elementos en el nuevo vector
            for (int i = 0; i < v.Length; i++){
                if(n(v[i])){ // si el resultado de N es true entonces anadio lo que haya en el vector en la posicion de [i] al nuevo vector y sumo la variable cant
                    result[i] = v[i];
                    cant++;
                }
            }

            int[] nuevo = new int[cant]; // creo un nuevo vector para eliminar los valores en 0 del vector anterior
            foreach(int numeros in result){
                if(numeros != 0){ // si el valor no es 0 entonces lo anadio y sumo pos
                    nuevo[pos]=numeros;
                    pos++;
                }
            }
            return nuevo; // retorno el nuevo vector
        }
    }
}
