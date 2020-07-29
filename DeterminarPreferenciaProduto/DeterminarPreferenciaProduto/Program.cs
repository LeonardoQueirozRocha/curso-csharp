using System;

namespace DeterminarPreferenciaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");

            Console.Write("Digite a opção de compra: ");
            int op = int.Parse(Console.ReadLine());
            while (op != 4)
            {
                if (op == 1)
                {
                    alcool++;
                }
                else if (op == 2)
                {
                    gasolina++;
                }
                else if (op == 3)
                {
                    diesel++;
                }

                Console.Write("Digite a opção de compra: ");
                op = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
