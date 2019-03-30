namespace Final_Project_Form
{
    partial class ItemsOnLoan
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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSearchBarcode = new System.Windows.Forms.Button();
			this.btnSearchName = new System.Windows.Forms.Button();
			this.txtSerialNo = new System.Windows.Forms.TextBox();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.txtResourceBarcode = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.loanedItemsGridView = new System.Windows.Forms.DataGridView();
			this.btnResourceType = new System.Windows.Forms.Button();
			this.txtResourceType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTotalRows = new System.Windows.Forms.Label();
			this.lblTotalItems = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnShuId = new System.Windows.Forms.Button();
			this.txtShuID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.loanedItemsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(1151, 656);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 89);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(1151, 23);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(103, 92);
			this.btnRefresh.TabIndex = 8;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSearchBarcode
			// 
			this.btnSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchBarcode.Location = new System.Drawing.Point(512, 105);
			this.btnSearchBarcode.Name = "btnSearchBarcode";
			this.btnSearchBarcode.Size = new System.Drawing.Size(106, 31);
			this.btnSearchBarcode.TabIndex = 5;
			this.btnSearchBarcode.Text = "Search";
			this.btnSearchBarcode.UseVisualStyleBackColor = true;
			this.btnSearchBarcode.Click += new System.EventHandler(this.btnSearchBarcode_Click);
			// 
			// btnSearchName
			// 
			this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchName.Location = new System.Drawing.Point(512, 68);
			this.btnSearchName.Name = "btnSearchName";
			this.btnSearchName.Size = new System.Drawing.Size(106, 31);
			this.btnSearchName.TabIndex = 4;
			this.btnSearchName.Text = "Search";
			this.btnSearchName.UseVisualStyleBackColor = true;
			this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
			// 
			// txtSerialNo
			// 
			this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNo.Location = new System.Drawing.Point(198, 105);
			this.txtSerialNo.Name = "txtSerialNo";
			this.txtSerialNo.Size = new System.Drawing.Size(217, 31);
			this.txtSerialNo.TabIndex = 1;
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(198, 68);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 0;
			// 
			// txtResourceBarcode
			// 
			this.txtResourceBarcode.AutoSize = true;
			this.txtResourceBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceBarcode.Location = new System.Drawing.Point(22, 105);
			this.txtResourceBarcode.Name = "txtResourceBarcode";
			this.txtResourceBarcode.Size = new System.Drawing.Size(136, 24);
			this.txtResourceBarcode.TabIndex = 62;
			this.txtResourceBarcode.Text = "Serial Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 24);
			this.label2.TabIndex = 61;
			this.label2.Text = "Resource Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 24);
			this.label1.TabIndex = 60;
			this.label1.Text = "Saearch For Item on Loan";
			// 
			// loanedItemsGridView
			// 
			this.loanedItemsGridView.AllowUserToAddRows = false;
			this.loanedItemsGridView.AllowUserToDeleteRows = false;
			this.loanedItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loanedItemsGridView.Location = new System.Drawing.Point(26, 250);
			this.loanedItemsGridView.Name = "loanedItemsGridView";
			this.loanedItemsGridView.ReadOnly = true;
			this.loanedItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loanedItemsGridView.Size = new System.Drawing.Size(1228, 395);
			this.loanedItemsGridView.TabIndex = 59;
			this.loanedItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanedItemsGridView_CellContentClick);
			// 
			// btnResourceType
			// 
			this.btnResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResourceType.Location = new System.Drawing.Point(512, 179);
			this.btnResourceType.Name = "btnResourceType";
			this.btnResourceType.Size = new System.Drawing.Size(106, 31);
			this.btnResourceType.TabIndex = 7;
			this.btnResourceType.Text = "Search";
			this.btnResourceType.UseVisualStyleBackColor = true;
			this.btnResourceType.Click += new System.EventHandler(this.btnResourceType_Click);
			// 
			// txtResourceType
			// 
			this.txtResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceType.Location = new System.Drawing.Point(198, 179);
			this.txtResourceType.Name = "txtResourceType";
			this.txtResourceType.Size = new System.Drawing.Size(217, 31);
			this.txtResourceType.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 24);
			this.label4.TabIndex = 72;
			this.label4.Text = "Resource Type:";
			// 
			// lblTotalRows
			// 
			this.lblTotalRows.AutoSize = true;
			this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalRows.Location = new System.Drawing.Point(682, 50);
			this.lblTotalRows.Name = "lblTotalRows";
			this.lblTotalRows.Size = new System.Drawing.Size(0, 24);
			this.lblTotalRows.TabIndex = 75;
			// 
			// lblTotalItems
			// 
			this.lblTotalItems.AutoSize = true;
			this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalItems.Location = new System.Drawing.Point(682, 25);
			this.lblTotalItems.Name = "lblTotalItems";
			this.lblTotalItems.Size = new System.Drawing.Size(0, 24);
			this.lblTotalItems.TabIndex = 74;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 69;
			this.label3.Text = "SHU ID:";
			// 
			// btnShuId
			// 
			this.btnShuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShuId.Location = new System.Drawing.Point(512, 142);
			this.btnShuId.Name = "btnShuId";
			this.btnShuId.Size = new System.Drawing.Size(106, 31);
			this.btnShuId.TabIndex = 6;
			this.btnShuId.Text = "Search";
			this.btnShuId.UseVisualStyleBackColor = true;
			this.btnShuId.Click += new System.EventHandler(this.btnShuId_Click);
			// 
			// txtShuID
			// 
			this.txtShuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShuID.Location = new System.Drawing.Point(198, 142);
			this.txtShuID.Name = "txtShuID";
			this.txtShuID.Size = new System.Drawing.Size(217, 31);
			this.txtShuID.TabIndex = 2;
			// 
			// ItemsOnLoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1276, 757);
			this.Controls.Add(this.lblTotalRows);
			this.Controls.Add(this.lblTotalItems);
			this.Controls.Add(this.btnResourceType);
			this.Controls.Add(this.txtResourceType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnShuId);
			this.Controls.Add(this.txtShuID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnSearchBarcode);
			this.Controls.Add(this.btnSearchName);
			this.Controls.Add(this.txtSerialNo);
			this.Controls.Add(this.txtResourceName);
			this.Controls.Add(this.txtResourceBarcode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loanedItemsGridView);
			this.Controls.Add(this.btnBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ItemsOnLoan";
			this.Text = "ItemsOnLoan";
			this.Load += new System.EventHandler(this.ItemsOnLoan_Load);
			((System.ComponentModel.ISupportInitialize)(this.loanedItemsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchBarcode;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label txtResourceBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView loanedItemsGridView;
		private System.Windows.Forms.Button btnResourceType;
		private System.Windows.Forms.TextBox txtResourceType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTotalRows;
		private System.Windows.Forms.Label lblTotalItems;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnShuId;
		private System.Windows.Forms.TextBox txtShuID;
	}
}