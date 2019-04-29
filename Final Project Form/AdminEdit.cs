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
	public partial class AdminEdit : Form
	{
		string username,password;
		string uid;
		public AdminEdit()
		{
			InitializeComponent();
		}

		private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e) //changing password characters to be visible
		{
			if (checkBoxShowPass.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e) //makes textboxes editable
		{
			txtUserName.ReadOnly = false;
			txtPassword.ReadOnly = false;
		}

		private void btnBackToLoan_Click(object sender, EventArgs e) //closes form
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e) //updates information in the database
		{
			if (txtPassword.Text == password && txtUserName.Text == username)
			{
				MessageBox.Show("You have not changed values!");
			}
			else
			{ 
				try
				{
					string connectionString = myGlobals.connString;
					SqlConnection connection = new SqlConnection(connectionString);
					connection.Open();
					string updateUser = "UPDATE adminAccounts SET username=@Username, password=@Password WHERE uid=@Uid";
					SqlCommand command = new SqlCommand(updateUser, connection);
					command.Parameters.AddWithValue("@Username", txtUserName.Text);
					command.Parameters.AddWithValue("@Password", txtPassword.Text);
					command.Parameters.AddWithValue("@uid", uid);
					command.ExecuteNonQuery();
					MessageBox.Show("The admin account has been successfully updated.");
					connection.Close();
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void AdminEdit_Load(object sender, EventArgs e) //fills information on form load load
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			string getAdmin = "select * FROM adminAccounts";
			SqlCommand command = new SqlCommand(getAdmin, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				uid = reader.GetString(reader.GetOrdinal("uid"));
				username = reader.GetString(reader.GetOrdinal("username"));
				password = reader.GetString(reader.GetOrdinal("password"));
			}
			connection.Close();
			txtUserName.Text = username;
			txtPassword.Text = password;
			txtPassword.UseSystemPasswordChar = true;
		}
	}
}
