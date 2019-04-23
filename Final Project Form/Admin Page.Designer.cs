namespace Final_Project_Form
{
	partial class Admin_Page
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
			this.btnStaffAccounts = new System.Windows.Forms.Button();
			this.btnAdminAccount = new System.Windows.Forms.Button();
			this.btnStaffMembers = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddStaffAccount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStaffAccounts
			// 
			this.btnStaffAccounts.Location = new System.Drawing.Point(12, 12);
			this.btnStaffAccounts.Name = "btnStaffAccounts";
			this.btnStaffAccounts.Size = new System.Drawing.Size(103, 61);
			this.btnStaffAccounts.TabIndex = 0;
			this.btnStaffAccounts.Text = "Staff Accounts";
			this.btnStaffAccounts.UseVisualStyleBackColor = true;
			this.btnStaffAccounts.Click += new System.EventHandler(this.btnStaffAccounts_Click);
			// 
			// btnAdminAccount
			// 
			this.btnAdminAccount.Location = new System.Drawing.Point(124, 12);
			this.btnAdminAccount.Name = "btnAdminAccount";
			this.btnAdminAccount.Size = new System.Drawing.Size(103, 61);
			this.btnAdminAccount.TabIndex = 1;
			this.btnAdminAccount.Text = "Admin Account";
			this.btnAdminAccount.UseVisualStyleBackColor = true;
			this.btnAdminAccount.Click += new System.EventHandler(this.btnAdminAccount_Click);
			// 
			// btnStaffMembers
			// 
			this.btnStaffMembers.Location = new System.Drawing.Point(12, 79);
			this.btnStaffMembers.Name = "btnStaffMembers";
			this.btnStaffMembers.Size = new System.Drawing.Size(103, 61);
			this.btnStaffMembers.TabIndex = 2;
			this.btnStaffMembers.Text = "Staff Members";
			this.btnStaffMembers.UseVisualStyleBackColor = true;
			this.btnStaffMembers.Click += new System.EventHandler(this.btnStaffMembers_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(77, 152);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(83, 51);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddStaffAccount
			// 
			this.btnAddStaffAccount.Location = new System.Drawing.Point(124, 79);
			this.btnAddStaffAccount.Name = "btnAddStaffAccount";
			this.btnAddStaffAccount.Size = new System.Drawing.Size(103, 61);
			this.btnAddStaffAccount.TabIndex = 4;
			this.btnAddStaffAccount.Text = "Add Staff Account";
			this.btnAddStaffAccount.UseVisualStyleBackColor = true;
			this.btnAddStaffAccount.Click += new System.EventHandler(this.btnAddStaffAccount_Click);
			// 
			// Admin_Page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 218);
			this.Controls.Add(this.btnAddStaffAccount);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnStaffMembers);
			this.Controls.Add(this.btnAdminAccount);
			this.Controls.Add(this.btnStaffAccounts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Admin_Page";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin_Page";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStaffAccounts;
		private System.Windows.Forms.Button btnAdminAccount;
		private System.Windows.Forms.Button btnStaffMembers;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAddStaffAccount;
	}
}