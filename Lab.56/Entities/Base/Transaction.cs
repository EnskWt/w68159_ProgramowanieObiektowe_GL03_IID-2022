using System;
using System.Collections.Generic;
using System.Text;
using Lab._56.Entities.Accounts;

namespace Lab._56.Entities.Base
{
    public abstract class Transaction
    {
        public Account Account { get; set; } = new Account();

        public int Amount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public abstract void Process();
    }
}
