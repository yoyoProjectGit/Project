using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Attempting To Log In", "Logging In", 1000);
            String username = txtUser.Text;
            String password = txtPass.Text;
            if (username.Equals("") && password.Equals(""))
            {
                AutoClosingMessageBox.Show("Login Successful", "Logging In", 1000);
               // System.Threading.Thread.Sleep(1000);
                mainMenu mainMenu = new mainMenu();
                this.Hide();
                mainMenu.Show();
                
            }
            else
            {
                AutoClosingMessageBox.Show("Invalid Username Or Password", "Logging Failed", 1000);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
   
}
