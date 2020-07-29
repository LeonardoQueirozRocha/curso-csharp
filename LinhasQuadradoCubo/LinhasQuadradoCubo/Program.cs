using System;

namespace LinhasQuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int valorQuadrado, valorCubo;

            for (int i = 1; i <= n; i++)
            {
                valorQuadrado = i * i;
                valorCubo = valorQuadrado * i;

                Console.WriteLine($"{i} {valorQuadrado} {valorCubo}");
            }
        }
    }
}
