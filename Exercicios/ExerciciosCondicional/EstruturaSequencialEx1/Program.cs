using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando programa
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"SOMA: {soma}");

        }
    }
}