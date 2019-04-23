namespace Final_Project_Form
{
    partial class DisposeItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposeItem));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnOrderNo = new System.Windows.Forms.Button();
			this.txtSupplierSource = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDispose = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSearchBarcode = new System.Windows.Forms.Button();
			this.btnSearchName = new System.Windows.Forms.Button();
			this.txtResourceBarcode = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSerialNumber = new System.Windows.Forms.TextBox();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inventoryGridView = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnGoBack = new System.Windows.Forms.Button();
			this.btnConfirmItems = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.pickedItemsGridView = new System.Windows.Forms.DataGridView();
			this.ResourceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaxLoanPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SupplierSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pickedItemsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1088, 653);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnOrderNo);
			this.tabPage1.Controls.Add(this.txtSupplierSource);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.btnDispose);
			this.tabPage1.Controls.Add(this.btnBack);
			this.tabPage1.Controls.Add(this.btnRefresh);
			this.tabPage1.Controls.Add(this.btnSearchBarcode);
			this.tabPage1.Controls.Add(this.btnSearchName);
			this.tabPage1.Controls.Add(this.txtResourceBarcode);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtSerialNumber);
			this.tabPage1.Controls.Add(this.txtResourceName);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.inventoryGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1080, 627);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Choose Item To Dispose";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnOrderNo
			// 
			this.btnOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrderNo.Location = new System.Drawing.Point(515, 204);
			this.btnOrderNo.Name = "btnOrderNo";
			this.btnOrderNo.Size = new System.Drawing.Size(106, 31);
			this.btnOrderNo.TabIndex = 5;
			this.btnOrderNo.Text = "Search";
			this.btnOrderNo.UseVisualStyleBackColor = true;
			this.btnOrderNo.Click += new System.EventHandler(this.btnOrderNo_Click);
			// 
			// txtSupplierSource
			// 
			this.txtSupplierSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSupplierSource.Location = new System.Drawing.Point(201, 204);
			this.txtSupplierSource.Name = "txtSupplierSource";
			this.txtSupplierSource.Size = new System.Drawing.Size(217, 31);
			this.txtSupplierSource.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 24);
			this.label3.TabIndex = 33;
			this.label3.Text = "Order Number";
			// 
			// btnDispose
			// 
			this.btnDispose.Location = new System.Drawing.Point(850, 24);
			this.btnDispose.Name = "btnDispose";
			this.btnDispose.Size = new System.Drawing.Size(103, 92);
			this.btnDispose.TabIndex = 6;
			this.btnDispose.Text = "Dispose Items";
			this.btnDispose.UseVisualStyleBackColor = true;
			this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(959, 581);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(103, 38);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(959, 24);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(103, 92);
			this.btnRefresh.TabIndex = 7;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSearchBarcode
			// 
			this.btnSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchBarcode.Location = new System.Drawing.Point(515, 146);
			this.btnSearchBarcode.Name = "btnSearchBarcode";
			this.btnSearchBarcode.Size = new System.Drawing.Size(106, 31);
			this.btnSearchBarcode.TabIndex = 4;
			this.btnSearchBarcode.Text = "Search";
			this.btnSearchBarcode.UseVisualStyleBackColor = true;
			this.btnSearchBarcode.Click += new System.EventHandler(this.btnSearchBarcode_Click);
			// 
			// btnSearchName
			// 
			this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchName.Location = new System.Drawing.Point(515, 85);
			this.btnSearchName.Name = "btnSearchName";
			this.btnSearchName.Size = new System.Drawing.Size(106, 31);
			this.btnSearchName.TabIndex = 3;
			this.btnSearchName.Text = "Search";
			this.btnSearchName.UseVisualStyleBackColor = true;
			this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
			// 
			// txtResourceBarcode
			// 
			this.txtResourceBarcode.AutoSize = true;
			this.txtResourceBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceBarcode.Location = new System.Drawing.Point(25, 146);
			this.txtResourceBarcode.Name = "txtResourceBarcode";
			this.txtResourceBarcode.Size = new System.Drawing.Size(169, 24);
			this.txtResourceBarcode.TabIndex = 27;
			this.txtResourceBarcode.Text = "Resource SerialNo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 24);
			this.label2.TabIndex = 26;
			this.label2.Text = "Resource Name:";
			// 
			// txtSerialNumber
			// 
			this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNumber.Location = new System.Drawing.Point(201, 146);
			this.txtSerialNumber.Name = "txtSerialNumber";
			this.txtSerialNumber.Size = new System.Drawing.Size(217, 31);
			this.txtSerialNumber.TabIndex = 1;
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(201, 85);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 24);
			this.label1.TabIndex = 23;
			this.label1.Text = "Search For Item To Dispose";
			// 
			// inventoryGridView
			// 
			this.inventoryGridView.AllowUserToAddRows = false;
			this.inventoryGridView.AllowUserToDeleteRows = false;
			this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.inventoryGridView.Location = new System.Drawing.Point(19, 250);
			this.inventoryGridView.Name = "inventoryGridView";
			this.inventoryGridView.ReadOnly = true;
			this.inventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.inventoryGridView.Size = new System.Drawing.Size(1043, 308);
			this.inventoryGridView.TabIndex = 22;
			this.inventoryGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryGridView_MouseClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnGoBack);
			this.tabPage2.Controls.Add(this.btnConfirmItems);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.pickedItemsGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1080, 627);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chosen Items";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnGoBack
			// 
			this.btnGoBack.Location = new System.Drawing.Point(634, 492);
			this.btnGoBack.Name = "btnGoBack";
			this.btnGoBack.Size = new System.Drawing.Size(121, 73);
			this.btnGoBack.TabIndex = 70;
			this.btnGoBack.Text = "Back";
			this.btnGoBack.UseVisualStyleBackColor = true;
			this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
			// 
			// btnConfirmItems
			// 
			this.btnConfirmItems.Location = new System.Drawing.Point(906, 492);
			this.btnConfirmItems.Name = "btnConfirmItems";
			this.btnConfirmItems.Size = new System.Drawing.Size(121, 73);
			this.btnConfirmItems.TabIndex = 69;
			this.btnConfirmItems.Text = "Confirm Items";
			this.btnConfirmItems.UseVisualStyleBackColor = true;
			this.btnConfirmItems.Click += new System.EventHandler(this.btnConfirmItems_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(46, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(407, 25);
			this.label8.TabIndex = 24;
			this.label8.Text = "These are your chosen items for disposal";
			// 
			// pickedItemsGridView
			// 
			this.pickedItemsGridView.AllowUserToAddRows = false;
			this.pickedItemsGridView.AllowUserToDeleteRows = false;
			this.pickedItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pickedItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceID,
            this.ResourceType,
            this.ResourceName,
            this.MaxLoanPeriod,
            this.Department,
            this.SerialNumber,
            this.DateAdded,
            this.SupplierSource,
            this.PurchasePrice,
            this.InStock,
            this.Notes,
            this.Total,
            this.AddedBy});
			this.pickedItemsGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.pickedItemsGridView.Location = new System.Drawing.Point(19, 143);
			this.pickedItemsGridView.Name = "pickedItemsGridView";
			this.pickedItemsGridView.ReadOnly = true;
			this.pickedItemsGridView.Size = new System.Drawing.Size(1043, 308);
			this.pickedItemsGridView.TabIndex = 23;
			// 
			// ResourceID
			// 
			this.ResourceID.HeaderText = "ResourceID";
			this.ResourceID.Name = "ResourceID";
			this.ResourceID.ReadOnly = true;
			// 
			// ResourceType
			// 
			this.ResourceType.HeaderText = "ResourceType";
			this.ResourceType.Name = "ResourceType";
			this.ResourceType.ReadOnly = true;
			// 
			// ResourceName
			// 
			this.ResourceName.HeaderText = "ResourceName";
			this.ResourceName.Name = "ResourceName";
			this.ResourceName.ReadOnly = true;
			// 
			// MaxLoanPeriod
			// 
			this.MaxLoanPeriod.HeaderText = "MaxLoanPeriod";
			this.MaxLoanPeriod.Name = "MaxLoanPeriod";
			this.MaxLoanPeriod.ReadOnly = true;
			// 
			// Department
			// 
			this.Department.HeaderText = "Department";
			this.Department.Name = "Department";
			this.Department.ReadOnly = true;
			// 
			// SerialNumber
			// 
			this.SerialNumber.HeaderText = "SerialNumber";
			this.SerialNumber.Name = "SerialNumber";
			this.SerialNumber.ReadOnly = true;
			// 
			// DateAdded
			// 
			this.DateAdded.HeaderText = "DateAdded";
			this.DateAdded.Name = "DateAdded";
			this.DateAdded.ReadOnly = true;
			// 
			// SupplierSource
			// 
			this.SupplierSource.HeaderText = "SupplierSource";
			this.SupplierSource.Name = "SupplierSource";
			this.SupplierSource.ReadOnly = true;
			// 
			// PurchasePrice
			// 
			this.PurchasePrice.HeaderText = "PurchasePrice";
			this.PurchasePrice.Name = "PurchasePrice";
			this.PurchasePrice.ReadOnly = true;
			// 
			// InStock
			// 
			this.InStock.HeaderText = "InStock";
			this.InStock.Name = "InStock";
			this.InStock.ReadOnly = true;
			// 
			// Notes
			// 
			this.Notes.HeaderText = "Notes";
			this.Notes.Name = "Notes";
			this.Notes.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// AddedBy
			// 
			this.AddedBy.HeaderText = "AddedBy";
			this.AddedBy.Name = "AddedBy";
			this.AddedBy.ReadOnly = true;
			// 
			// DisposeItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 653);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DisposeItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DisposeItem";
			this.Load += new System.EventHandler(this.DisposeItem_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pickedItemsGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchBarcode;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label txtResourceBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.DataGridView pickedItemsGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmItems;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtSupplierSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderNo;
        private System.Windows.Forms.TextBox txtSerialNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ResourceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaxLoanPeriod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department;
		private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
		private System.Windows.Forms.DataGridViewTextBoxColumn SupplierSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddedBy;
	}
}