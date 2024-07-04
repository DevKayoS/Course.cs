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

            Console.WriteLine("------------------------------");
            // operadores aritméticos
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 9 % 3;

            double n5 = (double) 10 / 8;

            //entenda x sendo a, y sendo b e z sendo c
            double x = 1.0, y = -3.0, z = -4.0;

            double delta = (Math.Pow(y, 2.0)) - (4.0 * x * z);

            double x1 = (-y + Math.Sqrt(delta) ) / (2.0 * x);
            double x2 = (-y - Math.Sqrt(delta)) / (2.0 * x);


            Console.WriteLine(delta);

            Console.WriteLine(x1);
            Console.WriteLine(x2);


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n5);
        }
    }
}