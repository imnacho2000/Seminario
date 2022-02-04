// Qué líneas del siguiente código provocan conversiones boxing y unboxing.


using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'A';
            string st1 = "A";
            object o1 = c1; // unboxing
            object o2 = st1; // unboxing
            char c2 = (char)o1; // unboxing
            string st2 = (string)o2; // boxing
        }
    }
}
