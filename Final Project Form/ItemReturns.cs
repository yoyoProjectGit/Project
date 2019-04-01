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
	public partial class ItemReturns : Form
	{
		DateTime returnDate = DateTime.Now;
		string BorrowerName;
		string BorrowerID;
		string BorrowerSurname;
		string BorrowerEmail;
		string scannableNum;
		string usertype;
		public ItemReturns()
		{
			InitializeComponent();
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btncheckSHUid_Click(object sender, EventArgs e)
		{
			if (txtStudentID.Text == "")
			{
				MessageBox.Show("Please Enter A Valid Student ID");
			}
			else
			{
				checkIfBNoExists();
			}

		}
		private void checkIfBNoExists()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand checkLoan = new SqlCommand("SELECT COUNT(*) FROM Loans WHERE BorrowerID like @ShuId", connection);
				checkLoan.Parameters.AddWithValue("@ShuId", txtStudentID.Text);
				int checker = (int)checkLoan.ExecuteScalar();
				if (checker > 0)
				{
					SqlCommand command = new SqlCommand("SELECT * FROM Loans WHERE BorrowerID like @ShuId", connection);
					command.Parameters.AddWithValue("@ShuId", txtStudentID.Text);
					using (SqlDataReader getLoanInfo = command.ExecuteReader())
					{
						while (getLoanInfo.Read())
						{
							BorrowerID = getLoanInfo["BorrowerID"].ToString();
							BorrowerSurname = getLoanInfo["BorrowerSurname"].ToString();
							BorrowerEmail = getLoanInfo["BorrowerEmail"].ToString();
							BorrowerName = getLoanInfo["BorrowerName"].ToString();
							usertype = getLoanInfo["UserType"].ToString();
							scannableNum = txtScanID.Text;
						}
						connection.Close();
					}
					command.Parameters.AddWithValue("@ShuId", txtStudentID.Text);
					ReturnUserItem returnItem = new ReturnUserItem(BorrowerID, BorrowerName, BorrowerSurname, BorrowerEmail, usertype, scannableNum);
					returnItem.Show();
				}
				else
				{
					SqlCommand checkId = new SqlCommand("SELECT COUNT(*) FROM students WHERE ShuId like @ShuId", connection);
					checkId.Parameters.AddWithValue("@ShuId", txtStudentID.Text);
					int checker2 = (int)checkId.ExecuteScalar();
					if (checker2 > 0)
					{
						MessageBox.Show("This student ID does not have any loans linked to it");
						connection.Close();
					}
					else
					{
						MessageBox.Show("This student ID doesnt exist");
						connection.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
			}
		}

		private void btnSearchSerialNo_Click(object sender, EventArgs e)
		{
			if (txtSerialNo.Text == "")
			{
				MessageBox.Show("Please Enter A Valid Serial Number");
			}
			else
			{
				checkIfSerialNoExists();
			}
		}
		private void checkIfSerialNoExists()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand checkId = new SqlCommand("SELECT COUNT(*) FROM Loans WHERE SerialNumber like @SerialNumber", connection);
				checkId.Parameters.AddWithValue("@SerialNumber", txtSerialNo.Text);
				int checker = (int)checkId.ExecuteScalar();
				if (checker > 0)
				{
					FindUserToReturnItem returnItem = new FindUserToReturnItem(txtSerialNo.Text);
					returnItem.Show();
				}
				else
				{
					SqlCommand checkSerial = new SqlCommand("SELECT COUNT(*) FROM resourcesTable WHERE SerialNumber like @SerialNumber", connection);
					checkSerial.Parameters.AddWithValue("@SerialNumber", txtSerialNo.Text);
					int checkserial = (int)checkSerial.ExecuteScalar();
					if (checkserial > 0)
					{
						MessageBox.Show("Nobody is currently Borrowing this Item.");
						connection.Close();
					}
					else
					{
						MessageBox.Show("This Serial Number Does Not Exist.");
						connection.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
			}
		}

		private void btnSearchScanID_Click(object sender, EventArgs e)
		{
			if (txtScanID.Text == "")
			{
				MessageBox.Show("Please Enter A Valid Scan ID");
			}
			else
			{
				checkIfScanIDExists();
			}
		}
		private void checkIfScanIDExists()
		{
			try
			{
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand checkId = new SqlCommand("SELECT COUNT(*) FROM Loans WHERE ScannableNum like @ScannableNum", connection);
				checkId.Parameters.AddWithValue("@ScannableNum", txtScanID.Text);
				int checker = (int)checkId.ExecuteScalar();
				if (checker > 0)
				{
					SqlCommand command = new SqlCommand("SELECT * FROM Loans WHERE ScannableNum like @ScannableNum", connection);
					command.Parameters.AddWithValue("@ScannableNum", txtScanID.Text);
					using (SqlDataReader getLoanInfo = command.ExecuteReader())
					{
						while (getLoanInfo.Read())
						{
							BorrowerID = getLoanInfo["BorrowerID"].ToString();
							BorrowerSurname = getLoanInfo["BorrowerSurname"].ToString();
							BorrowerEmail = getLoanInfo["BorrowerEmail"].ToString();
							BorrowerName = getLoanInfo["BorrowerName"].ToString();
							usertype = getLoanInfo["UserType"].ToString();
							scannableNum = txtScanID.Text;
						}
						connection.Close();
					}
					command.Parameters.AddWithValue("@ShuId", txtStudentID.Text);
					ReturnUserItem returnItem = new ReturnUserItem(BorrowerID, BorrowerName, BorrowerSurname, BorrowerEmail, usertype,scannableNum);
					returnItem.Show();
				}
				else
				{
					MessageBox.Show("This Scan ID does not have any loans linked to it.");
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
			}
		}

		private void txtSerialNo_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txtSerialNo.Text, "  ^ [0-9]"))
			{
				txtSerialNo.Text = "";
			}
		}

		private void txtSerialNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
	}
}
