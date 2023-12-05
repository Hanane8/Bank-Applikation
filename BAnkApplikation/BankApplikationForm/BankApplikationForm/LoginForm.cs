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
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser newAccount = new NewUser();
            newAccount.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}