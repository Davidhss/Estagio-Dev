using System;

namespace Metodo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça a criação de um método que receba o valor da venda, o valor da taxa e retorne o percentual da taxa cobrada.

            double venda, taxa, percentual;

            Console.Title = "Percentual da Taxa Cobrada";
        inicio:
            try
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Digite o valor da venda: ");
                venda = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor da taxa: ");
                taxa = Convert.ToDouble(Console.ReadLine());

                percentual = (100 - ((venda - taxa) / venda * 100));

                Console.WriteLine("O percentual da taxa cobrada é: {0}%", percentual);

                Console.WriteLine();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Valor inválido!");
                Console.WriteLine();
                goto inicio;
            }

            Console.WriteLine("Gostaria de recomeçar ? (sim ou nao)");
            string again = Console.ReadLine();

            switch (again)
            {
                case "sim":
                    Console.WriteLine();
                    goto inicio;
                case "nao":
                    Console.WriteLine("\nVolte sempre!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
