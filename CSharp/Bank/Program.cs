using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            Console.WriteLine("Welcome to Gringotts Bank! Type the number of one of the following options to continue...");
            Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement. Type exit at " +
            	"any time to leave the bank.");

            var userOption = Console.ReadLine();

            while (userOption != "exit")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Enter the amount you want to deposit");
                        Console.WriteLine(bankAccount.DepositFunds(double.Parse(Console.ReadLine())));
                        Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement. Type exit at " +
                        "any time to leave the bank.");
                        userOption = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Enter the amount you want to withdraw");
                        Console.WriteLine(bankAccount.WithdrawFunds(double.Parse(Console.ReadLine())));
                        Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement. Type exit at " +
                        "any time to leave the bank.");
                        userOption = Console.ReadLine();
                        break;

                    case "3":
                        StatementGenerator.ShowBankStatement(StatementGenerator.GenerateBankStatement(bankAccount));
                        Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement. Type exit at " +
                        "any time to leave the bank.");
                        userOption = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Sorry but I don't recognise that option");
                        Console.WriteLine("1: Deposit \n 2: Withrawal \n 3: Print account statement. Type exit at " +
                        "any time to leave the bank.");
                        userOption = Console.ReadLine();
                        break;
                }

            }

            Console.WriteLine("Byebye!");
        }


    }
}



