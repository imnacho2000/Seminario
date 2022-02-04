// Implementar un método estático para imprimir por consola todos los elementos de una matriz
// (arreglo de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de
// una fila en la misma línea en la consola.


using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           double [,] tabla = new double[,]{{1,2,3,4},{5,6,7,8},{9,10,11,12}};
           imprimirMatriz(tabla);

        }

        static void imprimirMatriz(double[,] matriz){
            for(int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    Console.Write(" Matriz en la fila {0} en la columna {1} tiene : {2} \n",(i+1) , (j + 1), matriz[i,j].ToString());
                }
            }
        }
    }
}
