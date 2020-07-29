using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorPago = ConversorDeMoeda.ValorPago(cotacaoDolar, quantidade);
            Console.WriteLine("Valor a ser pago em reais = " + valorPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
