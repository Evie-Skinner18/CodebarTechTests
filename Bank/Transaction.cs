using System;
namespace Bank
{
    public class Transaction
    {

        public string Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; set; }

        public string BalanceAfterTransaction { get; set; }


    }
}
