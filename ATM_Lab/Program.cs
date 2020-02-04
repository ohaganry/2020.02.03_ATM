using System;

namespace ATM_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            bool loggedIn = false;
            Console.WriteLine("Welcome to the GC ATM");
            while(!loggedIn)
            {
                int input = Methods.CheckRange(Methods.GetUserInput("1. Login\n2. Register"), 1, 2);
                switch(input)
                {
                    case 1:
                    atm.Login();
                    loggedIn = true;
                    break;

                    case 2:
                    atm.Register();
                    break;
                }
            }
            bool furtherAction = true;
            while(furtherAction)
            {
                int input1 = Methods.CheckRange(Methods.GetUserInput("\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Log Out"), 1, 4);
                switch(input1)
                {
                    case 1:
                    atm.CheckBalance();
                    break;

                    case 2:
                    double deposit = Methods.CheckRange(Methods.GetUserInput("How much would you like to deposit? (minimum $5)"), 5, 100000);
                    atm.Deposit(deposit);
                    break;

                    case 3:
                    double withdraw = Methods.CheckRange(Methods.GetUserInput("How much would you like to withdraw? (minimum $5 and max $10,000 per transaction)"), 5, 10000);
                    atm.Withdraw(withdraw);
                    break;

                    case 4:
                    atm.LogOut();
                    Environment.Exit(0);
                    break;
                }
                
            }
        }   
    }
}
