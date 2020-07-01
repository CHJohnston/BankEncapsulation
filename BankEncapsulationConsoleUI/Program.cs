using System;

namespace BankEncapsulationConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new instance of the BankAccount class
            BankAccount customer = new BankAccount();

            //Accept the user input of the deposit amount 
            Console.Write("Enter the amount for your deposit :");
            double depositamount = double.Parse(Console.ReadLine());

            //Pass the deposit amount to the Deposit method for the customer that will add it to their balance
            customer.Deposit(depositamount);
                      
            //Print out the new balance using the Get Balance method for the customer
            Console.Write($"Your Current Balance is {customer.GetBalance()}");
        }
    }
}
