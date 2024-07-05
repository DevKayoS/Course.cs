using System;
using System.Globalization;


namespace ExercicioEntraDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando programa
            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtyRooms = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto:");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //imprimindo os dados na tela
            Console.WriteLine(fullName);
            Console.WriteLine(qtyRooms);
            Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}