using Lab._4.Entities.AbstractBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._4.Entities.Accounts
{
    public class Account
    {
        public int Balance { get; set; } = 0;
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
