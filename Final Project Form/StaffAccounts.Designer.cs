namespace Final_Project_Form
{
	partial class StaffAccounts
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
			System.Windows.Forms.Label label9;
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnClose = new System.Windows.Forms.Button();
			this.staffGridView = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.departmentsList = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.btnBackToLoan = new System.Windows.Forms.Button();
			label9 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.staffGridView)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label9.Location = new System.Drawing.Point(21, 20);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(151, 25);
			label9.TabIndex = 2;
			label9.Text = "Staff Accounts";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(547, 325);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnClose);
			this.tabPage1.Controls.Add(label9);
			this.tabPage1.Controls.Add(this.staffGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(539, 299);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Staff Members";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(437, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 39);
			this.btnClose.TabIndex = 64;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// staffGridView
			// 
			this.staffGridView.AllowUserToAddRows = false;
			this.staffGridView.AllowUserToDeleteRows = false;
			this.staffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.staffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.staffGridView.Location = new System.Drawing.Point(3, 74);
			this.staffGridView.Name = "staffGridView";
			this.staffGridView.ReadOnly = true;
			this.staffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.staffGridView.Size = new System.Drawing.Size(521, 212);
			this.staffGridView.TabIndex = 1;
			this.staffGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffGridView_CellContentClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.departmentsList);
			this.tabPage2.Controls.Add(this.btnUpdate);
			this.tabPage2.Controls.Add(this.checkBoxShowPass);
			this.tabPage2.Controls.Add(this.btnEdit);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.txtPassword);
			this.tabPage2.Controls.Add(this.label22);
			this.tabPage2.Controls.Add(this.txtUserName);
			this.tabPage2.Controls.Add(this.label24);
			this.tabPage2.Controls.Add(this.btnBackToLoan);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(539, 299);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Edit Member";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// departmentsList
			// 
			this.departmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.departmentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.departmentsList.FormattingEnabled = true;
			this.departmentsList.Location = new System.Drawing.Point(191, 209);
			this.departmentsList.Name = "departmentsList";
			this.departmentsList.Size = new System.Drawing.Size(217, 33);
			this.departmentsList.TabIndex = 77;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(429, 205);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(87, 39);
			this.btnUpdate.TabIndex = 76;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// checkBoxShowPass
			// 
			this.checkBoxShowPass.AutoSize = true;
			this.checkBoxShowPass.Location = new System.Drawing.Point(414, 165);
			this.checkBoxShowPass.Name = "checkBoxShowPass";
			this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
			this.checkBoxShowPass.TabIndex = 75;
			this.checkBoxShowPass.Text = "Show Password";
			this.checkBoxShowPass.UseVisualStyleBackColor = true;
			this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(336, 18);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(87, 39);
			this.btnEdit.TabIndex = 74;
			this.btnEdit.Text = "Edit Member";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(24, 213);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(112, 24);
			this.label17.TabIndex = 73;
			this.label17.Text = "Department:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(24, 165);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(97, 24);
			this.label19.TabIndex = 70;
			this.label19.Text = "Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(191, 158);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(217, 31);
			this.txtPassword.TabIndex = 69;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(19, 114);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(110, 24);
			this.label22.TabIndex = 67;
			this.label22.Text = "User Name:";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(191, 110);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(217, 31);
			this.txtUserName.TabIndex = 65;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(21, 20);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(209, 37);
			this.label24.TabIndex = 64;
			this.label24.Text = "Staff Account";
			this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnBackToLoan
			// 
			this.btnBackToLoan.Location = new System.Drawing.Point(429, 18);
			this.btnBackToLoan.Name = "btnBackToLoan";
			this.btnBackToLoan.Size = new System.Drawing.Size(87, 39);
			this.btnBackToLoan.TabIndex = 63;
			this.btnBackToLoan.Text = "Back";
			this.btnBackToLoan.UseVisualStyleBackColor = true;
			this.btnBackToLoan.Click += new System.EventHandler(this.btnBackToLoan_Click);
			// 
			// StaffAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 329);
			this.Controls.Add(this.tabControl1);
			this.Name = "StaffAccounts";
			this.Text = "StaffAccounts";
			this.Load += new System.EventHandler(this.StaffAccounts_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.staffGridView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView staffGridView;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnBackToLoan;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.CheckBox checkBoxShowPass;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox departmentsList;
	}
}