using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double [,] tabla = new double[,]{ {2,3,4,5},{6,7,8,9},{10,11,12,13}};
            try{
                imprimir(tabla);
                double[] vector = GetDiagonalPrincipal(tabla);
                for (int i = 0; i < vector.Length; i++){
                    Console.WriteLine($"Vector en la posicion de {i} tiene = {vector[i].ToString()}");
                }
                double[] vector2 = GetDiagonalSecundaria(tabla);
                for (int i = 0; i < vector2.Length; i++){
                    Console.WriteLine($"vector2 en la posicion de {i} tiene = {vector2[i].ToString()}");
                }
            }    
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }           
        }
        static double[] GetDiagonalPrincipal(double[,] matriz){
            double[] diag = new double[matriz.GetLength(0)];
            double numero;
            for (int i = 0; i < matriz.GetLength(0); i++){
                  numero = matriz[i,i];
                  diag[i] = numero;
            }
            return diag;
        }
        static double[] GetDiagonalSecundaria(double[,] matriz){
            
            double[] diag = new double[matriz.GetLength(0)];
            double numero;
            int posicion = matriz.GetLength(0) - 1;
            for (int i = 0; i < matriz.GetLength(0); i++){
                  numero = matriz[i,posicion--];
                  diag[i] = numero;
            }
            return diag;
        }

        static void imprimir (double[,] tabla){
            if(tabla.GetLength(0) != tabla.GetLength(1)){
                throw new Exception($"Las matrices no son cuadraticas");
            }
        }
    }
}
