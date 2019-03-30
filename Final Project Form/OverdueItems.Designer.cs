namespace Final_Project_Form
{
    partial class OverdueItems
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
			this.overdueItemsGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.overdueItemsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(776, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(74, 35);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// overdueItemsGridView
			// 
			this.overdueItemsGridView.AllowUserToAddRows = false;
			this.overdueItemsGridView.AllowUserToDeleteRows = false;
			this.overdueItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.overdueItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.overdueItemsGridView.Location = new System.Drawing.Point(12, 88);
			this.overdueItemsGridView.Name = "overdueItemsGridView";
			this.overdueItemsGridView.ReadOnly = true;
			this.overdueItemsGridView.Size = new System.Drawing.Size(838, 372);
			this.overdueItemsGridView.TabIndex = 1;
			this.overdueItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.overdueItemsGridView_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Overdue Items";
			// 
			// OverdueItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 487);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.overdueItemsGridView);
			this.Controls.Add(this.btnBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "OverdueItems";
			this.Text = "OverdueItems";
			this.Load += new System.EventHandler(this.OverdueItems_Load);
			((System.ComponentModel.ISupportInitialize)(this.overdueItemsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView overdueItemsGridView;
        private System.Windows.Forms.Label label1;
    }
}