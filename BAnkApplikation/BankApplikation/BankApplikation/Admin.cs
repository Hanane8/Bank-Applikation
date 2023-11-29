using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikation
{
    internal class Admin
    {
        public string Adminname { get; private set; }
        private string Password;
        private List<User> UserList;

        public Admin(string adminname, string password)
        {
            Adminname = adminname;
            Password = password;
            UserList = new List<User>();

        }

    }
}
