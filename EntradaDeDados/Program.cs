using System;
using System.Globalization;

namespace EntradaDeDados
{
    class EntradaDeDados
    { 
        static void Main(string[] args)
        {
            //fazendo a leitura de dados pelo console
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] vet = Console.ReadLine().Split(' ');

            ////salvando numa variavel cada palavra
            //string a = vet[0];
            //string b = vet[1];
            //string c = vet[2];

            //Console.WriteLine(vet);

            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Console.WriteLine($"{a} {b} {c}");

            //fazendo a  leitura de numeros
            int num1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char genero = char.Parse(vet[1]);
            int idade  = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine("Voccê inseriu: " + num1);
            Console.WriteLine("Voccê inseriu: " + ch);
            Console.WriteLine("Voccê inseriu: " + num2);

            Console.WriteLine(name);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            Console.WriteLine($"{name} {genero} {idade} {altura:f2}");




        }

    }

}