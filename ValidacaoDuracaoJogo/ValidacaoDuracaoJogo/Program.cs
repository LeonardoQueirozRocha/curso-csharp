using System;

namespace ValidacaoDuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hours = Console.ReadLine().Split(' ');

            int startTime = int.Parse(hours[0]);
            int finalHour = int.Parse(hours[1]);
            int duration;

            if (finalHour <= startTime)
            {
                duration = finalHour - startTime + 24;
            }
            else
            {
                duration = finalHour - startTime;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORAS(S)");
        }
    }
}
