namespace Final_Project_Form
{
    partial class findUserEmail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findUserEmail));
			this.btnBack = new System.Windows.Forms.Button();
			this.studentGridView = new System.Windows.Forms.DataGridView();
			this.btnSearchSurname = new System.Windows.Forms.Button();
			this.btnSearchShu = new System.Windows.Forms.Button();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtShuId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(770, 561);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(115, 38);
			this.btnBack.TabIndex = 18;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// studentGridView
			// 
			this.studentGridView.AllowUserToAddRows = false;
			this.studentGridView.AllowUserToDeleteRows = false;
			this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentGridView.Location = new System.Drawing.Point(41, 231);
			this.studentGridView.Name = "studentGridView";
			this.studentGridView.ReadOnly = true;
			this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.studentGridView.Size = new System.Drawing.Size(844, 308);
			this.studentGridView.TabIndex = 17;
			this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick);
			// 
			// btnSearchSurname
			// 
			this.btnSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchSurname.Location = new System.Drawing.Point(527, 168);
			this.btnSearchSurname.Name = "btnSearchSurname";
			this.btnSearchSurname.Size = new System.Drawing.Size(106, 31);
			this.btnSearchSurname.TabIndex = 16;
			this.btnSearchSurname.Text = "Search";
			this.btnSearchSurname.UseVisualStyleBackColor = true;
			this.btnSearchSurname.Click += new System.EventHandler(this.btnSearchSurname_Click);
			// 
			// btnSearchShu
			// 
			this.btnSearchShu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchShu.Location = new System.Drawing.Point(527, 107);
			this.btnSearchShu.Name = "btnSearchShu";
			this.btnSearchShu.Size = new System.Drawing.Size(106, 31);
			this.btnSearchShu.TabIndex = 15;
			this.btnSearchShu.Text = "Search";
			this.btnSearchShu.UseVisualStyleBackColor = true;
			this.btnSearchShu.Click += new System.EventHandler(this.btnSearchShu_Click);
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSurname.Location = new System.Drawing.Point(213, 168);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(217, 31);
			this.txtSurname.TabIndex = 14;
			// 
			// txtShuId
			// 
			this.txtShuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShuId.Location = new System.Drawing.Point(213, 107);
			this.txtShuId.Name = "txtShuId";
			this.txtShuId.Size = new System.Drawing.Size(217, 31);
			this.txtShuId.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(97, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 24);
			this.label3.TabIndex = 12;
			this.label3.Text = "Surname";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(97, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "SHU ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Search by Person";
			// 
			// findUserEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 633);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.studentGridView);
			this.Controls.Add(this.btnSearchSurname);
			this.Controls.Add(this.btnSearchShu);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.txtShuId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "findUserEmail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "findUserEmail";
			this.Load += new System.EventHandler(this.findUserEmail_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button btnSearchSurname;
        private System.Windows.Forms.Button btnSearchShu;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtShuId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}