using MySql.Data.MySqlClient;
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
    public partial class loginForm : Form
    {
		public loginForm()
        {
            InitializeComponent();
		}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
			{ 
            string connectionString = myGlobals.connString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            AutoClosingMessageBox.Show("Attempting To Log In", "Logging In", 1000);
            SqlCommand command = new SqlCommand("select username,password from userLogins where username=@username and password=@password", connection);
            command.Parameters.AddWithValue("@username", txtUser.Text);
            command.Parameters.AddWithValue("@password", txtPass.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                    AutoClosingMessageBox.Show("Login Successful", "Logging In", 1000);
                    SqlCommand getUser = new SqlCommand("select department,uid from userLogins where username=@username", connection);
                    getUser.Parameters.AddWithValue("@username", txtUser.Text);
                    using (var reader = getUser.ExecuteReader())
                    {
                        while (reader.Read())
                        {  
                            currentUser.Department = reader[0].ToString();
                            currentUser.UserID = reader[1].ToString();
                        }
                    }
                    mainMenu mainMenu = new mainMenu();
                    this.Hide();
                    mainMenu.Show();
                    connection.Close();
            }
            else
            {
                AutoClosingMessageBox.Show("Invalid Username Or Password", "Login Failed", 1000);
				connection.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
