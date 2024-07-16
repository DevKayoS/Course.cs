using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main()
        {
            //programa de if e else simples
            Console.WriteLine("Entre com um número inteiro");
            int userNum = int.Parse(Console.ReadLine());

            int restoParImpar = userNum % 2;

            string par, impar;
            par = "Par!";
            impar = "Impar!";

            if (restoParImpar == 0)
            {
                Console.WriteLine(par);
            }
            else
            {
                Console.WriteLine(impar);
            }

            //////programa de encadeamento
            Console.WriteLine("Qual a hora atual?");
            int hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if ( hour < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hour >= 18)
            {
                Console.WriteLine("Boa Noite!");
            }
            else
            {
                Console.WriteLine("Digite uma hora valida! lembre-se apenas numeros inteiros ex: 10,12,9,5,23,24");
            }
        }
    }
}