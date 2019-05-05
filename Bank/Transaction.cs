using System;
namespace Bank
{
    public class Transaction
    {
        public int TransactionId = new Random().Next(0, 1000);

        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; set; }

        public double BalanceAfterTransaction { get; set; }

    }
}
