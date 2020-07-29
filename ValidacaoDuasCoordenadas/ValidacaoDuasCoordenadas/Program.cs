using System;

namespace ValidacaoDuasCoordenadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite os valores de X e Y: ");
            string[] coordenadas = Console.ReadLine().Split(' ');

            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                Console.Write("Digite novamente os valores de X e Y: ");
                coordenadas = Console.ReadLine().Split(' ');

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}
