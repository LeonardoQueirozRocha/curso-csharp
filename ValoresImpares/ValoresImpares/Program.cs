using System;

namespace ValoresImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro X no intervalo de 1 à 1000: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor fora do intervalo!");
            }
        }
    }
}
