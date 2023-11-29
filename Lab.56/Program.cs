using Lab._56.Entities.Accounts;
using Lab._56.Entities.Transactions;
using System;

namespace Lab._56
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account()
            {
                Balance = 100
            };

            var incomeTransaction = new IncomeTransaction()
            {
                Account = account,
                Amount = 15
            };

            var expenseTransaction = new ExpenseTransaction()
            {
                Account = account,
                Amount = 50
            };

            incomeTransaction.Process();
            expenseTransaction.Process();

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.Transactions.Count);
        }
    }
}
