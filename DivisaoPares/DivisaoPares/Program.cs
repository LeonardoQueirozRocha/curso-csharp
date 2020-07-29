using System;
using System.Globalization;

namespace DivisaoPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');

                int n1 = int.Parse(pares[0]);
                int n2 = int.Parse(pares[1]);

                if (n2 != 0)
                {
                    float divisao = (float)n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão Impossível!");
                }
            }
        }
    }
}
