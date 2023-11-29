using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikation
{
    internal class Transaction
    {
        public int SenderAccount { get; private set; }
        public string Receiver { get; private set; }
        public float Amount { get; private set; }
        public string TransactionDate { get; private set; }

        public Transaction(int senderAccount, string receiver, float amount, string transactionDate)
        {
            SenderAccount = senderAccount;
            Receiver = receiver;
            Amount = amount;
            TransactionDate = transactionDate;
        }
    }
}
