using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagementGUI
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            inventoryProcess inventoryProcess = new inventoryProcess();
            string userName = userNameField.Text.Trim();
            string password = passField.Text.Trim();
            string confirmPassword = conPassField.Text.Trim();

            if (userName == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (inventoryProcess.accountExist(userName, password))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            inventoryProcess.addAccount(userName, password);
            MessageBox.Show("Registration successful!");

            userNameField.Text = "";
            passField.Text = "";
            conPassField.Text = "";
           

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            userNameField.Text = "";
            passField.Text = "";
            conPassField.Text = "";
        }

       
    }
}
