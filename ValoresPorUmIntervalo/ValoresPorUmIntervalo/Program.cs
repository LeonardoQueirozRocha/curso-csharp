using System;

namespace ValoresPorUmIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int countIn = 0, countOut = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} in", countIn);
            Console.WriteLine("{0} out", countOut);
        }
    }
}
