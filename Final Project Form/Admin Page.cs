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
	public partial class Admin_Page : Form
	{
		public Admin_Page()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnStaffMembers_Click(object sender, EventArgs e)
		{

		}

		private void btnStaffAccounts_Click(object sender, EventArgs e)
		{
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "StaffAccounts")
				{
					isOpen = true;
					f.BringToFront();
					break;
				}
			}
			if (isOpen == false)
			{
				StaffAccounts staffacc = new StaffAccounts();
				staffacc.Show();
			}
		}
	}
}
