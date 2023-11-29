using Lab._56.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Entities.Transactions
{
    public class ExpenseTransaction : Transaction
    {
        public override void Process()
        {
            Account.Balance -= Amount;

            Account.AddTransaction(this);
        }
    }
}
