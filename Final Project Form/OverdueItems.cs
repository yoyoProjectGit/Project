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
            SqlCommand command = new SqlCommand("SELECT ResourceType, ResourceName, DueDate, BorrowerEmail, LoanedBy, BorrowerName, LoanNumber, DateLoaned," +
                "Department FROM Loans WHERE DueDate<@TodaysDate", connection);
            command.Parameters.AddWithValue("@TodaysDate", todaysDate);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            overdueItemsGridView.DataSource = dt;
            //this.overdueItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
