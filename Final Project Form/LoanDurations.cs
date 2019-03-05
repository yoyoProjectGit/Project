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

    public partial class LoanDurations : Form
    {
        int maxLoanPeriod = 0;
        int ResourceID;
        DateTime todaysDate = DateTime.Now;
        public LoanDurations(string type, string name, int loanprd, string dept, int ID, string firstname, 
            string surname, string shuid, string email)
        {
            InitializeComponent();
            txtResourceType.Text = type;
            txtResourceName.Text = name;
            txtDepartment.Text = dept;
            txtShuId.Text = shuid;
            txtFirstName.Text = firstname;
            txtSurname.Text = surname;
            txtEmail.Text = email;
            maxLoanPeriod = loanprd;
            ResourceID = ID;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLoanPeriod.Text == "" || txtLoanID.Text == "")
            {
                MessageBox.Show("Loan Duration and Loan ID are required!");
            }
            else
            {
                int loanPeriod = Convert.ToInt32(this.txtLoanPeriod.Text);
                if (loanPeriod > maxLoanPeriod)
                {
                    MessageBox.Show("The maximum loan period for this item is: " + maxLoanPeriod + " days");
                }
                else
                {
                    LoanUserItem();
                }
            }
        }

        private void txtLoanPeriod_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLoanPeriod.Text, "  ^ [0-9]"))
            {
                txtLoanPeriod.Text = "";
            }
        }

        private void txtLoanPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void LoanUserItem()
        {
            string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand checkLoan = new SqlCommand("SELECT COUNT(*) FROM Loans WHERE LoanNumber like @LoanNumber", connection);
            checkLoan.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
            int loanExists = (int)checkLoan.ExecuteScalar();
            if (loanExists > 0)
            {
                MessageBox.Show("This Loan ID has already been used, Please use a different Loan ID");
                connection.Close();
            } 
            else
            {

                connection.Close();
                try
                {
                    int loanPeriod = Convert.ToInt32(this.txtLoanPeriod.Text);
                    DateTime returnDate = todaysDate.AddDays(loanPeriod);
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    connection.Open();
                    string addUserCommand = "insert into Loans(ResourceID,ResourceType,ResourceName,DateLoaned," +
                    "LoanDuration,Department,BorrowerName,BorrowerID,BorrowerSurname,BorrowerEmail,Notes,LoanedBy,LoanNumber,LoanerID) " +
                                "values(@ResourceID,@ResourceType,@ResourceName,@DateLoaned,@LoanDuration,@Department,@BorrowerName," +
                                "@BorrowerID,@BorrowerSurname,@BorrowerEmail,@Notes,@LoanedBy,@LoanNumber,@LoanerID)";
                    SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                    addCommand.Parameters.AddWithValue("@ResourceID", ResourceID);
                    addCommand.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                    addCommand.Parameters.AddWithValue("@ResourceName", textInfo.ToTitleCase(txtResourceName.Text));
                    addCommand.Parameters.AddWithValue("@DateLoaned", todaysDate.ToString("yyyy-MM-dd H:mm:ss"));
                    addCommand.Parameters.AddWithValue("@LoanDuration", loanPeriod);
                    addCommand.Parameters.AddWithValue("@Department", textInfo.ToTitleCase(txtDepartment.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerName", textInfo.ToTitleCase(txtFirstName.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerID", textInfo.ToTitleCase(txtShuId.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerSurname", textInfo.ToTitleCase(txtSurname.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerEmail", txtEmail.Text);
                    addCommand.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    addCommand.Parameters.AddWithValue("@LoanedBy", CurrentUser.UserName);
                    addCommand.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
                    addCommand.Parameters.AddWithValue("@LoanerID", txtShuId.Text);
                    addCommand.ExecuteNonQuery();
                    AutoClosingMessageBox.Show("The item: " + txtResourceName.Text + " Has been successfully loaned to: " + txtFirstName.Text +
                        " For a total of: " + loanPeriod + " Days", "Loan Item ", 5000);
                    connection.Close();
                    this.Close();
                    removeItemFromResources();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }
        private void removeItemFromResources()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeResourceCommand = "UPDATE resourcesTable SET isOnLoan=@isOnLoan WHERE ResourceID=@ResourceID";
                SqlCommand addCommand = new SqlCommand(removeResourceCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceID", ResourceID);
                addCommand.Parameters.AddWithValue("@isOnLoan", true);
                addCommand.ExecuteNonQuery();
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
