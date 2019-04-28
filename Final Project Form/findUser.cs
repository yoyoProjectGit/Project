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
            if (e.ColumnIndex == 9 || e.ColumnIndex == 0)
            {
				int indexRow = e.RowIndex;
				if (indexRow >= 0)
				{
					DataGridViewRow row = this.studentGridView.Rows[e.RowIndex];
					var borrower = new currentBorrower();
					borrower.ShuId = row.Cells["ShuId"].Value.ToString();
					borrower.FirstName = row.Cells["FirstName"].Value.ToString();
					borrower.Surname = row.Cells["Surname"].Value.ToString();
					borrower.CourseDept = row.Cells["CourseDept"].Value.ToString();
					borrower.EmailAddress = row.Cells["EmailAddress"].Value.ToString();
					borrower.DateCreated = row.Cells["DateAdded"].Value.ToString();
					borrower.StartDate = row.Cells["StartDate"].Value.ToString();
					borrower.UserType = row.Cells["UserType"].Value.ToString();
					borrower.ScannableNum = row.Cells["ScannableNum"].Value.ToString();
					viewStudentInfo viewInfo = new viewStudentInfo(borrower.ShuId, borrower.FirstName, borrower.Surname,
						borrower.CourseDept, borrower.EmailAddress, borrower.DateCreated, borrower.StartDate, borrower.UserType, borrower.ScannableNum);
					viewInfo.Show();
				}
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

		private void btnScanID_Click(object sender, EventArgs e)
		{
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("ScannableNum LIKE '%" + txtScanID.Text + "%'");
			studentGridView.DataSource = dv.ToTable();
		}
	}
}
