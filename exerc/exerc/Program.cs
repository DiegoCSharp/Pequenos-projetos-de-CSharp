using System;
using System.Globalization;

namespace Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            if (idade > idade1)
            {
                Console.WriteLine($"Nome: {nome},  Idade: {idade}");
            }
            else 
            {
                Console.WriteLine($"Nome: {nome1},  Idade: {idade1}");
            } 
        }
    }
}
