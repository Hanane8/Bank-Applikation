namespace BankApplikationForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser newAccount = new NewUser();
            newAccount.Show();
        }
    }
}