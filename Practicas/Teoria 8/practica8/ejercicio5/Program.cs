using System;

namespace ejercicio5
{
    delegate int FuncionEntera(int n);
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 1, 2, 3, 4, 5 };
            vector.Print("Valores iniciales: ");
            var vector2 = vector.Select(n => n * 3);
            vector2.Print("Valores triplicados: ");
            vector.Select(n => n * n).Print("Cuadrados: ");
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
            int[] nuevo = new int[v.Length]; //Creo nuevo vector y le aniado la longitud del vector, que me llega por parametro
            for (int i = 0; i < v.Length; i++){ // recorro hasta la longitud del vector, que me llega por parametro
                nuevo[i]=n(v[i]); // al nuevo vector le cargo en la posicion de [i] los valores que retorne "n" en la posicion de [i];

            }
            return nuevo; // retorno el nuevo vector
        }
    }
}
