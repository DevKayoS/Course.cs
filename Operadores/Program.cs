using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores de atribuição, além desses podemos seguir a logica de *=, /=
            int a = 10;

            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3 ;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 10;
            c--;
            Console.WriteLine(c);

            int d = 10;
            int e = ++d;
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}