using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulationConsoleUI
{
    public class PersonalInformation
    {
        public PersonalInformation()
        {        
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        private string _phoneNumber ="";
        public string NumberFormatted
        {
            get
            {
                return _phoneNumber;
            }
            set 
            {
                _phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }

        //This is a Constructor for the Personal Information Class
        public PersonalInformation(string firstname, string lastname, string streetaddress, string address2, string city, string state, int zip)
        {
            FirstName = firstname;
            LastName = lastname;
            StreetAddress = streetaddress;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
