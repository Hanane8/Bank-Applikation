using Microsoft.VisualBasic.ApplicationServices;

namespace BankApplikationForm
{
    public partial class loginForm : Form
    {
        List<Person> PersonList = new List<Person>();
        public string filePerson = "PersonList.csv";
        public loginForm()
        {
            InitializeComponent();
            if (!File.Exists(filePerson))
            {
                try
                {

                    using (StreamWriter sw = new StreamWriter(filePerson))
                    {
                        sw.WriteLine(" Name; Password; Address; Email; Title ");
                    }
                    MessageBox.Show("PersonList.csv created successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating UserList.csv: {ex.Message}");
                }
            }
            LoadUsersFromFile();
        }

        public void LoadUsersFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(filePerson);
                foreach (string line in lines.Skip(1))
                {
                    string[] data = line.Split(';'); 
                    if (data.Length >= 5) // Ensure the line contains at least the expected number of fields
                    {
                        string name = data[0].Trim();
                        string password = data[1].Trim();
                        string address = data[2].Trim();
                        string email = data[3].Trim();
                        string title = data[4].Trim();

                        Person user = new Person(name, password, address, email, title);
                        PersonList.Add(user);
                    }
                    else
                    {
                        
                        Console.WriteLine($"Skipping line due to incorrect format: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }







        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser newAccount = new NewUser(this);
            if (newAccount.ShowDialog() == DialogResult.OK)
            {
                PersonList.Clear();
                LoadUsersFromFile();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string selectedRole = comboBox1.Text.ToLower(); 

            foreach (Person user in PersonList)
            {
                if (user.Name == username && user.Password == password)
                {
                    if ((selectedRole == "admin" && user.Title.ToLower() != "admin") || (selectedRole == "user" && user.Title.ToLower() != "user"))
                    {
                        MessageBox.Show($"You are not a {selectedRole}. You are a {user.Title.ToLower()}.");
                        return;
                    }

                    if (user.Title.ToLower() == "admin")
                    {
                        MessageBox.Show("Admin login successful!");
                        Admin adminForm = new Admin(); 
                        adminForm.Show();
                        return;
                    }
                    else if (user.Title.ToLower() == "user")
                    {
                        MessageBox.Show("Regular user login successful!");
                        User userForm = new User(true);
                        userForm.Show();
                        return;
                    }
                    return; 
                }
            }

            MessageBox.Show("Invalid username or password. Please try again.");
        }

    }

}