using System;
using System.Collections.Generic;

namespace ejercicio5
{
    class Program
    {
    static void Main(string[] args)
        {
    
            Nodo<int> n = new Nodo<int>(7);
            n.Insertar(3);
            n.Insertar(1);
            n.Insertar(5);
            n.Insertar(12);
            foreach (int elem in n.InOrder)
            {
            Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Altura: {n.Altura}");
            Console.WriteLine($"Cantidad: {n.CantNodos}");
            Console.WriteLine($"Mínimo: {n.ValorMinimo}");
            Console.WriteLine($"Máximo: {n.ValorMaximo}");
            Nodo<string> n2 = new Nodo<string>("hola");
            n2.Insertar("Mundo");
            n2.Insertar("XYZ");
            n2.Insertar("ABC");
            foreach (string elem in n2.InOrder)
            {
            Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Altura: {n2.Altura}");
            Console.WriteLine($"Cantidad: {n2.CantNodos}");
            Console.WriteLine($"Mínimo: {n2.ValorMinimo}");
            Console.WriteLine($"Máximo: {n2.ValorMaximo}");

            Console.ReadKey();

        }
    }
    

    class Nodo<T> where T: IComparable<T>
    {
        private T valor;
        private Nodo<T> hijoIzquierdo=null;
        private Nodo<T> hijoDerecho=null;

        public Nodo(T n){
            this.valor=n;
        }

        public Boolean Insertar (T n){
            if(n.CompareTo(valor)==0)
            {
                Console.WriteLine("El valor ingresado ya está dentro del arbol");
                return false;
            }
            if(n.CompareTo(valor) > 0){ //si n es mas grande que valor me devuelve un numero positivo
                if(hijoDerecho != null)
                {
                    return hijoDerecho.Insertar(n);
                }
                else
                {
                    hijoDerecho = new Nodo<T>(n);
                    return true;
                }
            }
            else
            {
                if(hijoIzquierdo != null)
                {
                    return hijoIzquierdo.Insertar(n);
                }
                else
                {
                    hijoIzquierdo = new Nodo<T>(n);
                    return true;
                }
            }
        }


        public List<T> InOrder{
                get{
                    List<T> l = new List<T>();
                    GetInOrder(ref l);
                    return l;
                }
        }

        private void GetInOrder (ref List<T> l)
        {
            if(hijoIzquierdo!= null)
            {
                hijoIzquierdo.GetInOrder(ref l);
            }

            l.Add(this.valor);
            if(hijoDerecho != null)
            {
                hijoDerecho.GetInOrder(ref l);
            }
        }

        public int Altura{
            get{
                int x=0;
                GetAltura(ref x,0);
                return x;
            }
        }
        private void GetAltura(ref int n,int k){
            if(n < k) {
                n=k;
            }
            if(hijoIzquierdo!=null)
            {
                hijoIzquierdo.GetAltura(ref n,k+1);
            }
            if(hijoDerecho!= null)
            {
                hijoDerecho.GetAltura(ref n,k+1);
            }
        }


        public int CantNodos
        {
           get{
                int x = 0;
                GetCantNodos(ref x);
                return x;
           } 
        }
        private void GetCantNodos(ref int n)
        {
            n++;
            if(hijoIzquierdo != null){
                hijoIzquierdo.GetCantNodos(ref n);
            }  
            if(hijoDerecho != null)
            {
                hijoDerecho.GetCantNodos(ref n);
            }
        }

        public T ValorMaximo
        {
           get{
                if(hijoDerecho!= null)
                {
                    return hijoDerecho.ValorMaximo;
                }
                else
                {
                    return valor;
                }
           } 
        }

        public T ValorMinimo 
        {
            get{
                if(hijoIzquierdo!= null)
                {
                    return hijoIzquierdo.ValorMinimo;
                }
                else
                {
                    return valor;
                }
            }
            
        }
    }
}
