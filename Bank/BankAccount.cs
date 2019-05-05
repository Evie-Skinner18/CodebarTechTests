using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public class BankAccount
    {
        private readonly string _option;
        public int Balance;
        public List<Transaction> Transactions;


        public BankAccount(string option) => _option = option;


        public string DepositFunds(int funds)
        {
            Transactions.Add(new Transaction()
            {
                TransactionDate = DateTime.Now,
                TransactionType = "Deposit",
                Amount = funds,
                BalanceAfterTransaction = Balance += funds
            }
            );

            return $"Deposit of {funds} made at {DateTime.Now} has been added to your account and will appear " +
            	"on your statement.";
        }

        public string WithdrawFunds(int withdrawalAmount)
        {
            return withdrawalAmount > Balance ? 
                "Withdrawal blocked! You don't have enough money soz." 
                    : 
                (Balance -= withdrawalAmount).ToString();
        }

    }
}
