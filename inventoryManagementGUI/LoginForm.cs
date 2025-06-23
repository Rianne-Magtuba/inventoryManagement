using BusinessLogic;
namespace inventoryManagementGUI
{
    public partial class LoginForm : Form
    {
        inventoryProcess inventoryProcess = new inventoryProcess();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameField.Text;
            string password = passField.Text;
            if (inventoryProcess.accountExist(userName, password))
            {
              
                MessageBox.Show("login Succesful!");
          
                mainForm mainForm = new mainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
