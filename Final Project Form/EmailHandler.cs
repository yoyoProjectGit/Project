﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Final_Project_Form
{
    public partial class EmailHandler : Form
    {
		string emailAddress = "";
        findUserEmail findEmail = new findUserEmail();
        public EmailHandler(string email)
        {
            InitializeComponent();
			emailAddress = email;
        }

        private void emailHandler() //set up connection with gmail servers and credentials, and sending
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("shuemailreminder@gmail.com", "yoyoprojectpass22"),
                    EnableSsl = true
                };
                client.Send("shuemailreminder@gmail.com", txtToWho.Text, txtSubject.Text, txtBody.Text);
                MessageBox.Show("Email successfully delivered");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) //close form
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e) //check if all textboxes are filled.
        {
			if (txtBody.Text == "" || txtSubject.Text == "" || txtToWho.Text == "")
			{
				MessageBox.Show("Please fill in the missing fields.");
			}
			else
			{
				emailHandler();
			}
        }

        private void btnFindEmail_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "findUserEmail")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                findEmail.Show();
                this.Close();
            }
        }
        public string TextBoxValue
        {
            get { return txtToWho.Text; }
            set { txtToWho.Text = value; }
        }

		private void EmailHandler_Load(object sender, EventArgs e)
		{
			txtToWho.Text = emailAddress;
		}
	}
}
