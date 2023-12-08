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
    internal class C_User : Person
    {
        private static int NextAccountNumber;
        private List<Account> Accounts;
        static C_User()
        {
            LoadNextAccountNumber();
        }
        public int AccountNumber { get; private set; }
        public C_User(string username, string password, string address, string email, string title)
            : base(username, password, address, email, title)
        {
            Accounts = new List<Account>();
            AccountNumber = NextAccountNumber++;
            
        }

        private static void LoadNextAccountNumber()
        {
            string filePath = "NextAccountNumber.txt";

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (int.TryParse(content, out int loadedNumber))
                {
                    NextAccountNumber = loadedNumber;
                    return;
                }
            }

            NextAccountNumber = 1;
        }

       
    }

}
