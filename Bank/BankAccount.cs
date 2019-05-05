using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public class BankAccount
    {
        //private readonly string _option;
        public double Balance;
        public List<Transaction> Transactions = new List<Transaction>();


        //public BankAccount(string option) => _option = option;


        public string DepositFunds(double funds)
        {
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = "Deposit",
                Amount = funds,
                BalanceAfterTransaction = Balance += funds
            };

            Transactions.Add(transaction);

            return $"Deposit of {funds} made at {DateTime.Now} has been added to your account and will appear " +
                $"on your statement. \n Your balance is now {Balance}";
        }


        public string WithdrawFunds(double withdrawalAmount)
        {
            if (withdrawalAmount > Balance)
            {
                return "Withdrawal blocked! You don't have enough money soz.";
            }

            Transactions.Add(new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = "Withdrawal",
                Amount = withdrawalAmount,
                BalanceAfterTransaction = Balance -= withdrawalAmount
            }
            );

            return $"Withdrawal of {withdrawalAmount} made at {DateTime.Now} has been deducted from your account " +
               $"and will appear on your statement. \n Your balance is now {Balance}";
        }

    }
}
