using System;
using System.Globalization;

namespace ExercicioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] infoGerais = Console.ReadLine().Split(' ');

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(infoGerais[0]);
            Console.WriteLine(infoGerais[1]);
            Console.WriteLine(infoGerais[2]);
        }
    }
}
