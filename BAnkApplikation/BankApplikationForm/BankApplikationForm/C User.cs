using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankApplikationForm
{
    internal class C_User: Person
    {
        private List<Account> Accounts {  get; set; }
        private int userId {  get; set; }
        public C_User(string username, string password )
        : base(username, password,  null, null, null)
        {
            
        }
        public void GetAccountList()
        {
            foreach ( Account account in Accounts )
            {
                
            }
        }
      
    }
}
