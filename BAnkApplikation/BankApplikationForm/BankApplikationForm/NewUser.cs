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
            Person newPerson = new Person(Name, Password, Address, Email, Title);
            PersonList.Add(newPerson);

            using (StreamWriter writer = new StreamWriter(filePerson, true))
            {
                writer.WriteLine($"{newPerson.Name};{newPerson.Password};{newPerson.Address};{newPerson.Email};{newPerson.Title}");
            }

            MessageBox.Show("New user created!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }




        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }

}
