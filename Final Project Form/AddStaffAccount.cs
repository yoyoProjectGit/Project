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
	public partial class AddStaffAccount : Form
	{
		public AddStaffAccount()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddStaffAccount_Load(object sender, EventArgs e)
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			string departmentCmd = "select * FROM departments";
			SqlCommand command = new SqlCommand(departmentCmd, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				departmentsList.Items.Add(reader.GetString(reader.GetOrdinal("Department")));
			}
			connection.Close();
			txtPassword.UseSystemPasswordChar = true;
		}
		private void checkUserNameExists()
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM userLogins WHERE username=@Username", connection);
			command.Parameters.AddWithValue("@Username", txtUsername.Text);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				MessageBox.Show("This username already exists.");
				return;
			}
			else
			{
				addStaffAccount();
			}
		}
		private void addStaffAccount()
		{
			try
			{ 
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();

				string addItemCommand = "insert into userLogins(username,password,department) " +
							"values(@Username,@Password,@Department)";
				SqlCommand addCommand = new SqlCommand(addItemCommand, connection);
				addCommand.Parameters.AddWithValue("@Username", txtUsername.Text);
				addCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
				addCommand.Parameters.AddWithValue("@Department", departmentsList.SelectedItem.ToString());
				addCommand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Account " + txtUsername.Text + " has been successfully created!", "Creating Account ", 10000);
				connection.Close();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			if (departmentsList.SelectedItem == null)
			{
				MessageBox.Show("Please select the department.");
			}
			else if (txtUsername.Text == "")
			{
				MessageBox.Show("Please enter a username.");
			}
			else if (txtPassword.Text == "" || txtPassword.TextLength < 6)
			{
				MessageBox.Show("Please enter a password longer than 6 characters.");
			}
			else
			{
				checkUserNameExists();
			}

		}

		private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
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
	}
}
