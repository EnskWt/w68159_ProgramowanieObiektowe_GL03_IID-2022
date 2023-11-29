using Lab._4.Entities.AbstractBase;
using Lab._4.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.Transactions
{
    public class IncomeTransaction : Transaction
    {
        public IncomeTransaction(int amount, Account account) : base(amount, account) { }

        public override void ProcessTransaction()
        {
            Account.Balance += Amount;

            Account.Transactions.Add(this);
        }
    }
}
