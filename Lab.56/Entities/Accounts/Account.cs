using Lab._56.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._56.Entities.Accounts
{
    public class Account
    {
        public int Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
