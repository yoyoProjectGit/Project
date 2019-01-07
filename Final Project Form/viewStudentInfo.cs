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
    public partial class viewStudentInfo : Form
    {
        string shuId,firstname, surName, courseDept, emailAddress, finishDate, prevName;
        public viewStudentInfo(string id, string name, string surname, string coursedept, string email, string finishdate)
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
            finishDatePicker.Value = Convert.ToDateTime(finishdate);
            finishDate = finishdate;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtShuId.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSurname.ReadOnly = false;
            txtCourseDept.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if ((txtShuId.Text.Equals(shuId) && txtFirstName.Text.Equals(firstname) && txtSurname.Text.Equals(surName)
                && txtCourseDept.Text.Equals(courseDept) && txtEmail.Text.Equals(emailAddress) 
                && finishDatePicker.Value.ToString().Equals(finishDate)))
            {
                MessageBox.Show("You have not changed any values!");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string updateUser = "UPDATE students SET ShuId=@ShuId, FirstName=@FirstName " +
                        ", Surname=@Surname, CourseDept=@CourseDept, EmailAddress=@EmailAddress, FinishDate=@FinishDate WHERE ShuId=@ShuId";
                    SqlCommand command = new SqlCommand(updateUser, connection);
                    command.Parameters.AddWithValue("@ShuId", txtShuId.Text);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    command.Parameters.AddWithValue("@CourseDept", txtCourseDept.Text);
                    command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                    command.Parameters.AddWithValue("@FinishDate", finishDatePicker.Value);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The student account of " + prevName + " " + txtSurname.Text + " has been successfully updated.");
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
