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
		int totalItems = 0;
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
				totalItems = 0;
				DataGridViewButtonColumn button = new DataGridViewButtonColumn();
				button.HeaderText = "View Item";
				button.Text = "View";
				button.UseColumnTextForButtonValue = true;
				loanedItemsGridView.Columns.Add(button);
				string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceType,ResourceName,SerialNumber,Quantity,LoanedBy," +
					"BorrowerName,UserType,BorrowerSurname,BorrowerID,BorrowerEmail,Department,DateLoaned,DueDate,LoanDuration," +
					"ScannableNum,Notes,LoanID,ResourceID FROM Loans", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                loanedItemsGridView.DataSource = dt;
                connection.Close();
				foreach (DataGridViewRow row in loanedItemsGridView.Rows)
				{
					totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
				}
				lblTotalItems.Text = "Total Individual Items In Table: " + totalItems;
				int count = loanedItemsGridView.Rows.Count;
				lblTotalRows.Text = "Total Rows In Table: " + count;
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loanedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.loanedItemsGridView.Rows[e.RowIndex];
                int resourceID = Convert.ToInt32(row.Cells["ResourceID"].Value.ToString());
                viewLoanedItem viewInfo = new viewLoanedItem(resourceID);
                viewInfo.Show();
            }
        }

		private void btnSearchName_Click(object sender, EventArgs e)
		{
			totalItems = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([ResourceName], System.String) LIKE '%" + txtResourceName.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanedItemsGridView.Rows)
			{
				totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items On Loan: " + totalItems;
			int count = loanedItemsGridView.Rows.Count;
			lblTotalRows.Text = "Total Rows In Table: " + count;
		}
		private void btnSearchBarcode_Click(object sender, EventArgs e)
		{
			totalItems = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtSerialNo.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanedItemsGridView.Rows)
			{
				totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items On Loan: " + totalItems;
			int count = loanedItemsGridView.Rows.Count;
			lblTotalRows.Text = "Total Rows In Table: " + count;
		}
		private void btnShuId_Click(object sender, EventArgs e)
		{
			totalItems = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([BorrowerID], System.String) LIKE '%" + txtShuID.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanedItemsGridView.Rows)
			{
				totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items On Loan: " + totalItems;
			int count = loanedItemsGridView.Rows.Count;
			lblTotalRows.Text = "Total Rows In Table: " + count;
		}

		private void btnResourceType_Click(object sender, EventArgs e)
		{
			totalItems = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([ResourceType], System.String) LIKE '%" + txtResourceType.Text + "%'");
			loanedItemsGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanedItemsGridView.Rows)
			{
				totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items On Loan: " + totalItems;
			int count = loanedItemsGridView.Rows.Count;
			lblTotalRows.Text = "Total Rows In Table: " + count;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			try
			{
				totalItems = 0;
				dt.Clear();
				dt.DefaultView.RowFilter = string.Empty;
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT ResourceType,ResourceName,SerialNumber,Quantity,LoanedBy," +
					"BorrowerName,UserType,BorrowerSurname,BorrowerID,BorrowerEmail,Department,DateLoaned,DueDate,LoanDuration," +
					"ScannableNum,Notes,LoanID,ResourceID FROM Loans", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(dt);
				loanedItemsGridView.DataSource = dt;
				connection.Close();
				foreach (DataGridViewRow row in loanedItemsGridView.Rows)
				{
					totalItems += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
				}
				lblTotalItems.Text = "Total Individual Items On Loan: " + totalItems;
				int count = loanedItemsGridView.Rows.Count;
				lblTotalRows.Text = "Total Rows In Table: " + count;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
