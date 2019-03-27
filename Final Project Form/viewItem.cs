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
using System.Globalization;
namespace Final_Project_Form
{
    public partial class viewItem : Form
    {
        string resourceType, resourceName, department, Notes, dateAdded, SupplierSource;
        int maxLoanPeriod, id;
        long serialNumber;
        DataTable dt = new DataTable("Item History");
        DataTable dt2 = new DataTable("Item Loaner");
        private void viewItem_Load(object sender, EventArgs e)
        {
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand loadHistory = new SqlCommand("SELECT LoanNumber,LoanerID,LoanedBy,DateLoaned,ReturnDate,LoanDuration,BorrowerName," +
                "BorrowerID,BorrowerEmail FROM LoanHistory WHERE ResourceID=@resourceID", connection);
            loadHistory.Parameters.AddWithValue("@resourceID", id);
            SqlDataAdapter adapter = new SqlDataAdapter(loadHistory);
            adapter.Fill(dt);
            itemHistoryGridView.DataSource = dt;
            SqlCommand loadCurrentLoaner = new SqlCommand("SELECT LoanNumber,BorrowerName,BorrowerID,DateLoaned,DueDate,LoanedBy,Quantity" +
                " FROM Loans WHERE ResourceID=@resourceID", connection);
            loadCurrentLoaner.Parameters.AddWithValue("@resourceID", id);
            SqlDataAdapter adapter2 = new SqlDataAdapter(loadCurrentLoaner);
            adapter2.Fill(dt2);
            LoanedItemsGridView.DataSource = dt2;
            connection.Close();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        decimal purchasePrice;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtResourceName.Text.Equals(resourceName) && txtResourceType.Text.Equals(resourceType) && txtNotes.Text.Equals(Notes) && 
                (departmentsList.SelectedIndex == departmentsList.FindString(department)) && txtMaxLoanPeriod.Text.Equals(maxLoanPeriod.ToString()) 
                && txtPurchasePrice.Text.Equals(purchasePrice.ToString()) && txtSerialNo.Text.Equals(serialNumber.ToString()) && txtSupplierSource.Text.Equals(SupplierSource)))
            {
                MessageBox.Show("You have not changed any values!");
            }
            else
            {
                try
                {
                    string connectionString = myGlobals.connString;
                    string selectedDept = this.departmentsList.GetItemText(this.departmentsList.SelectedItem);
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string updateItem = "UPDATE resourcesTable SET ResourceType=@ResourceType, ResourceName=@ResourceName " +
                        ", Notes=@Notes, SerialNumber=@SerialNumber, SupplierSource=@SupplierSource,Department=@Department ," +
                        "PurchasePrice=@PurchasePrice, MaxLoanPeriod=@MaxLoanPeriod " +
                        " WHERE ResourceID=@ResourceID";
                    SqlCommand command = new SqlCommand(updateItem, connection);
                    command.Parameters.AddWithValue("@ResourceID", id);
                    command.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                    command.Parameters.AddWithValue("@ResourceName", textInfo.ToTitleCase(txtResourceName.Text));
                    command.Parameters.AddWithValue("@Notes", textInfo.ToTitleCase(txtNotes.Text));
                    command.Parameters.AddWithValue("@MaxLoanPeriod", textInfo.ToTitleCase(txtMaxLoanPeriod.Text));
                    command.Parameters.AddWithValue("@SerialNumber", textInfo.ToTitleCase(txtSerialNo.Text));
                    command.Parameters.AddWithValue("@SupplierSource", textInfo.ToTitleCase(txtSupplierSource.Text));
                    command.Parameters.AddWithValue("@PurchasePrice", textInfo.ToTitleCase(txtPurchasePrice.Text));
                    command.Parameters.AddWithValue("@Department", selectedDept);
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("The item ID: " + id +  " has been successfully updated.");
                    this.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtResourceType.ReadOnly = false;
            txtResourceName.ReadOnly = false;
            txtMaxLoanPeriod.ReadOnly = false;
            txtSerialNo.ReadOnly = false;
            txtSupplierSource.ReadOnly = false;
            txtPurchasePrice.ReadOnly = false;
            txtNotes.ReadOnly = false;

        } 
        public viewItem(string type, string name, int loanprd, string dept, 
            long serialNo, string dateAdd, string orderNo, decimal price, string notes, int ID)
        {
            InitializeComponent();
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string departmentCmd = "select * FROM departments";
            SqlCommand command = new SqlCommand(departmentCmd, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                departmentsList.Items.Add(reader.GetString(reader.GetOrdinal("Department")));
            }

            connection.Close();
            txtResourceType.Text = type;
            resourceType = type;
            txtResourceName.Text = name;
            resourceName = name;
            txtAddedBy.Text = currentUser.UserName;
            departmentsList.SelectedIndex = departmentsList.FindString(dept);
            department = dept;
            txtNotes.Text = notes;
            Notes = notes;
            txtDateAdded.Text = dateAdd;
            dateAdded = dateAdd;
            txtSerialNo.Text = serialNo.ToString();
            serialNumber = serialNo;
            txtSupplierSource.Text = orderNo.ToString();
            SupplierSource = orderNo;
            txtMaxLoanPeriod.Text = loanprd.ToString();
            maxLoanPeriod = loanprd;
            txtPurchasePrice.Text = price.ToString();
            purchasePrice = price;
            id = ID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
