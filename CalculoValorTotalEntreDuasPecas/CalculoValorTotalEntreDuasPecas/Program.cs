using System;
using System.Globalization;

namespace CalculoValorTotalEntreDuasPecas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] primeiraPeca = Console.ReadLine().Split(' ');
            string[] segundaPeca = Console.ReadLine().Split(' ');

            int numeroPrimeiraPeca = int.Parse(primeiraPeca[0]);
            int qtdPrimeiraPeca = int.Parse(primeiraPeca[1]);
            double valorPrimeiraPeca = double.Parse(primeiraPeca[2], CultureInfo.InvariantCulture);

            int numeroSegundaPeca = int.Parse(segundaPeca[0]);
            int qtdSegundaPeca = int.Parse(segundaPeca[1]);
            double valorSegundaPeca = double.Parse(segundaPeca[2], CultureInfo.InvariantCulture);

            double valorTotal = qtdPrimeiraPeca * valorPrimeiraPeca + qtdSegundaPeca * valorSegundaPeca;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
