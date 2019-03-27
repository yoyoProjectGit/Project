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
    public partial class ViewDisposedItems : Form
    {
        DataTable dt = new DataTable("Disposed Items");
        public ViewDisposedItems()
        {
            InitializeComponent();
        }

        private void ViewDisposedItems_Load(object sender, EventArgs e)
        {
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM disposedItems", connection);
            command.Parameters.AddWithValue("@Department", currentUser.Department);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            disposedItemsGridView.DataSource = dt;
            connection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
