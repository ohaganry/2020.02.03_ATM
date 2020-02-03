using System;
using System.Collections.Generic;

namespace ATM_Lab
{
    public class Account
    {
        public string Name {get; set;}
        public string Password {get; set;}
        public double Balance {get; set;}

        //public string Password {private get; set;}
        public Account(){}

        public Account(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public Account(string name, string password, double balance)
        {
            Name = name;
            Password = password;
            Balance = balance;
        }
    }
}