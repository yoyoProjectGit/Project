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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            if ((txtShuId.Text).Equals("") || (txtFirstName.Text).Equals("") || (txtSurname.Text).Equals("") || (txtCourseDept.Text).Equals(""))
            {
                MessageBox.Show("You have not filled in a field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string addUserCommand = "insert into students(ShuId,FirstName,Surname,CourseDept,EmailAddress,FinishDate) " +
                                 "values(@ShuId,@FirstName,@Surname,@CourseDept,@EmailAddress,@FinishDate)";
                SqlCommand command = new SqlCommand(addUserCommand, connection);
                command.Parameters.AddWithValue("@ShuId", txtShuId.Text);
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                command.Parameters.AddWithValue("@CourseDept", txtCourseDept.Text);
                command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                command.Parameters.AddWithValue("@FinishDate", finishDatePicker.Value);
                command.ExecuteNonQuery();
                AutoClosingMessageBox.Show("An account for " + txtFirstName.Text + " " + txtSurname.Text + " has been successfully created.","Create account" ,2500);
                connection.Close();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
