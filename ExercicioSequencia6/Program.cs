using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double pi = 3.14159;
            
            string[] values = Console.ReadLine().Split(' ');

            a = float.Parse(values[0], CultureInfo.InvariantCulture);
            b = float.Parse(values[1], CultureInfo.InvariantCulture);
            c = float.Parse(values[2], CultureInfo.InvariantCulture);


            //fazendo os calculos
            double areaTriangulo = (a * c)/2;
            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaCircle = pi * (Math.Pow(c, 2));
            Console.WriteLine($"CIRCULO: {areaCircle.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaTrapezio = ((a + b) * c) / 2;
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaQuadrado = b * b;
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaRetangulo = a * b;
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}