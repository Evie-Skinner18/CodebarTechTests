using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;


namespace CodebarTestsTests
{
    [TestClass]
    public class CSharpBank
    {
        [TestMethod]
        public void CanDepositFunds_ShouldReturnTrue()
        {
            var bankAccount = new BankAccount();
            var message = bankAccount.DepositFunds(5.00);

            Assert.AreNotEqual(message, null);
            Assert.AreEqual(bankAccount.Balance, 5.00);
            Assert.AreEqual(message, $"Deposit of £{5.00} made at {DateTime.Now} has been added to your account and will appear " +
                                     $"on your statement. \n Your balance is now £{bankAccount.Balance}");
           
        }

        [TestMethod]
        public void CanAddDepositToTransactionList_ShouldReturnTrue()
        {
            var bankAccount = new BankAccount();
            bankAccount.DepositFunds(5.00);
            var transactionList = bankAccount.Transactions;
            var depositTransaction =
                transactionList.Where(t => t.TransactionType.Equals("Deposit")).FirstOrDefault();

            Assert.AreNotEqual(depositTransaction, null);
            Assert.AreEqual(depositTransaction.Amount, 5.00, bankAccount.Balance);
            Assert.AreEqual(depositTransaction.BalanceAfterTransaction, bankAccount.Balance);
        }

        [TestMethod]
        public void CanWithdrawFunds_ShouldReturnTrue()
        {
            var bankAccount = new BankAccount();
            bankAccount.DepositFunds(5.00);
            var message = bankAccount.WithdrawFunds(1.00);

            Assert.AreNotEqual(message, null);
            Assert.AreEqual(bankAccount.Balance, 4.00);
            Assert.AreEqual(message, $"Withdrawal of £{1.00} made at {DateTime.Now} has been deducted from your account " +
                                     $"and will appear on your statement. \n Your balance is now £{bankAccount.Balance}");
        }

        [TestMethod]
        public void CannotWithdrawMoreThanCurrentBalanceAmount_ShouldReturnTrue()
        {
            var bankAccount = new BankAccount();
            bankAccount.DepositFunds(5.00);
            var message = bankAccount.WithdrawFunds(6.00);
            
            Assert.AreNotEqual(message, null);
            Assert.AreEqual(message, "Withdrawal blocked! You don't have enough money soz.");
            Assert.AreEqual(bankAccount.Balance, 5.00);
        }

        [TestMethod]
        public void CanGenerateBankStatement_ShouldReturnTrue()
        {
            var bankAccount = new BankAccount();
            bankAccount.DepositFunds(5.00);
            bankAccount.DepositFunds(10.00);
            bankAccount.WithdrawFunds(6.00);

            // balance now should be 9.00
            var bankStatement = StatementGenerator.GenerateBankStatement(bankAccount);

            // first transaction should be most recent
            Assert.AreNotEqual(bankStatement, null);
            Assert.AreEqual(bankAccount.Balance, 9.00);
            Assert.AreEqual(bankStatement.First().TransactionType, "Withdrawal");
            Assert.IsTrue(bankStatement.FirstOrDefault().Amount.Equals(6.00));
            Assert.IsTrue(bankStatement.FirstOrDefault().TransactionId.Equals(2));
        }
    }
}
