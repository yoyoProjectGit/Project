﻿namespace Final_Project_Form
{
    partial class viewItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewItem));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnEdit = new System.Windows.Forms.Button();
			this.departmentsList = new System.Windows.Forms.ComboBox();
			this.txtAddedBy = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPurchasePrice = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSupplierSource = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDateAdded = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSerialNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMaxLoanPeriod = new System.Windows.Forms.TextBox();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.txtResourceType = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnGoBack = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.itemHistoryGridView = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnBack2 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.LoanedItemsGridView = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemHistoryGridView)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoanedItemsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(801, 450);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.btnEdit);
			this.tabPage1.Controls.Add(this.departmentsList);
			this.tabPage1.Controls.Add(this.txtAddedBy);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.txtPurchasePrice);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.txtSupplierSource);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.txtDateAdded);
			this.tabPage1.Controls.Add(this.txtNotes);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.btnBack);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtSerialNo);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.txtMaxLoanPeriod);
			this.tabPage1.Controls.Add(this.txtResourceName);
			this.tabPage1.Controls.Add(this.txtResourceType);
			this.tabPage1.Controls.Add(this.btnUpdate);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(793, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "View Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(549, 27);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(91, 33);
			this.btnEdit.TabIndex = 40;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// departmentsList
			// 
			this.departmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.departmentsList.FormattingEnabled = true;
			this.departmentsList.Location = new System.Drawing.Point(188, 245);
			this.departmentsList.Name = "departmentsList";
			this.departmentsList.Size = new System.Drawing.Size(217, 21);
			this.departmentsList.TabIndex = 27;
			// 
			// txtAddedBy
			// 
			this.txtAddedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddedBy.Location = new System.Drawing.Point(557, 176);
			this.txtAddedBy.Name = "txtAddedBy";
			this.txtAddedBy.ReadOnly = true;
			this.txtAddedBy.Size = new System.Drawing.Size(217, 31);
			this.txtAddedBy.TabIndex = 39;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(411, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 24);
			this.label6.TabIndex = 38;
			this.label6.Text = "Added By:";
			// 
			// txtPurchasePrice
			// 
			this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPurchasePrice.Location = new System.Drawing.Point(557, 134);
			this.txtPurchasePrice.Name = "txtPurchasePrice";
			this.txtPurchasePrice.ReadOnly = true;
			this.txtPurchasePrice.Size = new System.Drawing.Size(217, 31);
			this.txtPurchasePrice.TabIndex = 37;
			this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
			this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(411, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(143, 24);
			this.label11.TabIndex = 36;
			this.label11.Text = "Purchase Price:";
			// 
			// txtSupplierSource
			// 
			this.txtSupplierSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSupplierSource.Location = new System.Drawing.Point(557, 89);
			this.txtSupplierSource.Name = "txtSupplierSource";
			this.txtSupplierSource.ReadOnly = true;
			this.txtSupplierSource.Size = new System.Drawing.Size(217, 31);
			this.txtSupplierSource.TabIndex = 35;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(411, 93);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(151, 24);
			this.label10.TabIndex = 34;
			this.label10.Text = "Supplier/Source:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(21, 342);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 24);
			this.label9.TabIndex = 33;
			this.label9.Text = "Date Added:";
			// 
			// txtDateAdded
			// 
			this.txtDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateAdded.Location = new System.Drawing.Point(188, 335);
			this.txtDateAdded.Name = "txtDateAdded";
			this.txtDateAdded.ReadOnly = true;
			this.txtDateAdded.Size = new System.Drawing.Size(217, 31);
			this.txtDateAdded.TabIndex = 32;
			// 
			// txtNotes
			// 
			this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Location = new System.Drawing.Point(557, 245);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ReadOnly = true;
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(217, 108);
			this.txtNotes.TabIndex = 31;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(429, 245);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 24);
			this.label8.TabIndex = 30;
			this.label8.Text = "Notes:";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(607, 377);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(90, 36);
			this.btnBack.TabIndex = 28;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 24);
			this.label5.TabIndex = 25;
			this.label5.Text = "Serial No:";
			// 
			// txtSerialNo
			// 
			this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNo.Location = new System.Drawing.Point(188, 289);
			this.txtSerialNo.Name = "txtSerialNo";
			this.txtSerialNo.ReadOnly = true;
			this.txtSerialNo.Size = new System.Drawing.Size(217, 31);
			this.txtSerialNo.TabIndex = 24;
			this.txtSerialNo.TextChanged += new System.EventHandler(this.txtSerialNo_TextChanged);
			this.txtSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNo_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 245);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "Department:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Max Loan Period:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "Resource Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(21, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 24);
			this.label7.TabIndex = 20;
			this.label7.Text = "Resource Type:";
			// 
			// txtMaxLoanPeriod
			// 
			this.txtMaxLoanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxLoanPeriod.Location = new System.Drawing.Point(188, 191);
			this.txtMaxLoanPeriod.Name = "txtMaxLoanPeriod";
			this.txtMaxLoanPeriod.ReadOnly = true;
			this.txtMaxLoanPeriod.Size = new System.Drawing.Size(217, 31);
			this.txtMaxLoanPeriod.TabIndex = 18;
			this.txtMaxLoanPeriod.TextChanged += new System.EventHandler(this.txtMaxLoanPeriod_TextChanged);
			this.txtMaxLoanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxLoanPeriod_KeyPress);
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(188, 138);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.ReadOnly = true;
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 17;
			// 
			// txtResourceType
			// 
			this.txtResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceType.Location = new System.Drawing.Point(188, 89);
			this.txtResourceType.Name = "txtResourceType";
			this.txtResourceType.ReadOnly = true;
			this.txtResourceType.Size = new System.Drawing.Size(217, 31);
			this.txtResourceType.TabIndex = 16;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(646, 27);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(91, 33);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item Details";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnGoBack);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.itemHistoryGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(793, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "View Item History";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnGoBack
			// 
			this.btnGoBack.Location = new System.Drawing.Point(651, 30);
			this.btnGoBack.Name = "btnGoBack";
			this.btnGoBack.Size = new System.Drawing.Size(90, 36);
			this.btnGoBack.TabIndex = 32;
			this.btnGoBack.Text = "Back";
			this.btnGoBack.UseVisualStyleBackColor = true;
			this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(18, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(119, 25);
			this.label12.TabIndex = 31;
			this.label12.Text = "Item Hisory";
			// 
			// itemHistoryGridView
			// 
			this.itemHistoryGridView.AllowUserToAddRows = false;
			this.itemHistoryGridView.AllowUserToDeleteRows = false;
			this.itemHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.itemHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemHistoryGridView.Location = new System.Drawing.Point(7, 88);
			this.itemHistoryGridView.Name = "itemHistoryGridView";
			this.itemHistoryGridView.ReadOnly = true;
			this.itemHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itemHistoryGridView.Size = new System.Drawing.Size(779, 321);
			this.itemHistoryGridView.TabIndex = 30;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnBack2);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.LoanedItemsGridView);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(793, 424);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "View Current Loaner";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnBack2
			// 
			this.btnBack2.Location = new System.Drawing.Point(652, 8);
			this.btnBack2.Name = "btnBack2";
			this.btnBack2.Size = new System.Drawing.Size(90, 36);
			this.btnBack2.TabIndex = 33;
			this.btnBack2.Text = "Back";
			this.btnBack2.UseVisualStyleBackColor = true;
			this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(19, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(162, 25);
			this.label13.TabIndex = 2;
			this.label13.Text = "Current Loaner:";
			// 
			// LoanedItemsGridView
			// 
			this.LoanedItemsGridView.AllowUserToAddRows = false;
			this.LoanedItemsGridView.AllowUserToDeleteRows = false;
			this.LoanedItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.LoanedItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LoanedItemsGridView.Location = new System.Drawing.Point(22, 54);
			this.LoanedItemsGridView.Name = "LoanedItemsGridView";
			this.LoanedItemsGridView.ReadOnly = true;
			this.LoanedItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.LoanedItemsGridView.Size = new System.Drawing.Size(749, 336);
			this.LoanedItemsGridView.TabIndex = 1;
			// 
			// viewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "viewItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "viewItem";
			this.Load += new System.EventHandler(this.viewItem_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemHistoryGridView)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoanedItemsGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxLoanPeriod;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.TextBox txtResourceType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentsList;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView itemHistoryGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView LoanedItemsGridView;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnEdit;
    }
}