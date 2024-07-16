using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis
            int codigo1, codigo2, qtyProduct1, qtyProduct2;
            double productPrice1, productPrice2, totalPrice;

            //lendo o valor das variaveis
            string[] firstProduct = Console.ReadLine().Split(' ');
            string[] secondProduct = Console.ReadLine().Split(' ');


            //declarando os valores da peça 1
            codigo1 = int.Parse(firstProduct[0]);
            qtyProduct1= int.Parse(firstProduct[1]);
            productPrice1 = double.Parse(firstProduct[2], CultureInfo.InvariantCulture);

            //declarando os valores da peça 2
            codigo2 = int.Parse(secondProduct[0]);
            qtyProduct2 = int.Parse(secondProduct[1]);
            productPrice2 = double.Parse(secondProduct[2], CultureInfo.InvariantCulture);

            totalPrice = (qtyProduct1 * productPrice1) + (qtyProduct2 * productPrice2);

            Console.WriteLine($"VALOR TOTAL A PAGAR: R$ {totalPrice:f2}");
        }
    }
}