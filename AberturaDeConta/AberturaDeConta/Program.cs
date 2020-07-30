using System;
using System.Globalization;

namespace AberturaDeConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            double quantia;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n): ");

            char op = char.Parse(Console.ReadLine());
           
            if (op == 's' || op == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numero, titular, quantia);
            }
            else if (op == 'n' || op == 'N')
            {
                contaBancaria = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta: " + contaBancaria);

            Console.Write("\nEntre um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: " + contaBancaria);

            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);
            
            Console.WriteLine("Dados da conta atualizados: " + contaBancaria);
        }
    }
}
