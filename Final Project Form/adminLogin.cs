using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
	public partial class adminLogin : Form
	{
		public adminLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e) //login button click
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				AutoClosingMessageBox.Show("Attempting To Log In", "Logging In", 1000);
				SqlCommand command = new SqlCommand("select username,password from adminAccounts where username=@username and password=@password", connection); 
				command.Parameters.AddWithValue("@username", txtUser.Text);
				command.Parameters.AddWithValue("@password", txtPass.Text);
				SqlDataAdapter adapter = new SqlDataAdapter(command); //checks if there exists a username,password identical to whats in the textboxes
				DataTable table = new DataTable();
				adapter.Fill(table);
				if (table.Rows.Count > 0) //if there contains a row with that information, then the information is correct
				{
					AutoClosingMessageBox.Show("Login Successful", "Logging In", 1000);
					Admin_Page adminPage = new Admin_Page();
					this.Close();
					adminPage.Show();
					connection.Close();
				}
				else //there was no existing rows with the matching credentions, incorrect credentials
				{
					AutoClosingMessageBox.Show("Invalid Username Or Password", "Login Failed", 1000);
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnClear_Click(object sender, EventArgs e) //clears textboxes
		{
			txtUser.Text = "";
			txtPass.Text = "";
		}

		private void btnQuit_Click(object sender, EventArgs e) //closing form
		{
			this.Close();
		}

		private void adminLogin_Load(object sender, EventArgs e) //sets return button to be able to login on keypress
		{
			this.AcceptButton = btnLogin;
		}
	}
}
