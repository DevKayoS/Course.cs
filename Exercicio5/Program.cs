using System;

namespace Exercicio5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o codigo de 2 produtos");
            string[] values = Console.ReadLine().Split(" ");

            int productCode = int.Parse(values[0]);
            int qtyProduct = int.Parse(values[1]);

            double precoTotal = 0.0;

            if (productCode == 1)
            {
                precoTotal = 4.0 * qtyProduct;
            }
            else if (productCode == 2)
            {
                precoTotal = 4.50 * qtyProduct;
            }
            else if (productCode == 3)
            {
                precoTotal = 5.00 * qtyProduct;
            }
            else if (productCode == 4)
            {
                precoTotal = 2.0 * qtyProduct;
            }
            else if (productCode == 5)
            {
                precoTotal = 1.50 * qtyProduct;
            }

            Console.WriteLine($"TOTAL: R$ {precoTotal:f2}");
        }
    }
}