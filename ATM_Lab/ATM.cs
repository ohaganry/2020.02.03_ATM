using System;
using System.Collections.Generic;

namespace ATM_Lab
{
    public class ATM
    {
        public Account CurrentAccount {get; set;}
        private static List<Account> accounts = new List<Account>();

        private void list()
        {
            //Accounts = List<Account> accounts = new List<Account>();
            accounts.Add(new Account("Ryan", "password", 500.00));
            accounts.Add(new Account("Stephen", "MAGE", 1000000.00));
        }
        public void Register()
        {
            Console.WriteLine("Welcome to GC Bank Account Creation");
            string name = Methods.GetUserInput("Input your name:");
            string password = Methods.GetUserInput("Input a password:");
            Account a1 = new Account(name, password);
            accounts.Add(a1);
        }

        public void Login()
        {
            string name = Methods.GetUserInput("Input your login name:");
            string password = Methods.GetUserInput("Input your password");
            foreach(Account a in accounts)
            {
                if(name == a.Name && password == a.Password && CurrentAccount == null)
                {
                    CurrentAccount = a;
                }
                else if(name == a.Name && password == a.Password && CurrentAccount != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry! Another account is currently active");
                    Console.ResetColor();
                    CurrentAccount = null;
                    //return Login();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Sorry, this login info does not match our records");
                    Console.ResetColor();
                    //return Login();
                }
            }
        }

        public void LogOut()
        {
            CurrentAccount = null;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance = ${CurrentAccount.Balance}");
        }

        public void Withdraw(double amount)
        {
            if(amount <= CurrentAccount.Balance)
            {
                CurrentAccount.Balance = CurrentAccount.Balance - amount;
                Console.WriteLine($"New account balance = ${CurrentAccount.Balance}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Withdrawl amount exceeds current balance");
                Console.ResetColor();
            }
        }

        public void Deposit(double amount)
        {
            CurrentAccount.Balance += amount;
            Console.WriteLine($"New account balance = ${CurrentAccount.Balance}");
        }
    }
}