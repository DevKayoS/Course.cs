using System;

namespace Functions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = BiggestNumber(n1, n2, n3);

            Console.WriteLine($"O maior numero: {resultado}");
        }

        static int BiggestNumber(int n1, int n2, int n3)
        {
            int biggerNumber;

            if (n1 > n2 && n1 > n3)
            {
                biggerNumber = n1;
            }
            else if (n2 > n3)
            {
                biggerNumber = n2;

            }
            else 
            {
                biggerNumber = n3;
            }

            return biggerNumber;

        }
    }
}