using System;
using System.Globalization;

namespace While {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreve um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Raiz quadrada do número {x} é: ");

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.Write("Escreve outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (x >= 0.0)
                {
                    Console.Write($"Raiz quadrada do número {x} é: ");
                }
                else
                {
                    Console.Write("Número negativo, encerra o looping ! ");
                }
            }
         }
    }
}
 


