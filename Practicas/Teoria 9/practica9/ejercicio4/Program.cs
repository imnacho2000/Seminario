using System;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaGenerica<int> lista = new ListaGenerica<int>();
            lista.AgregarAdelante(3);
            lista.AgregarAdelante(100);
            lista.AgregarAtras(10);
            lista.AgregarAtras(11);
            lista.AgregarAdelante(0);
            IEnumerator<int> enumerador = lista.GetEnumerator();
            while (enumerador.MoveNext())
            {
                int i = enumerador.Current;
                Console.Write(i + " ");
            }
        }
    }
    class Nodo<T>
    {
        public T Valor { get; private set; }
        public Nodo<T> Proximo { get; set; } = null;
        public Nodo(T valor) => Valor = valor;
    }

    class ListaGenerica<T> : IEnumerable<T> 
    {
        private Nodo<T> primerElemento = null;
        public void AgregarAdelante(T dato)
        {
            Nodo <T> nodoNuevo = new Nodo<T>(dato);
            if(primerElemento == null)
            {
                primerElemento = nodoNuevo;
            }
            else
            {
                nodoNuevo.Proximo = primerElemento;
                primerElemento=nodoNuevo;
            }
        }
        public void AgregarAtras(T dato)
        {
            Nodo <T> nodoNuevo = new Nodo<T>(dato);
            if(primerElemento == null)
            {
                primerElemento = nodoNuevo;
            }
            else
            {
                Nodo<T> aux = primerElemento;
                while(aux.Proximo !=null){
                    aux = aux.Proximo;
                }
                    aux.Proximo = nodoNuevo;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeradorLista<T>(primerElemento);
        }

        private IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator1();
        }
                
    }
    class EnumeradorLista<T> : IEnumerator<T>
    {
        Nodo<T> Inicio;
        Nodo<T> Actual; 

        bool PrimerNext = true; 
        public EnumeradorLista(Nodo<T> primero)
        {
            Inicio=primero;
            Actual=primero;
        }
        public bool MoveNext()
        {
            if(!PrimerNext)
            {
                Actual = Actual.Proximo;
            }
            else
            {
                PrimerNext=false;
            }
                       
            if(Actual != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            PrimerNext = true;
            Actual = null;
        }
        public T Current
        {
            get{
                return Actual.Valor;
            }
        }
        object IEnumerator.Current
        {
            get{
                    return Actual.Valor;
                }
        }

        void IDisposable.Dispose() { }
    }
}
