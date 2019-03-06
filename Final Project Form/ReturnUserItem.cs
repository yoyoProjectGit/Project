﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Final_Project_Form
{
    public partial class ReturnUserItem : Form
    {
        string loanNumber;
        string resourceName;
        string resourceID;
        int resInt;
        DataTable dt = new DataTable("Inventory");
        public ReturnUserItem(string id, string firstname, string surname, string emailaddress)
        {
            InitializeComponent();
            txtCurrentId.Text = id;
            txtCurrentName.Text = firstname;
            txtCurrentSurname.Text = surname;
            txtCurrentEmail.Text = emailaddress;
            txtShuId2.Text = id;
            txtCurrentName2.Text = firstname;
            txtCurrentSurname2.Text = surname;
            txtCurrentEmail2.Text = emailaddress;
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
        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Copy DataGridViw " + ex);
            }
            return dgv_copy;
        }
        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.inventoryGridView.Rows[e.RowIndex];
            //dt.ImportRow(row);

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
                SqlCommand command = new SqlCommand("SELECT * FROM Loans WHERE BorrowerID=@ShuId", connection);
                command.Parameters.AddWithValue("@ShuId", txtCurrentId.Text);
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

        private void ReturnUserItem_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Chk";
                dgvCmb.HeaderText = "Choose";
                inventoryGridView.Columns.Add(dgvCmb);
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Loans WHERE BorrowerID=@ShuId", connection);
                command.Parameters.AddWithValue("@ShuId", txtCurrentId.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                inventoryGridView.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //foreach (DataGridViewColumn columns in inventoryGridView.Columns)
            //{
            //    pickedItemsGridView.Columns.Add((DataGridViewColumn)columns.Clone());
            //}
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

        private void btnLoanItems_Click(object sender, EventArgs e)
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
                    pickedItemsGridView.Rows[n].Cells[13].Value = item.Cells[14].Value.ToString();
                    pickedItemsGridView.Rows[n].Cells[14].Value = item.Cells[15].Value.ToString();
                }
            }
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnReturnItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in pickedItemsGridView.Rows)
            {
            addToLoanHistory(row);
            removeFromCurrentLoans(row);
            addToResources(row);
                AutoClosingMessageBox.Show("The item: " + resourceName +
                " Has been successfully returned", "Loan Item ", 5000);
            }

            this.Close();
        }
        private void addToLoanHistory(DataGridViewRow row)
        { 
            try
            {
                string DateLoaned = row.Cells["ResourceType"].Value.ToString();
                loanNumber = row.Cells["LoanNumber"].Value.ToString();
                resourceName = row.Cells["ResourceName"].Value.ToString();
                resourceID = row.Cells["ResourceID"].Value.ToString();
                resInt = Convert.ToInt32(resourceID);
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                DateTime returnDate = DateTime.Now;
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                connection.Open();
                string addUserCommand = "insert into LoanHistory(ResourceID,ResourceType,ResourceName,DateLoaned," +
                "LoanDuration,Department,BorrowerName,BorrowerID,BorrowerSurname,BorrowerEmail,Notes,LoanedBy,LoanNumber,LoanerID,ReturnDate) " +
                            "values(@ResourceID,@ResourceType,@ResourceName,@DateLoaned,@LoanDuration,@Department,@BorrowerName," +
                            "@BorrowerID,@BorrowerSurname,@BorrowerEmail,@Notes,@LoanedBy,@LoanNumber,@LoanerID,@ReturnDate)";
                SqlCommand addCommand = new SqlCommand(addUserCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceID", row.Cells["ResourceID"].Value.ToString());
                addCommand.Parameters.AddWithValue("@ResourceType", row.Cells["ResourceType"].Value.ToString());
                addCommand.Parameters.AddWithValue("@ResourceName", row.Cells["ResourceName"].Value.ToString());
                addCommand.Parameters.AddWithValue("@DateLoaned", row.Cells["DateLoaned"].Value.ToString());
                addCommand.Parameters.AddWithValue("@LoanDuration", row.Cells["LoanDuration"].Value.ToString());
                addCommand.Parameters.AddWithValue("@Department", row.Cells["Department"].Value.ToString());
                addCommand.Parameters.AddWithValue("@BorrowerName", row.Cells["BorrowerName"].Value.ToString());
                addCommand.Parameters.AddWithValue("@BorrowerID", row.Cells["BorrowerID"].Value.ToString());
                addCommand.Parameters.AddWithValue("@BorrowerSurname", row.Cells["BorrowerSurname"].Value.ToString());
                addCommand.Parameters.AddWithValue("@BorrowerEmail", row.Cells["BorrowerEmail"].Value.ToString());
                addCommand.Parameters.AddWithValue("@Notes", row.Cells["Notes"].Value.ToString());
                addCommand.Parameters.AddWithValue("@LoanedBy", row.Cells["LoanedBy"].Value.ToString());
                addCommand.Parameters.AddWithValue("@LoanNumber", row.Cells["LoanNumber"].Value.ToString());
                addCommand.Parameters.AddWithValue("@LoanerID", row.Cells["LoanerID"].Value.ToString());
                addCommand.Parameters.AddWithValue("@ReturnDate", returnDate.ToString("yyyy-MM-dd H:mm:ss"));
                addCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void removeFromCurrentLoans(DataGridViewRow row)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeResourceCommand = "DELETE FROM Loans WHERE LoanNumber=@LoanNumber";
                SqlCommand addCommand = new SqlCommand(removeResourceCommand, connection);
                addCommand.Parameters.AddWithValue("@LoanNumber", loanNumber);
                addCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addToResources(DataGridViewRow row)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string removeResourceCommand = "UPDATE resourcesTable SET isOnLoan=@isOnLoan WHERE ResourceID=@ResourceID";
                SqlCommand addCommand = new SqlCommand(removeResourceCommand, connection);
                addCommand.Parameters.AddWithValue("@ResourceID", resInt);
                addCommand.Parameters.AddWithValue("@isOnLoan", false);
                addCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
