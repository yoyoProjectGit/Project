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
        DataTable dt = new DataTable("Inventory");
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([ResourceID], System.String) LIKE '%" + txtResourceName.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
                    "SerialNumber,DateAdded,OrderNumber,PurchasePrice,Notes FROM resourcesTable", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                inventoryGridView.DataSource = dt;
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "View Info";
                button.Text = "View";
                button.UseColumnTextForButtonValue = true;
                inventoryGridView.Columns.Add(button);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtBarcode.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 || e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.inventoryGridView.Rows[e.RowIndex];
                var item = new currentItem();
                item.ResourceType = row.Cells["ResourceType"].Value.ToString();
                item.ResourceName = row.Cells["ResourceName"].Value.ToString();
                item.MaxLoanPeriod = (int)row.Cells["MaxLoanPeriod"].Value;
                item.Department = row.Cells["Department"].Value.ToString();
                item.SerialNumber = (long)row.Cells["SerialNumber"].Value;
                item.DateAdded = row.Cells["DateAdded"].Value.ToString();
                item.OrderNumber = row.Cells["OrderNumber"].Value.ToString();
                item.PurchasePrice = (decimal)row.Cells["PurchasePrice"].Value;
                item.Notes = row.Cells["Notes"].Value.ToString();
                item.ItemID = (int)row.Cells["ResourceID"].Value;
                viewItem viewInfo = new viewItem(item.ResourceType, item.ResourceName, item.MaxLoanPeriod,
                    item.Department, item.SerialNumber, item.DateAdded, item.OrderNumber,
                    item.PurchasePrice, item.Notes, item.ItemID);
                viewInfo.Show();
            }
            else
            {
                int columnIndex = e.ColumnIndex;
                MessageBox.Show("You have clicked column index " + columnIndex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            inventoryGridView.Refresh();
            string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
                    "SerialNumber,DateAdded,OrderNumber,PurchasePrice,Notes FROM resourcesTable", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            inventoryGridView.DataSource = dt;
            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.HeaderText = "View Info";
            //button.Text = "View";
            //button.UseColumnTextForButtonValue = true;
            //studentGridView.Columns.Add(button);
            connection.Close();
        }
    }
}
