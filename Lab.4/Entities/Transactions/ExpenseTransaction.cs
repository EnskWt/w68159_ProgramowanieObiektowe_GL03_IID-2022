using Lab._4.Entities.AbstractBase;
using System;
using Lab._4.Entities.Accounts;

namespace Lab._4.Entities.Transactions
{
    public class ExpenseTransaction : Transaction
    {
        public ExpenseTransaction(int amount, Account account) : base(amount, account) { }

        public override void ProcessTransaction()
        {
            if (Account.Balance - Amount < 0)
            {
                throw new ArgumentException();
            }

            Account.Balance -= Amount;

            Account.Transactions.Add(this);
        }
    }
}
