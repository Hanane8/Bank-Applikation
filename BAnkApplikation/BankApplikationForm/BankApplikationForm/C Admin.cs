using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    internal class C_Admin:Person
    {
       
        private List<User> UserList;
        public C_Admin(string username, string password)
                : base(username, password,  null, null, null)
        {

        }


    }

}
