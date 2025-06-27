using BusinessLogic;
using ReaLTaiizor.Controls;
namespace inventoryManagementGUI
{
    public partial class LoginForm : Form
    {
        inventoryProcess inventoryProcess = new inventoryProcess();
        public LoginForm()
        {
            InitializeComponent();
            passField.UseSystemPasswordChar = true;
        }


        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            string userName = userNameField.Text;
            string password = passField.Text;

            if (userName == " " || password == " ")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            if (inventoryProcess.accountExist(userName, password) == false)
            {
                MessageBox.Show(" Login failed Wrong username or passowrd");
                return;
            }

            MessageBox.Show("login Succesful!");
            //inventoryProcess.accountExist(userName, password);
            mainForm mainForm = new mainForm(userName);
            mainForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passField.UseSystemPasswordChar = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            userNameField.Text = "";
            passField.Text = "";
        }
    }
}
