// Codificar la clase Nodo de un árbol binario de búsqueda de valores enteros. Un árbol binario de
// búsqueda no tiene valores duplicados y el valor de un nodo cualquiera es mayor a todos los valores
// de su subárbol izquierdo y es menor a todos los valores de su subárbol derecho.
// Desarrollar los métodos métodos:
// 1. Insertar(valor): Inserta valor en el árbol descartándolo en caso que ya exista.
// 2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
// 3. GetAltura(): devuelve la altura del árbol.
// 4. GetCantNodos(): devuelve la cantidad de nodos que posee el árbol.
// 5. GetValorMáximo(): devuelve el valor máximo que contiene el árbol.
// 6. GetValorMínimo(): devuelve el valor mínimo que contiene el árbol.

using System;
using System.Collections;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo n = new Nodo(7);
            n.Insertar(8);
            n.Insertar(10);
            n.Insertar(3);
            n.Insertar(1);
            n.Insertar(5);
            n.Insertar(1);
            n.Insertar(14);
            foreach (int i in n.GetInOrder())
            {
            Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(n.GetAltura());
            Console.WriteLine(n.GetCantNodos());
            Console.WriteLine(n.GetValorMaximo());
            Console.WriteLine(n.GetValorMinimo());
        }

    class Nodo{
            
            public class Nodos{ 
                private Nodos hi;
                private Nodos hd;
                private int valor;
                public Nodos(int valor){
                    this.valor = valor;
                    this.hi = null;
                    this.hd = null;
                }

                public void setHijoIzq(Nodos hi){
                    this.hi = hi;
                }
                public void setHijoDer(Nodos hd){
                    this.hd = hd;
                }

                public Nodos getHijoIzq(){
                    return this.hi;
                }

                public Nodos getHijoDer(){
                    return this.hd;
                }

                public int getValor(){
                    return this.valor;
                }

            }

            public Nodos raiz;
            public Nodo(int valor){
                raiz = null;
                this.Insertar(valor);
            }
            public void Insertar(int valor){
                Nodos nuevo = new Nodos(valor);
                if(this.raiz == null){
                    this.raiz = nuevo;
                }   
                else{
                    this.raiz = this.insertarnodo(raiz, nuevo);
                }

            }
            public Nodos insertarnodo(Nodos actual, Nodos nuevo)
            {     
                if(nuevo.getValor().CompareTo(actual.getValor()) == 0){
                    // Console.WriteLine($"El valor {nuevo.valor} ya se encuentra en el arbol");
                    return actual;
                }
                else if(nuevo.getValor().CompareTo(actual.getValor()) < 0)
                {
                    if(actual.getHijoIzq() == null)
                    {
                        actual.setHijoIzq(nuevo);
                        return actual;
                    }    
                    else
                    {
                        actual.setHijoIzq(insertarnodo(actual.getHijoIzq(),nuevo));
                        return actual;
                    }
                }   
                else{
                    if(actual.getHijoDer() == null){
                        actual.setHijoDer(nuevo);
                        return actual;
                    }
                    else{
                        actual.setHijoDer(insertarnodo(actual.getHijoDer(),nuevo));
                        return actual;
                    }
                } 
            }
            public int contadorDeNodos(Nodos arbol,ref int cant){
                cant = 1;
                if(arbol == null){
                    return 0;
                }
                else 
                {         
                    cant += contadorDeNodos(arbol.getHijoIzq(), ref cant);
                    cant += contadorDeNodos(arbol.getHijoDer(), ref cant);
                }   
                return cant;
            }
            public int GetCantNodos(){
                int cant = 0;
                int total = contadorDeNodos(getRaiz(),ref cant);
                return total;
            }

            public ArrayList enOrden(ref ArrayList arreglo,Nodos arbol){
                if(arbol == null)
                    return arreglo;
                enOrden(ref arreglo,arbol.getHijoIzq());
                arreglo.Add(arbol.getValor());
                enOrden(ref arreglo,arbol.getHijoDer());
                return arreglo;
            }
            public ArrayList GetInOrder(){
                ArrayList valores = new ArrayList();
                valores = enOrden(ref valores,getRaiz());
                return valores;
            }

            public Nodos getRaiz(){
                return this.raiz;
            }

            public int retornarAltura(Nodos raiz){
                if (raiz == null) {
                    return -1;
                }

                int izquierda = retornarAltura(raiz.getHijoIzq());
                int derecha = retornarAltura(raiz.getHijoDer());

                if (izquierda > derecha) {
                    return izquierda + 1;
                } else {
                    return derecha + 1;
                }
            }

            public int GetAltura() {
                int total;
                total = retornarAltura(getRaiz());
                if (raiz == null) {
                    return -1;
                }
                return total;
            }

            public int GetValorMinimo(){
                Nodos buscando =  getRaiz();
                int menor = buscando.getHijoIzq().getValor();
                while(buscando.getHijoIzq() != null){
                    buscando = buscando.getHijoIzq();
                    menor = buscando.getValor();
                }
                return menor;
            }

            public int GetValorMaximo(){
                Nodos buscando = getRaiz();
                int mayor = buscando.getValor();
                while(buscando.getHijoDer() != null){
                    buscando = buscando.getHijoDer();
                    mayor = buscando.getValor();
                }
                return mayor;
            }
        }
    }
}
