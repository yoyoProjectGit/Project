namespace Final_Project_Form
{
    partial class mainMenu
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
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnSearchPerson = new System.Windows.Forms.Button();
			this.btnViewInventory = new System.Windows.Forms.Button();
			this.btnAddResource = new System.Windows.Forms.Button();
			this.btnOverdueItems = new System.Windows.Forms.Button();
			this.btnEmails = new System.Windows.Forms.Button();
			this.btnItemsOnLoan = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnLoanItem = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.btnReturnItem = new System.Windows.Forms.Button();
			this.btnDisposeItem = new System.Windows.Forms.Button();
			this.btnViewDisposedItems = new System.Windows.Forms.Button();
			this.btnExtendLoan = new System.Windows.Forms.Button();
			this.lblLoginName = new System.Windows.Forms.Label();
			this.lblDepartment2 = new System.Windows.Forms.Label();
			this.btnLoanHistory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(10, 98);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(118, 95);
			this.btnAddUser.TabIndex = 0;
			this.btnAddUser.Text = "Add Borrower";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnSearchPerson
			// 
			this.btnSearchPerson.Location = new System.Drawing.Point(10, 401);
			this.btnSearchPerson.Name = "btnSearchPerson";
			this.btnSearchPerson.Size = new System.Drawing.Size(118, 95);
			this.btnSearchPerson.TabIndex = 1;
			this.btnSearchPerson.Text = "Find Borrower";
			this.btnSearchPerson.UseVisualStyleBackColor = true;
			this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
			// 
			// btnViewInventory
			// 
			this.btnViewInventory.Location = new System.Drawing.Point(143, 300);
			this.btnViewInventory.Name = "btnViewInventory";
			this.btnViewInventory.Size = new System.Drawing.Size(118, 95);
			this.btnViewInventory.TabIndex = 2;
			this.btnViewInventory.Text = "View Inventory";
			this.btnViewInventory.UseVisualStyleBackColor = true;
			this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
			// 
			// btnAddResource
			// 
			this.btnAddResource.Location = new System.Drawing.Point(143, 98);
			this.btnAddResource.Name = "btnAddResource";
			this.btnAddResource.Size = new System.Drawing.Size(118, 95);
			this.btnAddResource.TabIndex = 4;
			this.btnAddResource.Text = "Add New Resource";
			this.btnAddResource.UseVisualStyleBackColor = true;
			this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
			// 
			// btnOverdueItems
			// 
			this.btnOverdueItems.Location = new System.Drawing.Point(143, 502);
			this.btnOverdueItems.Name = "btnOverdueItems";
			this.btnOverdueItems.Size = new System.Drawing.Size(118, 95);
			this.btnOverdueItems.TabIndex = 5;
			this.btnOverdueItems.Text = "View Overdue Items";
			this.btnOverdueItems.UseVisualStyleBackColor = true;
			this.btnOverdueItems.Click += new System.EventHandler(this.btnOverdueItems_Click);
			// 
			// btnEmails
			// 
			this.btnEmails.Location = new System.Drawing.Point(143, 401);
			this.btnEmails.Name = "btnEmails";
			this.btnEmails.Size = new System.Drawing.Size(118, 95);
			this.btnEmails.TabIndex = 6;
			this.btnEmails.Text = "Email Handler";
			this.btnEmails.UseVisualStyleBackColor = true;
			this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
			// 
			// btnItemsOnLoan
			// 
			this.btnItemsOnLoan.Location = new System.Drawing.Point(10, 502);
			this.btnItemsOnLoan.Name = "btnItemsOnLoan";
			this.btnItemsOnLoan.Size = new System.Drawing.Size(118, 95);
			this.btnItemsOnLoan.TabIndex = 7;
			this.btnItemsOnLoan.Text = "View Items On Loan";
			this.btnItemsOnLoan.UseVisualStyleBackColor = true;
			this.btnItemsOnLoan.Click += new System.EventHandler(this.btnItemsOnLoan_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(143, 707);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(118, 95);
			this.btnLogOut.TabIndex = 8;
			this.btnLogOut.Text = "Log Out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnLoanItem
			// 
			this.btnLoanItem.Location = new System.Drawing.Point(10, 199);
			this.btnLoanItem.Name = "btnLoanItem";
			this.btnLoanItem.Size = new System.Drawing.Size(118, 95);
			this.btnLoanItem.TabIndex = 9;
			this.btnLoanItem.Text = "Loan Item";
			this.btnLoanItem.UseVisualStyleBackColor = true;
			this.btnLoanItem.Click += new System.EventHandler(this.btnLoanItem_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(645, 43);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(0, 25);
			this.lblName.TabIndex = 10;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDepartment.Location = new System.Drawing.Point(645, 83);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(0, 25);
			this.lblDepartment.TabIndex = 11;
			// 
			// btnReturnItem
			// 
			this.btnReturnItem.Location = new System.Drawing.Point(143, 199);
			this.btnReturnItem.Name = "btnReturnItem";
			this.btnReturnItem.Size = new System.Drawing.Size(118, 95);
			this.btnReturnItem.TabIndex = 12;
			this.btnReturnItem.Text = "Return Item";
			this.btnReturnItem.UseVisualStyleBackColor = true;
			this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
			// 
			// btnDisposeItem
			// 
			this.btnDisposeItem.Location = new System.Drawing.Point(12, 707);
			this.btnDisposeItem.Name = "btnDisposeItem";
			this.btnDisposeItem.Size = new System.Drawing.Size(118, 95);
			this.btnDisposeItem.TabIndex = 13;
			this.btnDisposeItem.Text = "Dispose Of Item";
			this.btnDisposeItem.UseVisualStyleBackColor = true;
			this.btnDisposeItem.Click += new System.EventHandler(this.btnDisposeItem_Click);
			// 
			// btnViewDisposedItems
			// 
			this.btnViewDisposedItems.Location = new System.Drawing.Point(143, 606);
			this.btnViewDisposedItems.Name = "btnViewDisposedItems";
			this.btnViewDisposedItems.Size = new System.Drawing.Size(118, 95);
			this.btnViewDisposedItems.TabIndex = 14;
			this.btnViewDisposedItems.Text = "View Disposed Items";
			this.btnViewDisposedItems.UseVisualStyleBackColor = true;
			this.btnViewDisposedItems.Click += new System.EventHandler(this.btnViewDisposedItems_Click);
			// 
			// btnExtendLoan
			// 
			this.btnExtendLoan.Location = new System.Drawing.Point(10, 300);
			this.btnExtendLoan.Name = "btnExtendLoan";
			this.btnExtendLoan.Size = new System.Drawing.Size(118, 95);
			this.btnExtendLoan.TabIndex = 15;
			this.btnExtendLoan.Text = "Extend Loan";
			this.btnExtendLoan.UseVisualStyleBackColor = true;
			this.btnExtendLoan.Click += new System.EventHandler(this.btnExtendLoan_Click);
			// 
			// lblLoginName
			// 
			this.lblLoginName.AutoSize = true;
			this.lblLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoginName.Location = new System.Drawing.Point(6, 19);
			this.lblLoginName.Name = "lblLoginName";
			this.lblLoginName.Size = new System.Drawing.Size(51, 20);
			this.lblLoginName.TabIndex = 16;
			this.lblLoginName.Text = "label1";
			// 
			// lblDepartment2
			// 
			this.lblDepartment2.AutoSize = true;
			this.lblDepartment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDepartment2.Location = new System.Drawing.Point(6, 56);
			this.lblDepartment2.Name = "lblDepartment2";
			this.lblDepartment2.Size = new System.Drawing.Size(51, 20);
			this.lblDepartment2.TabIndex = 17;
			this.lblDepartment2.Text = "label2";
			// 
			// btnLoanHistory
			// 
			this.btnLoanHistory.Location = new System.Drawing.Point(12, 606);
			this.btnLoanHistory.Name = "btnLoanHistory";
			this.btnLoanHistory.Size = new System.Drawing.Size(118, 95);
			this.btnLoanHistory.TabIndex = 18;
			this.btnLoanHistory.Text = "View Loan History";
			this.btnLoanHistory.UseVisualStyleBackColor = true;
			this.btnLoanHistory.Click += new System.EventHandler(this.button1_Click);
			// 
			// mainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 808);
			this.Controls.Add(this.btnLoanHistory);
			this.Controls.Add(this.lblDepartment2);
			this.Controls.Add(this.lblLoginName);
			this.Controls.Add(this.btnExtendLoan);
			this.Controls.Add(this.btnViewDisposedItems);
			this.Controls.Add(this.btnDisposeItem);
			this.Controls.Add(this.btnReturnItem);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnLoanItem);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnItemsOnLoan);
			this.Controls.Add(this.btnEmails);
			this.Controls.Add(this.btnOverdueItems);
			this.Controls.Add(this.btnAddResource);
			this.Controls.Add(this.btnViewInventory);
			this.Controls.Add(this.btnSearchPerson);
			this.Controls.Add(this.btnAddUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "mainMenu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.mainMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnOverdueItems;
        private System.Windows.Forms.Button btnEmails;
        private System.Windows.Forms.Button btnItemsOnLoan;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLoanItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.Button btnDisposeItem;
        private System.Windows.Forms.Button btnViewDisposedItems;
		private System.Windows.Forms.Button btnExtendLoan;
		private System.Windows.Forms.Label lblLoginName;
		private System.Windows.Forms.Label lblDepartment2;
		private System.Windows.Forms.Button btnLoanHistory;
	}
}