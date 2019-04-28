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
    public partial class Inventory : Form
    {
		int totalInStock = 0;
        DataTable dt = new DataTable("Inventory");
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
				totalInStock = 0;
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
                    "SerialNumber,DateAdded,SupplierSource,PurchasePrice,Notes,InStock,Total,AddedBy FROM resourcesTable WHERE Department=@Department", connection);
                command.Parameters.AddWithValue("@Department", currentUser.Department);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                inventoryGridView.DataSource = dt;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "View Info";
                button.Text = "View";
                button.UseColumnTextForButtonValue = true;
                inventoryGridView.Columns.Add(button);
                inventoryGridView.Columns[0].Visible = false;
                inventoryGridView.Columns[3].Visible = false;
                inventoryGridView.Columns[4].Visible = false;
                inventoryGridView.Columns[7].Visible = false;
                inventoryGridView.Columns[8].Visible = false;
				inventoryGridView.Columns[12].Visible = false;
				connection.Close();
				foreach(DataGridViewRow row in inventoryGridView.Rows)
				{
					totalInStock +=Convert.ToInt32(row.Cells["InStock"].Value.ToString());
				}
				lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
				int count = inventoryGridView.Rows.Count;
				lblTotalRows.Text = "Total Resources: " + count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13 || e.ColumnIndex == 0)
            {
				int indexRow = e.RowIndex;
				if (indexRow >= 0)
				{
					DataGridViewRow row = this.inventoryGridView.Rows[e.RowIndex];
					var item = new currentItem();
					item.ResourceType = row.Cells["ResourceType"].Value.ToString();
					item.ResourceName = row.Cells["ResourceName"].Value.ToString();
					item.MaxLoanPeriod = (int)row.Cells["MaxLoanPeriod"].Value;
					item.Department = row.Cells["Department"].Value.ToString();
					item.SerialNumber = (long)row.Cells["SerialNumber"].Value;
					item.DateAdded = row.Cells["DateAdded"].Value.ToString();
					item.SupplierSource = row.Cells["SupplierSource"].Value.ToString();
					item.PurchasePrice = (decimal)row.Cells["PurchasePrice"].Value;
					item.Notes = row.Cells["Notes"].Value.ToString();
					item.ItemID = (int)row.Cells["ResourceID"].Value;
					item.AddedBy = row.Cells["AddedBy"].Value.ToString();
					viewItem viewInfo = new viewItem(item.ResourceType, item.ResourceName, item.MaxLoanPeriod,
						item.Department, item.SerialNumber, item.DateAdded, item.SupplierSource,
						item.PurchasePrice, item.Notes, item.ItemID,item.AddedBy);
					viewInfo.Show();
				}
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
			totalInStock = 0;
			dt.Clear();
            dt.DefaultView.RowFilter = string.Empty;
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
			SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
				"SerialNumber,DateAdded,SupplierSource,PurchasePrice,Notes,InStock,Total,AddedBy FROM resourcesTable WHERE Department=@Department", connection);
			command.Parameters.AddWithValue("@Department", currentUser.Department);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            inventoryGridView.DataSource = dt;
            connection.Close();
			foreach (DataGridViewRow row in inventoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["InStock"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = inventoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}
		private void btnSearchBarcode_Click(object sender, EventArgs e)
		{
			totalInStock = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtBarcode.Text + "%'");
			inventoryGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in inventoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["InStock"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = inventoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}

		private void btnSearchName_Click(object sender, EventArgs e)
		{
			totalInStock = 0;
			DataView dv = dt.DefaultView;
			dv.RowFilter = string.Format("CONVERT([ResourceName], System.String) LIKE '%" + txtResourceName.Text + "%'");
			inventoryGridView.DataSource = dv.ToTable();
			foreach (DataGridViewRow row in inventoryGridView.Rows)
			{
				totalInStock += Convert.ToInt32(row.Cells["InStock"].Value.ToString());
			}
			lblTotalItems.Text = "Total Individual Items In Table: " + totalInStock;
			int count = inventoryGridView.Rows.Count;
			lblTotalRows.Text = "Total Resources: " + count;
		}

	}
}
