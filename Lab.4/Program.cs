using Lab._4.Entities.Accounts;
using Lab._4.Entities.Transactions;
using System;

namespace Lab._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account()
            {
                Balance = 100,
            };


            var transaction = new IncomeTransaction(15, account);
            transaction.ProcessTransaction();

            Console.WriteLine(account.Balance);
        }
    }
}
