using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            float n5 = 4.5f; 
            double n6 = 4.6;

            string separation = "----------------";

            string nome = "Kayo";

            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(separation);
            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);

            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);


            //Console.WriteLine(separation);

            int n8 = int.MinValue;
            int n9 = int.MaxValue;
            sbyte n10 = sbyte.MinValue;
            decimal n11 = decimal.MinValue;
            decimal n12 = decimal.MaxValue;


            //Console.WriteLine(n8);
            //Console.WriteLine(n9);
            //Console.WriteLine(n10);
            //Console.WriteLine(n11);
            //Console.WriteLine(n12);


            //Console.WriteLine(separation);
            int idade = 32;
            double saldo = 2272.546323123;
            string user = "Julia";


            //Console.WriteLine("{0} tem {1} anos e possui R${2}", user, idade, saldo.ToString("F2"));
            //Console.WriteLine("{0} tem {1} anos e possui R${2:F2}", user, idade, saldo);

            //Console.WriteLine($"{user} tem {idade} anos e possui o saldo de R${saldo:F2}");

            //Console.WriteLine(user + " tem " + idade + " anos e possui o saldo de R$" + saldo.ToString("F2"));




            // Console.Write("Bom dia");
            // Console.WriteLine("Boa Tarde");
            // Console.WriteLine("Boa noite");

            // Console.WriteLine(separation);

            // Console.WriteLine(generoPessoa);
            // Console.WriteLine(idade);
            // Console.WriteLine(saldo);
            // Console.WriteLine(user);

            // Console.WriteLine(saldo.ToString("F2"));
            // Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));



            //conversão implicita de tipos ex: passando de float para double
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            //fazendo o casting de double para float
            b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.2;
            //fazendo casting de double para int
            d = (int)c;
            Console.WriteLine(d);


            int e = 5;
            int f = 2;

            double resultado = (double) e / f;

            Console.WriteLine(resultado);


        }

    }
}
