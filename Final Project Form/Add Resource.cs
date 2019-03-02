using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public partial class Add_Resource : Form
    {
        public Add_Resource()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            int caseNo = default;
            int parsedValue;
            if ((txtResourceType.Text).Equals("") || (txtResourceName.Text).Equals("") || (txtSerialNo.Text).Equals(""))
            {
                caseNo = 1;
            }
            if (departmentsList.SelectedItem == null)
            {
                caseNo = 2;
            }
            if ((txtLoanPeriod.Text).Equals("") || !int.TryParse(txtLoanPeriod.Text, out parsedValue))
            {
                caseNo = 3;
            }
            if ((txtQuantity.Text).Equals("") || !int.TryParse(txtQuantity.Text, out parsedValue))
            {
                caseNo = 4;
            }
            switch (caseNo)
            {
                case 1:
                    MessageBox.Show("You have not filled in an important field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 2:
                    MessageBox.Show("Please select your department!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;       
                case 3:
                    MessageBox.Show("A max loan period is required (amount of days)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 4:
                    MessageBox.Show("A quantity is required (Integer)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                default:
                    break;
            }
           
           try
           {
               DateTime dateTime = DateTime.Now;
               
               TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
               string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
               SqlConnection connection = new SqlConnection(connectionString);
               connection.Open();

                string addUserCommand = "insert into resourcesTable(ResourceType,ResourceName,Quantity,MaxLoanPeriod,OrderNumber," +
                "PurchasePrice,SerialNumber,Department,Notes,DateAdded,isOnLoan,AddedBy) " +
                            "values(@ResourceType,@ResourceName,@Quantity,@MaxLoanPeriod,@OrderNumber,@PurchasePrice,@SerialNumber," +
                            "@Department,@Notes,@DateAdded,@isOnLoan,@AddedBy)";
                SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                addCommand.Parameters.AddWithValue("@ResourceName", textInfo.ToTitleCase(txtResourceName.Text));
                addCommand.Parameters.AddWithValue("@Quantity", textInfo.ToTitleCase(txtQuantity.Text));
                addCommand.Parameters.AddWithValue("@MaxLoanPeriod", textInfo.ToTitleCase(txtLoanPeriod.Text));
                addCommand.Parameters.AddWithValue("@OrderNumber", textInfo.ToTitleCase(txtOrderNo.Text));
                addCommand.Parameters.AddWithValue("@PurchasePrice", textInfo.ToTitleCase(txtPurchasePrice.Text));
                addCommand.Parameters.AddWithValue("@SerialNumber", textInfo.ToTitleCase(txtSerialNo.Text));
                addCommand.Parameters.AddWithValue("@Department", textInfo.ToTitleCase(departmentsList.SelectedItem.ToString()));
                addCommand.Parameters.AddWithValue("@Notes", textInfo.ToTitleCase(txtNotes.Text));
                addCommand.Parameters.AddWithValue("@DateAdded", dateTime.ToString("yyyy-MM-dd H:mm:ss"));
                addCommand.Parameters.AddWithValue("@isOnLoan", false);
                addCommand.Parameters.AddWithValue("@AddedBy", CurrentUser.UserName);
                addCommand.ExecuteNonQuery();
                   AutoClosingMessageBox.Show("The item: " + txtResourceName.Text + " Quantity: " + txtQuantity.Text + " Max Loan Period: " + txtLoanPeriod.Text 
                       + " Serial No: " + txtSerialNo.Text +" has been successfully added to the inventory", "Add Resource ", 10000);
                   connection.Close();
                   this.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }

        private void Add_Resource_Load(object sender, EventArgs e)
        {
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
        }
    }
}
