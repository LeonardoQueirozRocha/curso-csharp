using System;

namespace ValidacaoNumerosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
