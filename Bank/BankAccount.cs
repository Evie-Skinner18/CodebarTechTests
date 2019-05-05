using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public class BankAccount
    {
        private readonly string _option;
        public int Balance;
        public List<string> Transactions;


        public BankAccount(string option) => _option = option;


        public string DepositFunds(int funds)
        {
            //Transactions.Add
            return (Balance += funds).ToString();
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
