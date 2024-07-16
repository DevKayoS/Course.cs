using System;

namespace Exercicio4
{
    class Program
    {
        static void Main()
        {
            
            string[] values = Console.ReadLine().Split(" ");

            int startGame = int.Parse(values[0]);
            int finalGame = int.Parse(values[1]);


            int durationGame;

            if(startGame < finalGame)
            {
                durationGame = startGame - finalGame;
            } else
            {
                durationGame = 24 - startGame + finalGame;
            }

            Console.WriteLine($"O JOGO DUROU {durationGame} HORA(S)");


        }
    }

}