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

            string connectionString = "Data Source=DESKTOP-BV5T9NA;Initial Catalog=ProjectDB;Integrated Security=True";
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
                    SqlCommand getUser = new SqlCommand("select name, department,uid from userLogins where username=@username", connection);
                    getUser.Parameters.AddWithValue("@username", txtUser.Text);
                    using (var reader = getUser.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CurrentUser.UserName = reader[0].ToString();
                            CurrentUser.Department = reader[1].ToString();
                            CurrentUser.UserID = reader[2].ToString();
                        }
                    }
                    mainMenu mainMenu = new mainMenu();
                    this.Hide();
                    mainMenu.Show();
                    connection.Close();
            }
            else
            {
                AutoClosingMessageBox.Show("Invalid Username Or Password", "Logging Failed", 1000);
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
