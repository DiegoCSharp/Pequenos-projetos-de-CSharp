using System;
using System.Globalization;

namespace DadosPessoais
{
    class DadosPessoais
    {
        static void Main(string[] args)
        {

            Cadastro x, y;
            x = new Cadastro();
            y = new Cadastro();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            }
        }
    }
}
