// Codificar una clase llamada Ecuacion2 para representar una ecuación de 2o grado. Esta clase
// debe tener 3 campos privados, los coeficientes a, b y c de tipo double. La única forma de establecer
// los valores de estos campos será en el momento de la instanciación de un objeto Ecuacion2.
// Codificar los siguientes métodos:
// ● GetDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene
// la siguiente fórmula, b2-4ac

// ● GetCantidadDeRaices(): devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces reales
// que posee la ecuación. Si el discriminante es negativo no tiene raíces reales, si el
// discriminante es cero tiene una única raíz, si el discriminante es mayor que cero posee 2
// raíces reales.
// ● ImprimirRaices(): imprime la única o las 2 posibles raíces reales de la ecuación. En caso
// de no poseer soluciones reales debe imprimir una leyenda que así lo especifique.


using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecuacion2 a = new Ecuacion2(2,4,2);
            Console.WriteLine($"Discriminante obtenida: {a.GetDiscriminante()}");
            Console.WriteLine($"Raices obtenida: {a.ImprimirRaices()}");
        }
    }
    class Ecuacion2 {
        private double a,b,c;

        public Ecuacion2(double a,double b,double c){
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getA(){
            return this.a;
        }
        public double getB(){
            return this.b;
        }
        public double getC(){
            return this.c;
        }

        public void setA(double a){
            this.a = a;
        }
        public void setB(double b){
            this.b = b;
        }
        public void setC(double c){
            this.c = c;
        }

        public double GetDiscriminante(){
            return  Math.Pow(b,2) - 4 * (this.getA() * this.getC());
        }

        public double GetCantidadDeRaices(){
            if(GetDiscriminante() == 0){
                return 1;
            }
            else if(GetDiscriminante() < -0){
                return 0;
            }
            else{
                return 2;
            }
        }

        public string ImprimirRaices(){
            if(this.GetDiscriminante()  > 0){
                double x1 = ((-this.b + this.GetDiscriminante()) / (2 * getA()));
                double x2 = ((-this.b - this.GetDiscriminante()) / (2 * getA()));
                string aux = $"X1: {x1} X2: {x2}";
                return aux;
            }
            else if(this.GetDiscriminante() == 0){
                double x1 = ((-this.b + this.GetDiscriminante()) / (2 * getA()));
                string aux = $"X1: {x1}";
                return aux;
            }   
            else{
                return $"No existe raiz real";
            }
        }
    }
}
