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
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(85, 55);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(86, 53);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(85, 114);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(86, 53);
            this.btnSearchPerson.TabIndex = 1;
            this.btnSearchPerson.Text = "Search by Person";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Location = new System.Drawing.Point(85, 173);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(86, 53);
            this.btnViewInventory.TabIndex = 2;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(85, 291);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(86, 53);
            this.btnAddResource.TabIndex = 4;
            this.btnAddResource.Text = "Add New Resource";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnOverdueItems
            // 
            this.btnOverdueItems.Location = new System.Drawing.Point(448, 55);
            this.btnOverdueItems.Name = "btnOverdueItems";
            this.btnOverdueItems.Size = new System.Drawing.Size(86, 53);
            this.btnOverdueItems.TabIndex = 5;
            this.btnOverdueItems.Text = "View Overdue Items";
            this.btnOverdueItems.UseVisualStyleBackColor = true;
            this.btnOverdueItems.Click += new System.EventHandler(this.btnOverdueItems_Click);
            // 
            // btnEmails
            // 
            this.btnEmails.Location = new System.Drawing.Point(448, 114);
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.Size = new System.Drawing.Size(86, 53);
            this.btnEmails.TabIndex = 6;
            this.btnEmails.Text = "Email Handler";
            this.btnEmails.UseVisualStyleBackColor = true;
            this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
            // 
            // btnItemsOnLoan
            // 
            this.btnItemsOnLoan.Location = new System.Drawing.Point(448, 173);
            this.btnItemsOnLoan.Name = "btnItemsOnLoan";
            this.btnItemsOnLoan.Size = new System.Drawing.Size(86, 53);
            this.btnItemsOnLoan.TabIndex = 7;
            this.btnItemsOnLoan.Text = "View Items On Loan";
            this.btnItemsOnLoan.UseVisualStyleBackColor = true;
            this.btnItemsOnLoan.Click += new System.EventHandler(this.btnItemsOnLoan_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(740, 580);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(159, 54);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 717);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

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
    }
}