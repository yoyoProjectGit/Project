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
        string resourceType, resourceName, department, Notes, dateAdded, orderNumber;
        int maxLoanPeriod, id;
        long serialNumber;
        decimal purchasePrice;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtResourceName.Text.Equals(resourceName) && txtResourceType.Text.Equals(resourceType) && txtNotes.Text.Equals(Notes) && 
                (departmentsList.SelectedIndex == departmentsList.FindString(department)) && txtMaxLoanPeriod.Text.Equals(maxLoanPeriod.ToString()) 
                && txtPurchasePrice.Text.Equals(purchasePrice.ToString()) && txtSerialNo.Text.Equals(serialNumber.ToString())))
            {
                MessageBox.Show("You have not changed any values!");
            }
            else
            {
               

                try
                {
                    string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                    string selectedDept = this.departmentsList.GetItemText(this.departmentsList.SelectedItem);
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string updateItem = "UPDATE resourcesTable SET ResourceType=@ResourceType, ResourceName=@ResourceName " +
                        ", Notes=@Notes, SerialNumber=@SerialNumber, OrderNumber=@OrderNumber,Department=@Department ,PurchasePrice=@PurchasePrice " +
                        " WHERE ResourceID=@ResourceID";
                    SqlCommand command = new SqlCommand(updateItem, connection);
                    command.Parameters.AddWithValue("@ResourceID", id);
                    command.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                    command.Parameters.AddWithValue("@ResourceName", textInfo.ToTitleCase(txtResourceName.Text));
                    command.Parameters.AddWithValue("@Notes", textInfo.ToTitleCase(txtNotes.Text));
                    command.Parameters.AddWithValue("@SerialNumber", textInfo.ToTitleCase(txtSerialNo.Text));
                    command.Parameters.AddWithValue("@OrderNumber", textInfo.ToTitleCase(txtOrderNum.Text));
                    command.Parameters.AddWithValue("@PurchasePrice", textInfo.ToTitleCase(txtPurchasePrice.Text));
                    command.Parameters.AddWithValue("@Department", selectedDept);
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("The item ID: " + id +  " has been successfully updated.");
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
            txtOrderNum.ReadOnly = false;
            txtPurchasePrice.ReadOnly = false;
            txtNotes.ReadOnly = false;

        } 
        public viewItem(string type, string name, int loanprd, string dept, 
            long serialNo, string dateAdd, string orderNo, decimal price, string notes, int ID)
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
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
            departmentsList.SelectedIndex = departmentsList.FindString(dept);
            department = dept;
            txtNotes.Text = notes;
            Notes = notes;
            txtDateAdded.Text = dateAdd;
            dateAdded = dateAdd;
            txtSerialNo.Text = serialNo.ToString();
            serialNumber = serialNo;
            txtOrderNum.Text = orderNo.ToString();
            orderNumber = orderNo;
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
