﻿namespace Exercicio3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira dois valores:");

            string[] valores = Console.ReadLine().Split(' ');
            
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }

        }
    }
}