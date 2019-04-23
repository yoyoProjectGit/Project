namespace Final_Project_Form
{
    partial class ItemReturns
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemReturns));
			this.label1 = new System.Windows.Forms.Label();
			this.txtSerialNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStudentID = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btncheckSHUid = new System.Windows.Forms.Button();
			this.btnSearchSerialNo = new System.Windows.Forms.Button();
			this.btnSearchScanID = new System.Windows.Forms.Button();
			this.txtScanID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(114, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Return Borrowed Items";
			// 
			// txtSerialNo
			// 
			this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNo.Location = new System.Drawing.Point(175, 78);
			this.txtSerialNo.Name = "txtSerialNo";
			this.txtSerialNo.Size = new System.Drawing.Size(169, 31);
			this.txtSerialNo.TabIndex = 0;
			this.txtSerialNo.TextChanged += new System.EventHandler(this.txtSerialNo_TextChanged);
			this.txtSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNo_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Serial Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Student ID:";
			// 
			// txtStudentID
			// 
			this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentID.Location = new System.Drawing.Point(175, 125);
			this.txtStudentID.Name = "txtStudentID";
			this.txtStudentID.Size = new System.Drawing.Size(169, 31);
			this.txtStudentID.TabIndex = 1;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(437, 218);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 60);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btncheckSHUid
			// 
			this.btncheckSHUid.Location = new System.Drawing.Point(374, 125);
			this.btncheckSHUid.Name = "btncheckSHUid";
			this.btncheckSHUid.Size = new System.Drawing.Size(92, 31);
			this.btncheckSHUid.TabIndex = 4;
			this.btncheckSHUid.Text = "Check SHU ID";
			this.btncheckSHUid.UseVisualStyleBackColor = true;
			this.btncheckSHUid.Click += new System.EventHandler(this.btncheckSHUid_Click);
			// 
			// btnSearchSerialNo
			// 
			this.btnSearchSerialNo.Location = new System.Drawing.Point(374, 78);
			this.btnSearchSerialNo.Name = "btnSearchSerialNo";
			this.btnSearchSerialNo.Size = new System.Drawing.Size(92, 31);
			this.btnSearchSerialNo.TabIndex = 3;
			this.btnSearchSerialNo.Text = "Check SerialNo";
			this.btnSearchSerialNo.UseVisualStyleBackColor = true;
			this.btnSearchSerialNo.Click += new System.EventHandler(this.btnSearchSerialNo_Click);
			// 
			// btnSearchScanID
			// 
			this.btnSearchScanID.Location = new System.Drawing.Point(374, 173);
			this.btnSearchScanID.Name = "btnSearchScanID";
			this.btnSearchScanID.Size = new System.Drawing.Size(92, 31);
			this.btnSearchScanID.TabIndex = 5;
			this.btnSearchScanID.Text = "Check Scan ID";
			this.btnSearchScanID.UseVisualStyleBackColor = true;
			this.btnSearchScanID.Click += new System.EventHandler(this.btnSearchScanID_Click);
			// 
			// txtScanID
			// 
			this.txtScanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScanID.Location = new System.Drawing.Point(175, 173);
			this.txtScanID.Name = "txtScanID";
			this.txtScanID.Size = new System.Drawing.Size(169, 31);
			this.txtScanID.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Scan Card:";
			// 
			// ItemReturns
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 290);
			this.Controls.Add(this.btnSearchScanID);
			this.Controls.Add(this.txtScanID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSearchSerialNo);
			this.Controls.Add(this.btncheckSHUid);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtStudentID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSerialNo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ItemReturns";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ItemReturns";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btncheckSHUid;
		private System.Windows.Forms.Button btnSearchSerialNo;
		private System.Windows.Forms.Button btnSearchScanID;
		private System.Windows.Forms.TextBox txtScanID;
		private System.Windows.Forms.Label label4;
	}
}