using System;
using System.Globalization;

namespace Aprovacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno01 = new Aluno();
            Aluno Aluno02 = new Aluno();


            Console.Write("Nome do Aluno: ");
            Aluno01.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Aluno01.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno01.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno01.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.Write("NOTA FINAL: " + Aluno01.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            if (Aluno01.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + Aluno01.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }


        }


    }
}
