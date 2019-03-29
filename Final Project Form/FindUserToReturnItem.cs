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
	public partial class FindUserToReturnItem : Form
	{
		DateTime returnDate;
		string LoanID, resourceID, resourceType, resourceName, DateLoaned,
			LoanDuration, Department, BorrowerName, BorrowerID,
			BorrowerSurname, BorrowerEmail, Notes, LoanedBy, scannableNum,
			serialNumber, userType;
		int stock, quantity;
		DataTable dt = new DataTable("Loans");
		public FindUserToReturnItem(string serialnumber)
		{
			InitializeComponent();
			serialNumber = serialnumber;
		}
		private void btnSearchShu_Click(object sender, EventArgs e)
		{
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("BorrowerID LIKE '%" + txtShuId.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
		}
		private void btnSearchSurname_Click(object sender, EventArgs e)
		{
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("BorrowerSurname LIKE '%" + txtSurname.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
		}
		private void btnScanID_Click(object sender, EventArgs e)
		{
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("ScannableNum LIKE '%" + txtScanID.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand command = new SqlCommand("SELECT ResourceName,SerialNumber,Quantity,LoanedBy," +
				"BorrowerID,BorrowerName,BorrowerSurname,BorrowerEmail,UserType,DateLoaned,DueDate,LoanDuration," +
				"ScannableNum,ResourceType,LoanID,ResourceID,Notes,Department FROM Loans WHERE SerialNumber=@SerialNumber", connection);
			command.Parameters.AddWithValue("@SerialNumber", serialNumber);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
			loanedItemsGridView.DataSource = dt;
			connection.Close();
		}

		private void FindUserToReturnItem_Load(object sender, EventArgs e)
		{
			try
			{
				DataGridViewButtonColumn button = new DataGridViewButtonColumn();
				button.HeaderText = "Return Item";
				button.Text = "Return";
				button.UseColumnTextForButtonValue = true;
				loanedItemsGridView.Columns.Add(button);
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT ResourceName,SerialNumber,Quantity,LoanedBy," +
					"BorrowerID,BorrowerName,BorrowerSurname,BorrowerEmail,UserType,DateLoaned,DueDate,LoanDuration," +
					"ScannableNum,ResourceType,LoanID,ResourceID,Notes,Department FROM Loans WHERE SerialNumber=@SerialNumber", connection);
				command.Parameters.AddWithValue("@SerialNumber", serialNumber);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(dt);
				loanedItemsGridView.DataSource = dt;
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void loanedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				DialogResult dialogResult = MessageBox.Show("You are returning a total of: "+ quantity+ " "+ resourceName + 
					"'s Borrowed by: " + BorrowerName + " " + BorrowerID, "Are you sure?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					try
					{
						DataGridViewRow row = this.loanedItemsGridView.Rows[e.RowIndex];
						returnDate = DateTime.Now;
						resourceID = row.Cells["ResourceID"].Value.ToString();
						LoanID = row.Cells["LoanID"].Value.ToString();
						resourceType = row.Cells["resourceType"].Value.ToString();
						resourceName = row.Cells["resourceName"].Value.ToString();
						LoanedBy = row.Cells["LoanedBy"].Value.ToString();
						BorrowerID = row.Cells["BorrowerID"].Value.ToString();
						BorrowerName = row.Cells["BorrowerName"].Value.ToString();
						BorrowerSurname = row.Cells["BorrowerSurname"].Value.ToString();
						BorrowerEmail = row.Cells["BorrowerEmail"].Value.ToString();
						Notes = row.Cells["Notes"].Value.ToString();
						DateLoaned = row.Cells["DateLoaned"].Value.ToString();
						LoanDuration = row.Cells["LoanDuration"].Value.ToString();
						Department = row.Cells["Department"].Value.ToString();
						quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
						scannableNum = row.Cells["ScannableNum"].Value.ToString();
						userType = row.Cells["UserType"].Value.ToString();
						addToLoanHistory();
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					
				}
				else if (dialogResult == DialogResult.No)
				{
					return;
				}
			}
		}
		private void addToLoanHistory()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				string addLoanHistory = "insert into LoanHistory(LoanID,ResourceID,ResourceType,ResourceName,DateLoaned," +
				"LoanDuration,Department,BorrowerName,BorrowerID,Notes,LoanedBy,ReturnDate,Quantity,ScannableNum,UserType) " +
							"values(@LoanID,@ResourceID,@ResourceType,@ResourceName,@DateLoaned,@LoanDuration,@Department,@BorrowerName," +
							"@BorrowerID,@Notes,@LoanedBy,@ReturnDate,@Quantity,@ScannableNum,@UserType)";
				SqlCommand addCommand = new SqlCommand(addLoanHistory, connection);
				addCommand.Parameters.AddWithValue("@LoanID", LoanID);
				addCommand.Parameters.AddWithValue("@ResourceID", resourceID);
				addCommand.Parameters.AddWithValue("@ResourceType", resourceType);
				addCommand.Parameters.AddWithValue("@ResourceName", resourceName);
				addCommand.Parameters.AddWithValue("@DateLoaned", Convert.ToDateTime(DateLoaned));
				addCommand.Parameters.AddWithValue("@LoanDuration", LoanDuration);
				addCommand.Parameters.AddWithValue("@Department", Department);
				addCommand.Parameters.AddWithValue("@BorrowerName", BorrowerName);
				addCommand.Parameters.AddWithValue("@BorrowerID", BorrowerID);
				addCommand.Parameters.AddWithValue("@Notes", Notes);
				addCommand.Parameters.AddWithValue("@LoanedBy", LoanedBy);
				addCommand.Parameters.AddWithValue("@Quantity", quantity);
				addCommand.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(returnDate));
				addCommand.Parameters.AddWithValue("@ScannableNum", scannableNum);
				addCommand.Parameters.AddWithValue("@UserType", userType);
				addCommand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("The item: " + resourceName + " Has been successfully returned", "Return Item ", 5000);
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			makeResourceLoanable();
		}
		private void makeResourceLoanable()
		{
			getTotalStock();
			int id = Convert.ToInt32(resourceID);
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				string setResourceNotLoaned = "UPDATE resourcesTable SET InStock=@InStock WHERE ResourceID=@ResourceID";
				SqlCommand addCommand = new SqlCommand(setResourceNotLoaned, connection);
				addCommand.Parameters.AddWithValue("@ResourceID", id);
				addCommand.Parameters.AddWithValue("@InStock", quantity + stock);
				addCommand.ExecuteNonQuery();
				connection.Close();
				removeFromActiveLoans();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void removeFromActiveLoans()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand remove = new SqlCommand("DELETE FROM Loans WHERE LoanID=@LoanID", connection);
				remove.Parameters.AddWithValue("@LoanID", LoanID);
				remove.ExecuteNonQuery();
				connection.Close();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
			}
		}
		private void getTotalStock()
		{
			string connectionString = myGlobals.connString;
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand getLoan = new SqlCommand("SELECT InStock FROM resourcesTable WHERE ResourceID like @ResourceID", connection);
			getLoan.Parameters.AddWithValue("@ResourceID", resourceID);
			using (SqlDataReader getInfo = getLoan.ExecuteReader())
			{
				while (getInfo.Read())
				{
					stock = Convert.ToInt32(getInfo["InStock"].ToString());
				}
				connection.Close();
			}
		}
	}
}
