namespace Final_Project_Form
{
    partial class DisposeChosenItems
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
			this.txtResourceType = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtItemID = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDispose = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMethodOfDisposal = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(283, 510);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(103, 59);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "Cancel";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtResourceType
			// 
			this.txtResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceType.Location = new System.Drawing.Point(186, 28);
			this.txtResourceType.Name = "txtResourceType";
			this.txtResourceType.ReadOnly = true;
			this.txtResourceType.Size = new System.Drawing.Size(217, 31);
			this.txtResourceType.TabIndex = 71;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity.Location = new System.Drawing.Point(186, 437);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(217, 31);
			this.txtQuantity.TabIndex = 2;
			this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			// 
			// txtItemID
			// 
			this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItemID.Location = new System.Drawing.Point(186, 139);
			this.txtItemID.Name = "txtItemID";
			this.txtItemID.ReadOnly = true;
			this.txtItemID.Size = new System.Drawing.Size(217, 31);
			this.txtItemID.TabIndex = 74;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDepartment.Location = new System.Drawing.Point(186, 102);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.ReadOnly = true;
			this.txtDepartment.Size = new System.Drawing.Size(217, 31);
			this.txtDepartment.TabIndex = 75;
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(186, 65);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.ReadOnly = true;
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 76;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 24);
			this.label7.TabIndex = 77;
			this.label7.Text = "Resource Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 24);
			this.label1.TabIndex = 78;
			this.label1.Text = "Resource Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 24);
			this.label2.TabIndex = 79;
			this.label2.Text = "Department:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 24);
			this.label3.TabIndex = 80;
			this.label3.Text = "ResourceID:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 444);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 24);
			this.label4.TabIndex = 81;
			this.label4.Text = "Quantity:";
			// 
			// btnDispose
			// 
			this.btnDispose.Location = new System.Drawing.Point(21, 510);
			this.btnDispose.Name = "btnDispose";
			this.btnDispose.Size = new System.Drawing.Size(103, 59);
			this.btnDispose.TabIndex = 3;
			this.btnDispose.Text = "Dispose Items";
			this.btnDispose.UseVisualStyleBackColor = true;
			this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 24);
			this.label5.TabIndex = 83;
			this.label5.Text = "Reason:";
			// 
			// txtReason
			// 
			this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReason.Location = new System.Drawing.Point(186, 191);
			this.txtReason.Multiline = true;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(217, 98);
			this.txtReason.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 313);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(179, 24);
			this.label6.TabIndex = 85;
			this.label6.Text = "Method Of Disposal:";
			// 
			// txtMethodOfDisposal
			// 
			this.txtMethodOfDisposal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMethodOfDisposal.Location = new System.Drawing.Point(186, 309);
			this.txtMethodOfDisposal.Multiline = true;
			this.txtMethodOfDisposal.Name = "txtMethodOfDisposal";
			this.txtMethodOfDisposal.Size = new System.Drawing.Size(217, 98);
			this.txtMethodOfDisposal.TabIndex = 1;
			// 
			// DisposeChosenItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 581);
			this.Controls.Add(this.txtMethodOfDisposal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtReason);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnDispose);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtResourceName);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.txtItemID);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtResourceType);
			this.Controls.Add(this.btnBack);
			this.Name = "DisposeChosenItems";
			this.Text = "DisposeChosenItems";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtResourceType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMethodOfDisposal;
    }
}