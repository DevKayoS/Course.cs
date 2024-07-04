using System;

namespace EntradaDeDados
{
    class EntradaDeDados
    { 
        static void Main(string[] args)
        {
            //fazendo a leitura de dados pelo console
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');

            //salvando numa variavel cada palavra
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(vet);

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine($"{a} {b} {c}");



        }

    }

}