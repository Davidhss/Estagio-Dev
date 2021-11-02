using System;

namespace Media_Mediana_ModoConsole
{
    class Program
    {
        static double Media(double[] vet)
        {
            double soma = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }
            return soma / vet.Length;
        }

        static double Mediana(double[] vet)
        {
            double mediana;
            double x = vet.Length / 2;

            if (vet.Length % 2 == 1)
            {
                mediana = vet[(int)Math.Ceiling(x)];
            }
            else
            {
                mediana = (vet[(int)x - 1] + vet[(int)x]) / 2;
            }
            return mediana;
        }

        static void Main(string[] args)
        {
            int i, n;
            double media, mediana;

            Console.Write("Quantos números você colocará: ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (i = 0; i < n; i++)
            {
                Console.Write("Insira um número: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            media = Media(vet);
            mediana = Mediana(vet);

            Console.WriteLine();

            Console.WriteLine("Média: {0}", media);
            Console.WriteLine("Mediana: {0}", mediana);

            Console.ReadKey();
        }
    }
}
