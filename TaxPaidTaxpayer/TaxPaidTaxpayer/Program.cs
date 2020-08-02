using System;
using System.Globalization;
using System.Collections.Generic;
using TaxPaidTaxpayer.Entities;

namespace TaxPaidTaxpayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            System.Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");

                System.Console.Write("Individual or campany (i/c)? ");
                char op = char.Parse(Console.ReadLine());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'i')
                {
                    System.Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    System.Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            System.Console.WriteLine("\nTAXES PAID:");
            double sum = 0.0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                System.Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax());
                sum += taxPayer.Tax();
            }

            System.Console.WriteLine("\nTOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
