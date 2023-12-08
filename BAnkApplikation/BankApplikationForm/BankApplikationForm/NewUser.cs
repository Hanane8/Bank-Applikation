using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikationForm
{
    public partial class NewUser : Form
    {
        List<Person> PersonList = new List<Person>();
        public string filePerson = "PersonList.csv";
        Person person;
        loginForm loginForm;

        public NewUser(loginForm loginform)
        {
            InitializeComponent();
            loginForm = loginform;
        }

        private void NewAccount_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = this.textBox1.Text;
            string Password = this.textBox2.Text;
            string Address = this.textBox3.Text;
            string Email = this.textBox4.Text;
            string Title = this.comboBox1.Text;

            bool isNewUser = Title.ToLower() == "user";

            if (!File.Exists(filePerson) || !File.ReadLines(filePerson).First().Contains("AccountNumber"))
            {
                using (StreamWriter writer = new StreamWriter(filePerson, true))
                {
                    writer.WriteLine("Name;Password;Address;Email;Title;AccountNumber");
                }
            }

            using (StreamWriter writer = new StreamWriter(filePerson, true))
            {
                string line = $"{Name};{Password};{Address};{Email};{Title}";

                if (isNewUser)
                {
                    C_User newUser = new C_User(Name, Password, Address, Email, Title);
                    PersonList.Add(newUser);
                    line += $";{newUser.AccountNumber}";
                    MessageBox.Show("New user created!");
                }
                else
                {
                    C_Admin newAdmin = new C_Admin(Name, Password, Address, Email, Title);
                    PersonList.Add(newAdmin);
                    MessageBox.Show("New admin created!");
                }

                writer.WriteLine(line);
            }

            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }
    }
}
