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
            Console.Write("Enter your Deposit Amount: ");
            double depositamount = double.Parse(Console.ReadLine());           

            //Pass the deposit amount to the Deposit method for the customer that will add it to their balance
            customer.Deposit(depositamount);
                      
            //Print out the new balance using the Get Balance method for the customer
            Console.WriteLine($"Your Current Balance is {customer.GetBalance(), 0:c}");
            Console.WriteLine();

            //Instantiate a new instance of the PersonalInformation Class
            PersonalInformation personalInformation = new PersonalInformation();
            //Ask the user to input their phone number
            Console.Write("Enter your phone number: ");
            personalInformation.NumberFormatted = Console.ReadLine();
            //Print out the formatted phone number
            Console.Write($"You entered the following phone number {personalInformation.NumberFormatted}");
            Console.WriteLine();
        }
    }
}
