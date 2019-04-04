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
	public partial class LoanHistory : Form
	{
		DataTable dt = new DataTable("Loan History");
		int totalInStock = 0;
		public LoanHistory()
		{
			InitializeComponent();
		}

		private void LoanHistory_Load(object sender, EventArgs e)
		{
			try
			{
				totalInStock = 0;
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("Select * FROM LoanHistory", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(dt);
				loanHistoryGridView.DataSource = dt;
				connection.Close();
				foreach (DataGridViewRow row in loanHistoryGridView.Rows)
				{
					totalInStock += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
				}
				lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
				int count = loanHistoryGridView.Rows.Count;
				lblTotalRows.Text = "Total Resources: " + count;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSearchName_Click(object sender, EventArgs e)
		{
			totalInStock = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([ResourceName], System.String) LIKE '%" + txtResourceName.Text + "%'");
			loanHistoryGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanHistoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = loanHistoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}
		private void btnShuId_Click(object sender, EventArgs e)
		{
			totalInStock = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([BorrowerID], System.String) LIKE '%" + txtShuID.Text + "%'");
			loanHistoryGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanHistoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = loanHistoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}

		private void btnResourceType_Click(object sender, EventArgs e)
		{
			totalInStock = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([ResourceType], System.String) LIKE '%" + txtResourceType.Text + "%'");
			loanHistoryGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in loanHistoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = loanHistoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			try
			{
				totalInStock = 0;
				dt.Clear();
				dt.DefaultView.RowFilter = string.Empty;
				string connectionString = myGlobals.connString;
				SqlConnection connection = new SqlConnection(connectionString);
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM LoanHistory", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(dt);
				loanHistoryGridView.DataSource = dt;
				connection.Close();
				foreach (DataGridViewRow row in loanHistoryGridView.Rows)
				{
					totalInStock += Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
				}
				lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
				int count = loanHistoryGridView.Rows.Count;
				lblTotalRows.Text = "Total Resources: " + count;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
