using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikation
{
    internal class User
    {
        public string Username { get; private set; }
        private string Password;
        private List<Account> Accounts;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Accounts = new List<Account>();
        }
    }
}
