using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace COURSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = ("Entre com seu nome: "+ Console.ReadLine());
            Console.Write("Quantos quartos tem na sua casa?  ");
            int quarto = int.Parse(Console.ReadLine());
            Console.Write("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre seu ultimo nome, idade e altura (mesma linha):  ");

            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Fim !!! ");
        }
    }
}
