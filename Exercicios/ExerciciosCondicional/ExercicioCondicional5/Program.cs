using System;
using System.Globalization;


namespace Exercicio6
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Escolha um numero");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0.0 && num <= 25.00 )
            {
                Console.WriteLine("Interalo (0,25]");
            }
            else if (num >= 25.0 && num <= 50.00)
            {
                Console.WriteLine("Interalo (25,50]");
            }
            else if (num >= 50.00 && num <= 75.00)
            {
                Console.WriteLine("Interalo (50,75]");
            }
            else if (num >= 75.00 && num <= 100.00)
            {
                Console.WriteLine("Interalo 75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}