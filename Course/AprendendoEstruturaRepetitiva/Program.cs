using System;
using System.Globalization;

namespace AprendendoRepeticao
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digitar um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            while (num >= 0.0)
            {
                double result = Math.Sqrt(num);
                Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo");
        }
    }
}