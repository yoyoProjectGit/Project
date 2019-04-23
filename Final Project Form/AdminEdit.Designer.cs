namespace Final_Project_Form
{
	partial class AdminEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEdit));
			this.btnUpdate = new System.Windows.Forms.Button();
			this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(405, 213);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(87, 39);
			this.btnUpdate.TabIndex = 89;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// checkBoxShowPass
			// 
			this.checkBoxShowPass.AutoSize = true;
			this.checkBoxShowPass.Location = new System.Drawing.Point(405, 152);
			this.checkBoxShowPass.Name = "checkBoxShowPass";
			this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
			this.checkBoxShowPass.TabIndex = 88;
			this.checkBoxShowPass.Text = "Show Password";
			this.checkBoxShowPass.UseVisualStyleBackColor = true;
			this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(327, 21);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(87, 39);
			this.btnEdit.TabIndex = 87;
			this.btnEdit.Text = "Edit Account";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(15, 152);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(97, 24);
			this.label19.TabIndex = 85;
			this.label19.Text = "Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(182, 145);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(217, 31);
			this.txtPassword.TabIndex = 84;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(10, 101);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(110, 24);
			this.label22.TabIndex = 82;
			this.label22.Text = "User Name:";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(182, 97);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(217, 31);
			this.txtUserName.TabIndex = 80;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(12, 23);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(235, 37);
			this.label24.TabIndex = 79;
			this.label24.Text = "Admin Account";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(420, 21);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 39);
			this.btnClose.TabIndex = 78;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnBackToLoan_Click);
			// 
			// AdminEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 270);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.checkBoxShowPass);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdminEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminEdit";
			this.Load += new System.EventHandler(this.AdminEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.CheckBox checkBoxShowPass;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnClose;
	}
}