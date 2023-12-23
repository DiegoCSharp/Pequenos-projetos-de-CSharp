using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            Produto P = new Produto();
            

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            P.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            P.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do Produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de Produto a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            P.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto Atualizado: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de Produto a ser Removida: ");
            int remover = int.Parse(Console.ReadLine());
            P.RemoverProduto(remover);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto Atualizado: " + P);

        }
    }
}
