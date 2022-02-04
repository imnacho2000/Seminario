// Implementar la clase Matriz que se utilizará para trabajar con matrices matemáticas.
// Implementar los dos constructores y todos los métodos que se detallan a continuación:
// public Matriz(int filas, int columnas)
// public Matriz(double[,] matriz)
// public void SetElemento(int fila, int columna, double elemento)
// public double GetElemento(int fila, int columna)
// public void Imprimir()
// public void Imprimir(string formatString)

// public double[] GetFila(int fila)
// public double[] GetColumna(int columna)
// public double[] GetDiagonalPrincipal()
// public double[] GetDiagonalSecundaria()
// public double[][] GetArregloDeArreglo()
// public void Sumarle(Matriz m)
// public void Restarle(Matriz m)
// public void MultiplicarPor(Matriz m)

using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz A = new Matriz(2, 3);
            for (int i = 0; i < 6; i++) A.SetElemento(i / 3, i % 3, (i + 1) / 3.0);
            Console.WriteLine("Impresión de la matriz A");
            A.Imprimir("0.000");
            double[,] aux = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matriz B = new Matriz(aux);
            Console.WriteLine("\nImpresión de la matriz B");
            B.Imprimir();
            Console.WriteLine("\nAcceso al elemento B[1,2]={0}", B.GetElemento(1, 2));
            Console.Write("\nfila 1 de A: ");
            foreach (double d in A.GetFila(1)) Console.Write("{0:0.0} ", d);
            Console.Write("\n\nColumna 0 de B: ");
            foreach (double d in B.GetColumna(0)) Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal principal de B: ");
            foreach (double d in B.GetDiagonalPrincipal()) Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal secundaria de B: ");
            foreach (double d in B.GetDiagonalSecundaria()) Console.Write("{0} ", d);
            A.MultiplicarPor(B);
            Console.WriteLine("\n\nA multiplicado por B");
            A.Imprimir();
            Console.ReadKey();
        }
 
        class Matriz{
           
            private double [,] matriz;
            public Matriz(int F,int C){
                this.matriz= new double[F,C];
            }

            public Matriz(double[,] matriz){
                this.matriz = matriz;
            }

            public double getTFila(){
                return this.matriz.GetLength(0);
            }

            public double retornarAmbos(int F,int C){
                return this.matriz[F,C];
            }

            public double getTColumna(){
                return this.matriz.GetLength(1);
            }

            public void SetElemento(int F,int C, double elemento){
                this.matriz[F,C] = elemento; 
            }

            public double GetElemento(int fila, int columna){
                 return this.matriz[fila,columna];
             }

            public void Imprimir (){
                for(int i = 0; i < this.matriz.GetLength(0); i++){
                    for(int j = 0; j < this.matriz.GetLength(1); j++){
                        Console.Write($"{this.matriz[i, j]}\t");
                     }
                    Console.WriteLine();
                 }
            }

            public void Imprimir(string formatString){
                for(int i = 0; i < this.matriz.GetLength(0); i++){
                    for(int j = 0; j < this.matriz.GetLength(1); j++){
                       formatString = $"{this.matriz[i, j]}\t";
                       Console.Write(formatString);
                     }
                     Console.WriteLine();
                 }
            }

            public double[] GetFila(int fila){
                double[] vector = new double[this.matriz.GetLength(0) + 1];
                double numero;
                for(int j = 0; j <= this.matriz.GetLength(0); j++){
                    numero = this.matriz[fila,j];
                    vector[j] = numero;
                }
                return vector;
            }

            public double[] GetColumna(int columna){
                double[] vector = new double[this.matriz.GetLength(1)];
                double numero;
                for(int j = 0; j < this.matriz.GetLength(1); j++){
                    numero = this.matriz[j,columna];
                    vector[j] = numero;
                }
                return vector;
            }

            public double[] GetDiagonalPrincipal(){
                double[] diag = new double[this.matriz.GetLength(0)];
                double numero;
                for (int i = 0; i < this.matriz.GetLength(0); i++){
                      numero = matriz[i,i];
                    diag[i] = numero;
                 }
                return diag;
            }

            public double[] GetDiagonalSecundaria(){
                double[] diag = new double[matriz.GetLength(0)];
                double numero;
                int posicion = matriz.GetLength(0) - 1;
                for (int i = 0; i < matriz.GetLength(0); i++){
                    numero = matriz[i,posicion--];
                    diag[i] = numero;
                }
                return diag;
            }


            public double[][] GetArregloDeArreglo(double[,] matriz){
                double fila = this.matriz.GetLength(0);
                double columna = this.matriz.GetLength(1);
                double [][] vectorDeVector = new double[this.matriz.GetLength(0)][];      
                for (int i = 0; i < this.matriz.GetLength(0); i++){
                    vectorDeVector[i] = new double[(int)columna];
                    for(int j = 0; j < this.matriz.GetLength(1); j++){
                        double numero = this.matriz[i,j];
                        vectorDeVector[i][j] = numero;
                    }
                }
                return vectorDeVector;
            }

            public void Sumarle(Matriz m){
               if((this.matriz.GetLength(0) == m.getTFila()) && (this.matriz.GetLength(1) == m.getTColumna())){
                    for (int i = 0; i < this.matriz.GetLength(0); i++){
                        for (int j = 0; j < this.matriz.GetLength(1); j++){
                            this.matriz[i,j] = this.matriz[i,j] + m.retornarAmbos(i,j);
                        }
                    }
                }
                else{
                    Console.WriteLine($"No se pudo realizar la opreacion");
                }
            }

        public void MultiplicarPor(Matriz m) {
             double [,] C = new double[this.matriz.GetLength(0),(int)m.getTColumna()]; 
             if (this.matriz.GetLength(1) == m.getTFila()){
                for (int i = 0; i < this.matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < m.getTColumna(); j++)
                    {  
                        C[i,j] = 0;
                        for (int z = 0; z < this.matriz.GetLength(1); z++)
                        {
                             C[i,j] += this.matriz[i, z] * m.retornarAmbos(z,j);
                        }
                    }
                }
                this.matriz = C;
             }
             else
             {
                Console.WriteLine("Matrices no cuadraticas");
             }
        }

            public void Restarle(Matriz m){
                if((this.matriz.GetLength(0) == m.getTFila()) &&(this.matriz.GetLength(1) == m.getTColumna())){
                    for (int i = 0; i < this.matriz.GetLength(0); i++){
                        for (int j = 0; j < this.matriz.GetLength(1); j++){
                             this.matriz[i,j] = this.matriz[i,j] - m.retornarAmbos(i,j);
                        }
                    }
                }
                else{
                    Console.WriteLine("La matriz no es cuadratica");
                }
            }
        }
    }
}