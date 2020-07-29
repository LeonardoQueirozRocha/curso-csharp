using System;
using System.Globalization;

namespace ValidacaoIntervaloNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (number <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (number <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (number <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
