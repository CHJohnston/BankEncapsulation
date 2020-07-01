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
            //This uses the Parameterized Constructor Initialization syntax

            PersonalInformation personalInformation = new PersonalInformation("Firstname" ,"Lastname","123 Main St","","Hometown", "AL", 35215);            

            //Ask the user to input their phone number
            Console.Write("Enter your phone number: ");
            personalInformation.NumberFormatted = Console.ReadLine();

            Console.WriteLine($"Your Account Information: ");
            Console.WriteLine($"Name:    {personalInformation.FirstName}  {personalInformation.LastName}");
            Console.WriteLine($"Address: {personalInformation.StreetAddress}  {personalInformation.Address2}");
            Console.WriteLine($"         {personalInformation.City}, {personalInformation.State} {personalInformation.Zip}");
            //Print out the formatted phone number
            Console.WriteLine($"Phone:   {personalInformation.NumberFormatted}");        
            
        }
    }
}
