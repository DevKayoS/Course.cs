using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            Console.WriteLine("Insira o valor do raio:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //fazendo o calculo da area
            area = 3.14159 * (Math.Pow(raio, 2.0));
            //imprimindo resultado
            Console.WriteLine($"A={area.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}