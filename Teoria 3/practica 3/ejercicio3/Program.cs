// Idem al anterior pero ahora con un parámetro más que representa la plantilla de formato que
// debe aplicarse a los números al imprimirse. La plantilla de formato es un string de acuerdo a las
// convenciones de formato compuesto, por ejemplo “0.0” implica escribir los valores reales con
// un dígito para la parte decimal. Observar que no hay inconveniente para implementar dos
// métodos con el mismo nombre siempre que NO lleven la misma cantidad de parámetros con los
// mismos tipos y en el mismo orden (sobrecarga de métodos).
using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           string formatoString = "";
           double [,] tabla = new double[,]{{1.3456,2.3456,3.3456,4.3456},{5,6,7,8},{9,10,11,12}};
           imprimirMatriz(tabla,formatoString);

        }

        static void imprimirMatriz(double[,] matriz, string formatoString){
            for(int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j <  matriz.GetLength(1); j++){
                    
                    formatoString = $"Matriz en la fila {i} en la columna {j} tiene = {matriz[i,j].ToString("0.00")}";
                    Console.WriteLine(formatoString);
                    
                    // Console.Write(" Matriz en la fila {0} en la columna {1} tiene : {2} \n",(i+1) , (j + 1), matriz[i,j].ToString());
                }
            }
        }
    }
}
