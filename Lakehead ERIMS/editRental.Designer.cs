namespace Lakehead_ERIMS
{
    partial class editRental
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
            this.invoiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invoiceNumberTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOutPicker = new System.Windows.Forms.DateTimePicker();
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.studentFirstNameLabel = new System.Windows.Forms.Label();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.equipNameLabel = new System.Windows.Forms.Label();
            this.equipNumberLabel = new System.Windows.Forms.Label();
            this.studentLastNameLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.tblEquipTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.studentNumberLbl = new System.Windows.Forms.Label();
            this.studentNumberTbx = new System.Windows.Forms.TextBox();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.studentNameTbx = new System.Windows.Forms.TextBox();
            this.studentAddressLbl = new System.Windows.Forms.Label();
            this.studentAddressTbx = new System.Windows.Forms.TextBox();
            this.studentPhoneLbl = new System.Windows.Forms.Label();
            this.studentPhoneTbx = new System.Windows.Forms.TextBox();
            this.studentCourseLbl = new System.Windows.Forms.Label();
            this.studentCourseTbx = new System.Windows.Forms.TextBox();
            this.rentalDateOutClearBtn = new System.Windows.Forms.Button();
            this.rentalDateOutDpk = new System.Windows.Forms.DateTimePicker();
            this.rentalDateDueClearBtn = new System.Windows.Forms.Button();
            this.rentalDateDueDpk = new System.Windows.Forms.DateTimePicker();
            this.rentalDateOutLbl = new System.Windows.Forms.Label();
            this.rentalDateDueLbl = new System.Windows.Forms.Label();
            this.rentalSearchingTbx = new System.Windows.Forms.TextBox();
            this.rentalSearchingBtn = new System.Windows.Forms.Button();
            this.rentalLbx = new System.Windows.Forms.ListBox();
            this.formTitle = new System.Windows.Forms.Label();
            this.tblRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInformationGbx = new System.Windows.Forms.GroupBox();
            this.rentalItemsGbx = new System.Windows.Forms.GroupBox();
            this.paymentSummaryGbx = new System.Windows.Forms.GroupBox();
            this.itemNumberDashLbl = new System.Windows.Forms.Label();
            this.itemNumberBTbx = new System.Windows.Forms.TextBox();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.itemNumberATbx = new System.Windows.Forms.TextBox();
            this.itemQuantityTbx = new System.Windows.Forms.TextBox();
            this.itemQuantityLbl = new System.Windows.Forms.Label();
            this.paymentRentalDaysTbx = new System.Windows.Forms.TextBox();
            this.paymentRentalDaysLbl = new System.Windows.Forms.Label();
            this.paymentOtherFeesTbx = new System.Windows.Forms.TextBox();
            this.paymentOtherFeesLbl = new System.Windows.Forms.Label();
            this.paymentSubtotalTbx = new System.Windows.Forms.TextBox();
            this.paymentSubtotalLbl = new System.Windows.Forms.Label();
            this.paymentPSTTbx = new System.Windows.Forms.TextBox();
            this.paymentPSTLbl = new System.Windows.Forms.Label();
            this.paymentGSTTbx = new System.Windows.Forms.TextBox();
            this.paymentGSTLbl = new System.Windows.Forms.Label();
            this.paymentTotalTbx = new System.Windows.Forms.TextBox();
            this.paymentTotalLbl = new System.Windows.Forms.Label();
            this.paymentSubtotalWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentPSTWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentGSTWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentWaiveLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalBindingSource)).BeginInit();
            this.studentInformationGbx.SuspendLayout();
            this.rentalItemsGbx.SuspendLayout();
            this.paymentSummaryGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceButton
            // 
            this.invoiceButton.Location = new System.Drawing.Point(56, 73);
            this.invoiceButton.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(89, 22);
            this.invoiceButton.TabIndex = 0;
            this.invoiceButton.Text = "Enter";
            this.invoiceButton.UseVisualStyleBackColor = true;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Invoice Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invoiceNumberTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.invoiceButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 632);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Number";
            // 
            // invoiceNumberTextbox
            // 
            this.invoiceNumberTextbox.Location = new System.Drawing.Point(129, 23);
            this.invoiceNumberTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceNumberTextbox.Name = "invoiceNumberTextbox";
            this.invoiceNumberTextbox.Size = new System.Drawing.Size(53, 20);
            this.invoiceNumberTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 790);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 853);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 887);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 917);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 950);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Equipment Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 979);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Equipment Number:";
            // 
            // dateOutPicker
            // 
            this.dateOutPicker.Location = new System.Drawing.Point(126, 887);
            this.dateOutPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateOutPicker.Name = "dateOutPicker";
            this.dateOutPicker.Size = new System.Drawing.Size(127, 20);
            this.dateOutPicker.TabIndex = 9;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.Location = new System.Drawing.Point(125, 919);
            this.DueDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(127, 20);
            this.DueDatePicker.TabIndex = 10;
            // 
            // studentFirstNameLabel
            // 
            this.studentFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentFirstNameLabel.Location = new System.Drawing.Point(158, 790);
            this.studentFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentFirstNameLabel.Name = "studentFirstNameLabel";
            this.studentFirstNameLabel.Size = new System.Drawing.Size(76, 19);
            this.studentFirstNameLabel.TabIndex = 11;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberLabel.Location = new System.Drawing.Point(158, 848);
            this.studentNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(76, 19);
            this.studentNumberLabel.TabIndex = 12;
            // 
            // equipNameLabel
            // 
            this.equipNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipNameLabel.Location = new System.Drawing.Point(158, 950);
            this.equipNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipNameLabel.Name = "equipNameLabel";
            this.equipNameLabel.Size = new System.Drawing.Size(76, 19);
            this.equipNameLabel.TabIndex = 13;
            // 
            // equipNumberLabel
            // 
            this.equipNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipNumberLabel.Location = new System.Drawing.Point(158, 974);
            this.equipNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipNumberLabel.Name = "equipNumberLabel";
            this.equipNumberLabel.Size = new System.Drawing.Size(76, 19);
            this.equipNumberLabel.TabIndex = 14;
            // 
            // studentLastNameLabel
            // 
            this.studentLastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentLastNameLabel.Location = new System.Drawing.Point(158, 818);
            this.studentLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLastNameLabel.Name = "studentLastNameLabel";
            this.studentLastNameLabel.Size = new System.Drawing.Size(76, 19);
            this.studentLastNameLabel.TabIndex = 16;
            this.studentLastNameLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 818);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Student Last Name:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(385, 818);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 52);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(382, 899);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 50);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tblRentalTableAdapter1
            // 
            this.tblRentalTableAdapter1.ClearBeforeFill = true;
            // 
            // tblStudentTableAdapter1
            // 
            this.tblStudentTableAdapter1.ClearBeforeFill = true;
            // 
            // tblEquipTableAdapter1
            // 
            this.tblEquipTableAdapter1.ClearBeforeFill = true;
            // 
            // luEquipmentDataSet1
            // 
            this.luEquipmentDataSet1.DataSetName = "LUEquipmentDataSet";
            this.luEquipmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentNumberLbl
            // 
            this.studentNumberLbl.AutoSize = true;
            this.studentNumberLbl.Location = new System.Drawing.Point(17, 31);
            this.studentNumberLbl.Name = "studentNumberLbl";
            this.studentNumberLbl.Size = new System.Drawing.Size(87, 13);
            this.studentNumberLbl.TabIndex = 27;
            this.studentNumberLbl.Text = "Student Number:";
            // 
            // studentNumberTbx
            // 
            this.studentNumberTbx.Enabled = false;
            this.studentNumberTbx.Location = new System.Drawing.Point(110, 28);
            this.studentNumberTbx.MaxLength = 30;
            this.studentNumberTbx.Name = "studentNumberTbx";
            this.studentNumberTbx.Size = new System.Drawing.Size(150, 20);
            this.studentNumberTbx.TabIndex = 26;
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.AutoSize = true;
            this.studentNameLbl.Location = new System.Drawing.Point(26, 57);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(78, 13);
            this.studentNameLbl.TabIndex = 29;
            this.studentNameLbl.Text = "Student Name:";
            // 
            // studentNameTbx
            // 
            this.studentNameTbx.Enabled = false;
            this.studentNameTbx.Location = new System.Drawing.Point(110, 54);
            this.studentNameTbx.MaxLength = 30;
            this.studentNameTbx.Name = "studentNameTbx";
            this.studentNameTbx.Size = new System.Drawing.Size(150, 20);
            this.studentNameTbx.TabIndex = 28;
            // 
            // studentAddressLbl
            // 
            this.studentAddressLbl.AutoSize = true;
            this.studentAddressLbl.Location = new System.Drawing.Point(27, 83);
            this.studentAddressLbl.Name = "studentAddressLbl";
            this.studentAddressLbl.Size = new System.Drawing.Size(77, 13);
            this.studentAddressLbl.TabIndex = 31;
            this.studentAddressLbl.Text = "Local Address:";
            // 
            // studentAddressTbx
            // 
            this.studentAddressTbx.Enabled = false;
            this.studentAddressTbx.Location = new System.Drawing.Point(110, 80);
            this.studentAddressTbx.MaxLength = 30;
            this.studentAddressTbx.Name = "studentAddressTbx";
            this.studentAddressTbx.Size = new System.Drawing.Size(150, 20);
            this.studentAddressTbx.TabIndex = 30;
            // 
            // studentPhoneLbl
            // 
            this.studentPhoneLbl.AutoSize = true;
            this.studentPhoneLbl.Location = new System.Drawing.Point(34, 109);
            this.studentPhoneLbl.Name = "studentPhoneLbl";
            this.studentPhoneLbl.Size = new System.Drawing.Size(70, 13);
            this.studentPhoneLbl.TabIndex = 33;
            this.studentPhoneLbl.Text = "Local Phone:";
            // 
            // studentPhoneTbx
            // 
            this.studentPhoneTbx.Enabled = false;
            this.studentPhoneTbx.Location = new System.Drawing.Point(110, 106);
            this.studentPhoneTbx.MaxLength = 30;
            this.studentPhoneTbx.Name = "studentPhoneTbx";
            this.studentPhoneTbx.Size = new System.Drawing.Size(150, 20);
            this.studentPhoneTbx.TabIndex = 32;
            // 
            // studentCourseLbl
            // 
            this.studentCourseLbl.AutoSize = true;
            this.studentCourseLbl.Location = new System.Drawing.Point(317, 31);
            this.studentCourseLbl.Name = "studentCourseLbl";
            this.studentCourseLbl.Size = new System.Drawing.Size(43, 13);
            this.studentCourseLbl.TabIndex = 36;
            this.studentCourseLbl.Text = "Course:";
            // 
            // studentCourseTbx
            // 
            this.studentCourseTbx.Location = new System.Drawing.Point(366, 28);
            this.studentCourseTbx.MaxLength = 30;
            this.studentCourseTbx.Name = "studentCourseTbx";
            this.studentCourseTbx.Size = new System.Drawing.Size(150, 20);
            this.studentCourseTbx.TabIndex = 35;
            // 
            // rentalDateOutClearBtn
            // 
            this.rentalDateOutClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateOutClearBtn.Location = new System.Drawing.Point(522, 54);
            this.rentalDateOutClearBtn.Name = "rentalDateOutClearBtn";
            this.rentalDateOutClearBtn.Size = new System.Drawing.Size(25, 20);
            this.rentalDateOutClearBtn.TabIndex = 100;
            this.rentalDateOutClearBtn.Text = "C";
            this.rentalDateOutClearBtn.UseVisualStyleBackColor = true;
            // 
            // rentalDateOutDpk
            // 
            this.rentalDateOutDpk.CustomFormat = " ";
            this.rentalDateOutDpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateOutDpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateOutDpk.Location = new System.Drawing.Point(366, 54);
            this.rentalDateOutDpk.Name = "rentalDateOutDpk";
            this.rentalDateOutDpk.Size = new System.Drawing.Size(150, 20);
            this.rentalDateOutDpk.TabIndex = 99;
            this.rentalDateOutDpk.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            // 
            // rentalDateDueClearBtn
            // 
            this.rentalDateDueClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateDueClearBtn.Location = new System.Drawing.Point(522, 80);
            this.rentalDateDueClearBtn.Name = "rentalDateDueClearBtn";
            this.rentalDateDueClearBtn.Size = new System.Drawing.Size(25, 20);
            this.rentalDateDueClearBtn.TabIndex = 102;
            this.rentalDateDueClearBtn.Text = "C";
            this.rentalDateDueClearBtn.UseVisualStyleBackColor = true;
            // 
            // rentalDateDueDpk
            // 
            this.rentalDateDueDpk.CustomFormat = " ";
            this.rentalDateDueDpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateDueDpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateDueDpk.Location = new System.Drawing.Point(366, 80);
            this.rentalDateDueDpk.Name = "rentalDateDueDpk";
            this.rentalDateDueDpk.Size = new System.Drawing.Size(150, 20);
            this.rentalDateDueDpk.TabIndex = 101;
            this.rentalDateDueDpk.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            // 
            // rentalDateOutLbl
            // 
            this.rentalDateOutLbl.AutoSize = true;
            this.rentalDateOutLbl.Location = new System.Drawing.Point(307, 57);
            this.rentalDateOutLbl.Name = "rentalDateOutLbl";
            this.rentalDateOutLbl.Size = new System.Drawing.Size(53, 13);
            this.rentalDateOutLbl.TabIndex = 103;
            this.rentalDateOutLbl.Text = "Date Out:";
            // 
            // rentalDateDueLbl
            // 
            this.rentalDateDueLbl.AutoSize = true;
            this.rentalDateDueLbl.Location = new System.Drawing.Point(304, 83);
            this.rentalDateDueLbl.Name = "rentalDateDueLbl";
            this.rentalDateDueLbl.Size = new System.Drawing.Size(56, 13);
            this.rentalDateDueLbl.TabIndex = 104;
            this.rentalDateDueLbl.Text = "Date Due:";
            // 
            // rentalSearchingTbx
            // 
            this.rentalSearchingTbx.Location = new System.Drawing.Point(346, 151);
            this.rentalSearchingTbx.Margin = new System.Windows.Forms.Padding(2);
            this.rentalSearchingTbx.MaxLength = 20;
            this.rentalSearchingTbx.Name = "rentalSearchingTbx";
            this.rentalSearchingTbx.Size = new System.Drawing.Size(164, 20);
            this.rentalSearchingTbx.TabIndex = 105;
            // 
            // rentalSearchingBtn
            // 
            this.rentalSearchingBtn.Location = new System.Drawing.Point(515, 150);
            this.rentalSearchingBtn.Name = "rentalSearchingBtn";
            this.rentalSearchingBtn.Size = new System.Drawing.Size(55, 21);
            this.rentalSearchingBtn.TabIndex = 106;
            this.rentalSearchingBtn.Text = "Search";
            this.rentalSearchingBtn.UseVisualStyleBackColor = true;
            // 
            // rentalLbx
            // 
            this.rentalLbx.DataSource = this.tblRentalBindingSource;
            this.rentalLbx.DisplayMember = "Inv_Num";
            this.rentalLbx.FormattingEnabled = true;
            this.rentalLbx.Location = new System.Drawing.Point(15, 49);
            this.rentalLbx.Name = "rentalLbx";
            this.rentalLbx.ScrollAlwaysVisible = true;
            this.rentalLbx.Size = new System.Drawing.Size(554, 95);
            this.rentalLbx.TabIndex = 108;
            this.rentalLbx.ValueMember = "Inv_Num";
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(11, 9);
            this.formTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(562, 25);
            this.formTitle.TabIndex = 107;
            this.formTitle.Text = "Edit Rental";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblRentalBindingSource
            // 
            this.tblRentalBindingSource.DataMember = "tblRental";
            this.tblRentalBindingSource.DataSource = this.luEquipmentDataSet1;
            // 
            // studentInformationGbx
            // 
            this.studentInformationGbx.Controls.Add(this.studentNumberTbx);
            this.studentInformationGbx.Controls.Add(this.studentNumberLbl);
            this.studentInformationGbx.Controls.Add(this.studentNameTbx);
            this.studentInformationGbx.Controls.Add(this.studentNameLbl);
            this.studentInformationGbx.Controls.Add(this.studentAddressTbx);
            this.studentInformationGbx.Controls.Add(this.rentalDateDueLbl);
            this.studentInformationGbx.Controls.Add(this.studentAddressLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateOutLbl);
            this.studentInformationGbx.Controls.Add(this.studentPhoneTbx);
            this.studentInformationGbx.Controls.Add(this.rentalDateDueClearBtn);
            this.studentInformationGbx.Controls.Add(this.studentPhoneLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateDueDpk);
            this.studentInformationGbx.Controls.Add(this.studentCourseTbx);
            this.studentInformationGbx.Controls.Add(this.rentalDateOutClearBtn);
            this.studentInformationGbx.Controls.Add(this.studentCourseLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateOutDpk);
            this.studentInformationGbx.Location = new System.Drawing.Point(15, 200);
            this.studentInformationGbx.Name = "studentInformationGbx";
            this.studentInformationGbx.Size = new System.Drawing.Size(554, 143);
            this.studentInformationGbx.TabIndex = 109;
            this.studentInformationGbx.TabStop = false;
            this.studentInformationGbx.Text = "Student Information";
            // 
            // rentalItemsGbx
            // 
            this.rentalItemsGbx.Controls.Add(this.itemQuantityTbx);
            this.rentalItemsGbx.Controls.Add(this.itemQuantityLbl);
            this.rentalItemsGbx.Controls.Add(this.itemNumberDashLbl);
            this.rentalItemsGbx.Controls.Add(this.itemNumberATbx);
            this.rentalItemsGbx.Controls.Add(this.itemNumberLbl);
            this.rentalItemsGbx.Controls.Add(this.itemNumberBTbx);
            this.rentalItemsGbx.Location = new System.Drawing.Point(15, 350);
            this.rentalItemsGbx.Name = "rentalItemsGbx";
            this.rentalItemsGbx.Size = new System.Drawing.Size(360, 223);
            this.rentalItemsGbx.TabIndex = 110;
            this.rentalItemsGbx.TabStop = false;
            this.rentalItemsGbx.Text = "Rental Items";
            // 
            // paymentSummaryGbx
            // 
            this.paymentSummaryGbx.Controls.Add(this.paymentWaiveLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentGSTWaiveChbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentPSTWaiveChbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalWaiveChbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentTotalTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentTotalLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentGSTTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentGSTLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentPSTTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentPSTLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentOtherFeesTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentOtherFeesLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentRentalDaysTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentRentalDaysLbl);
            this.paymentSummaryGbx.Location = new System.Drawing.Point(381, 350);
            this.paymentSummaryGbx.Name = "paymentSummaryGbx";
            this.paymentSummaryGbx.Size = new System.Drawing.Size(188, 223);
            this.paymentSummaryGbx.TabIndex = 111;
            this.paymentSummaryGbx.TabStop = false;
            this.paymentSummaryGbx.Text = "Payment Summary";
            // 
            // itemNumberDashLbl
            // 
            this.itemNumberDashLbl.AutoSize = true;
            this.itemNumberDashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberDashLbl.Location = new System.Drawing.Point(133, 29);
            this.itemNumberDashLbl.Name = "itemNumberDashLbl";
            this.itemNumberDashLbl.Size = new System.Drawing.Size(12, 15);
            this.itemNumberDashLbl.TabIndex = 67;
            this.itemNumberDashLbl.Text = "-";
            // 
            // itemNumberBTbx
            // 
            this.itemNumberBTbx.Location = new System.Drawing.Point(148, 28);
            this.itemNumberBTbx.MaxLength = 3;
            this.itemNumberBTbx.Name = "itemNumberBTbx";
            this.itemNumberBTbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberBTbx.TabIndex = 65;
            // 
            // itemNumberLbl
            // 
            this.itemNumberLbl.AutoSize = true;
            this.itemNumberLbl.Location = new System.Drawing.Point(12, 31);
            this.itemNumberLbl.Name = "itemNumberLbl";
            this.itemNumberLbl.Size = new System.Drawing.Size(70, 13);
            this.itemNumberLbl.TabIndex = 66;
            this.itemNumberLbl.Text = "Item Number:";
            // 
            // itemNumberATbx
            // 
            this.itemNumberATbx.Location = new System.Drawing.Point(88, 28);
            this.itemNumberATbx.MaxLength = 3;
            this.itemNumberATbx.Name = "itemNumberATbx";
            this.itemNumberATbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberATbx.TabIndex = 64;
            // 
            // itemQuantityTbx
            // 
            this.itemQuantityTbx.Enabled = false;
            this.itemQuantityTbx.Location = new System.Drawing.Point(259, 28);
            this.itemQuantityTbx.MaxLength = 30;
            this.itemQuantityTbx.Name = "itemQuantityTbx";
            this.itemQuantityTbx.Size = new System.Drawing.Size(95, 20);
            this.itemQuantityTbx.TabIndex = 105;
            // 
            // itemQuantityLbl
            // 
            this.itemQuantityLbl.AutoSize = true;
            this.itemQuantityLbl.Location = new System.Drawing.Point(204, 31);
            this.itemQuantityLbl.Name = "itemQuantityLbl";
            this.itemQuantityLbl.Size = new System.Drawing.Size(49, 13);
            this.itemQuantityLbl.TabIndex = 106;
            this.itemQuantityLbl.Text = "Quantity:";
            // 
            // paymentRentalDaysTbx
            // 
            this.paymentRentalDaysTbx.Location = new System.Drawing.Point(84, 49);
            this.paymentRentalDaysTbx.MaxLength = 30;
            this.paymentRentalDaysTbx.Name = "paymentRentalDaysTbx";
            this.paymentRentalDaysTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentRentalDaysTbx.TabIndex = 107;
            // 
            // paymentRentalDaysLbl
            // 
            this.paymentRentalDaysLbl.AutoSize = true;
            this.paymentRentalDaysLbl.Location = new System.Drawing.Point(10, 52);
            this.paymentRentalDaysLbl.Name = "paymentRentalDaysLbl";
            this.paymentRentalDaysLbl.Size = new System.Drawing.Size(68, 13);
            this.paymentRentalDaysLbl.TabIndex = 108;
            this.paymentRentalDaysLbl.Text = "Rental Days:";
            // 
            // paymentOtherFeesTbx
            // 
            this.paymentOtherFeesTbx.Location = new System.Drawing.Point(84, 75);
            this.paymentOtherFeesTbx.MaxLength = 30;
            this.paymentOtherFeesTbx.Name = "paymentOtherFeesTbx";
            this.paymentOtherFeesTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentOtherFeesTbx.TabIndex = 109;
            // 
            // paymentOtherFeesLbl
            // 
            this.paymentOtherFeesLbl.AutoSize = true;
            this.paymentOtherFeesLbl.Location = new System.Drawing.Point(16, 78);
            this.paymentOtherFeesLbl.Name = "paymentOtherFeesLbl";
            this.paymentOtherFeesLbl.Size = new System.Drawing.Size(62, 13);
            this.paymentOtherFeesLbl.TabIndex = 110;
            this.paymentOtherFeesLbl.Text = "Other Fees:";
            // 
            // paymentSubtotalTbx
            // 
            this.paymentSubtotalTbx.Enabled = false;
            this.paymentSubtotalTbx.Location = new System.Drawing.Point(84, 101);
            this.paymentSubtotalTbx.MaxLength = 30;
            this.paymentSubtotalTbx.Name = "paymentSubtotalTbx";
            this.paymentSubtotalTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentSubtotalTbx.TabIndex = 111;
            // 
            // paymentSubtotalLbl
            // 
            this.paymentSubtotalLbl.AutoSize = true;
            this.paymentSubtotalLbl.Location = new System.Drawing.Point(29, 105);
            this.paymentSubtotalLbl.Name = "paymentSubtotalLbl";
            this.paymentSubtotalLbl.Size = new System.Drawing.Size(49, 13);
            this.paymentSubtotalLbl.TabIndex = 112;
            this.paymentSubtotalLbl.Text = "Subtotal:";
            // 
            // paymentPSTTbx
            // 
            this.paymentPSTTbx.Enabled = false;
            this.paymentPSTTbx.Location = new System.Drawing.Point(84, 127);
            this.paymentPSTTbx.MaxLength = 30;
            this.paymentPSTTbx.Name = "paymentPSTTbx";
            this.paymentPSTTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentPSTTbx.TabIndex = 113;
            // 
            // paymentPSTLbl
            // 
            this.paymentPSTLbl.AutoSize = true;
            this.paymentPSTLbl.Location = new System.Drawing.Point(47, 130);
            this.paymentPSTLbl.Name = "paymentPSTLbl";
            this.paymentPSTLbl.Size = new System.Drawing.Size(31, 13);
            this.paymentPSTLbl.TabIndex = 114;
            this.paymentPSTLbl.Text = "PST:";
            // 
            // paymentGSTTbx
            // 
            this.paymentGSTTbx.Enabled = false;
            this.paymentGSTTbx.Location = new System.Drawing.Point(84, 153);
            this.paymentGSTTbx.MaxLength = 30;
            this.paymentGSTTbx.Name = "paymentGSTTbx";
            this.paymentGSTTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentGSTTbx.TabIndex = 115;
            // 
            // paymentGSTLbl
            // 
            this.paymentGSTLbl.AutoSize = true;
            this.paymentGSTLbl.Location = new System.Drawing.Point(46, 157);
            this.paymentGSTLbl.Name = "paymentGSTLbl";
            this.paymentGSTLbl.Size = new System.Drawing.Size(32, 13);
            this.paymentGSTLbl.TabIndex = 116;
            this.paymentGSTLbl.Text = "GST:";
            // 
            // paymentTotalTbx
            // 
            this.paymentTotalTbx.Enabled = false;
            this.paymentTotalTbx.Location = new System.Drawing.Point(84, 179);
            this.paymentTotalTbx.MaxLength = 30;
            this.paymentTotalTbx.Name = "paymentTotalTbx";
            this.paymentTotalTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentTotalTbx.TabIndex = 117;
            // 
            // paymentTotalLbl
            // 
            this.paymentTotalLbl.AutoSize = true;
            this.paymentTotalLbl.Location = new System.Drawing.Point(44, 182);
            this.paymentTotalLbl.Name = "paymentTotalLbl";
            this.paymentTotalLbl.Size = new System.Drawing.Size(34, 13);
            this.paymentTotalLbl.TabIndex = 118;
            this.paymentTotalLbl.Text = "Total:";
            // 
            // paymentSubtotalWaiveChbx
            // 
            this.paymentSubtotalWaiveChbx.AutoSize = true;
            this.paymentSubtotalWaiveChbx.Location = new System.Drawing.Point(156, 104);
            this.paymentSubtotalWaiveChbx.Name = "paymentSubtotalWaiveChbx";
            this.paymentSubtotalWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentSubtotalWaiveChbx.TabIndex = 119;
            this.paymentSubtotalWaiveChbx.UseVisualStyleBackColor = true;
            // 
            // paymentPSTWaiveChbx
            // 
            this.paymentPSTWaiveChbx.AutoSize = true;
            this.paymentPSTWaiveChbx.Location = new System.Drawing.Point(156, 130);
            this.paymentPSTWaiveChbx.Name = "paymentPSTWaiveChbx";
            this.paymentPSTWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentPSTWaiveChbx.TabIndex = 120;
            this.paymentPSTWaiveChbx.UseVisualStyleBackColor = true;
            // 
            // paymentGSTWaiveChbx
            // 
            this.paymentGSTWaiveChbx.AutoSize = true;
            this.paymentGSTWaiveChbx.Location = new System.Drawing.Point(156, 156);
            this.paymentGSTWaiveChbx.Name = "paymentGSTWaiveChbx";
            this.paymentGSTWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentGSTWaiveChbx.TabIndex = 121;
            this.paymentGSTWaiveChbx.UseVisualStyleBackColor = true;
            // 
            // paymentWaiveLbl
            // 
            this.paymentWaiveLbl.AutoSize = true;
            this.paymentWaiveLbl.Location = new System.Drawing.Point(144, 28);
            this.paymentWaiveLbl.Name = "paymentWaiveLbl";
            this.paymentWaiveLbl.Size = new System.Drawing.Size(38, 13);
            this.paymentWaiveLbl.TabIndex = 122;
            this.paymentWaiveLbl.Text = "Waive";
            // 
            // editRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 1012);
            this.Controls.Add(this.paymentSummaryGbx);
            this.Controls.Add(this.rentalItemsGbx);
            this.Controls.Add(this.studentInformationGbx);
            this.Controls.Add(this.rentalSearchingTbx);
            this.Controls.Add(this.rentalSearchingBtn);
            this.Controls.Add(this.rentalLbx);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.studentLastNameLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.equipNumberLabel);
            this.Controls.Add(this.equipNameLabel);
            this.Controls.Add(this.studentNumberLabel);
            this.Controls.Add(this.studentFirstNameLabel);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.dateOutPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "editRental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Rental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalBindingSource)).EndInit();
            this.studentInformationGbx.ResumeLayout(false);
            this.studentInformationGbx.PerformLayout();
            this.rentalItemsGbx.ResumeLayout(false);
            this.rentalItemsGbx.PerformLayout();
            this.paymentSummaryGbx.ResumeLayout(false);
            this.paymentSummaryGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox invoiceNumberTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOutPicker;
        private System.Windows.Forms.DateTimePicker DueDatePicker;
        private System.Windows.Forms.Label studentFirstNameLabel;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.Label equipNameLabel;
        private System.Windows.Forms.Label equipNumberLabel;
        private System.Windows.Forms.Label studentLastNameLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private System.Windows.Forms.Label studentNumberLbl;
        private System.Windows.Forms.TextBox studentNumberTbx;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.TextBox studentNameTbx;
        private System.Windows.Forms.Label studentAddressLbl;
        private System.Windows.Forms.TextBox studentAddressTbx;
        private System.Windows.Forms.Label studentPhoneLbl;
        private System.Windows.Forms.TextBox studentPhoneTbx;
        private System.Windows.Forms.Label studentCourseLbl;
        private System.Windows.Forms.TextBox studentCourseTbx;
        private System.Windows.Forms.Button rentalDateOutClearBtn;
        private System.Windows.Forms.DateTimePicker rentalDateOutDpk;
        private System.Windows.Forms.Button rentalDateDueClearBtn;
        private System.Windows.Forms.DateTimePicker rentalDateDueDpk;
        private System.Windows.Forms.Label rentalDateOutLbl;
        private System.Windows.Forms.Label rentalDateDueLbl;
        private System.Windows.Forms.TextBox rentalSearchingTbx;
        private System.Windows.Forms.Button rentalSearchingBtn;
        private System.Windows.Forms.ListBox rentalLbx;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.BindingSource tblRentalBindingSource;
        private System.Windows.Forms.GroupBox studentInformationGbx;
        private System.Windows.Forms.GroupBox rentalItemsGbx;
        private System.Windows.Forms.GroupBox paymentSummaryGbx;
        private System.Windows.Forms.TextBox itemQuantityTbx;
        private System.Windows.Forms.Label itemQuantityLbl;
        private System.Windows.Forms.Label itemNumberDashLbl;
        private System.Windows.Forms.TextBox itemNumberATbx;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.TextBox itemNumberBTbx;
        private System.Windows.Forms.TextBox paymentTotalTbx;
        private System.Windows.Forms.Label paymentTotalLbl;
        private System.Windows.Forms.TextBox paymentGSTTbx;
        private System.Windows.Forms.Label paymentGSTLbl;
        private System.Windows.Forms.TextBox paymentPSTTbx;
        private System.Windows.Forms.Label paymentPSTLbl;
        private System.Windows.Forms.TextBox paymentSubtotalTbx;
        private System.Windows.Forms.Label paymentSubtotalLbl;
        private System.Windows.Forms.TextBox paymentOtherFeesTbx;
        private System.Windows.Forms.Label paymentOtherFeesLbl;
        private System.Windows.Forms.TextBox paymentRentalDaysTbx;
        private System.Windows.Forms.Label paymentRentalDaysLbl;
        private System.Windows.Forms.CheckBox paymentGSTWaiveChbx;
        private System.Windows.Forms.CheckBox paymentPSTWaiveChbx;
        private System.Windows.Forms.CheckBox paymentSubtotalWaiveChbx;
        private System.Windows.Forms.Label paymentWaiveLbl;
    }
}