using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gringotts Bank! Type the number of one of the following options to continue...");
            Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement");
        }
    }
}

//User can interact with the code using a REPL like IRB or with the JavaScript console.
//User can make deposits and withdrawals.
//User should not be able to withdraw more money than they have in their account.
//User can print their account statement which should show date, amount withdrawn/deposited and balance.
//The account statement should be printed in descending order (latest date first).
