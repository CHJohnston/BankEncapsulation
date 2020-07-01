using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationConsoleUI
{
    public class BankAccount
    {
        //Create a private field of type double named balance with a value of 0
        private double _balance = 0;

        //Define Method named Deposit that will accept a double and store the value in the balance field
        public double Deposit(double amount) 
        {
            _balance += amount;
            return _balance;
        }

        //Define a Method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()
        {          
            return _balance;
        }
    }
}
