using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationConsoleUI
{
    public class BankAccount
    {
        //Create a private field of type double named balance with a value of 0
        //A field is a local variable used within the class
        private double _balance = 0;

        //Define Method named Deposit that will accept a double and store the value in the balance field it returns no value
        public void Deposit(double amount) 
        {
            _balance += amount;            
        }

        //Define a Method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()
        {          
            return _balance;
        }
    }
}
