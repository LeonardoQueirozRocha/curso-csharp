using System;
using System.Globalization;
using System.Collections.Generic;
using ProductTag.Entities;

namespace ProductTag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            System.Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberProducts; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");

                System.Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'i')
                {
                    System.Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (op == 'u')
                {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }
            System.Console.WriteLine();

            System.Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                System.Console.WriteLine(product.PriceTag());
            }
        }
    }
}
