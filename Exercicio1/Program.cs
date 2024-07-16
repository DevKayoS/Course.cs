using System;

namespace Exercico1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira a senha:");
            string password = Console.ReadLine();

            while (password != "2002")
            {
                Console.WriteLine("Senha Invalida");
                password = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}