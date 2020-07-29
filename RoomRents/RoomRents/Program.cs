using System;

namespace RoomRents
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] rent = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("\nRent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                rent[room] = new Student(name, email);
            }

            Console.WriteLine("\nOccupied Rooms:");
            for (int i = 0; i < rent.Length; i++)
            {
                if(rent[i] != null)
                {
                    Console.WriteLine(i + ": " + rent[i]);
                }
            }
        }
    }
}
