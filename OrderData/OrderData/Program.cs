using System;
using System.Globalization;
using OrderData.Entities;
using OrderData.Entities.Enums;

namespace OrderData
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter cliente data:");

            System.Console.Write("Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(name, email, birthDate);

            System.Console.WriteLine("Enter order data:");

            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            System.Console.Write("How many items to this order? ");
            int itemsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsQuantity; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");

                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();

                System.Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.Write("Product quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }
            System.Console.WriteLine("\n" + order);
        }
    }
}
