using EqualsAndGetHeshCodeExample.Entities;
using System;
using System.Runtime.CompilerServices;

namespace EqualsAndGetHeshCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a==b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
