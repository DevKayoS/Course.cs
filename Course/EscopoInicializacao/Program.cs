using System;

namespace EscopoInicializacao
{
    class Program
    {
       static void Main()
        {
            double preco = double.Parse(Console.ReadLine());

            

            if(preco > 10)
            {
                double desconto = preco * 0.1;
                Console.WriteLine(desconto);
            }

        }
    }
}