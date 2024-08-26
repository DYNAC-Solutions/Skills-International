using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class Login : Form
    {

        private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "Admin", "Skills@123" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void loginGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (users.ContainsKey(username) && users[username] == password)
            {
                // Hide login form and show the registration form
                this.Hide();
                Register registrationForm = new Register();
                registrationForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Show error message if login credentials are incorrect
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameInput.Clear();
            passwordInput.Clear();
            usernameInput.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
