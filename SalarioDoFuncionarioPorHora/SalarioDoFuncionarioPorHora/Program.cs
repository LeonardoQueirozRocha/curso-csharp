using System;
using System.Globalization;

namespace SalarioDoFuncionarioPorHora
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double hourlyWage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = workedHours * hourlyWage;

            Console.WriteLine();
            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
