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
    public partial class DisposeItem : Form
    {
        DataTable dt = new DataTable("Inventory");
        public DisposeItem()
        {
            InitializeComponent();
        }
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([ResourceName], System.String) LIKE '%" + txtResourceName.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }
        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtSerialNumber.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }

        private void btnOrderNo_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([SupplierSource], System.String) LIKE '%" + txtSupplierSource.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.DefaultView.RowFilter = string.Empty;
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
					"SerialNumber,DateAdded,SupplierSource,PurchasePrice,InStock,Notes,Total,addedBy " +
					"FROM resourcesTable WHERE Department=@Department AND InStock>0", connection);
            command.Parameters.AddWithValue("@Department", currentUser.Department);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            inventoryGridView.DataSource = dt;
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisposeItem_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Chk";
                dgvCmb.HeaderText = "Choose";
                inventoryGridView.Columns.Add(dgvCmb);
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
					"SerialNumber,DateAdded,SupplierSource,PurchasePrice,InStock,Notes,Total,addedBy " +
					"FROM resourcesTable WHERE Department=@Department AND InStock>0", connection);
                command.Parameters.AddWithValue("@Department", currentUser.Department);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                inventoryGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventoryGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (inventoryGridView.SelectedRows[0].Cells[0].Value == null)
            {
                inventoryGridView.SelectedRows[0].Cells[0].Value = false;
            }

            if ((bool)inventoryGridView.SelectedRows[0].Cells[0].Value == false)
            {
                inventoryGridView.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                inventoryGridView.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            pickedItemsGridView.Rows.Clear();
            foreach (DataGridViewRow item in inventoryGridView.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    item.Cells[0].Value = false;
                }
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = pickedItemsGridView.Rows.Add();
                    pickedItemsGridView.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[7].Value = item.Cells[8].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[8].Value = item.Cells[9].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[9].Value = item.Cells[10].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[10].Value = item.Cells[11].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[11].Value = item.Cells[12].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[12].Value = item.Cells[13].Value.ToString();
                }
            }
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnConfirmItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in pickedItemsGridView.Rows)
            {   //string maxprd = row.Cells["MaxLoanPeriod"].Value.ToString();
                int maxprd = 0;
                int resourceid = 0;
                int quantity = 0;
                int total = 0;
                Int32.TryParse(row.Cells["MaxLoanPeriod"].Value.ToString(), out maxprd);
                Int32.TryParse(row.Cells["ResourceID"].Value.ToString(), out resourceid);
                Int32.TryParse(row.Cells["InStock"].Value.ToString(), out quantity);
                Int32.TryParse(row.Cells["Total"].Value.ToString(), out total);
                long SerialNo = Convert.ToInt64(row.Cells["SerialNumber"].Value.ToString());
                long PurchasePrice = Convert.ToInt64(row.Cells["PurchasePrice"].Value.ToString());
                decimal decPurchasePrice = Convert.ToDecimal(PurchasePrice);
                //MessageBox.Show(maxprd);
                var item = new currentItem();
                item.ResourceType = row.Cells["ResourceType"].Value.ToString();
                item.ResourceName = row.Cells["ResourceName"].Value.ToString();
                item.MaxLoanPeriod = maxprd;
                item.Department = row.Cells["Department"].Value.ToString();
                item.Quantity = quantity;
                item.SerialNumber = SerialNo;
                item.DateAdded = row.Cells["DateAdded"].Value.ToString();
                item.SupplierSource = row.Cells["SupplierSource"].Value.ToString();
                item.PurchasePrice = decPurchasePrice;
                item.Notes = row.Cells["Notes"].Value.ToString();
                item.ItemID = resourceid;
                item.Total = total;
                item.AddedBy = row.Cells["AddedBy"].Value.ToString();
                DisposeChosenItems chosenItems = new DisposeChosenItems(item.ResourceType, item.ResourceName, item.MaxLoanPeriod,
                    item.Quantity, item.Department, item.ItemID, item.Total, item.AddedBy, item.SerialNumber, item.DateAdded, item.SupplierSource,item.PurchasePrice,
                    item.Notes);
                chosenItems.Show();

            }
            this.Close();
        }

    }
}
