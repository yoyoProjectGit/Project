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

        private void btnAddResource_Click(object sender, EventArgs e) //buttonclick check if boxes contain data
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
           
           try //insert data into database
           {
               DateTime dateTime = DateTime.Now;
               
               TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
               string connectionString = myGlobals.connString;
               SqlConnection connection = new SqlConnection(connectionString);
               connection.Open();

                string addItemCommand = "insert into resourcesTable(ResourceType,ResourceName,InStock,MaxLoanPeriod,SupplierSource," +
                "PurchasePrice,SerialNumber,Department,Notes,DateAdded,AddedBy,Total) " +
							"values(@ResourceType,@ResourceName,@InStock,@MaxLoanPeriod,@SupplierSource,@PurchasePrice,@SerialNumber," +
                            "@Department,@Notes,@DateAdded,@AddedBy,@Total)";
                SqlCommand addCommand = new SqlCommand(addItemCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceType", textInfo.ToTitleCase(txtResourceType.Text));
                addCommand.Parameters.AddWithValue("@ResourceName", txtResourceName.Text);
                addCommand.Parameters.AddWithValue("@InStock", txtQuantity.Text);
                addCommand.Parameters.AddWithValue("@MaxLoanPeriod", textInfo.ToTitleCase(txtLoanPeriod.Text));
                addCommand.Parameters.AddWithValue("@SupplierSource", txtSupplierSource.Text);
                addCommand.Parameters.AddWithValue("@PurchasePrice", txtPurchasePrice.Text);
                addCommand.Parameters.AddWithValue("@SerialNumber",txtSerialNo.Text);
                addCommand.Parameters.AddWithValue("@Department", departmentsList.SelectedItem.ToString());
                addCommand.Parameters.AddWithValue("@Notes", txtNotes.Text);
                addCommand.Parameters.AddWithValue("@DateAdded", dateTime);
                addCommand.Parameters.AddWithValue("@AddedBy", currentUser.UserName);
                addCommand.Parameters.AddWithValue("@Total", txtQuantity.Text);
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

        private void Add_Resource_Load(object sender, EventArgs e) //form load fill departments combobox
        {
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
        }

		private void txtQuantity_TextChanged(object sender, EventArgs e) //only ints into textbox
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "  ^ [0-9]"))
			{
				txtQuantity.Text = "";
			}
		}

		private void txtLoanPeriod_TextChanged(object sender, EventArgs e) //only ints into textbox
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txtLoanPeriod.Text, "  ^ [0-9]"))
			{
				txtLoanPeriod.Text = "";
			}
		}

		private void txtSerialNo_TextChanged(object sender, EventArgs e) //only ints into textbox
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txtSerialNo.Text, "  ^ [0-9]"))
			{
				txtSerialNo.Text = "";
			}
		}

		private void txtPurchasePrice_TextChanged(object sender, EventArgs e) //only ints into textbox
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txtPurchasePrice.Text, "  ^ [0-9]"))
			{
				txtPurchasePrice.Text = "";
			}
		}

		private void txtLoanPeriod_KeyPress(object sender, KeyPressEventArgs e) //only ints into textbox
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e) //only ints into textbox
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		private void txtSerialNo_KeyPress(object sender, KeyPressEventArgs e) //only ints into textbox
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e) //only ints into textbox
		{
			char ch = e.KeyChar;
			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}
	}
}
