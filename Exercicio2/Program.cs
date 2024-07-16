using System;

namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escreva as coordenadas");
            string[] cordenates = Console.ReadLine().Split(" ");

            int coordX = int.Parse(cordenates[0]);
            int coordY = int.Parse(cordenates[1]);

            while (coordX != 0 || coordY != 0)
            {
                if (coordX > 0 && coordY > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (coordX < 0 && coordY > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (coordX < 0 && coordY < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (coordX > 0 && coordY < 0)
                {
                    Console.WriteLine("quarto");
                }


                cordenates = Console.ReadLine().Split(" ");
                coordX = int.Parse(cordenates[0]);
                coordY = int.Parse(cordenates[1]);

            }


        }


    }
}