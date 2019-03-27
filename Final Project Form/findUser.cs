using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Final_Project_Form
{
    public partial class findUser : Form 
    {
        DataTable dt = new DataTable("Students");
        public findUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchShu_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ShuId LIKE '%" + txtShuId.Text + "%'");
            studentGridView.DataSource = dv.ToTable();
        }

        private void findUser_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM students", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                studentGridView.DataSource = dt;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "View Info";
                button.Text = "View";
                button.UseColumnTextForButtonValue = true;
                studentGridView.Columns.Add(button);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchSurname_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("surname LIKE '%" + txtSurname.Text + "%'");
            studentGridView.DataSource = dv.ToTable();
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.studentGridView.Rows[e.RowIndex];
                var student = new currentBorrower();
                student.ShuId = row.Cells["ShuId"].Value.ToString();
                student.FirstName = row.Cells["FirstName"].Value.ToString();
                student.Surname = row.Cells["Surname"].Value.ToString();
                student.CourseDept = row.Cells["CourseDept"].Value.ToString();
                student.EmailAddress = row.Cells["EmailAddress"].Value.ToString();
                student.DateCreated = row.Cells["DateAdded"].Value.ToString();
                student.FinishDate = row.Cells["FinishDate"].Value.ToString();
                viewStudentInfo viewInfo = new viewStudentInfo(student.ShuId, student.FirstName, student.Surname,
                    student.CourseDept, student.EmailAddress, student.DateCreated, student.FinishDate);
                viewInfo.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.DefaultView.RowFilter = string.Empty;
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM students", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            studentGridView.DataSource = dt;
            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.HeaderText = "View Info";
            //button.Text = "View";
            //button.UseColumnTextForButtonValue = true;
            //studentGridView.Columns.Add(button);
            connection.Close();
        }
    }
}
