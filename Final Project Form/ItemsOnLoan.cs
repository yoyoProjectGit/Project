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
    public partial class ItemsOnLoan : Form
    {
        DataTable dt = new DataTable("Loaned Items");
        public ItemsOnLoan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemsOnLoan_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Loans", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                loanedItemsGridView.DataSource = dt;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "View Info";
                button.Text = "View";
                button.UseColumnTextForButtonValue = true;
                loanedItemsGridView.Columns.Add(button);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loanedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16 || e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.loanedItemsGridView.Rows[e.RowIndex];
                string loanNumber = row.Cells["LoanNumber"].Value.ToString();
                int resourceID = Convert.ToInt32(row.Cells["ResourceID"].Value.ToString());
                viewLoanedItem viewInfo = new viewLoanedItem(loanNumber,resourceID);
                viewInfo.Show();
            }
        }
    }
}
