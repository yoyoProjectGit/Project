namespace Final_Project_Form
{
    partial class ViewDisposedItems
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDisposedItems));
			this.disposedItemsGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.disposedItemsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// disposedItemsGridView
			// 
			this.disposedItemsGridView.AllowUserToAddRows = false;
			this.disposedItemsGridView.AllowUserToDeleteRows = false;
			this.disposedItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.disposedItemsGridView.Location = new System.Drawing.Point(12, 96);
			this.disposedItemsGridView.Name = "disposedItemsGridView";
			this.disposedItemsGridView.ReadOnly = true;
			this.disposedItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.disposedItemsGridView.Size = new System.Drawing.Size(1139, 473);
			this.disposedItemsGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 24);
			this.label1.TabIndex = 78;
			this.label1.Text = "Disposed Items:";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(1024, 25);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(95, 46);
			this.btnBack.TabIndex = 79;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// ViewDisposedItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1163, 581);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.disposedItemsGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ViewDisposedItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewDisposedItems";
			this.Load += new System.EventHandler(this.ViewDisposedItems_Load);
			((System.ComponentModel.ISupportInitialize)(this.disposedItemsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView disposedItemsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}