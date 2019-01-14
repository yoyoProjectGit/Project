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
    public partial class LoanUserItem : Form
    {
        DataTable dt = new DataTable("Inventory");
        public LoanUserItem(string id, string firstname, string surname, string emailaddress)
        {
            InitializeComponent();
            txtCurrentId.Text = id;
            txtCurrentName.Text = firstname;
            txtCurrentSurname.Text = surname;
            txtCurrentEmail.Text = emailaddress;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtBarcode.Text + "%'");
            inventoryGridView.DataSource = dv.ToTable();
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pickedItemsGridView.Rows.Add(this.inventoryGridView.Rows[e.RowIndex].Clone());
            //foreach (DataGridViewRow r in inventoryGridView.Rows[e.RowIndex])
            //{
            //    int index = pickedItemsGridView.Rows.Add(r.Clone() as DataGridViewRow);
            //    foreach (DataGridViewCell o in r.Cells)
            //    {
            //        pickedItemsGridView.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
            //    }
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.DefaultView.RowFilter = string.Empty;
            inventoryGridView.Refresh();
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
                                    "SerialNumber,DateAdded,OrderNumber,PurchasePrice,Notes FROM resourcesTable WHERE Department=@Department", connection);
                command.Parameters.AddWithValue("@Department", CurrentUser.Department);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                inventoryGridView.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoanUserItem_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ResourceID,ResourceType,ResourceName,MaxLoanPeriod,Department," +
                    "SerialNumber,DateAdded,OrderNumber,PurchasePrice,Notes FROM resourcesTable WHERE Department=@Department", connection);
                command.Parameters.AddWithValue("@Department", CurrentUser.Department);
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
            foreach (DataGridViewColumn columns in inventoryGridView.Columns)
            {
                pickedItemsGridView.Columns.Add((DataGridViewColumn)columns.Clone());
            }
        }
    }
}
