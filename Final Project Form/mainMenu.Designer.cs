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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
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
			this.btnAdmin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddUser
			// 
			this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
			this.btnAddUser.Location = new System.Drawing.Point(15, 86);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(110, 49);
			this.btnAddUser.TabIndex = 0;
			this.btnAddUser.Text = "Add Borrower";
			this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnSearchPerson
			// 
			this.btnSearchPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPerson.Image")));
			this.btnSearchPerson.Location = new System.Drawing.Point(15, 380);
			this.btnSearchPerson.Name = "btnSearchPerson";
			this.btnSearchPerson.Size = new System.Drawing.Size(110, 49);
			this.btnSearchPerson.TabIndex = 1;
			this.btnSearchPerson.Text = "Find Borrower";
			this.btnSearchPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearchPerson.UseVisualStyleBackColor = true;
			this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
			// 
			// btnViewInventory
			// 
			this.btnViewInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnViewInventory.Image")));
			this.btnViewInventory.Location = new System.Drawing.Point(148, 282);
			this.btnViewInventory.Name = "btnViewInventory";
			this.btnViewInventory.Size = new System.Drawing.Size(110, 49);
			this.btnViewInventory.TabIndex = 2;
			this.btnViewInventory.Text = "View Inventory";
			this.btnViewInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnViewInventory.UseVisualStyleBackColor = true;
			this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
			// 
			// btnAddResource
			// 
			this.btnAddResource.Image = ((System.Drawing.Image)(resources.GetObject("btnAddResource.Image")));
			this.btnAddResource.Location = new System.Drawing.Point(148, 86);
			this.btnAddResource.Name = "btnAddResource";
			this.btnAddResource.Size = new System.Drawing.Size(110, 49);
			this.btnAddResource.TabIndex = 4;
			this.btnAddResource.Text = "Add Resource";
			this.btnAddResource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddResource.UseVisualStyleBackColor = true;
			this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
			// 
			// btnOverdueItems
			// 
			this.btnOverdueItems.Image = ((System.Drawing.Image)(resources.GetObject("btnOverdueItems.Image")));
			this.btnOverdueItems.Location = new System.Drawing.Point(148, 478);
			this.btnOverdueItems.Name = "btnOverdueItems";
			this.btnOverdueItems.Size = new System.Drawing.Size(110, 49);
			this.btnOverdueItems.TabIndex = 5;
			this.btnOverdueItems.Text = "View Overdue Items";
			this.btnOverdueItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOverdueItems.UseVisualStyleBackColor = true;
			this.btnOverdueItems.Click += new System.EventHandler(this.btnOverdueItems_Click);
			// 
			// btnEmails
			// 
			this.btnEmails.Image = ((System.Drawing.Image)(resources.GetObject("btnEmails.Image")));
			this.btnEmails.Location = new System.Drawing.Point(148, 380);
			this.btnEmails.Name = "btnEmails";
			this.btnEmails.Size = new System.Drawing.Size(110, 49);
			this.btnEmails.TabIndex = 6;
			this.btnEmails.Text = "Email Handler";
			this.btnEmails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEmails.UseVisualStyleBackColor = true;
			this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
			// 
			// btnItemsOnLoan
			// 
			this.btnItemsOnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnItemsOnLoan.Image")));
			this.btnItemsOnLoan.Location = new System.Drawing.Point(15, 478);
			this.btnItemsOnLoan.Name = "btnItemsOnLoan";
			this.btnItemsOnLoan.Size = new System.Drawing.Size(110, 49);
			this.btnItemsOnLoan.TabIndex = 7;
			this.btnItemsOnLoan.Text = "View Items On Loan";
			this.btnItemsOnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnItemsOnLoan.UseVisualStyleBackColor = true;
			this.btnItemsOnLoan.Click += new System.EventHandler(this.btnItemsOnLoan_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
			this.btnLogOut.Location = new System.Drawing.Point(148, 747);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(110, 49);
			this.btnLogOut.TabIndex = 8;
			this.btnLogOut.Text = "Log Out";
			this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnLoanItem
			// 
			this.btnLoanItem.Image = ((System.Drawing.Image)(resources.GetObject("btnLoanItem.Image")));
			this.btnLoanItem.Location = new System.Drawing.Point(15, 184);
			this.btnLoanItem.Name = "btnLoanItem";
			this.btnLoanItem.Size = new System.Drawing.Size(110, 49);
			this.btnLoanItem.TabIndex = 9;
			this.btnLoanItem.Text = "Loan Item";
			this.btnLoanItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
			this.btnReturnItem.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnItem.Image")));
			this.btnReturnItem.Location = new System.Drawing.Point(148, 184);
			this.btnReturnItem.Name = "btnReturnItem";
			this.btnReturnItem.Size = new System.Drawing.Size(110, 49);
			this.btnReturnItem.TabIndex = 12;
			this.btnReturnItem.Text = "Return Item";
			this.btnReturnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReturnItem.UseVisualStyleBackColor = true;
			this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
			// 
			// btnDisposeItem
			// 
			this.btnDisposeItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDisposeItem.Image")));
			this.btnDisposeItem.Location = new System.Drawing.Point(17, 674);
			this.btnDisposeItem.Name = "btnDisposeItem";
			this.btnDisposeItem.Size = new System.Drawing.Size(110, 49);
			this.btnDisposeItem.TabIndex = 13;
			this.btnDisposeItem.Text = "Dispose Of Item";
			this.btnDisposeItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDisposeItem.UseVisualStyleBackColor = true;
			this.btnDisposeItem.Click += new System.EventHandler(this.btnDisposeItem_Click);
			// 
			// btnViewDisposedItems
			// 
			this.btnViewDisposedItems.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDisposedItems.Image")));
			this.btnViewDisposedItems.Location = new System.Drawing.Point(148, 576);
			this.btnViewDisposedItems.Name = "btnViewDisposedItems";
			this.btnViewDisposedItems.Size = new System.Drawing.Size(110, 49);
			this.btnViewDisposedItems.TabIndex = 14;
			this.btnViewDisposedItems.Text = "View Disposed Items";
			this.btnViewDisposedItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnViewDisposedItems.UseVisualStyleBackColor = true;
			this.btnViewDisposedItems.Click += new System.EventHandler(this.btnViewDisposedItems_Click);
			// 
			// btnExtendLoan
			// 
			this.btnExtendLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnExtendLoan.Image")));
			this.btnExtendLoan.Location = new System.Drawing.Point(15, 282);
			this.btnExtendLoan.Name = "btnExtendLoan";
			this.btnExtendLoan.Size = new System.Drawing.Size(110, 49);
			this.btnExtendLoan.TabIndex = 15;
			this.btnExtendLoan.Text = "Extend Loan";
			this.btnExtendLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
			this.btnLoanHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnLoanHistory.Image")));
			this.btnLoanHistory.Location = new System.Drawing.Point(17, 576);
			this.btnLoanHistory.Name = "btnLoanHistory";
			this.btnLoanHistory.Size = new System.Drawing.Size(110, 49);
			this.btnLoanHistory.TabIndex = 18;
			this.btnLoanHistory.Text = "View Loan History";
			this.btnLoanHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLoanHistory.UseVisualStyleBackColor = true;
			this.btnLoanHistory.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
			this.btnAdmin.Location = new System.Drawing.Point(148, 674);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(110, 49);
			this.btnAdmin.TabIndex = 19;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// mainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 808);
			this.Controls.Add(this.btnAdmin);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "mainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
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
		private System.Windows.Forms.Button btnAdmin;
	}
}