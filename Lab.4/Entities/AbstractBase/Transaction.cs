using Lab._4.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.AbstractBase
{
    public abstract class Transaction
    {
        public int Amount { get; set; }

        public Account Account { get; set; } = new Account();

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        public abstract void ProcessTransaction();

        public Transaction(int amount, Account account)
        {
            Amount = amount;
            Account = account;
        }
    }
}
