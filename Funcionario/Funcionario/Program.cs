using Funcionario;
using System;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        static void Main(string[] args)
        {
            Colaborador C = new Colaborador();

            Console.WriteLine("Dados do Funcionário: ");

            Console.Write("Nome: ");
            C.Nome = (Console.ReadLine());

            Console.WriteLine();
            Console.Write("Salário bruto: ");
            C.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Imposto: ");
            C.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + C);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C.AumentarSalario(porcent);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + C);



        }
    }
}
