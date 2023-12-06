using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    internal class C_Admin : Person
    {
        private List<C_User> UserList;

        public C_Admin(string username, string password, string address, string email, string title)
            : base(username, password, address, email, title)
        {
            UserList = new List<C_User>();
        }
    }


}
