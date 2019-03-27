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
        int amountinstock;
        public LoanDurations(string type, string name, int loanprd, int quantity,string dept, int ID, string firstname, 
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
            amountinstock = quantity;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtLoanPeriod.Text == "" || txtLoanID.Text == "")
            {
                MessageBox.Show("Loan Duration, Loan ID and Quantity are required!");
            }
            else
            {
                int loanPeriod = Convert.ToInt32(this.txtLoanPeriod.Text);
                if (loanPeriod > maxLoanPeriod)
                {
                    MessageBox.Show("The maximum loan period for this item is: " + maxLoanPeriod + " days");
                }
                else if (loanPeriod == 0 )
                {
                    MessageBox.Show("You cannot loan an item for 0 days!");
                }
                else if (amountinstock < Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show("There is only " + amountinstock + " " + txtResourceName.Text + " in stock.");
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
            string connectionString = myGlobals.connString;
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
                    DateTime todaysDate = DateTime.Now;
                    int loanPeriod = Convert.ToInt32(this.txtLoanPeriod.Text);
                    DateTime returnDate = todaysDate.AddDays(loanPeriod);
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    connection.Open();
                    string addUserCommand = "insert into Loans(ResourceID,ResourceType,ResourceName,DateLoaned," +
                    "LoanDuration,Department,BorrowerName,BorrowerID,BorrowerSurname,BorrowerEmail,Notes,LoanedBy,LoanNumber,LoanerID,DueDate,Quantity) " +
                                "values(@ResourceID,@ResourceType,@ResourceName,@DateLoaned,@LoanDuration,@Department,@BorrowerName," +
                                "@BorrowerID,@BorrowerSurname,@BorrowerEmail,@Notes,@LoanedBy,@LoanNumber,@LoanerID,@DueDate,@Quantity)";
                    SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                    addCommand.Parameters.AddWithValue("@ResourceID", ResourceID);
                    addCommand.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                    addCommand.Parameters.AddWithValue("@ResourceName", textInfo.ToTitleCase(txtResourceName.Text));
                    addCommand.Parameters.AddWithValue("@DateLoaned", todaysDate);
                    addCommand.Parameters.AddWithValue("@LoanDuration", loanPeriod);
                    addCommand.Parameters.AddWithValue("@Department", textInfo.ToTitleCase(txtDepartment.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerName", textInfo.ToTitleCase(txtFirstName.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerID", textInfo.ToTitleCase(txtShuId.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerSurname", textInfo.ToTitleCase(txtSurname.Text));
                    addCommand.Parameters.AddWithValue("@BorrowerEmail", txtEmail.Text);
                    addCommand.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    addCommand.Parameters.AddWithValue("@LoanedBy", currentUser.UserName);
                    addCommand.Parameters.AddWithValue("@LoanNumber", txtLoanID.Text);
                    addCommand.Parameters.AddWithValue("@LoanerID", currentUser.UserID);
                    addCommand.Parameters.AddWithValue("@DueDate", returnDate);
                    addCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                    addCommand.ExecuteNonQuery();
                    AutoClosingMessageBox.Show("The item: " + txtResourceName.Text + " x" + txtQuantity.Text+" Has been successfully loaned to: " + txtFirstName.Text +
                        " For a total of: " + loanPeriod + " Days", "Loan Item ", 5000);
                    connection.Close();
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
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeResourceCommand = "UPDATE resourcesTable SET Quantity=@Quantity WHERE ResourceID=@ResourceID";
                SqlCommand addCommand = new SqlCommand(removeResourceCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceID", ResourceID);
                addCommand.Parameters.AddWithValue("@Quantity", amountinstock - Convert.ToInt32(txtQuantity.Text));
                addCommand.ExecuteNonQuery();
                connection.Close();
                emailUserNotify();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void emailUserNotify()
        {
            try
            {
            string connectionString = myGlobals.connString;
            string procName = "EmailUser";
                using (var conn = new SqlConnection(connectionString))
                using (var email = new SqlCommand(procName, conn)
                {
                    CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                email.Parameters.AddWithValue("@email", txtEmail.Text);
                email.Parameters.AddWithValue("@profilename", "SHUEmail");
                email.Parameters.AddWithValue("@thesubject", "Loan Notifier");
                email.Parameters.AddWithValue("@thebody", "You have been Loaned the item: " + txtResourceName.Text + " x" + txtQuantity.Text 
                    +" For a total of " + txtLoanPeriod.Text + " Days");
                email.ExecuteNonQuery();
                conn.Close();
            }
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }
    }
}
