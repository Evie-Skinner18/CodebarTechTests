using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public static class StatementGenerator
    {

        public static List<Transaction> GenerateBankStatement(BankAccount account)
        {
            return account.Transactions.OrderByDescending(t => t.TransactionDate).ToList();
        }


        public static void ShowBankStatement(List<Transaction> transactions)
        {
            foreach (var t in transactions)
            {
                Console.WriteLine(
                    $"Transaction: {t.TransactionId} \n Date: {t.TransactionDate} \n " +
                    $"Type: {t.TransactionType} \n Amount: {t.Amount} \n " +
                    $"Balance after this transaction: {t.BalanceAfterTransaction}");
            }
        }
    }
}
