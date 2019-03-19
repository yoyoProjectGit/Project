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
    public partial class viewLoanedItem : Form
    {
        DataTable dt = new DataTable("Loaned Items History");
        string loanNumber;
        int resourceID;
        string resourceType;
        string resourceName;
        int maxLoanPeriod;
        string orderNumber;
        decimal purchasePrice;
        long serialNumber;
        string department;
        string notes;
        string dateAdded;
        string addedBy;
        public viewLoanedItem(string loanNum, int resourceId)
        {
            InitializeComponent();
            loanNumber = loanNum;
            resourceID = resourceId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewLoanedItem_Load(object sender, EventArgs e)
        {
            getData();
            fillData();
            loadItemHistory();
        }
        private void getData()
        {
            try
            {
                string connectionString = myGlobals.connString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand checkId = new SqlCommand("SELECT * FROM resourcesTable WHERE ResourceID=@resourceID", connection);
                checkId.Parameters.AddWithValue("@resourceID", resourceID);  
                using (SqlDataReader getData = checkId.ExecuteReader())
                {
                    while (getData.Read())
                    {
                        resourceType = getData["ResourceType"].ToString();
                        resourceName = getData["ResourceName"].ToString();
                        maxLoanPeriod = Convert.ToInt32(getData["MaxLoanPeriod"].ToString());
                        orderNumber = getData["OrderNumber"].ToString();
                        purchasePrice = Convert.ToInt32(getData["purchasePrice"].ToString());
                        serialNumber = Convert.ToInt32(getData["serialNumber"].ToString());
                        department = getData["Department"].ToString();
                        notes = getData["Notes"].ToString();
                        dateAdded = getData["DateAdded"].ToString();
                        addedBy = getData["AddedBy"].ToString();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        private void fillData()
        {
            txtResourceType.Text = resourceType;
            txtResourceName.Text = resourceName;
            txtAddedBy.Text = addedBy;
            txtDepartment.Text = department;
            txtNotes.Text = notes;
            txtDateAdded.Text = dateAdded;
            txtSerialNo.Text = serialNumber.ToString();
            txtOrderNum.Text = orderNumber;
            txtMaxLoanPeriod.Text = maxLoanPeriod.ToString();
            txtPurchasePrice.Text = purchasePrice.ToString();
        }
        private void loadItemHistory()
        {
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand loadHistory = new SqlCommand("SELECT LoanNumber,LoanerID,LoanedBy,DateLoaned,ReturnDate,LoanDuration,BorrowerName," +
                "BorrowerID,BorrowerEmail FROM LoanHistory WHERE ResourceID=@resourceID", connection);
            loadHistory.Parameters.AddWithValue("@resourceID", resourceID);
            SqlDataAdapter adapter = new SqlDataAdapter(loadHistory);
            adapter.Fill(dt);
            itemHistoryGridView.DataSource = dt;
            connection.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
