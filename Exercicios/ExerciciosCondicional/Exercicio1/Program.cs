﻿using System;

namespace ExercicioCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int num = int.Parse(Console.ReadLine());


            if (num >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            } 
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}