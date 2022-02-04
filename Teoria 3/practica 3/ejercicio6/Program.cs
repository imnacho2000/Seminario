// Implementar los siguientes métodos estáticos que devuelvan la suma, resta y multiplicación de
// matrices pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del
// mismo tamaño, en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad
// de columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una
// excepción ArgumentException con un mensaje explicativo.



using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[,]{
                {1,2,3,4},{5,7,8,9},{10,11,12,13}
            };
            double[,] B = new double[,]{
                {1,2,3,4},{5,7,8,9},{10,11,12,13}
            };

            double[,]C = Suma(A,B);
            double[,]D = Resta(A,B);
            
            Console.WriteLine("Matriz de suma: ");
            imprimirMatriz(C);
            
            Console.WriteLine("Matriz de resta: ");
            imprimirMatriz(D);
            
            try{
                imprimir(A,B);
                double[,]E = Multiplicación(A,B);
                Console.WriteLine("Matriz de multiplicación: ");
                imprimirMatriz(E);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static double [,] Suma(double[,] A , double [,] B){
            double filas = A.GetLength(0);
            double columnas = A.GetLength(1);   
            if((filas == B.GetLength(0)) && (columnas == B.GetLength(1))){
                double [,] vector3 = new double[(int)filas,(int)columnas];
                for (int i = 0; i < A.GetLength(0); i++){
                    for (int j = 0; j < A.GetLength(1); j++){
                        vector3[i,j] = A[i,j] + B [i,j];
                    }
                }
            return vector3;
            }
            else{
                return null;
            }
        }
        
        static double [,] Resta(double[,] A , double [,] B){
            double filas = A.GetLength(0);
            double columnas = A.GetLength(1);   
            if((filas == B.GetLength(0)) && (columnas == B.GetLength(1))){
                double [,] vector3 = new double[(int)filas,(int)columnas];
                for (int i = 0; i < A.GetLength(0); i++){
                    for (int j = 0; j < A.GetLength(1); j++){
                        vector3[i,j] = A[i,j] - B [i,j];
                    }
                }
            return vector3;
            }
            else{
                return null;
            }
        }

         static double [,] Multiplicación(double[,] A , double [,] B){
            double filas = A.GetLength(0);
            double columnas = A.GetLength(1);   
            double [,] vector3 = new double[(int)filas,(int)columnas];
            for (int i = 0; i < A.GetLength(0); i++){
                 for (int j = 0; j < A.GetLength(1); j++){
                        vector3[i,j] = A[i,j] * B [i,j];
                 }
             }
            return vector3;
        }

        static void imprimir (double[,] A , double[,] B){
            if((A.GetLength(0) != B.GetLength(0) && (A.GetLength(1) != B.GetLength(1)))){
                throw new Exception($"Las matrices no son del mismo tamanio");
            }
        }

        static void imprimirMatriz(double[,] tabla){
            for(int i = 0; i < tabla.GetLength(0); i++){
                for(int j = 0; j < tabla.GetLength(1); j++){
                    Console.WriteLine($"Matriz en la fila {i} en la columna {j} tiene = {tabla[i, j]}");
                }
            }
        }
    
    }
}
