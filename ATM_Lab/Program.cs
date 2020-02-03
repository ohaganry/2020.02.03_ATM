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
            int input1 = Methods.CheckRange(Methods.GetUserInput("\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Log Out"), 1, 4);
        }
    }
}
