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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e) //checks if data inserted into the textboxes are correct
        {
            System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            if ((txtShuId.Text).Equals("") || (txtFirstName.Text).Equals("") || (txtSurname.Text).Equals("") || (txtCourseDept.Text).Equals(""))
            {
                MessageBox.Show("You have not filled in a field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			if (dropUserType.SelectedItem == null)
			{
				MessageBox.Show("Please select the User Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            if (txtEmail.Text.Length >= 0)
            {
                if (!email.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                    return;
                }
            }
            try //inserting into the database
            {
                DateTime dateTime = DateTime.Now;
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string checkUserCommand = "SELECT COUNT(*) FROM students WHERE ShuId=@ShuId";
                SqlCommand command = new SqlCommand(checkUserCommand, connection);
                command.Parameters.AddWithValue("@ShuId", textInfo.ToTitleCase(txtShuId.Text));
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0 )
                {
                    string addUserCommand = "insert into students(ShuId,FirstName,Surname,CourseDept,EmailAddress,DateAdded,StartDate,ScannableNum,UserType) " +
							   "values(@ShuId,@FirstName,@Surname,@CourseDept,@EmailAddress,@DateAdded,@StartDate,@ScannableNum,@UserType)";
                    SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                    addCommand.Parameters.AddWithValue("@ShuId", textInfo.ToTitleCase(txtShuId.Text));
                    addCommand.Parameters.AddWithValue("@FirstName", textInfo.ToTitleCase(txtFirstName.Text));
                    addCommand.Parameters.AddWithValue("@Surname", textInfo.ToTitleCase(txtSurname.Text));
                    addCommand.Parameters.AddWithValue("@CourseDept", textInfo.ToTitleCase(txtCourseDept.Text));
                    addCommand.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                    addCommand.Parameters.AddWithValue("@DateAdded", dateTime);
                    addCommand.Parameters.AddWithValue("@StartDate", startDatePicker.Value);
					addCommand.Parameters.AddWithValue("@ScannableNum", txtScanID.Text);
					addCommand.Parameters.AddWithValue("@UserType", dropUserType.SelectedItem.ToString());
					addCommand.ExecuteNonQuery();
                    AutoClosingMessageBox.Show("An account for " + txtFirstName.Text + " " + txtSurname.Text + " has been successfully created.", "Create account", 2500);
                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An account for this SHU ID already exists");
                }
              
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void AddUser_Load(object sender, EventArgs e) //filling email box
		{
			txtEmail.Text = "@my.shu.ac.uk";
		}

		private void btnStudentEmail_Click(object sender, EventArgs e)
		{
			txtEmail.Text = "@my.shu.ac.uk";
		}

		private void btnStaffEmail_Click(object sender, EventArgs e)
		{
			txtEmail.Text = "@shu.ac.uk";
		}
	}
}
