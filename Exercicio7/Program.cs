using System;
using System.Globalization;


namespace Exercicio7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira dois numeros com uma casa decimal");
            string[] values = Console.ReadLine().Split(" ");

            double numX = double.Parse(values[0], CultureInfo.InvariantCulture);
            double numY = double.Parse(values[1], CultureInfo.InvariantCulture);

            if(numX == 0.0 && numY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (numX == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (numY == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (numX > 0.0 && numY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (numX < 0.0 && numY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (numX < 0.0 && numY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (numX > 0.0 && numY < 0.0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}