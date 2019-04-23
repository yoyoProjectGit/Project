namespace Final_Project_Form
{
	partial class AddStaffAccount
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffAccount));
			this.label1 = new System.Windows.Forms.Label();
			this.departmentsList = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Staff Account";
			// 
			// departmentsList
			// 
			this.departmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.departmentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.departmentsList.FormattingEnabled = true;
			this.departmentsList.Location = new System.Drawing.Point(150, 53);
			this.departmentsList.Name = "departmentsList";
			this.departmentsList.Size = new System.Drawing.Size(217, 33);
			this.departmentsList.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 24);
			this.label7.TabIndex = 40;
			this.label7.Text = "Username:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(10, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 39;
			this.label8.Text = "Department:";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(150, 100);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(217, 31);
			this.txtUsername.TabIndex = 24;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(448, 93);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(97, 55);
			this.btnClose.TabIndex = 38;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(448, 28);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(97, 58);
			this.btnAddUser.TabIndex = 34;
			this.btnAddUser.Text = "Add Account";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(10, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 24);
			this.label9.TabIndex = 29;
			this.label9.Text = "Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(150, 143);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(217, 31);
			this.txtPassword.TabIndex = 25;
			// 
			// checkBoxShowPass
			// 
			this.checkBoxShowPass.AutoSize = true;
			this.checkBoxShowPass.Location = new System.Drawing.Point(382, 154);
			this.checkBoxShowPass.Name = "checkBoxShowPass";
			this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
			this.checkBoxShowPass.TabIndex = 89;
			this.checkBoxShowPass.Text = "Show Password";
			this.checkBoxShowPass.UseVisualStyleBackColor = true;
			this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
			// 
			// AddStaffAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 192);
			this.Controls.Add(this.checkBoxShowPass);
			this.Controls.Add(this.departmentsList);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddStaffAccount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddStaffAccount";
			this.Load += new System.EventHandler(this.AddStaffAccount_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox departmentsList;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.CheckBox checkBoxShowPass;
	}
}