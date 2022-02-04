// Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
// a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
// noviembre, octubre ..., enero)
// c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
// nombre de un mes
// Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses


using System;

namespace ejercicio13
{
    enum Meses{
        Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Diciembre
    }
    class Program
    {
        static void Main(string[] args)
        {
        bool ok = false;
        for (Meses E = Meses.Diciembre; E >= Meses.Enero; E--) {
              Console.WriteLine("Mes: {0}",E);
          }
         Console.WriteLine("Ingrese un mes:");
         string d = Console.ReadLine();
         for(Meses E = Meses.Enero; E <= Meses.Diciembre; E++){
             if(d.Equals(E.ToString())){
                 ok = true;
                 break;
             }
             else{
                 ok = false;
             }
         }

        string informar = ok == true ? "se encuentra en la enumracion" : "no se encuentra en la enumeracion";
        Console.WriteLine("El mes {0} {1}", d, informar);
        }
    }
}
