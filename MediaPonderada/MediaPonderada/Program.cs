using System;
using System.Globalization;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (n1 * 2 + n2 * 3 + n3 * 5) / (2 + 3 + 5);

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
