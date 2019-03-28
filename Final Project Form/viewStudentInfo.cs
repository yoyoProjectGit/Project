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
        string shuId,firstname, surName, courseDept, emailAddress,startDate, prevName,userType,scannableNum;
        DataTable dt = new DataTable("User Loans");
        DataTable dt2 = new DataTable("User History");

		TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
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

        private void viewStudentInfo_Load(object sender, EventArgs e)
        {
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ResourceType, ResourceName, DateLoaned, DueDate, UserType, BorrowerName,LoanedBy,Quantity" +
                " FROM Loans WHERE BorrowerID=@ShuId", connection);
            command.Parameters.AddWithValue("@ShuId", txtShuId.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dt);
            LoanedItemsGridView.DataSource = dt;
            SqlCommand command2 = new SqlCommand("SELECT ResourceType, ResourceName, DateLoaned, ReturnDate, BorrowerName, LoanedBy, Quantity" +
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
    }
}
