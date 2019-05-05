using System;
namespace Bank
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; set; }

        public double BalanceAfterTransaction { get; set; }

    }
}
