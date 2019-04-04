using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public partial class viewStudentInfo : Form
    {
        string shuId,firstname, surName, courseDept, 
			emailAddress,startDate, prevName,userType,
			scannableNum,resourceID, resourceType,DateLoaned,LoanDuration,
			Department,BorrowerID,Notes,LoanedBy,quantity;
        DataTable dt = new DataTable("User Loans");

		private void btnBackToLoan_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage2;
		}
		private void txtTotalDays_TextChanged(object sender, EventArgs e)
		{
		
			if (System.Text.RegularExpressions.Regex.IsMatch(txtTotalDays.Text, "  ^ [0-9]"))
			{
				txtTotalDays.Text = "";
			}
		}
		private void txtTotalDays_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		DataTable dt2 = new DataTable("User History");
		string maxprd;
		int loanID;
		DateTime todaysDate;
		private void LoanedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9 || e.ColumnIndex == 0)
			{
				DataGridViewRow row = this.LoanedItemsGridView.Rows[e.RowIndex];
				txtResourceName.Text = row.Cells["ResourceName"].Value.ToString();
				txtSerialNo.Text = row.Cells["SerialNumber"].Value.ToString();
				txtDateLoaned.Text = row.Cells["DateLoaned"].Value.ToString();
				txtDueDate.Text = row.Cells["DueDate"].Value.ToString();
				txtBorrowerName.Text = row.Cells["BorrowerName"].Value.ToString();
				txtUserType.Text = row.Cells["UserType"].Value.ToString();
				loanID = Convert.ToInt32(row.Cells["LoanID"].Value);
				getMaxLoanPrd();
				txtTotalDays.Text = maxprd;
				tabControl1.SelectedTab = tabPage4;
				resourceID = row.Cells["ResourceID"].Value.ToString();
				resourceType = row.Cells["ResourceType"].Value.ToString();
				DateLoaned = row.Cells["DateLoaned"].Value.ToString();
				LoanDuration = row.Cells["LoanDuration"].Value.ToString();
				Department = row.Cells["Department"].Value.ToString();
				BorrowerID = row.Cells["BorrowerID"].Value.ToString();
				Notes = row.Cells["Notes"].Value.ToString();
				LoanedBy = row.Cells["LoanedBy"].Value.ToString();
				quantity = row.Cells["Quantity"].Value.ToString();
				todaysDate = DateTime.Now;
			}
		}

		TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

		private void btnExtendLoan_Click(object sender, EventArgs e)
		{
			if (txtTotalDays.Text == "")
			{
				MessageBox.Show("Please enter how many days you want to extend this item by.");
			}
			else
			{
				int loanPeriod = Convert.ToInt32(this.txtTotalDays.Text);
				try
				{
					if (loanPeriod > Convert.ToInt32(maxprd))
					{
						DialogResult dialogResult = MessageBox.Show("The maximum loan period for " + txtResourceName.Text +
							" is: " + maxprd + " days", "Are you sure you want to loan this item for "+ txtTotalDays.Text+" Days?",
							MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
						{
							extendLoan();
							addExtendToHistory();
							AutoClosingMessageBox.Show("The item: " + txtResourceName.Text +
							" Has been successfully Extended For: " + txtTotalDays.Text + " Days.", "Loan Item ", 5000);
						}
						else if (dialogResult == DialogResult.No)
						{
							return;
						}
					}
					else
					{
						extendLoan();
						addExtendToHistory();
						AutoClosingMessageBox.Show("The item: " + txtResourceName.Text +
						" Has been successfully Extended For: " + txtTotalDays.Text + " Days.", "Loan Item ", 5000);
						}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
				this.Close();
			}
		}

		public viewStudentInfo(string id, string name, string surname, string coursedept, string email, string datecreated, string startdate,string usertype,string scannablenum)
		{
			InitializeComponent();
			txtShuId.Text = id;
			shuId = id;
			txtFirstName.Text = name;
			prevName = name;
			firstname = name;
			txtSurname.Text = surname;
			surName = surname;
			txtCourseDept.Text = coursedept;
			courseDept = coursedept;
			txtEmail.Text = email;
			emailAddress = email;
			txtDateAdded.Text = datecreated;
			startDatePicker.Value = Convert.ToDateTime(startdate);
			startDate = startdate;
			userType = usertype;
			scannableNum = scannablenum;
			txtScanID.Text = scannablenum;
			dropUserType.SelectedIndex = dropUserType.FindString(usertype);
		}
		private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		//ResourceType, ResourceName, DateLoaned, DueDate, UserType, BorrowerName,Quantity
		private void viewStudentInfo_Load(object sender, EventArgs e)
        {
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ResourceType, ResourceName, DateLoaned, DueDate, UserType, " +
				"BorrowerName,Quantity,SerialNumber,LoanedBy,BorrowerID,BorrowerSurname,BorrowerEmail,LoanDuration," +
					"ScannableNum,LoanID,ResourceID,Notes,Department FROM Loans WHERE BorrowerID=@ShuID", connection);
            command.Parameters.AddWithValue("@ShuId", txtShuId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
            LoanedItemsGridView.DataSource = dt;
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Extend Loan";
			button.Text = "Extend";
			button.UseColumnTextForButtonValue = true;
			LoanedItemsGridView.Columns.Add(button);
			LoanedItemsGridView.Columns[7].Visible = false;
			LoanedItemsGridView.Columns[8].Visible = false;
			LoanedItemsGridView.Columns[9].Visible = false;
			LoanedItemsGridView.Columns[10].Visible = false;
			LoanedItemsGridView.Columns[11].Visible = false;
			LoanedItemsGridView.Columns[12].Visible = false;
			LoanedItemsGridView.Columns[13].Visible = false;
			LoanedItemsGridView.Columns[14].Visible = false;
			LoanedItemsGridView.Columns[15].Visible = false;
			LoanedItemsGridView.Columns[16].Visible = false;
			LoanedItemsGridView.Columns[17].Visible = false;
			SqlCommand command2 = new SqlCommand("SELECT ResourceType, ResourceName, DateLoaned, ReturnDate, BorrowerName, LoanedBy, Quantity, Notes" +
                " FROM LoanHistory WHERE BorrowerID=@ShuId", connection);
            command2.Parameters.AddWithValue("@ShuId", txtShuId.Text);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            adapter2.Fill(dt2);
            loanHistory.DataSource = dt2;
            connection.Close();
		}
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtShuId.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtCourseDept.ReadOnly = false;
            txtEmail.ReadOnly = false;
			txtScanID.ReadOnly = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if ((txtShuId.Text.Equals(shuId) && txtFirstName.Text.Equals(firstname) && txtSurname.Text.Equals(surName)
                && txtCourseDept.Text.Equals(courseDept) && txtEmail.Text.Equals(emailAddress) 
                && startDatePicker.Value.ToString().Equals(startDate) && txtScanID.Text.Equals(scannableNum) && (dropUserType.SelectedIndex == dropUserType.FindString(userType))))
            {
                MessageBox.Show("You have not changed any values!");
            }
            else
            {
                try
                {
					string selectedUserType = this.dropUserType.GetItemText(this.dropUserType.SelectedItem);
					string connectionString = myGlobals.connString;
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string updateUser = "UPDATE students SET ShuId=@ShuId, FirstName=@FirstName " +
						", Surname=@Surname, CourseDept=@CourseDept, EmailAddress=@EmailAddress, StartDate=@StartDate," +
						" ScannableNum=@ScannableNum, UserType=@UserType WHERE ShuId=@ShuId";
                    SqlCommand command = new SqlCommand(updateUser, connection);
                    command.Parameters.AddWithValue("@ShuId", txtShuId.Text);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    command.Parameters.AddWithValue("@CourseDept", txtCourseDept.Text);
                    command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                    command.Parameters.AddWithValue("@StartDate", startDatePicker.Value);
					command.Parameters.AddWithValue("@ScannableNum", txtScanID.Text);
					command.Parameters.AddWithValue("@UserType", selectedUserType);
					command.ExecuteNonQuery();
                    MessageBox.Show("The student account of " + prevName + " " + txtSurname.Text + " has been successfully updated.");
                    connection.Close();
					this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
		private void getMaxLoanPrd()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT MaxLoanPeriod FROM resourcesTable WHERE SerialNumber=@SerialNumber", connection);
				command.Parameters.AddWithValue("@SerialNumber", txtSerialNo.Text);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					maxprd = reader[0].ToString();

				}
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void extendLoan()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				DateTime todaysDate = DateTime.Now;
				DateTime dueDate = todaysDate.AddDays(Convert.ToInt32(txtTotalDays.Text));
				TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
				connection.Open();
				string updateCommand = "UPDATE Loans SET DueDate=@DueDate, LoanDuration=@LoanDuration,DateLoaned=@todaysDate WHERE LoanID=@LoanID";
				SqlCommand extendCommand = new SqlCommand(updateCommand, connection);
				extendCommand.Parameters.AddWithValue("@LoanID", loanID);
				extendCommand.Parameters.AddWithValue("@DueDate", dueDate);
				extendCommand.Parameters.AddWithValue("@LoanDuration", Convert.ToInt32(txtTotalDays.Text));
				extendCommand.Parameters.AddWithValue("@todaysDate", todaysDate);
				extendCommand.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void addExtendToHistory()
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
				addCommand.Parameters.AddWithValue("@LoanID", loanID);
				addCommand.Parameters.AddWithValue("@ResourceID", resourceID);
				addCommand.Parameters.AddWithValue("@ResourceType", resourceType);
				addCommand.Parameters.AddWithValue("@ResourceName", txtResourceName.Text);
				addCommand.Parameters.AddWithValue("@DateLoaned", Convert.ToDateTime(DateLoaned));
				addCommand.Parameters.AddWithValue("@LoanDuration", LoanDuration);
				addCommand.Parameters.AddWithValue("@Department", Department);
				addCommand.Parameters.AddWithValue("@BorrowerName", txtBorrowerName.Text);
				addCommand.Parameters.AddWithValue("@BorrowerID", BorrowerID);
				addCommand.Parameters.AddWithValue("@Notes", "Extended by: " + LoanedBy + " For a total of: " + txtTotalDays.Text + " Days.");
				addCommand.Parameters.AddWithValue("@LoanedBy", LoanedBy);
				addCommand.Parameters.AddWithValue("@Quantity", quantity);
				addCommand.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(todaysDate));
				addCommand.Parameters.AddWithValue("@ScannableNum", scannableNum);
				addCommand.Parameters.AddWithValue("@UserType", userType);
				addCommand.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
