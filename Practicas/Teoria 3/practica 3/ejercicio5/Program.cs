// Implementar un método estático que devuelva un arreglo de arreglos con los mismos elementos
// que la matriz pasada como parámetro:


using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double [,] tabla = new double[,]{{1,2,3,4},{5,6,7,8}};
            
            double [][] vector = GetArregloDeArreglo(tabla);
            
            for (int i = 0; i < vector.Length; i++){
                for (int j = 0; j < vector[i].Length; j++){
                        Console.WriteLine("Vector en la fila {0} y columna {1}, tiene: {2} ", i, j ,vector[i][j].ToString());
                }
            }
         }
        static double[][] GetArregloDeArreglo(double[,] tabla){
            double fila = tabla.GetLength(0);
            double columna = tabla.GetLength(1);
            double [][] vectorDeVector = new double[tabla.GetLength(0)][];      
            for (int i = 0; i < tabla.GetLength(0); i++){
                vectorDeVector[i] = new double[(int)columna];
                for(int j = 0; j < tabla.GetLength(1); j++){
                    double numero = tabla[i,j];
                    vectorDeVector[i][j] = numero;
                }
            }
            return vectorDeVector;
        }
    }
}
