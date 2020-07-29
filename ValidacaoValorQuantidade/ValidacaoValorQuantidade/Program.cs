using System;
using System.Globalization;

namespace ValidacaoValorQuantidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CODIGO   ESPECIFICAÇÃO       PREÇO");
            Console.WriteLine("1        Chachohrro Quente   R$4.00");
            Console.WriteLine("2        X-Salada            R$4.50");
            Console.WriteLine("3        X-Bacon             R$5.00");
            Console.WriteLine("4        Torrada simples     R$2.00");
            Console.WriteLine("5        Refrigenrante       R$1.50");
            Console.Write("Digite a opção e a quantidade: ");

            string[] dados = Console.ReadLine().Split(' ');
            int opcao = int.Parse(dados[0]);
            int quantidade = int.Parse(dados[1]);
            double preco = 0, total;

            if (opcao == 1)
            {
                preco = 4.00;
            }
            else if (opcao == 2)
            {
                preco = 4.50;
            }
            else if (opcao == 3)
            {
                preco = 5.00;
            }
            else if (opcao == 4)
            {
                preco = 2.00;
            }
            else if (opcao == 5)
            {
                preco = 1.50;
            }
           
            total = preco * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
