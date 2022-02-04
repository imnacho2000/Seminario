using System;

namespace ejercicio11
{
    class Program
    {
        static void Main()
        {
            Articulo a = new Articulo();
            a.PrecioCambiado += precioCambiado; // Se suscribe al evento, a.PrecioCambiado se suscribe al evento precioCambiado de a 
            a.Codigo = 1;
            a.Precio = 10;
            a.Precio = 12;
            a.Precio = 12;
            a.Precio = 14;
        }

        public static void precioCambiado(object sender, PrecioCambiadoEventArgs e)
        {
            string texto = $"Artículo {e.Codigo} valía {e.PrecioAnterior}";
            texto += $" y ahora vale {e.PrecioNuevo}";
            Console.WriteLine(texto);
        }
    }
    delegate void PrecioCambiadoEventHandler(object sender,PrecioCambiadoEventArgs e); //Defino el precioCambiadoEventHandler, manejador del evento, Tipo especial de clase cuyos objetos
// almacenan referencias a uno o más métodos de manera de poder ejecutar en cadena esos métodos, Permiten pasar métodos como parámetros a otros métodos, Los delegados usados para invocar a los manejadores de eventos deben tener 2 argumentos: uno de tipo object que contendrá al objeto que genera el evento y otro de tipo EventArgs (o derivado) para pasar argumentos. Además su tipo de retorno debe ser void, El tipo deleĀado EventHandler se utiliza para el caso de un evento que no requiere pasar datos como parámetros cuando se invoque el deleĀado
    class PrecioCambiadoEventArgs : EventArgs{ //Defino la clase PrecioCambiadoEventArgs con 3 variables de instancia codigo, precio anterior y precio nuevo, esta clase contiene la info del evento, Es una clase vacía, no lleva datos,pero constituye la clase base de todas las que se utilizan para pasar arĀumentos
        public int Codigo {get;set;}
        public double PrecioAnterior {get;set;}
        public double PrecioNuevo {get;set;}
    }
    class Articulo{ //Defino la clase articulo con las propiedades de escritura, lectura codigo y precio y, ademas, el eventHandler _precioCambiado

        private PrecioCambiadoEventHandler _precioCambiado; 
        public int Codigo {get;set;}
        public double _precio=0;
        public double Precio{
            set
            {
                if((_precioCambiado != null) && (value != _precio)){ // soempre tengo que preveer que alguien se haya suscripto antes de lanzarlo, por eso hago el _precioCambiado != null 
                    _precioCambiado(this,new PrecioCambiadoEventArgs(){Codigo=this.Codigo,PrecioAnterior=this._precio,PrecioNuevo=value});
                    _precio = value;
                }  
            }
            get
            {
                return _precio;
            }
        }
        public event PrecioCambiadoEventHandler PrecioCambiado{ // evento, se encolan y desencolan los delegados, Un evento puede tener varios suscriptores. Un suscriptor puede manejar varios eventos de varios editores, Nunca se provocan eventos que no tienen suscriptores.Así como una propiedad controla el acceso a un campo de una clase u objeto, un evento lo hacecon respecto a campos de tipo delegados, permitiendo ejecutar código cada vez que se añade o elimina un método del campo delegado. A diferencia de los delegados, a los eventos sólo se le pueden aplicar dos operaciones: += y -=.
            add{
                this._precioCambiado += value; // CódiĀo que se ejecutará cuando desde aÿuera se haĀa un += En este bloque la variable implícita value contiene el deleĀado que se desea encolar
            }
            remove{
                this._precioCambiado -= value; // CódiĀo que se ejecutará cuando desde aÿuera se haĀa un -= En este bloque la variable implícita value contiene el deleĀado que se desea encolar
            }
        }
    }
}
