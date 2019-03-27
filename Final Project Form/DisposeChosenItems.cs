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
    public partial class DisposeChosenItems : Form
    {
        int instock = 0;
        int Total = 0;
        int loanPrd = 0;
        int resourceID;
        decimal purchasePrice = 0;
        long serialNo;
        string addedBy,  dateAdded,  orderNo,  Notes;
        public DisposeChosenItems(string type, string name, int loanprd, int quantity, string dept, int ID, int total, string addedby,
            long serialno, string dateadded, string orderno, decimal purchaseprice, string notes)
        {
            InitializeComponent();
            txtDepartment.Text = dept;
            txtResourceName.Text = name;
            txtResourceType.Text = type;
            txtItemID.Text = ID.ToString();
            instock = quantity;
            Total = total;
            addedBy = addedby;
            serialNo = serialno;
            dateAdded = dateadded;
            orderNo = orderno;
            purchasePrice = purchaseprice;
            Notes = notes;
            loanPrd = loanprd;
            resourceID = ID;
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            if (txtMethodOfDisposal.Text == "" || txtQuantity.Text == "") 
            {
                MessageBox.Show("Quantity & Method of Disposal is required!");
            }
            else if (Convert.ToInt32(txtQuantity.Text) > instock)
            {
                MessageBox.Show("There is only " + instock + " of these in stock!");
            }
            else if (Convert.ToInt32(txtQuantity.Text).Equals(Total))
            {
                RemoveFromResources();
                AddToDisposedResources();
                AutoClosingMessageBox.Show("The item: " + txtResourceName.Text + " x" + txtQuantity.Text + " Has been successfully disposed", "Dispose Item ", 5000);
                this.Close();
            }
            else if(Convert.ToInt32(txtQuantity.Text) < Total)
            {
                RemoveFromResourceQuantity();
                AddToDisposedResources();
                AutoClosingMessageBox.Show("The item: " + txtResourceName.Text + " x" + txtQuantity.Text + " Has been successfully disposed", "Dispose Item ", 5000);
                this.Close();
            }
        }

        private void RemoveFromResources()
        {
            try
            { 
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeQuantityCommand = "DELETE FROM resourcesTable WHERE ResourceID=@ResourceID";
                SqlCommand remCommand = new SqlCommand(removeQuantityCommand, connection);
                remCommand.Parameters.AddWithValue("@ResourceID", resourceID);
                remCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }
        private void RemoveFromResourceQuantity()
        {
            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeQuantityCommand = "UPDATE resourcesTable SET InStock=@InStock, Total=@Total WHERE ResourceID=@ResourceID";
                SqlCommand remCommand = new SqlCommand(removeQuantityCommand, connection);
                remCommand.Parameters.AddWithValue("@ResourceID", resourceID);
                remCommand.Parameters.AddWithValue("@InStock", instock - quantity);
                remCommand.Parameters.AddWithValue("@Total", Total - quantity);
                remCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }
        private void AddToDisposedResources()
        {
            for (int i = 0; i < Convert.ToInt32(txtQuantity.Text); i++)
            {
                try
                {
                    DateTime todaysDate = DateTime.Now;
                    string connectionString = myGlobals.connString;
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string addtoDisposedCommand = "insert into disposedItems(ResourceType,ResourceName,MaxLoanPeriod,SupplierSource," +
                     "PurchasePrice,SerialNumber,Department,DisposalDate,MethodOfDisposal,DisposedBy,DisposalInfo,Notes,DateAdded,AddedBy) " +
                                 "values(@ResourceType,@ResourceName,@MaxLoanPeriod,@SupplierSource,@PurchasePrice,@SerialNumber," +
                                 "@Department,@DisposalDate,@MethodOfDisposal,@DisposedBy,@DisposalInfo,@Notes,@DateAdded,@AddedBy)";
                    SqlCommand command = new SqlCommand(addtoDisposedCommand, connection);
                    command.Parameters.AddWithValue("@ResourceType", txtResourceType.Text);
                    command.Parameters.AddWithValue("@ResourceName", txtResourceName.Text);
                    command.Parameters.AddWithValue("@MaxLoanPeriod", loanPrd);
                    command.Parameters.AddWithValue("@SupplierSource", orderNo);
                    command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                    command.Parameters.AddWithValue("@SerialNumber", serialNo);
                    command.Parameters.AddWithValue("@DisposalDate", todaysDate);
                    command.Parameters.AddWithValue("@MethodOfDisposal", txtMethodOfDisposal.Text);
                    command.Parameters.AddWithValue("@DisposedBy", currentUser.UserName);
                    command.Parameters.AddWithValue("@DisposalInfo", txtReason.Text);
                    command.Parameters.AddWithValue("@Notes", Notes);
                    command.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    command.Parameters.AddWithValue("@DateAdded", Convert.ToDateTime(dateAdded));
                    command.Parameters.AddWithValue("@AddedBy", addedBy);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
