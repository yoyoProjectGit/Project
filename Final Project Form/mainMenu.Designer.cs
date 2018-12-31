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
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEmails = new System.Windows.Forms.Button();
            this.btnItemsOnLoan = new System.Windows.Forms.Button();
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
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(85, 114);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(86, 53);
            this.btnSearchPerson.TabIndex = 1;
            this.btnSearchPerson.Text = "Search by Person";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Location = new System.Drawing.Point(85, 173);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(86, 53);
            this.btnViewInventory.TabIndex = 2;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(85, 232);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(86, 53);
            this.btnSearchItem.TabIndex = 3;
            this.btnSearchItem.Text = "Search For Item";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add New Resource";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(448, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 53);
            this.button6.TabIndex = 5;
            this.button6.Text = "View Overdue Items";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnEmails
            // 
            this.btnEmails.Location = new System.Drawing.Point(448, 114);
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.Size = new System.Drawing.Size(86, 53);
            this.btnEmails.TabIndex = 6;
            this.btnEmails.Text = "Email Handler";
            this.btnEmails.UseVisualStyleBackColor = true;
            // 
            // btnItemsOnLoan
            // 
            this.btnItemsOnLoan.Location = new System.Drawing.Point(448, 173);
            this.btnItemsOnLoan.Name = "btnItemsOnLoan";
            this.btnItemsOnLoan.Size = new System.Drawing.Size(86, 53);
            this.btnItemsOnLoan.TabIndex = 7;
            this.btnItemsOnLoan.Text = "View Items On Loan";
            this.btnItemsOnLoan.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 717);
            this.Controls.Add(this.btnItemsOnLoan);
            this.Controls.Add(this.btnEmails);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnAddUser);
            this.Name = "mainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEmails;
        private System.Windows.Forms.Button btnItemsOnLoan;
    }
}