using System;

namespace Exercicio3
{
    class Program
    {
        static void Main()
        {
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;
            Console.WriteLine("Digite o codigo do produto e digite 4 qunado quiser finalizar a aplicação");
            int code = int.Parse(Console.ReadLine());

            while (code != 4)
            {
                if (code == 1)
                {
                    Alcool = Alcool + 1;
                }
                else if (code == 2)
                {
                    Gasolina = Gasolina + 1;
                }
                else if (code == 3)
                {
                    Diesel = Diesel + 1;
                }

                code = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {Alcool}");
            Console.WriteLine($"Gasolina: {Gasolina}");
            Console.WriteLine($"Diesel: {Diesel}");

        }
    }

}