using System;
using System.Threading;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutar(); // Llamo al metodo estatico Ejecutar
        }
        public static void Ejecutar()
        {
            Temporizador t = new Temporizador(); // Creo una variable de tipo Temporizador (que es una clase)
            t.Tic += (sender, e) => // Al evento Tic le mando sender y e, (Sender = Objeto y e = los argumentos)
            {
                Console.Write(DateTime.Now.ToString("HH:mm:ss") + " "); //imprimo el tiempo actual junto a la hora, minutos y segundos
                if (e.Tics == 5) //En caso que los tics sean = 5, habilitado se pone en falso, cortando dicho evento
            {
                t.Habilitado = false;
            }
            };
            t.Intervalo = 2000; // Setea el intervalo en 2000
            t.Habilitado = true; // Setea el habilitaod en true
            Console.WriteLine();
            t.Intervalo = 1000; // Seta el intervalo en 1000 
            t.Habilitado = true; // Setea el habilitaod en true
        }
    }
    class TicEventArgs : EventArgs {
        public int Tics {get; set;} //Creo el evento TicEventargs con una variable instancia de tipo entera Tics
    }

    delegate void TicEventHandler(object sender,TicEventArgs e); // creo un TicEventHandler ya que no utilizo datos para pasar como parametros
    class Temporizador {
        private int _intervalo; // Creo la clase temporizador con 3 variables de instancia, un intervalo de tipo INT, un habilitado de tipo BOOL y un tic de tipo de EventHandler
        private bool _habilitado;
        private TicEventHandler _tic;
        public event TicEventHandler Tic{
            add
            {
                _tic+=value; //Le asigno a _tic los valores recibidos
            }
            remove{
                _tic-=value; // Le "resto" a _tic los valores recibidos
            }
        }
        public int Intervalo{ // creo un get/set de intervalo donde retorno el intervalo y en caso de que el valor recibido sea mayor o igual a 100 se lo asigno
            get
            {
                return this._intervalo; 
            }
             set
            { 
                if(value>=100)
                {
                    this._intervalo=value;
                }
            }
        }
               
        public bool Habilitado
        {
            get   //Creo un get/set de habilitado donde lo retorno y un set donde si en caso de ser falso se lo asigno ya que empieza en true y sino si la variable de instancia, _tic, es null entonces a habilitado le asigno el valor y llamo al metodo reloj
            {
                return this._habilitado;
            }
            set 
            {
                if(value == false)
            {
                this._habilitado=value;
            }
            else
                if(this._tic != null)
                {
                    this._habilitado=value;
                    reloj();
                    }
                }
        }
        public void reloj() 
        {
            int tics = 1; // inicializo la variable tics en 1
            while(_habilitado){ // mientras este habilitado (true)
                Thread.Sleep(_intervalo); // utilizo el metodo Thread.sleep (Suspende el subproceso actual durante el período de tiempo especificado) para supsender el subproceso con el valor de _intervalo
                if(_tic != null) // si el tic no es null entonces instancio el tic, con el objeto que vengo trabajando y suscribiendolo al evento y instanciando los valores del args con los tics creados localmente
                {
                    _tic(this,new TicEventArgs(){Tics=tics});
                }
                tics++; // Sumo los tics para poder cortar segun lo indicado en el main
            }
        }
    }
}
