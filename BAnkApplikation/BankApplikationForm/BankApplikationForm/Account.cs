using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankApplikationForm
{
    internal class Account
    {

        public float Balance { get; private set; }
        private List<Transaction> Transactions;

        public Account()
        {
            Balance = 0;
            Transactions = new List<Transaction>();
        }
    }
}
