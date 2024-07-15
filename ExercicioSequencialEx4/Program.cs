using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hours;
            double priceByHour, salary;
            
            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            priceByHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = priceByHour * hours;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary:f2}");


        }
    }
}