using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplikationForm
{
    internal class Person
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }

        public Person(string name, string password, string address, string email, string title)
        {
            Name = name;
            Password = password;
            Address = address;
            Email = email;
            Title = title;
        }
    }
}
