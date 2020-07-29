using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaDeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int employeesQuantity = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < employeesQuantity; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee searchId = list.Find(x => x.Id == id);

                if (searchId == null)
                {
                    list.Add(new Employee(id, name, salary));
                }
                else
                {
                    Console.WriteLine("This ID " + id + " already exist!");
                }
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee selectEmployee = list.Find(x => x.Id == employeeId);

            if (selectEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                selectEmployee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
