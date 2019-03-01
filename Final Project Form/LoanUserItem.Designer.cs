namespace Final_Project_Form
{
    partial class LoanUserItem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoanItems = new System.Windows.Forms.Button();
            this.txtCurrentId = new System.Windows.Forms.TextBox();
            this.txtCurrentEmail = new System.Windows.Forms.TextBox();
            this.txtCurrentSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchBarcode = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.txtResourceBarcode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pickedItemsGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShuId2 = new System.Windows.Forms.TextBox();
            this.txtCurrentEmail2 = new System.Windows.Forms.TextBox();
            this.txtCurrentSurname2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCurrentName2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConfirmItems = new System.Windows.Forms.Button();
            this.ResourceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLoanPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.Size = new System.Drawing.Size(1587, 745);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoanItems);
            this.tabPage1.Controls.Add(this.txtCurrentId);
            this.tabPage1.Controls.Add(this.txtCurrentEmail);
            this.tabPage1.Controls.Add(this.txtCurrentSurname);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCurrentName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.btnSearchBarcode);
            this.tabPage1.Controls.Add(this.btnSearchName);
            this.tabPage1.Controls.Add(this.txtBarcode);
            this.tabPage1.Controls.Add(this.txtResourceName);
            this.tabPage1.Controls.Add(this.txtResourceBarcode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.inventoryGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1579, 719);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoanItems
            // 
            this.btnLoanItems.Location = new System.Drawing.Point(1340, 574);
            this.btnLoanItems.Name = "btnLoanItems";
            this.btnLoanItems.Size = new System.Drawing.Size(105, 64);
            this.btnLoanItems.TabIndex = 58;
            this.btnLoanItems.Text = "Loan Items";
            this.btnLoanItems.UseVisualStyleBackColor = true;
            this.btnLoanItems.Click += new System.EventHandler(this.btnLoanItems_Click);
            // 
            // txtCurrentId
            // 
            this.txtCurrentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentId.Location = new System.Drawing.Point(1146, 216);
            this.txtCurrentId.Name = "txtCurrentId";
            this.txtCurrentId.ReadOnly = true;
            this.txtCurrentId.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentId.TabIndex = 57;
            // 
            // txtCurrentEmail
            // 
            this.txtCurrentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentEmail.Location = new System.Drawing.Point(1146, 173);
            this.txtCurrentEmail.Name = "txtCurrentEmail";
            this.txtCurrentEmail.ReadOnly = true;
            this.txtCurrentEmail.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentEmail.TabIndex = 56;
            // 
            // txtCurrentSurname
            // 
            this.txtCurrentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSurname.Location = new System.Drawing.Point(1146, 130);
            this.txtCurrentSurname.Name = "txtCurrentSurname";
            this.txtCurrentSurname.ReadOnly = true;
            this.txtCurrentSurname.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentSurname.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1014, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Shu ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1014, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1014, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1014, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "First Name";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentName.Location = new System.Drawing.Point(1146, 86);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.ReadOnly = true;
            this.txtCurrentName.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentName.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1426, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Current Student";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(715, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 92);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(836, 643);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 59);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchBarcode
            // 
            this.btnSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarcode.Location = new System.Drawing.Point(502, 150);
            this.btnSearchBarcode.Name = "btnSearchBarcode";
            this.btnSearchBarcode.Size = new System.Drawing.Size(106, 31);
            this.btnSearchBarcode.TabIndex = 46;
            this.btnSearchBarcode.Text = "Search";
            this.btnSearchBarcode.UseVisualStyleBackColor = true;
            this.btnSearchBarcode.Click += new System.EventHandler(this.btnSearchBarcode_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(502, 89);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(106, 31);
            this.btnSearchName.TabIndex = 45;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(188, 150);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(217, 31);
            this.txtBarcode.TabIndex = 44;
            // 
            // txtResourceName
            // 
            this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResourceName.Location = new System.Drawing.Point(188, 89);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(217, 31);
            this.txtResourceName.TabIndex = 43;
            // 
            // txtResourceBarcode
            // 
            this.txtResourceBarcode.AutoSize = true;
            this.txtResourceBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResourceBarcode.Location = new System.Drawing.Point(12, 150);
            this.txtResourceBarcode.Name = "txtResourceBarcode";
            this.txtResourceBarcode.Size = new System.Drawing.Size(173, 24);
            this.txtResourceBarcode.TabIndex = 42;
            this.txtResourceBarcode.Text = "Resource Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Resource Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search For Item to loan";
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.AllowUserToDeleteRows = false;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(16, 273);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.ReadOnly = true;
            this.inventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryGridView.Size = new System.Drawing.Size(1093, 353);
            this.inventoryGridView.TabIndex = 39;
            this.inventoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellContentClick);
            this.inventoryGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryGridView_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConfirmItems);
            this.tabPage2.Controls.Add(this.txtShuId2);
            this.tabPage2.Controls.Add(this.txtCurrentEmail2);
            this.tabPage2.Controls.Add(this.txtCurrentSurname2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtCurrentName2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.pickedItemsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1579, 719);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chosen Items";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.OrderNumber,
            this.PurchasePrice,
            this.Notes});
            this.pickedItemsGridView.Location = new System.Drawing.Point(110, 326);
            this.pickedItemsGridView.Name = "pickedItemsGridView";
            this.pickedItemsGridView.ReadOnly = true;
            this.pickedItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pickedItemsGridView.Size = new System.Drawing.Size(1043, 300);
            this.pickedItemsGridView.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "These are your chosen items for loan";
            // 
            // txtShuId2
            // 
            this.txtShuId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShuId2.Location = new System.Drawing.Point(1126, 216);
            this.txtShuId2.Name = "txtShuId2";
            this.txtShuId2.ReadOnly = true;
            this.txtShuId2.Size = new System.Drawing.Size(312, 31);
            this.txtShuId2.TabIndex = 67;
            // 
            // txtCurrentEmail2
            // 
            this.txtCurrentEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentEmail2.Location = new System.Drawing.Point(1126, 173);
            this.txtCurrentEmail2.Name = "txtCurrentEmail2";
            this.txtCurrentEmail2.ReadOnly = true;
            this.txtCurrentEmail2.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentEmail2.TabIndex = 66;
            // 
            // txtCurrentSurname2
            // 
            this.txtCurrentSurname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSurname2.Location = new System.Drawing.Point(1126, 130);
            this.txtCurrentSurname2.Name = "txtCurrentSurname2";
            this.txtCurrentSurname2.ReadOnly = true;
            this.txtCurrentSurname2.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentSurname2.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(994, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 64;
            this.label9.Text = "Shu ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(994, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 63;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(994, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(994, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 24);
            this.label12.TabIndex = 61;
            this.label12.Text = "First Name";
            // 
            // txtCurrentName2
            // 
            this.txtCurrentName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentName2.Location = new System.Drawing.Point(1126, 86);
            this.txtCurrentName2.Name = "txtCurrentName2";
            this.txtCurrentName2.ReadOnly = true;
            this.txtCurrentName2.Size = new System.Drawing.Size(312, 31);
            this.txtCurrentName2.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1406, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 24);
            this.label13.TabIndex = 59;
            this.label13.Text = "Current Student";
            // 
            // btnConfirmItems
            // 
            this.btnConfirmItems.Location = new System.Drawing.Point(1330, 542);
            this.btnConfirmItems.Name = "btnConfirmItems";
            this.btnConfirmItems.Size = new System.Drawing.Size(121, 73);
            this.btnConfirmItems.TabIndex = 68;
            this.btnConfirmItems.Text = "Confirm Items";
            this.btnConfirmItems.UseVisualStyleBackColor = true;
            this.btnConfirmItems.Click += new System.EventHandler(this.btnConfirmItems_Click);
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
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "OrderNumber";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // LoanUserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 757);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoanUserItem";
            this.Text = "LoanUserItem";
            this.Load += new System.EventHandler(this.LoanUserItem_Load);
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
        private System.Windows.Forms.TextBox txtCurrentId;
        private System.Windows.Forms.TextBox txtCurrentEmail;
        private System.Windows.Forms.TextBox txtCurrentSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchBarcode;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.Label txtResourceBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView pickedItemsGridView;
        private System.Windows.Forms.Button btnLoanItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShuId2;
        private System.Windows.Forms.TextBox txtCurrentEmail2;
        private System.Windows.Forms.TextBox txtCurrentSurname2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCurrentName2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConfirmItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxLoanPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}