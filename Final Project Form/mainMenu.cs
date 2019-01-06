using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Form
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            AutoClosingMessageBox.Show("Attempting To Log Out", "Logging Out", 1000);
            this.Close();
            loginForm.Show();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "loginForm")
                    Application.OpenForms[i].Close();
            }
            AutoClosingMessageBox.Show("Successfully Logged Out", "Logging Out", 1000);
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if (f.Text== "AddUser")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddUser addUser = new AddUser();
                addUser.Show();
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Find User")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                findUser findUser = new findUser();
                findUser.Show();
            }

        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Inventory")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                Inventory inventory = new Inventory();
                inventory.Show();
            }

        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "searchItem")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                searchItem searchItem = new searchItem();
                searchItem.Show();
            }

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Add Resource")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                Add_Resource addResource = new Add_Resource();
                addResource.Show();
            }

        }

        private void btnOverdueItems_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "OverdueItems")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                OverdueItems overdueItems = new OverdueItems();
                overdueItems.Show();
            }

        }

        private void btnEmails_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "EmailHandler")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                EmailHandler emailhandler = new EmailHandler();
                emailhandler.Show();
            }

        }

        private void btnItemsOnLoan_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ItemsOnLoan")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                ItemsOnLoan itemsOnLoan = new ItemsOnLoan();
                itemsOnLoan.Show();
            }

        }
    }
}
