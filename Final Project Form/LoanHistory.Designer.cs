namespace Final_Project_Form
{
	partial class LoanHistory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanHistory));
			this.loanHistoryGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnResourceType = new System.Windows.Forms.Button();
			this.txtResourceType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnShuId = new System.Windows.Forms.Button();
			this.txtShuID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearchName = new System.Windows.Forms.Button();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblTotalRows = new System.Windows.Forms.Label();
			this.lblTotalItems = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// loanHistoryGridView
			// 
			this.loanHistoryGridView.AllowUserToAddRows = false;
			this.loanHistoryGridView.AllowUserToDeleteRows = false;
			this.loanHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loanHistoryGridView.Location = new System.Drawing.Point(12, 215);
			this.loanHistoryGridView.Name = "loanHistoryGridView";
			this.loanHistoryGridView.ReadOnly = true;
			this.loanHistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loanHistoryGridView.Size = new System.Drawing.Size(1126, 446);
			this.loanHistoryGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "Loan History";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(1015, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(123, 55);
			this.btnClose.TabIndex = 18;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnResourceType
			// 
			this.btnResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResourceType.Location = new System.Drawing.Point(523, 133);
			this.btnResourceType.Name = "btnResourceType";
			this.btnResourceType.Size = new System.Drawing.Size(106, 31);
			this.btnResourceType.TabIndex = 80;
			this.btnResourceType.Text = "Search";
			this.btnResourceType.UseVisualStyleBackColor = true;
			this.btnResourceType.Click += new System.EventHandler(this.btnResourceType_Click);
			// 
			// txtResourceType
			// 
			this.txtResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceType.Location = new System.Drawing.Point(209, 133);
			this.txtResourceType.Name = "txtResourceType";
			this.txtResourceType.Size = new System.Drawing.Size(217, 31);
			this.txtResourceType.TabIndex = 76;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 24);
			this.label4.TabIndex = 84;
			this.label4.Text = "Resource Type:";
			// 
			// btnShuId
			// 
			this.btnShuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShuId.Location = new System.Drawing.Point(523, 96);
			this.btnShuId.Name = "btnShuId";
			this.btnShuId.Size = new System.Drawing.Size(106, 31);
			this.btnShuId.TabIndex = 79;
			this.btnShuId.Text = "Search";
			this.btnShuId.UseVisualStyleBackColor = true;
			this.btnShuId.Click += new System.EventHandler(this.btnShuId_Click);
			// 
			// txtShuID
			// 
			this.txtShuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShuID.Location = new System.Drawing.Point(209, 96);
			this.txtShuID.Name = "txtShuID";
			this.txtShuID.Size = new System.Drawing.Size(217, 31);
			this.txtShuID.TabIndex = 75;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 83;
			this.label3.Text = "SHU ID:";
			// 
			// btnSearchName
			// 
			this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchName.Location = new System.Drawing.Point(523, 59);
			this.btnSearchName.Name = "btnSearchName";
			this.btnSearchName.Size = new System.Drawing.Size(106, 31);
			this.btnSearchName.TabIndex = 77;
			this.btnSearchName.Text = "Search";
			this.btnSearchName.UseVisualStyleBackColor = true;
			this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(209, 59);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 73;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 24);
			this.label2.TabIndex = 81;
			this.label2.Text = "Resource Name:";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(832, 97);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(103, 92);
			this.btnRefresh.TabIndex = 85;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// lblTotalRows
			// 
			this.lblTotalRows.AutoSize = true;
			this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalRows.Location = new System.Drawing.Point(656, 68);
			this.lblTotalRows.Name = "lblTotalRows";
			this.lblTotalRows.Size = new System.Drawing.Size(0, 24);
			this.lblTotalRows.TabIndex = 87;
			// 
			// lblTotalItems
			// 
			this.lblTotalItems.AutoSize = true;
			this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalItems.Location = new System.Drawing.Point(656, 43);
			this.lblTotalItems.Name = "lblTotalItems";
			this.lblTotalItems.Size = new System.Drawing.Size(0, 24);
			this.lblTotalItems.TabIndex = 86;
			// 
			// LoanHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 700);
			this.Controls.Add(this.lblTotalRows);
			this.Controls.Add(this.lblTotalItems);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnResourceType);
			this.Controls.Add(this.txtResourceType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnShuId);
			this.Controls.Add(this.txtShuID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSearchName);
			this.Controls.Add(this.txtResourceName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loanHistoryGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoanHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoanHistory";
			this.Load += new System.EventHandler(this.LoanHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView loanHistoryGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnResourceType;
		private System.Windows.Forms.TextBox txtResourceType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnShuId;
		private System.Windows.Forms.TextBox txtShuID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSearchName;
		private System.Windows.Forms.TextBox txtResourceName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label lblTotalRows;
		private System.Windows.Forms.Label lblTotalItems;
	}
}