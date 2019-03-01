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
        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("CONVERT([SerialNumber], System.String) LIKE '%" + txtBarcode.Text + "%'");
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
                DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                dgvCmb.ValueType = typeof(bool);
                dgvCmb.Name = "Chk";
                dgvCmb.HeaderText = "Tick";
                inventoryGridView.Columns.Add(dgvCmb);
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
            foreach(DataGridViewRow item in inventoryGridView.Rows)
            {
                if(item.Cells[0].Value == null)
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
                }
            }
        }

        private void btnConfirmItems_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in pickedItemsGridView.Rows)
            {    
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
                LoanDurations viewInfo = new LoanDurations(item.ResourceType, item.ResourceName, item.MaxLoanPeriod,
                    item.Department, item.SerialNumber, item.DateAdded, item.OrderNumber,
                    item.PurchasePrice, item.Notes, item.ItemID);
                viewInfo.Show();
            }
        }
    }
}