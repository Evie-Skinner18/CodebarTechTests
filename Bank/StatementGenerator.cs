using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    public static class StatementGenerator
    {
      // _bankAccount
        public static List<Transaction> GenerateBankStatement(BankAccount account)
        {
            return account.Transactions;
        }

        public static void ShowBankStatement(List<Transaction>)
        {

        }
    }
}
