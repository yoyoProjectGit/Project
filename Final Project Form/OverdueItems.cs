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
    public partial class OverdueItems : Form
    {
        DataTable dt = new DataTable("Overdue Loans");
        public OverdueItems()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OverdueItems_Load(object sender, EventArgs e)
        {
            string connectionString = myGlobals.connString;
            DateTime todaysDate = DateTime.Now;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ResourceType,ResourceName,DueDate,BorrowerEmail,LoanedBy,UserType,BorrowerName,DateLoaned," +
                "Department FROM Loans WHERE DueDate<@TodaysDate", connection);
            command.Parameters.AddWithValue("@TodaysDate", todaysDate);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            overdueItemsGridView.DataSource = dt;
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			button.HeaderText = "Send Email";
			button.Text = "Email";
			button.UseColumnTextForButtonValue = true;
			overdueItemsGridView.Columns.Add(button);
			connection.Close();
		}

		private void overdueItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9 || e.ColumnIndex == 0)
			{
				DataGridViewRow row = this.overdueItemsGridView.Rows[e.RowIndex];
				var borrower = new currentBorrower();
				borrower.EmailAddress = row.Cells["BorrowerEmail"].Value.ToString();
				EmailHandler emailBorrower = new EmailHandler(borrower.EmailAddress);
				emailBorrower.Show();
			}
		}
	}
}
