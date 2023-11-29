using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikation
{
    internal class Account
    {
        private static int NextAccountId = 1;
        public int AccountId { get; private set; }
        public float Balance { get; private set; }
        private List<Transaction> Transactions;

        public Account()
        {
            AccountId = NextAccountId++;
            Balance = 0;
            Transactions = new List<Transaction>();
        }
    }
}
