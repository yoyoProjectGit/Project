namespace Final_Project_Form
{
    partial class viewStudentInfo
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label9;
			System.Windows.Forms.Label label10;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStudentInfo));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dropUserType = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtScanID = new System.Windows.Forms.TextBox();
			this.txtDateAdded = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.btnBack = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCourseDept = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtShuId = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnClose = new System.Windows.Forms.Button();
			this.LoanedItemsGridView = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnClose2 = new System.Windows.Forms.Button();
			this.loanHistory = new System.Windows.Forms.DataGridView();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTotalDays = new System.Windows.Forms.TextBox();
			this.btnExtendLoan = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.txtDueDate = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtDateLoaned = new System.Windows.Forms.TextBox();
			this.txtBorrowerName = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtSerialNo = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txtUserType = new System.Windows.Forms.TextBox();
			this.txtResourceName = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.btnBackToLoan = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoanedItemsGridView)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loanHistory)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label9.Location = new System.Drawing.Point(22, 20);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(218, 25);
			label9.TabIndex = 1;
			label9.Text = "Current Loaned Items";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label10.Location = new System.Drawing.Point(17, 22);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(213, 25);
			label10.TabIndex = 2;
			label10.Text = "Student Loan History";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(772, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.dropUserType);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.txtScanID);
			this.tabPage1.Controls.Add(this.txtDateAdded);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.startDatePicker);
			this.tabPage1.Controls.Add(this.btnBack);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtEmail);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.txtCourseDept);
			this.tabPage1.Controls.Add(this.txtSurname);
			this.tabPage1.Controls.Add(this.txtFirstName);
			this.tabPage1.Controls.Add(this.txtShuId);
			this.tabPage1.Controls.Add(this.btnUpdate);
			this.tabPage1.Controls.Add(this.btnEdit);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(764, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "View Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dropUserType
			// 
			this.dropUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dropUserType.FormattingEnabled = true;
			this.dropUserType.Items.AddRange(new object[] {
            "Student",
            "Staff"});
			this.dropUserType.Location = new System.Drawing.Point(188, 75);
			this.dropUserType.Name = "dropUserType";
			this.dropUserType.Size = new System.Drawing.Size(292, 33);
			this.dropUserType.TabIndex = 36;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(38, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(135, 24);
			this.label11.TabIndex = 35;
			this.label11.Text = "Scannable No:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(38, 79);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 24);
			this.label12.TabIndex = 34;
			this.label12.Text = "User Type:";
			// 
			// txtScanID
			// 
			this.txtScanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScanID.Location = new System.Drawing.Point(188, 116);
			this.txtScanID.Name = "txtScanID";
			this.txtScanID.ReadOnly = true;
			this.txtScanID.Size = new System.Drawing.Size(292, 31);
			this.txtScanID.TabIndex = 33;
			// 
			// txtDateAdded
			// 
			this.txtDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateAdded.Location = new System.Drawing.Point(188, 338);
			this.txtDateAdded.Name = "txtDateAdded";
			this.txtDateAdded.ReadOnly = true;
			this.txtDateAdded.Size = new System.Drawing.Size(292, 31);
			this.txtDateAdded.TabIndex = 31;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(38, 342);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 30;
			this.label8.Text = "Date added:";
			// 
			// startDatePicker
			// 
			this.startDatePicker.Location = new System.Drawing.Point(188, 387);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(217, 20);
			this.startDatePicker.TabIndex = 29;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(607, 377);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(90, 36);
			this.btnBack.TabIndex = 28;
			this.btnBack.Text = "Close";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 381);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 24);
			this.label6.TabIndex = 26;
			this.label6.Text = "Start Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 305);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 24);
			this.label5.TabIndex = 25;
			this.label5.Text = "Email Address:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(188, 301);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(292, 31);
			this.txtEmail.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 268);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "Course/Dept:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 24);
			this.label3.TabIndex = 22;
			this.label3.Text = "Surname:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "First Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(38, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 24);
			this.label7.TabIndex = 20;
			this.label7.Text = "SHU ID:";
			// 
			// txtCourseDept
			// 
			this.txtCourseDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCourseDept.Location = new System.Drawing.Point(188, 264);
			this.txtCourseDept.Name = "txtCourseDept";
			this.txtCourseDept.ReadOnly = true;
			this.txtCourseDept.Size = new System.Drawing.Size(292, 31);
			this.txtCourseDept.TabIndex = 19;
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSurname.Location = new System.Drawing.Point(188, 227);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.ReadOnly = true;
			this.txtSurname.Size = new System.Drawing.Size(292, 31);
			this.txtSurname.TabIndex = 18;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(188, 190);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.ReadOnly = true;
			this.txtFirstName.Size = new System.Drawing.Size(292, 31);
			this.txtFirstName.TabIndex = 17;
			// 
			// txtShuId
			// 
			this.txtShuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShuId.Location = new System.Drawing.Point(188, 153);
			this.txtShuId.Name = "txtShuId";
			this.txtShuId.ReadOnly = true;
			this.txtShuId.Size = new System.Drawing.Size(292, 31);
			this.txtShuId.TabIndex = 16;
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
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(489, 27);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(91, 33);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personal Info";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnClose);
			this.tabPage2.Controls.Add(label9);
			this.tabPage2.Controls.Add(this.LoanedItemsGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(764, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "View Loans";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(658, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(87, 39);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// LoanedItemsGridView
			// 
			this.LoanedItemsGridView.AllowUserToAddRows = false;
			this.LoanedItemsGridView.AllowUserToDeleteRows = false;
			this.LoanedItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.LoanedItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LoanedItemsGridView.Location = new System.Drawing.Point(8, 61);
			this.LoanedItemsGridView.Name = "LoanedItemsGridView";
			this.LoanedItemsGridView.ReadOnly = true;
			this.LoanedItemsGridView.Size = new System.Drawing.Size(749, 355);
			this.LoanedItemsGridView.TabIndex = 0;
			this.LoanedItemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanedItemsGridView_CellContentClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnClose2);
			this.tabPage3.Controls.Add(label10);
			this.tabPage3.Controls.Add(this.loanHistory);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(764, 424);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "View Loan History";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnClose2
			// 
			this.btnClose2.Location = new System.Drawing.Point(658, 16);
			this.btnClose2.Name = "btnClose2";
			this.btnClose2.Size = new System.Drawing.Size(87, 39);
			this.btnClose2.TabIndex = 3;
			this.btnClose2.Text = "Close";
			this.btnClose2.UseVisualStyleBackColor = true;
			this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
			// 
			// loanHistory
			// 
			this.loanHistory.AllowUserToAddRows = false;
			this.loanHistory.AllowUserToDeleteRows = false;
			this.loanHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.loanHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loanHistory.Location = new System.Drawing.Point(8, 61);
			this.loanHistory.Name = "loanHistory";
			this.loanHistory.ReadOnly = true;
			this.loanHistory.Size = new System.Drawing.Size(749, 355);
			this.loanHistory.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.txtTotalDays);
			this.tabPage4.Controls.Add(this.btnExtendLoan);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.txtDueDate);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.label17);
			this.tabPage4.Controls.Add(this.txtDateLoaned);
			this.tabPage4.Controls.Add(this.txtBorrowerName);
			this.tabPage4.Controls.Add(this.label19);
			this.tabPage4.Controls.Add(this.txtSerialNo);
			this.tabPage4.Controls.Add(this.label21);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.txtUserType);
			this.tabPage4.Controls.Add(this.txtResourceName);
			this.tabPage4.Controls.Add(this.label24);
			this.tabPage4.Controls.Add(this.btnBackToLoan);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(764, 424);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Extend Loan";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(432, 243);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(315, 24);
			this.label14.TabIndex = 62;
			this.label14.Text = "Days are extended from todays date!";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(478, 184);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(98, 37);
			this.label13.TabIndex = 61;
			this.label13.Text = "Days:";
			// 
			// txtTotalDays
			// 
			this.txtTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalDays.Location = new System.Drawing.Point(597, 190);
			this.txtTotalDays.Name = "txtTotalDays";
			this.txtTotalDays.Size = new System.Drawing.Size(44, 31);
			this.txtTotalDays.TabIndex = 60;
			this.txtTotalDays.TextChanged += new System.EventHandler(this.txtTotalDays_TextChanged);
			this.txtTotalDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDays_KeyPress);
			// 
			// btnExtendLoan
			// 
			this.btnExtendLoan.Location = new System.Drawing.Point(648, 348);
			this.btnExtendLoan.Name = "btnExtendLoan";
			this.btnExtendLoan.Size = new System.Drawing.Size(99, 52);
			this.btnExtendLoan.TabIndex = 59;
			this.btnExtendLoan.Text = "Extend";
			this.btnExtendLoan.UseVisualStyleBackColor = true;
			this.btnExtendLoan.Click += new System.EventHandler(this.btnExtendLoan_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(27, 348);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(93, 24);
			this.label15.TabIndex = 58;
			this.label15.Text = "Due Date:";
			// 
			// txtDueDate
			// 
			this.txtDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDueDate.Location = new System.Drawing.Point(194, 341);
			this.txtDueDate.Name = "txtDueDate";
			this.txtDueDate.ReadOnly = true;
			this.txtDueDate.Size = new System.Drawing.Size(217, 31);
			this.txtDueDate.TabIndex = 57;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(27, 296);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(122, 24);
			this.label16.TabIndex = 56;
			this.label16.Text = "Date Loaned:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(27, 243);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(148, 24);
			this.label17.TabIndex = 55;
			this.label17.Text = "Borrower Name:";
			// 
			// txtDateLoaned
			// 
			this.txtDateLoaned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDateLoaned.Location = new System.Drawing.Point(194, 292);
			this.txtDateLoaned.Name = "txtDateLoaned";
			this.txtDateLoaned.ReadOnly = true;
			this.txtDateLoaned.Size = new System.Drawing.Size(217, 31);
			this.txtDateLoaned.TabIndex = 54;
			// 
			// txtBorrowerName
			// 
			this.txtBorrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBorrowerName.Location = new System.Drawing.Point(194, 243);
			this.txtBorrowerName.Name = "txtBorrowerName";
			this.txtBorrowerName.ReadOnly = true;
			this.txtBorrowerName.Size = new System.Drawing.Size(217, 31);
			this.txtBorrowerName.TabIndex = 53;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(27, 148);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(92, 24);
			this.label19.TabIndex = 51;
			this.label19.Text = "Serial No:";
			// 
			// txtSerialNo
			// 
			this.txtSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNo.Location = new System.Drawing.Point(194, 141);
			this.txtSerialNo.Name = "txtSerialNo";
			this.txtSerialNo.ReadOnly = true;
			this.txtSerialNo.Size = new System.Drawing.Size(217, 31);
			this.txtSerialNo.TabIndex = 50;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(27, 197);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(102, 24);
			this.label21.TabIndex = 48;
			this.label21.Text = "User Type:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(27, 93);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(153, 24);
			this.label22.TabIndex = 47;
			this.label22.Text = "Resource Name:";
			// 
			// txtUserType
			// 
			this.txtUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserType.Location = new System.Drawing.Point(194, 193);
			this.txtUserType.Name = "txtUserType";
			this.txtUserType.ReadOnly = true;
			this.txtUserType.Size = new System.Drawing.Size(217, 31);
			this.txtUserType.TabIndex = 45;
			// 
			// txtResourceName
			// 
			this.txtResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResourceName.Location = new System.Drawing.Point(194, 93);
			this.txtResourceName.Name = "txtResourceName";
			this.txtResourceName.ReadOnly = true;
			this.txtResourceName.Size = new System.Drawing.Size(217, 31);
			this.txtResourceName.TabIndex = 44;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(24, 19);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(351, 37);
			this.label24.TabIndex = 41;
			this.label24.Text = "Item Chosen To Extend";
			// 
			// btnBackToLoan
			// 
			this.btnBackToLoan.Location = new System.Drawing.Point(648, 17);
			this.btnBackToLoan.Name = "btnBackToLoan";
			this.btnBackToLoan.Size = new System.Drawing.Size(87, 39);
			this.btnBackToLoan.TabIndex = 3;
			this.btnBackToLoan.Text = "Back";
			this.btnBackToLoan.UseVisualStyleBackColor = true;
			this.btnBackToLoan.Click += new System.EventHandler(this.btnBackToLoan_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// viewStudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 450);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "viewStudentInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "viewStudentInfo";
			this.Load += new System.EventHandler(this.viewStudentInfo_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoanedItemsGridView)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loanHistory)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourseDept;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtShuId;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView LoanedItemsGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView loanHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtScanID;
		private System.Windows.Forms.ComboBox dropUserType;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnBackToLoan;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtTotalDays;
		private System.Windows.Forms.Button btnExtendLoan;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtDueDate;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtDateLoaned;
		private System.Windows.Forms.TextBox txtBorrowerName;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtSerialNo;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtUserType;
		private System.Windows.Forms.TextBox txtResourceName;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ImageList imageList1;
	}
}