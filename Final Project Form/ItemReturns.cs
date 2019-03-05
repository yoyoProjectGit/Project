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
        string LoanID;
        string resourceID;
        string resourceType;
        string resourceName;
        string DateLoaned;
        string LoanDuration;
        string Department;
        string BorrowerName;
        string BorrowerID;
        string BorrowerSurname;
        string BorrowerEmail;
        string Notes;
        string LoanedBy;
        string LoanNumber;
        string LoanerID;

        public ItemReturns()
        {
            InitializeComponent();
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" && txtLoanID.Text == "")
            {
                MessageBox.Show("Student ID or Loan ID is required to continue!");
            }
            else
            {
                getLoans();
            }

        }
        private void addToLoanHistory()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string addUserCommand = "insert into LoanHistory(ResourceID,ResourceType,ResourceName,DateLoaned," +
                "LoanDuration,Department,BorrowerName,BorrowerID,BorrowerSurname,BorrowerEmail,Notes,LoanedBy,LoanNumber,LoanerID,ReturnDate) " +
                            "values(@ResourceID,@ResourceType,@ResourceName,@DateLoaned,@LoanDuration,@Department,@BorrowerName," +
                            "@BorrowerID,@BorrowerSurname,@BorrowerEmail,@Notes,@LoanedBy,@LoanNumber,@LoanerID,@ReturnDate)";
                SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceID", resourceID);
                addCommand.Parameters.AddWithValue("@ResourceType", resourceType);
                addCommand.Parameters.AddWithValue("@ResourceName", resourceName);
                addCommand.Parameters.AddWithValue("@DateLoaned", DateLoaned);
                addCommand.Parameters.AddWithValue("@LoanDuration", LoanDuration);
                addCommand.Parameters.AddWithValue("@Department", Department);
                addCommand.Parameters.AddWithValue("@BorrowerName", BorrowerName);
                addCommand.Parameters.AddWithValue("@BorrowerID", BorrowerID);
                addCommand.Parameters.AddWithValue("@BorrowerSurname", BorrowerSurname);
                addCommand.Parameters.AddWithValue("@BorrowerEmail", BorrowerEmail);
                addCommand.Parameters.AddWithValue("@Notes", Notes);
                addCommand.Parameters.AddWithValue("@LoanedBy", LoanedBy);
                addCommand.Parameters.AddWithValue("@LoanNumber", LoanNumber);
                addCommand.Parameters.AddWithValue("@LoanerID", LoanerID);
                addCommand.Parameters.AddWithValue("@ReturnDate", returnDate.ToString("yyyy-MM-dd H:mm:ss"));
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
            int id = Convert.ToInt32(resourceID);
            try
          {
            string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string setResourceNotLoaned = "UPDATE resourcesTable SET isOnLoan=@isOnLoan WHERE ResourceID=@ResourceID";
            SqlCommand addCommand = new SqlCommand(setResourceNotLoaned, connection);
            addCommand.Parameters.AddWithValue("@ResourceID", id);
            addCommand.Parameters.AddWithValue("@isOnLoan", false);
            addCommand.ExecuteNonQuery();
            connection.Close();
            removeFromActiveLoans();
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
        private void getLoans()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand checkLoan = new SqlCommand("SELECT COUNT(*) FROM Loans WHERE LoanNumber like @LoanNumber", connection);
                checkLoan.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
                int loanExists = (int)checkLoan.ExecuteScalar();
                if (loanExists > 0)
                {
                    SqlCommand getLoan = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,DateLoaned," +
                    "LoanDuration,Department,BorrowerName,BorrowerID,BorrowerSurname," +
                    "BorrowerEmail,Notes,LoanedBy,LoanNumber,LoanerID,LoanNumber,LoanID" +
                    " FROM Loans WHERE LoanNumber like @LoanNumber", connection);
                    getLoan.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
                    using (SqlDataReader getLoanInfo = getLoan.ExecuteReader())
                    {
                        while (getLoanInfo.Read())
                        {
                            resourceID  = getLoanInfo["ResourceID"].ToString();
                            LoanID = getLoanInfo["LoanID"].ToString();
                            resourceName = getLoanInfo["resourceName"].ToString();
                            resourceType = getLoanInfo["resourceType"].ToString();
                            LoanedBy = getLoanInfo["LoanedBy"].ToString();
                            LoanerID = getLoanInfo["LoanerID"].ToString();
                            BorrowerID = getLoanInfo["BorrowerID"].ToString();
                            BorrowerSurname = getLoanInfo["BorrowerSurname"].ToString();
                            BorrowerEmail = getLoanInfo["BorrowerEmail"].ToString();
                            Notes = getLoanInfo["Notes"].ToString();
                            DateLoaned = getLoanInfo["DateLoaned"].ToString();
                            LoanNumber = getLoanInfo["LoanNumber"].ToString();
                            LoanDuration = getLoanInfo["LoanDuration"].ToString();
                            Department = getLoanInfo["Department"].ToString();
                            BorrowerName = getLoanInfo["BorrowerName"].ToString();
                        }
                        connection.Close();
                    }
                    addToLoanHistory();
                }
                else
                {
                    MessageBox.Show("This Loan ID does not exist");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(checkLoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        private void removeFromActiveLoans()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand remove = new SqlCommand("DELETE FROM Loans WHERE LoanNumber=@LoanNumber", connection);
                remove.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
                remove.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
