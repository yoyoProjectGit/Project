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
	public partial class StaffMembers : Form
	{
		DataTable dt = new DataTable("Staff Members");
		public StaffMembers()
		{
			InitializeComponent();
		}

		private void StaffMembers_Load(object sender, EventArgs e)
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM students WHERE UserType='Staff'", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
			staffMemberGridView.DataSource = dt;
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Delete User";
			button.Text = "Delete";
			button.UseColumnTextForButtonValue = true;
			staffMemberGridView.Columns.Add(button);
			staffMemberGridView.Columns[1].Visible = false;
			staffMemberGridView.Columns[5].Visible = false;
			staffMemberGridView.Columns[7].Visible = false;
			staffMemberGridView.Columns[8].Visible = false;
			connection.Close();
		}

		private void staffMemberGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9 || e.ColumnIndex == 0)
			{
				DataGridViewRow row = this.staffMemberGridView.Rows[e.RowIndex];
				txtUserType.Text = "Staff";
				txtScanID.Text = row.Cells["ScannableNum"].Value.ToString();
				txtShuId.Text = row.Cells["ShuId"].Value.ToString();
				txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
				txtSurname.Text = row.Cells["Surname"].Value.ToString();
				txtCourseDept.Text = row.Cells["CourseDept"].Value.ToString();
				txtEmail.Text = row.Cells["EmailAddress"].Value.ToString();
				txtDateAdded.Text = row.Cells["DateAdded"].Value.ToString();
				txtStartDate.Text = row.Cells["StartDate"].Value.ToString();
				tabControl1.SelectedTab = tabPage2;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("You are about to delete the Staff member " + txtFirstName.Text +
							"."," Are you sure you want to remove them?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				checkIfUserHasLoans();
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
		}

		private void deleteUser()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				string removeQuantityCommand = "DELETE FROM students WHERE ShuId=@ShuId";
				SqlCommand remCommand = new SqlCommand(removeQuantityCommand, connection);
				remCommand.Parameters.AddWithValue("@ShuId", txtShuId.Text);
				remCommand.ExecuteNonQuery();
				connection.Close();
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void checkIfUserHasLoans()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Loans WHERE BorrowerID=@BorrowerID", connection);
				command.Parameters.AddWithValue("@BorrowerID", txtShuId.Text);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						MessageBox.Show("This user currently has another item on loan.");
						return;
					}
					else
					{
						deleteUser();
					}
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClose2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
