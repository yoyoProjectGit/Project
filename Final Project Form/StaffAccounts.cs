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
	public partial class StaffAccounts : Form
	{
		string userID;
		DataTable dt = new DataTable("Staff Members");
		public StaffAccounts()
		{
			InitializeComponent();
		}

		private void btnBackToLoan_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage1;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void StaffAccounts_Load(object sender, EventArgs e)
		{

			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM userLogins", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
			staffGridView.DataSource = dt;
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "View Account";
			button.Text = "View";
			staffGridView.Columns[0].Visible = false;
			staffGridView.Columns[2].Visible = false;
			button.UseColumnTextForButtonValue = true;
			staffGridView.Columns.Add(button);
			string departmentCmd = "select * FROM departments";
			SqlCommand command2 = new SqlCommand(departmentCmd, connection);
			SqlDataReader reader = command2.ExecuteReader();
			while (reader.Read())
			{
				departmentsList.Items.Add(reader.GetString(reader.GetOrdinal("Department")));
			}
			connection.Close();
		}

		private void staffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 5 || e.ColumnIndex == 0)
			{
				DataGridViewRow row = this.staffGridView.Rows[e.RowIndex];
				txtUserName.Text = row.Cells["username"].Value.ToString();
				txtPassword.Text = row.Cells["password"].Value.ToString();
				txtName.Text = row.Cells["name"].Value.ToString();
				txtPassword.UseSystemPasswordChar = true;
				checkBoxShowPass.Checked = false;
				departmentsList.SelectedIndex = departmentsList.FindString(row.Cells["department"].Value.ToString());
				userID = row.Cells["uid"].Value.ToString();
				tabControl1.SelectedTab = tabPage2;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			txtUserName.ReadOnly = false;
			txtPassword.ReadOnly = false;
			txtName.ReadOnly = false;
		}

		private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxShowPass.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string selectedDepartment = this.departmentsList.GetItemText(this.departmentsList.SelectedItem);
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				string updateUser = "UPDATE userLogins SET username=@Username, password=@Password " +
					", name=@Name, department=@Department WHERE uid=@Uid";
				SqlCommand command = new SqlCommand(updateUser, connection);
				
				command.Parameters.AddWithValue("@Password", txtPassword.Text);
				command.Parameters.AddWithValue("@Username", txtUserName.Text);
				command.Parameters.AddWithValue("@uid", userID);
				command.Parameters.AddWithValue("@Department", selectedDepartment);
				command.Parameters.AddWithValue("@Name", txtName.Text);
				command.ExecuteNonQuery();
				MessageBox.Show("The staff account  " + txtUserName.Text + " has been successfully updated.");
				connection.Close();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
