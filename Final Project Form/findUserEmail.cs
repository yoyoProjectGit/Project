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
    public partial class findUserEmail : Form
    {
        public string ReturnEmail { get; set; }
        DataTable dt = new DataTable("Students");
        public findUserEmail()
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

        private void findUserEmail_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM students", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                studentGridView.DataSource = dt;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Get Email";
                button.Text = "Get Email";
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
                EmailHandler emailhandler = new EmailHandler();
                DataGridViewRow row = this.studentGridView.Rows[e.RowIndex];
                var student = new currentStudent();
                student.EmailAddress = row.Cells["EmailAddress"].Value.ToString();
                //this.ReturnEmail = student.EmailAddress;
                emailhandler.TextBoxValue = student.EmailAddress;
                emailhandler.Show();
                this.Close();
         //       emailReturn();
            }
        }

    }
}
