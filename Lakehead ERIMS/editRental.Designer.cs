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
            this.tblRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formTitle = new System.Windows.Forms.Label();
            this.studentInformationGbx = new System.Windows.Forms.GroupBox();
            this.rentalItemsGbx = new System.Windows.Forms.GroupBox();
            this.removeAllItemsBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.rentalItemsDgv = new System.Windows.Forms.DataGridView();
            this.itemNumberClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRentalClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityTbx = new System.Windows.Forms.TextBox();
            this.itemQuantityLbl = new System.Windows.Forms.Label();
            this.itemNumberDashLbl = new System.Windows.Forms.Label();
            this.itemNumberATbx = new System.Windows.Forms.TextBox();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.itemNumberBTbx = new System.Windows.Forms.TextBox();
            this.paymentSummaryGbx = new System.Windows.Forms.GroupBox();
            this.paymentWaiveLbl = new System.Windows.Forms.Label();
            this.paymentGSTWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentPSTWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentSubtotalWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentTotalTbx = new System.Windows.Forms.TextBox();
            this.paymentTotalLbl = new System.Windows.Forms.Label();
            this.paymentGSTTbx = new System.Windows.Forms.TextBox();
            this.paymentGSTLbl = new System.Windows.Forms.Label();
            this.paymentPSTTbx = new System.Windows.Forms.TextBox();
            this.paymentPSTLbl = new System.Windows.Forms.Label();
            this.paymentSubtotalTbx = new System.Windows.Forms.TextBox();
            this.paymentSubtotalLbl = new System.Windows.Forms.Label();
            this.paymentOtherFeesTbx = new System.Windows.Forms.TextBox();
            this.paymentOtherFeesLbl = new System.Windows.Forms.Label();
            this.paymentRentalDaysTbx = new System.Windows.Forms.TextBox();
            this.paymentRentalDaysLbl = new System.Windows.Forms.Label();
            this.updateRentalBtn = new System.Windows.Forms.Button();
            this.voidRentalBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalBindingSource)).BeginInit();
            this.studentInformationGbx.SuspendLayout();
            this.rentalItemsGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDgv)).BeginInit();
            this.paymentSummaryGbx.SuspendLayout();
            this.SuspendLayout();
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
            this.studentCourseTbx.TextChanged += new System.EventHandler(this.RentalFieldChanged);
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
            this.rentalDateOutDpk.CloseUp += new System.EventHandler(this.RentalDpk_CloseUp);
            this.rentalDateOutDpk.ValueChanged += new System.EventHandler(this.RentalDpk_ValueChanged);
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
            this.rentalDateDueDpk.CloseUp += new System.EventHandler(this.RentalDpk_CloseUp);
            this.rentalDateDueDpk.ValueChanged += new System.EventHandler(this.RentalDpk_ValueChanged);
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
            this.rentalLbx.SelectedIndexChanged += new System.EventHandler(this.rentalLbx_SelectedIndexChanged);
            this.rentalLbx.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.rentalLbx_Format);
            // 
            // tblRentalBindingSource
            // 
            this.tblRentalBindingSource.DataMember = "tblRental";
            this.tblRentalBindingSource.DataSource = this.luEquipmentDataSet1;
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
            this.rentalItemsGbx.Controls.Add(this.removeAllItemsBtn);
            this.rentalItemsGbx.Controls.Add(this.deleteItemBtn);
            this.rentalItemsGbx.Controls.Add(this.rentalItemsDgv);
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
            // removeAllItemsBtn
            // 
            this.removeAllItemsBtn.Enabled = false;
            this.removeAllItemsBtn.Location = new System.Drawing.Point(207, 179);
            this.removeAllItemsBtn.Name = "removeAllItemsBtn";
            this.removeAllItemsBtn.Size = new System.Drawing.Size(90, 34);
            this.removeAllItemsBtn.TabIndex = 109;
            this.removeAllItemsBtn.Text = "Remove All";
            this.removeAllItemsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Enabled = false;
            this.deleteItemBtn.Location = new System.Drawing.Point(55, 179);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(90, 34);
            this.deleteItemBtn.TabIndex = 108;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            // 
            // rentalItemsDgv
            // 
            this.rentalItemsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentalItemsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberClm,
            this.itemNameClm,
            this.itemRentalClm});
            this.rentalItemsDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rentalItemsDgv.Location = new System.Drawing.Point(6, 67);
            this.rentalItemsDgv.MultiSelect = false;
            this.rentalItemsDgv.Name = "rentalItemsDgv";
            this.rentalItemsDgv.RowHeadersVisible = false;
            this.rentalItemsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rentalItemsDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rentalItemsDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rentalItemsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalItemsDgv.Size = new System.Drawing.Size(348, 103);
            this.rentalItemsDgv.TabIndex = 107;
            // 
            // itemNumberClm
            // 
            this.itemNumberClm.HeaderText = "Number";
            this.itemNumberClm.Name = "itemNumberClm";
            // 
            // itemNameClm
            // 
            this.itemNameClm.HeaderText = "Name";
            this.itemNameClm.Name = "itemNameClm";
            // 
            // itemRentalClm
            // 
            this.itemRentalClm.HeaderText = "Rental";
            this.itemRentalClm.Name = "itemRentalClm";
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
            // itemNumberATbx
            // 
            this.itemNumberATbx.Location = new System.Drawing.Point(88, 28);
            this.itemNumberATbx.MaxLength = 3;
            this.itemNumberATbx.Name = "itemNumberATbx";
            this.itemNumberATbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberATbx.TabIndex = 64;
            this.itemNumberATbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
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
            // itemNumberBTbx
            // 
            this.itemNumberBTbx.Location = new System.Drawing.Point(148, 28);
            this.itemNumberBTbx.MaxLength = 3;
            this.itemNumberBTbx.Name = "itemNumberBTbx";
            this.itemNumberBTbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberBTbx.TabIndex = 65;
            this.itemNumberBTbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
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
            // paymentWaiveLbl
            // 
            this.paymentWaiveLbl.AutoSize = true;
            this.paymentWaiveLbl.Location = new System.Drawing.Point(144, 28);
            this.paymentWaiveLbl.Name = "paymentWaiveLbl";
            this.paymentWaiveLbl.Size = new System.Drawing.Size(38, 13);
            this.paymentWaiveLbl.TabIndex = 122;
            this.paymentWaiveLbl.Text = "Waive";
            // 
            // paymentGSTWaiveChbx
            // 
            this.paymentGSTWaiveChbx.AutoSize = true;
            this.paymentGSTWaiveChbx.Location = new System.Drawing.Point(156, 156);
            this.paymentGSTWaiveChbx.Name = "paymentGSTWaiveChbx";
            this.paymentGSTWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentGSTWaiveChbx.TabIndex = 121;
            this.paymentGSTWaiveChbx.UseVisualStyleBackColor = true;
            this.paymentGSTWaiveChbx.CheckedChanged += new System.EventHandler(this.RentalFieldChanged);
            // 
            // paymentPSTWaiveChbx
            // 
            this.paymentPSTWaiveChbx.AutoSize = true;
            this.paymentPSTWaiveChbx.Location = new System.Drawing.Point(156, 130);
            this.paymentPSTWaiveChbx.Name = "paymentPSTWaiveChbx";
            this.paymentPSTWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentPSTWaiveChbx.TabIndex = 120;
            this.paymentPSTWaiveChbx.UseVisualStyleBackColor = true;
            this.paymentPSTWaiveChbx.CheckedChanged += new System.EventHandler(this.RentalFieldChanged);
            // 
            // paymentSubtotalWaiveChbx
            // 
            this.paymentSubtotalWaiveChbx.AutoSize = true;
            this.paymentSubtotalWaiveChbx.Location = new System.Drawing.Point(156, 104);
            this.paymentSubtotalWaiveChbx.Name = "paymentSubtotalWaiveChbx";
            this.paymentSubtotalWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentSubtotalWaiveChbx.TabIndex = 119;
            this.paymentSubtotalWaiveChbx.UseVisualStyleBackColor = true;
            this.paymentSubtotalWaiveChbx.CheckedChanged += new System.EventHandler(this.RentalFieldChanged);
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
            // paymentOtherFeesTbx
            // 
            this.paymentOtherFeesTbx.Location = new System.Drawing.Point(84, 75);
            this.paymentOtherFeesTbx.MaxLength = 30;
            this.paymentOtherFeesTbx.Name = "paymentOtherFeesTbx";
            this.paymentOtherFeesTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentOtherFeesTbx.TabIndex = 109;
            this.paymentOtherFeesTbx.TextChanged += new System.EventHandler(this.RentalFieldChanged);
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
            // paymentRentalDaysTbx
            // 
            this.paymentRentalDaysTbx.Location = new System.Drawing.Point(84, 49);
            this.paymentRentalDaysTbx.MaxLength = 30;
            this.paymentRentalDaysTbx.Name = "paymentRentalDaysTbx";
            this.paymentRentalDaysTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentRentalDaysTbx.TabIndex = 107;
            this.paymentRentalDaysTbx.TextChanged += new System.EventHandler(this.RentalFieldChanged);
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
            // updateRentalBtn
            // 
            this.updateRentalBtn.Enabled = false;
            this.updateRentalBtn.Location = new System.Drawing.Point(76, 599);
            this.updateRentalBtn.Name = "updateRentalBtn";
            this.updateRentalBtn.Size = new System.Drawing.Size(90, 34);
            this.updateRentalBtn.TabIndex = 110;
            this.updateRentalBtn.Text = "Update Rental";
            this.updateRentalBtn.UseVisualStyleBackColor = true;
            // 
            // voidRentalBtn
            // 
            this.voidRentalBtn.Location = new System.Drawing.Point(247, 599);
            this.voidRentalBtn.Name = "voidRentalBtn";
            this.voidRentalBtn.Size = new System.Drawing.Size(90, 34);
            this.voidRentalBtn.TabIndex = 112;
            this.voidRentalBtn.Text = "Void Rental";
            this.voidRentalBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(420, 599);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 34);
            this.exitBtn.TabIndex = 113;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.voidRentalBtn);
            this.Controls.Add(this.updateRentalBtn);
            this.Controls.Add(this.paymentSummaryGbx);
            this.Controls.Add(this.rentalItemsGbx);
            this.Controls.Add(this.studentInformationGbx);
            this.Controls.Add(this.rentalSearchingTbx);
            this.Controls.Add(this.rentalSearchingBtn);
            this.Controls.Add(this.rentalLbx);
            this.Controls.Add(this.formTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "editRental";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Rental";
            this.Load += new System.EventHandler(this.editRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentalBindingSource)).EndInit();
            this.studentInformationGbx.ResumeLayout(false);
            this.studentInformationGbx.PerformLayout();
            this.rentalItemsGbx.ResumeLayout(false);
            this.rentalItemsGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDgv)).EndInit();
            this.paymentSummaryGbx.ResumeLayout(false);
            this.paymentSummaryGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView rentalItemsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRentalClm;
        private System.Windows.Forms.Button removeAllItemsBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button updateRentalBtn;
        private System.Windows.Forms.Button voidRentalBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}