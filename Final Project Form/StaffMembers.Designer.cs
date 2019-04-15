namespace Final_Project_Form
{
	partial class StaffMembers
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.staffMemberGridView = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtStartDate = new System.Windows.Forms.TextBox();
			this.txtUserType = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtScanID = new System.Windows.Forms.TextBox();
			this.txtDateAdded = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCourseDept = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtShuId = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btnClose2 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.staffMemberGridView)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, -1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(798, 439);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnClose2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.staffMemberGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(790, 413);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Staff Members";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Staff Members";
			// 
			// staffMemberGridView
			// 
			this.staffMemberGridView.AllowUserToAddRows = false;
			this.staffMemberGridView.AllowUserToDeleteRows = false;
			this.staffMemberGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.staffMemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.staffMemberGridView.Location = new System.Drawing.Point(8, 86);
			this.staffMemberGridView.Name = "staffMemberGridView";
			this.staffMemberGridView.ReadOnly = true;
			this.staffMemberGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.staffMemberGridView.Size = new System.Drawing.Size(776, 328);
			this.staffMemberGridView.TabIndex = 0;
			this.staffMemberGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffMemberGridView_CellContentClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtStartDate);
			this.tabPage2.Controls.Add(this.txtUserType);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.txtScanID);
			this.tabPage2.Controls.Add(this.txtDateAdded);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.btnBack);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txtEmail);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.txtCourseDept);
			this.tabPage2.Controls.Add(this.txtSurname);
			this.tabPage2.Controls.Add(this.txtFirstName);
			this.tabPage2.Controls.Add(this.txtShuId);
			this.tabPage2.Controls.Add(this.btnDelete);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(790, 413);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chosen Member";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStartDate.Location = new System.Drawing.Point(211, 371);
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.ReadOnly = true;
			this.txtStartDate.Size = new System.Drawing.Size(292, 31);
			this.txtStartDate.TabIndex = 59;
			// 
			// txtUserType
			// 
			this.txtUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserType.Location = new System.Drawing.Point(211, 76);
			this.txtUserType.Name = "txtUserType";
			this.txtUserType.ReadOnly = true;
			this.txtUserType.Size = new System.Drawing.Size(292, 31);
			this.txtUserType.TabIndex = 58;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(61, 117);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(135, 24);
			this.label11.TabIndex = 57;
			this.label11.Text = "Scannable No:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(61, 76);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 24);
			this.label12.TabIndex = 56;
			this.label12.Text = "User Type:";
			// 
			// txtScanID
			// 
			this.txtScanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScanID.Location = new System.Drawing.Point(211, 113);
			this.txtScanID.Name = "txtScanID";
			this.txtScanID.ReadOnly = true;
			this.txtScanID.Size = new System.Drawing.Size(292, 31);
			this.txtScanID.TabIndex = 55;
			// 
			// txtDateAdded
			// 
			this.txtDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateAdded.Location = new System.Drawing.Point(211, 335);
			this.txtDateAdded.Name = "txtDateAdded";
			this.txtDateAdded.ReadOnly = true;
			this.txtDateAdded.Size = new System.Drawing.Size(292, 31);
			this.txtDateAdded.TabIndex = 54;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(61, 339);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 53;
			this.label8.Text = "Date added:";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(681, 366);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(90, 36);
			this.btnBack.TabIndex = 51;
			this.btnBack.Text = "Close";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(61, 378);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 24);
			this.label6.TabIndex = 50;
			this.label6.Text = "Start Date:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(61, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 24);
			this.label5.TabIndex = 49;
			this.label5.Text = "Email Address:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(211, 298);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(292, 31);
			this.txtEmail.TabIndex = 48;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 265);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 47;
			this.label4.Text = "Course/Dept:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 24);
			this.label3.TabIndex = 46;
			this.label3.Text = "Surname:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 45;
			this.label2.Text = "First Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(61, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 24);
			this.label7.TabIndex = 44;
			this.label7.Text = "SHU ID:";
			// 
			// txtCourseDept
			// 
			this.txtCourseDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCourseDept.Location = new System.Drawing.Point(211, 261);
			this.txtCourseDept.Name = "txtCourseDept";
			this.txtCourseDept.ReadOnly = true;
			this.txtCourseDept.Size = new System.Drawing.Size(292, 31);
			this.txtCourseDept.TabIndex = 43;
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSurname.Location = new System.Drawing.Point(211, 224);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.ReadOnly = true;
			this.txtSurname.Size = new System.Drawing.Size(292, 31);
			this.txtSurname.TabIndex = 42;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(211, 187);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.ReadOnly = true;
			this.txtFirstName.Size = new System.Drawing.Size(292, 31);
			this.txtFirstName.TabIndex = 41;
			// 
			// txtShuId
			// 
			this.txtShuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShuId.Location = new System.Drawing.Point(211, 150);
			this.txtShuId.Name = "txtShuId";
			this.txtShuId.ReadOnly = true;
			this.txtShuId.Size = new System.Drawing.Size(292, 31);
			this.txtShuId.TabIndex = 40;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(630, 24);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(130, 55);
			this.btnDelete.TabIndex = 39;
			this.btnDelete.Text = "Delete Staff Member";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(31, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(205, 37);
			this.label9.TabIndex = 37;
			this.label9.Text = "Personal Info";
			// 
			// btnClose2
			// 
			this.btnClose2.Location = new System.Drawing.Point(669, 16);
			this.btnClose2.Name = "btnClose2";
			this.btnClose2.Size = new System.Drawing.Size(90, 36);
			this.btnClose2.TabIndex = 52;
			this.btnClose2.Text = "Close";
			this.btnClose2.UseVisualStyleBackColor = true;
			this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
			// 
			// StaffMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "StaffMembers";
			this.Text = "StaffMembers";
			this.Load += new System.EventHandler(this.StaffMembers_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.staffMemberGridView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView staffMemberGridView;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtScanID;
		private System.Windows.Forms.TextBox txtDateAdded;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCourseDept;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtShuId;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUserType;
		private System.Windows.Forms.TextBox txtStartDate;
		private System.Windows.Forms.Button btnClose2;
	}
}