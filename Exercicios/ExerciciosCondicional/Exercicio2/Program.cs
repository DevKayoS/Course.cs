using System;

namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Par!");
            } else
            {
                Console.WriteLine("Impar!");
            }

        }
    }

}