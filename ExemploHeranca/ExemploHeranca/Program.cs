using System;
using ExemploHeranca.Entities;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account acc = new Account(1001, "Alex", 0.0);
            // BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // // UPCASTING

            // Account acc1 = bacc;
            // Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            // Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // // DOWNCASTING

            // BusinessAccount acc4 = (BusinessAccount)acc2;
            // acc4.Loan(100.00);

            // //BusinessAccount acc5 = (BusinessAccount)acc3;
            // if (acc3 is BusinessAccount)
            // {
            //     //BusinessAccount acc5 = (BusinessAccount)acc3;
            //     BusinessAccount acc5 = acc3 as BusinessAccount;
            //     acc5.Loan(200.00);
            //     System.Console.WriteLine("Loan!");
            // }

            // if (acc3 is SavingsAccount)
            // {
            //     //SavingsAccount acc5 = (SavingsAccount)acc3;
            //     SavingsAccount acc5 = acc3 as SavingsAccount;
            //     acc5.UpdateBalance();
            //     System.Console.WriteLine("Update!");
            // }

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            
            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);
        }
    }
}
