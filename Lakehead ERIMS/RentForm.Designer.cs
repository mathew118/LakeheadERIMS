namespace Lakehead_ERIMS
{
    partial class RentForm
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
            this.lUEquipmentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.lUEquipmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
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
            this.studentInformationGbx = new System.Windows.Forms.GroupBox();
            this.orptChbx = new System.Windows.Forms.CheckBox();
            this.studentNumberTbx = new System.Windows.Forms.TextBox();
            this.studentNumberLbl = new System.Windows.Forms.Label();
            this.studentNameTbx = new System.Windows.Forms.TextBox();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.studentAddressTbx = new System.Windows.Forms.TextBox();
            this.rentalDateDueLbl = new System.Windows.Forms.Label();
            this.studentAddressLbl = new System.Windows.Forms.Label();
            this.rentalDateOutLbl = new System.Windows.Forms.Label();
            this.studentPhoneTbx = new System.Windows.Forms.TextBox();
            this.studentPhoneLbl = new System.Windows.Forms.Label();
            this.rentalDateDueDpk = new System.Windows.Forms.DateTimePicker();
            this.studentCourseTbx = new System.Windows.Forms.TextBox();
            this.studentCourseLbl = new System.Windows.Forms.Label();
            this.rentalDateOutDpk = new System.Windows.Forms.DateTimePicker();
            this.paymentSummaryGbx = new System.Windows.Forms.GroupBox();
            this.paymentWaiveLbl = new System.Windows.Forms.Label();
            this.paymentHSTWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentSubtotalWaiveChbx = new System.Windows.Forms.CheckBox();
            this.paymentTotalTbx = new System.Windows.Forms.TextBox();
            this.paymentTotalLbl = new System.Windows.Forms.Label();
            this.paymentHSTTbx = new System.Windows.Forms.TextBox();
            this.paymentHSTLbl = new System.Windows.Forms.Label();
            this.paymentSubtotalTbx = new System.Windows.Forms.TextBox();
            this.paymentSubtotalLbl = new System.Windows.Forms.Label();
            this.paymentRentalDaysTbx = new System.Windows.Forms.TextBox();
            this.paymentRentalDaysLbl = new System.Windows.Forms.Label();
            this.accountBalanceGbx = new System.Windows.Forms.GroupBox();
            this.deleteFeeChbx = new System.Windows.Forms.RadioButton();
            this.payFeeChbx = new System.Windows.Forms.RadioButton();
            this.ignoreFeeChbx = new System.Windows.Forms.RadioButton();
            this.outstandingFeeTbx = new System.Windows.Forms.TextBox();
            this.outstandingFeeLbl = new System.Windows.Forms.Label();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.existingRentalsBtn = new System.Windows.Forms.Button();
            this.enterStudentNumberTbx = new System.Windows.Forms.TextBox();
            this.enterStudentNumberLbl = new System.Windows.Forms.Label();
            this.enterStudentNumberBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetRentalBtn = new System.Windows.Forms.Button();
            this.processRentalBtn = new System.Windows.Forms.Button();
            this.tblStatusTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).BeginInit();
            this.rentalItemsGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDgv)).BeginInit();
            this.studentInformationGbx.SuspendLayout();
            this.paymentSummaryGbx.SuspendLayout();
            this.accountBalanceGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lUEquipmentDataSetBindingSource1
            // 
            this.lUEquipmentDataSetBindingSource1.DataSource = this.lUEquipmentDataSet;
            this.lUEquipmentDataSetBindingSource1.Position = 0;
            // 
            // lUEquipmentDataSet
            // 
            this.lUEquipmentDataSet.DataSetName = "LUEquipmentDataSet";
            this.lUEquipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEquipBindingSource
            // 
            this.tblEquipBindingSource.DataMember = "tblEquip";
            this.tblEquipBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // tblEquipTableAdapter
            // 
            this.tblEquipTableAdapter.ClearBeforeFill = true;
            // 
            // lUEquipmentDataSetBindingSource
            // 
            this.lUEquipmentDataSetBindingSource.DataSource = this.lUEquipmentDataSet;
            this.lUEquipmentDataSetBindingSource.Position = 0;
            // 
            // tblRentalTableAdapter1
            // 
            this.tblRentalTableAdapter1.ClearBeforeFill = true;
            // 
            // tblStudentTableAdapter1
            // 
            this.tblStudentTableAdapter1.ClearBeforeFill = true;
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
            this.rentalItemsGbx.Location = new System.Drawing.Point(12, 342);
            this.rentalItemsGbx.Name = "rentalItemsGbx";
            this.rentalItemsGbx.Size = new System.Drawing.Size(360, 223);
            this.rentalItemsGbx.TabIndex = 13;
            this.rentalItemsGbx.TabStop = false;
            this.rentalItemsGbx.Text = "Rental Items";
            // 
            // removeAllItemsBtn
            // 
            this.removeAllItemsBtn.Enabled = false;
            this.removeAllItemsBtn.Location = new System.Drawing.Point(207, 179);
            this.removeAllItemsBtn.Name = "removeAllItemsBtn";
            this.removeAllItemsBtn.Size = new System.Drawing.Size(90, 34);
            this.removeAllItemsBtn.TabIndex = 18;
            this.removeAllItemsBtn.Text = "Remove All";
            this.removeAllItemsBtn.UseVisualStyleBackColor = true;
            this.removeAllItemsBtn.Click += new System.EventHandler(this.removeAllItemsBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Enabled = false;
            this.deleteItemBtn.Location = new System.Drawing.Point(55, 179);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(90, 34);
            this.deleteItemBtn.TabIndex = 17;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // rentalItemsDgv
            // 
            this.rentalItemsDgv.AllowUserToAddRows = false;
            this.rentalItemsDgv.AllowUserToDeleteRows = false;
            this.rentalItemsDgv.AllowUserToResizeRows = false;
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
            this.rentalItemsDgv.ReadOnly = true;
            this.rentalItemsDgv.RowHeadersVisible = false;
            this.rentalItemsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rentalItemsDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rentalItemsDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rentalItemsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalItemsDgv.Size = new System.Drawing.Size(348, 103);
            this.rentalItemsDgv.TabIndex = 16;
            this.rentalItemsDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.rentalItemsDgv_RowsChanged);
            this.rentalItemsDgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.rentalItemsDgv_RowsRemoved);
            this.rentalItemsDgv.SelectionChanged += new System.EventHandler(this.rentalItemsDgv_SelectionChanged);
            // 
            // itemNumberClm
            // 
            this.itemNumberClm.FillWeight = 30F;
            this.itemNumberClm.HeaderText = "Number";
            this.itemNumberClm.Name = "itemNumberClm";
            this.itemNumberClm.ReadOnly = true;
            // 
            // itemNameClm
            // 
            this.itemNameClm.HeaderText = "Name";
            this.itemNameClm.Name = "itemNameClm";
            this.itemNameClm.ReadOnly = true;
            // 
            // itemRentalClm
            // 
            this.itemRentalClm.FillWeight = 30F;
            this.itemRentalClm.HeaderText = "Rental";
            this.itemRentalClm.Name = "itemRentalClm";
            this.itemRentalClm.ReadOnly = true;
            // 
            // itemQuantityTbx
            // 
            this.itemQuantityTbx.Enabled = false;
            this.itemQuantityTbx.Location = new System.Drawing.Point(259, 28);
            this.itemQuantityTbx.MaxLength = 30;
            this.itemQuantityTbx.Name = "itemQuantityTbx";
            this.itemQuantityTbx.ReadOnly = true;
            this.itemQuantityTbx.Size = new System.Drawing.Size(95, 20);
            this.itemQuantityTbx.TabIndex = 15;
            this.itemQuantityTbx.Text = "0";
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
            this.itemNumberATbx.Enabled = false;
            this.itemNumberATbx.Location = new System.Drawing.Point(88, 28);
            this.itemNumberATbx.MaxLength = 3;
            this.itemNumberATbx.Name = "itemNumberATbx";
            this.itemNumberATbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberATbx.TabIndex = 13;
            this.itemNumberATbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
            this.itemNumberATbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericOnly);
            this.itemNumberATbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoTabItemNum);
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
            this.itemNumberBTbx.Enabled = false;
            this.itemNumberBTbx.Location = new System.Drawing.Point(148, 28);
            this.itemNumberBTbx.MaxLength = 3;
            this.itemNumberBTbx.Name = "itemNumberBTbx";
            this.itemNumberBTbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberBTbx.TabIndex = 14;
            this.itemNumberBTbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
            this.itemNumberBTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericOnly);
            // 
            // studentInformationGbx
            // 
            this.studentInformationGbx.Controls.Add(this.orptChbx);
            this.studentInformationGbx.Controls.Add(this.studentNumberTbx);
            this.studentInformationGbx.Controls.Add(this.studentNumberLbl);
            this.studentInformationGbx.Controls.Add(this.studentNameTbx);
            this.studentInformationGbx.Controls.Add(this.studentNameLbl);
            this.studentInformationGbx.Controls.Add(this.studentAddressTbx);
            this.studentInformationGbx.Controls.Add(this.rentalDateDueLbl);
            this.studentInformationGbx.Controls.Add(this.studentAddressLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateOutLbl);
            this.studentInformationGbx.Controls.Add(this.studentPhoneTbx);
            this.studentInformationGbx.Controls.Add(this.studentPhoneLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateDueDpk);
            this.studentInformationGbx.Controls.Add(this.studentCourseTbx);
            this.studentInformationGbx.Controls.Add(this.studentCourseLbl);
            this.studentInformationGbx.Controls.Add(this.rentalDateOutDpk);
            this.studentInformationGbx.Location = new System.Drawing.Point(12, 79);
            this.studentInformationGbx.Name = "studentInformationGbx";
            this.studentInformationGbx.Size = new System.Drawing.Size(324, 257);
            this.studentInformationGbx.TabIndex = 14;
            this.studentInformationGbx.TabStop = false;
            this.studentInformationGbx.Text = "Student Information";
            // 
            // orptChbx
            // 
            this.orptChbx.AutoCheck = false;
            this.orptChbx.AutoSize = true;
            this.orptChbx.Enabled = false;
            this.orptChbx.Location = new System.Drawing.Point(267, 148);
            this.orptChbx.Name = "orptChbx";
            this.orptChbx.Size = new System.Drawing.Size(56, 17);
            this.orptChbx.TabIndex = 105;
            this.orptChbx.Text = "ORPT";
            this.orptChbx.UseVisualStyleBackColor = true;
            // 
            // studentNumberTbx
            // 
            this.studentNumberTbx.Enabled = false;
            this.studentNumberTbx.Location = new System.Drawing.Point(110, 42);
            this.studentNumberTbx.MaxLength = 30;
            this.studentNumberTbx.Name = "studentNumberTbx";
            this.studentNumberTbx.ReadOnly = true;
            this.studentNumberTbx.Size = new System.Drawing.Size(150, 20);
            this.studentNumberTbx.TabIndex = 5;
            // 
            // studentNumberLbl
            // 
            this.studentNumberLbl.AutoSize = true;
            this.studentNumberLbl.Location = new System.Drawing.Point(17, 45);
            this.studentNumberLbl.Name = "studentNumberLbl";
            this.studentNumberLbl.Size = new System.Drawing.Size(87, 13);
            this.studentNumberLbl.TabIndex = 27;
            this.studentNumberLbl.Text = "Student Number:";
            // 
            // studentNameTbx
            // 
            this.studentNameTbx.Enabled = false;
            this.studentNameTbx.Location = new System.Drawing.Point(110, 68);
            this.studentNameTbx.MaxLength = 30;
            this.studentNameTbx.Name = "studentNameTbx";
            this.studentNameTbx.ReadOnly = true;
            this.studentNameTbx.Size = new System.Drawing.Size(150, 20);
            this.studentNameTbx.TabIndex = 6;
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.AutoSize = true;
            this.studentNameLbl.Location = new System.Drawing.Point(26, 71);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(78, 13);
            this.studentNameLbl.TabIndex = 29;
            this.studentNameLbl.Text = "Student Name:";
            // 
            // studentAddressTbx
            // 
            this.studentAddressTbx.Enabled = false;
            this.studentAddressTbx.Location = new System.Drawing.Point(110, 94);
            this.studentAddressTbx.MaxLength = 30;
            this.studentAddressTbx.Name = "studentAddressTbx";
            this.studentAddressTbx.ReadOnly = true;
            this.studentAddressTbx.Size = new System.Drawing.Size(150, 20);
            this.studentAddressTbx.TabIndex = 7;
            // 
            // rentalDateDueLbl
            // 
            this.rentalDateDueLbl.AutoSize = true;
            this.rentalDateDueLbl.Location = new System.Drawing.Point(48, 201);
            this.rentalDateDueLbl.Name = "rentalDateDueLbl";
            this.rentalDateDueLbl.Size = new System.Drawing.Size(56, 13);
            this.rentalDateDueLbl.TabIndex = 104;
            this.rentalDateDueLbl.Text = "Date Due:";
            // 
            // studentAddressLbl
            // 
            this.studentAddressLbl.AutoSize = true;
            this.studentAddressLbl.Location = new System.Drawing.Point(27, 97);
            this.studentAddressLbl.Name = "studentAddressLbl";
            this.studentAddressLbl.Size = new System.Drawing.Size(77, 13);
            this.studentAddressLbl.TabIndex = 31;
            this.studentAddressLbl.Text = "Local Address:";
            // 
            // rentalDateOutLbl
            // 
            this.rentalDateOutLbl.AutoSize = true;
            this.rentalDateOutLbl.Location = new System.Drawing.Point(51, 175);
            this.rentalDateOutLbl.Name = "rentalDateOutLbl";
            this.rentalDateOutLbl.Size = new System.Drawing.Size(53, 13);
            this.rentalDateOutLbl.TabIndex = 103;
            this.rentalDateOutLbl.Text = "Date Out:";
            // 
            // studentPhoneTbx
            // 
            this.studentPhoneTbx.Enabled = false;
            this.studentPhoneTbx.Location = new System.Drawing.Point(110, 120);
            this.studentPhoneTbx.MaxLength = 30;
            this.studentPhoneTbx.Name = "studentPhoneTbx";
            this.studentPhoneTbx.ReadOnly = true;
            this.studentPhoneTbx.Size = new System.Drawing.Size(150, 20);
            this.studentPhoneTbx.TabIndex = 8;
            // 
            // studentPhoneLbl
            // 
            this.studentPhoneLbl.AutoSize = true;
            this.studentPhoneLbl.Location = new System.Drawing.Point(34, 123);
            this.studentPhoneLbl.Name = "studentPhoneLbl";
            this.studentPhoneLbl.Size = new System.Drawing.Size(70, 13);
            this.studentPhoneLbl.TabIndex = 33;
            this.studentPhoneLbl.Text = "Local Phone:";
            // 
            // rentalDateDueDpk
            // 
            this.rentalDateDueDpk.CustomFormat = " ";
            this.rentalDateDueDpk.Enabled = false;
            this.rentalDateDueDpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateDueDpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateDueDpk.Location = new System.Drawing.Point(110, 198);
            this.rentalDateDueDpk.Name = "rentalDateDueDpk";
            this.rentalDateDueDpk.Size = new System.Drawing.Size(150, 20);
            this.rentalDateDueDpk.TabIndex = 11;
            this.rentalDateDueDpk.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            this.rentalDateDueDpk.ValueChanged += new System.EventHandler(this.rentalDateDpk_ValueChanged);
            // 
            // studentCourseTbx
            // 
            this.studentCourseTbx.Enabled = false;
            this.studentCourseTbx.Location = new System.Drawing.Point(110, 146);
            this.studentCourseTbx.MaxLength = 20;
            this.studentCourseTbx.Name = "studentCourseTbx";
            this.studentCourseTbx.Size = new System.Drawing.Size(150, 20);
            this.studentCourseTbx.TabIndex = 9;
            // 
            // studentCourseLbl
            // 
            this.studentCourseLbl.AutoSize = true;
            this.studentCourseLbl.Location = new System.Drawing.Point(61, 149);
            this.studentCourseLbl.Name = "studentCourseLbl";
            this.studentCourseLbl.Size = new System.Drawing.Size(43, 13);
            this.studentCourseLbl.TabIndex = 36;
            this.studentCourseLbl.Text = "Course:";
            // 
            // rentalDateOutDpk
            // 
            this.rentalDateOutDpk.CustomFormat = " ";
            this.rentalDateOutDpk.Enabled = false;
            this.rentalDateOutDpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateOutDpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDateOutDpk.Location = new System.Drawing.Point(110, 172);
            this.rentalDateOutDpk.Name = "rentalDateOutDpk";
            this.rentalDateOutDpk.Size = new System.Drawing.Size(150, 20);
            this.rentalDateOutDpk.TabIndex = 10;
            this.rentalDateOutDpk.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            this.rentalDateOutDpk.ValueChanged += new System.EventHandler(this.rentalDateDpk_ValueChanged);
            // 
            // paymentSummaryGbx
            // 
            this.paymentSummaryGbx.Controls.Add(this.paymentWaiveLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentHSTWaiveChbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalWaiveChbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentTotalTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentTotalLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentHSTTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentHSTLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentSubtotalLbl);
            this.paymentSummaryGbx.Controls.Add(this.paymentRentalDaysTbx);
            this.paymentSummaryGbx.Controls.Add(this.paymentRentalDaysLbl);
            this.paymentSummaryGbx.Location = new System.Drawing.Point(378, 342);
            this.paymentSummaryGbx.Name = "paymentSummaryGbx";
            this.paymentSummaryGbx.Size = new System.Drawing.Size(188, 223);
            this.paymentSummaryGbx.TabIndex = 20;
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
            // paymentHSTWaiveChbx
            // 
            this.paymentHSTWaiveChbx.AutoSize = true;
            this.paymentHSTWaiveChbx.Enabled = false;
            this.paymentHSTWaiveChbx.Location = new System.Drawing.Point(156, 117);
            this.paymentHSTWaiveChbx.Name = "paymentHSTWaiveChbx";
            this.paymentHSTWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentHSTWaiveChbx.TabIndex = 25;
            this.paymentHSTWaiveChbx.UseVisualStyleBackColor = true;
            this.paymentHSTWaiveChbx.CheckedChanged += new System.EventHandler(this.paymentChanged);
            // 
            // paymentSubtotalWaiveChbx
            // 
            this.paymentSubtotalWaiveChbx.AutoSize = true;
            this.paymentSubtotalWaiveChbx.Checked = true;
            this.paymentSubtotalWaiveChbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paymentSubtotalWaiveChbx.Enabled = false;
            this.paymentSubtotalWaiveChbx.Location = new System.Drawing.Point(156, 91);
            this.paymentSubtotalWaiveChbx.Name = "paymentSubtotalWaiveChbx";
            this.paymentSubtotalWaiveChbx.Size = new System.Drawing.Size(15, 14);
            this.paymentSubtotalWaiveChbx.TabIndex = 24;
            this.paymentSubtotalWaiveChbx.UseVisualStyleBackColor = true;
            this.paymentSubtotalWaiveChbx.CheckedChanged += new System.EventHandler(this.paymentChanged);
            // 
            // paymentTotalTbx
            // 
            this.paymentTotalTbx.Enabled = false;
            this.paymentTotalTbx.Location = new System.Drawing.Point(84, 140);
            this.paymentTotalTbx.MaxLength = 30;
            this.paymentTotalTbx.Name = "paymentTotalTbx";
            this.paymentTotalTbx.ReadOnly = true;
            this.paymentTotalTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentTotalTbx.TabIndex = 23;
            this.paymentTotalTbx.Text = "$0.00";
            // 
            // paymentTotalLbl
            // 
            this.paymentTotalLbl.AutoSize = true;
            this.paymentTotalLbl.Location = new System.Drawing.Point(44, 143);
            this.paymentTotalLbl.Name = "paymentTotalLbl";
            this.paymentTotalLbl.Size = new System.Drawing.Size(34, 13);
            this.paymentTotalLbl.TabIndex = 118;
            this.paymentTotalLbl.Text = "Total:";
            // 
            // paymentHSTTbx
            // 
            this.paymentHSTTbx.Enabled = false;
            this.paymentHSTTbx.Location = new System.Drawing.Point(84, 114);
            this.paymentHSTTbx.MaxLength = 30;
            this.paymentHSTTbx.Name = "paymentHSTTbx";
            this.paymentHSTTbx.ReadOnly = true;
            this.paymentHSTTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentHSTTbx.TabIndex = 22;
            this.paymentHSTTbx.Text = "$0.00";
            // 
            // paymentHSTLbl
            // 
            this.paymentHSTLbl.AutoSize = true;
            this.paymentHSTLbl.Location = new System.Drawing.Point(47, 117);
            this.paymentHSTLbl.Name = "paymentHSTLbl";
            this.paymentHSTLbl.Size = new System.Drawing.Size(32, 13);
            this.paymentHSTLbl.TabIndex = 114;
            this.paymentHSTLbl.Text = "HST:";
            // 
            // paymentSubtotalTbx
            // 
            this.paymentSubtotalTbx.Enabled = false;
            this.paymentSubtotalTbx.Location = new System.Drawing.Point(84, 88);
            this.paymentSubtotalTbx.MaxLength = 30;
            this.paymentSubtotalTbx.Name = "paymentSubtotalTbx";
            this.paymentSubtotalTbx.ReadOnly = true;
            this.paymentSubtotalTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentSubtotalTbx.TabIndex = 21;
            this.paymentSubtotalTbx.Text = "$0.00";
            // 
            // paymentSubtotalLbl
            // 
            this.paymentSubtotalLbl.AutoSize = true;
            this.paymentSubtotalLbl.Location = new System.Drawing.Point(29, 92);
            this.paymentSubtotalLbl.Name = "paymentSubtotalLbl";
            this.paymentSubtotalLbl.Size = new System.Drawing.Size(49, 13);
            this.paymentSubtotalLbl.TabIndex = 112;
            this.paymentSubtotalLbl.Text = "Subtotal:";
            // 
            // paymentRentalDaysTbx
            // 
            this.paymentRentalDaysTbx.Enabled = false;
            this.paymentRentalDaysTbx.Location = new System.Drawing.Point(84, 62);
            this.paymentRentalDaysTbx.MaxLength = 30;
            this.paymentRentalDaysTbx.Name = "paymentRentalDaysTbx";
            this.paymentRentalDaysTbx.Size = new System.Drawing.Size(53, 20);
            this.paymentRentalDaysTbx.TabIndex = 19;
            this.paymentRentalDaysTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rentalDaysTbxChanged);
            // 
            // paymentRentalDaysLbl
            // 
            this.paymentRentalDaysLbl.AutoSize = true;
            this.paymentRentalDaysLbl.Location = new System.Drawing.Point(10, 65);
            this.paymentRentalDaysLbl.Name = "paymentRentalDaysLbl";
            this.paymentRentalDaysLbl.Size = new System.Drawing.Size(68, 13);
            this.paymentRentalDaysLbl.TabIndex = 108;
            this.paymentRentalDaysLbl.Text = "Rental Days:";
            // 
            // accountBalanceGbx
            // 
            this.accountBalanceGbx.Controls.Add(this.deleteFeeChbx);
            this.accountBalanceGbx.Controls.Add(this.payFeeChbx);
            this.accountBalanceGbx.Controls.Add(this.ignoreFeeChbx);
            this.accountBalanceGbx.Controls.Add(this.outstandingFeeTbx);
            this.accountBalanceGbx.Controls.Add(this.outstandingFeeLbl);
            this.accountBalanceGbx.Location = new System.Drawing.Point(342, 185);
            this.accountBalanceGbx.Name = "accountBalanceGbx";
            this.accountBalanceGbx.Size = new System.Drawing.Size(224, 151);
            this.accountBalanceGbx.TabIndex = 123;
            this.accountBalanceGbx.TabStop = false;
            this.accountBalanceGbx.Text = "Account Balance";
            // 
            // deleteFeeChbx
            // 
            this.deleteFeeChbx.AutoSize = true;
            this.deleteFeeChbx.Enabled = false;
            this.deleteFeeChbx.Location = new System.Drawing.Point(56, 109);
            this.deleteFeeChbx.Name = "deleteFeeChbx";
            this.deleteFeeChbx.Size = new System.Drawing.Size(77, 17);
            this.deleteFeeChbx.TabIndex = 111;
            this.deleteFeeChbx.TabStop = true;
            this.deleteFeeChbx.Text = "Delete Fee";
            this.deleteFeeChbx.UseVisualStyleBackColor = true;
            // 
            // payFeeChbx
            // 
            this.payFeeChbx.AutoSize = true;
            this.payFeeChbx.Enabled = false;
            this.payFeeChbx.Location = new System.Drawing.Point(56, 86);
            this.payFeeChbx.Name = "payFeeChbx";
            this.payFeeChbx.Size = new System.Drawing.Size(64, 17);
            this.payFeeChbx.TabIndex = 110;
            this.payFeeChbx.TabStop = true;
            this.payFeeChbx.Text = "Pay Fee";
            this.payFeeChbx.UseVisualStyleBackColor = true;
            // 
            // ignoreFeeChbx
            // 
            this.ignoreFeeChbx.AutoSize = true;
            this.ignoreFeeChbx.Enabled = false;
            this.ignoreFeeChbx.Location = new System.Drawing.Point(56, 63);
            this.ignoreFeeChbx.Name = "ignoreFeeChbx";
            this.ignoreFeeChbx.Size = new System.Drawing.Size(76, 17);
            this.ignoreFeeChbx.TabIndex = 109;
            this.ignoreFeeChbx.TabStop = true;
            this.ignoreFeeChbx.Text = "Ignore Fee";
            this.ignoreFeeChbx.UseVisualStyleBackColor = true;
            // 
            // outstandingFeeTbx
            // 
            this.outstandingFeeTbx.Enabled = false;
            this.outstandingFeeTbx.Location = new System.Drawing.Point(124, 30);
            this.outstandingFeeTbx.MaxLength = 30;
            this.outstandingFeeTbx.Name = "outstandingFeeTbx";
            this.outstandingFeeTbx.ReadOnly = true;
            this.outstandingFeeTbx.Size = new System.Drawing.Size(69, 20);
            this.outstandingFeeTbx.TabIndex = 19;
            this.outstandingFeeTbx.Text = "$0.00";
            // 
            // outstandingFeeLbl
            // 
            this.outstandingFeeLbl.AutoSize = true;
            this.outstandingFeeLbl.Location = new System.Drawing.Point(30, 32);
            this.outstandingFeeLbl.Name = "outstandingFeeLbl";
            this.outstandingFeeLbl.Size = new System.Drawing.Size(88, 13);
            this.outstandingFeeLbl.TabIndex = 108;
            this.outstandingFeeLbl.Text = "Outstanding Fee:";
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Location = new System.Drawing.Point(358, 114);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(90, 34);
            this.updateStudentBtn.TabIndex = 107;
            this.updateStudentBtn.Text = "Update Student";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            this.updateStudentBtn.Click += new System.EventHandler(this.updateStudentBtn_Click);
            // 
            // existingRentalsBtn
            // 
            this.existingRentalsBtn.Location = new System.Drawing.Point(468, 114);
            this.existingRentalsBtn.Name = "existingRentalsBtn";
            this.existingRentalsBtn.Size = new System.Drawing.Size(90, 34);
            this.existingRentalsBtn.TabIndex = 124;
            this.existingRentalsBtn.Text = "Existing Rentals";
            this.existingRentalsBtn.UseVisualStyleBackColor = true;
            // 
            // enterStudentNumberTbx
            // 
            this.enterStudentNumberTbx.Location = new System.Drawing.Point(136, 33);
            this.enterStudentNumberTbx.MaxLength = 20;
            this.enterStudentNumberTbx.Name = "enterStudentNumberTbx";
            this.enterStudentNumberTbx.Size = new System.Drawing.Size(106, 20);
            this.enterStudentNumberTbx.TabIndex = 105;
            this.enterStudentNumberTbx.Enter += new System.EventHandler(this.rentalSearchingTbx_Enter);
            this.enterStudentNumberTbx.Leave += new System.EventHandler(this.rentalSearchingTbx_Enter);
            // 
            // enterStudentNumberLbl
            // 
            this.enterStudentNumberLbl.AutoSize = true;
            this.enterStudentNumberLbl.Location = new System.Drawing.Point(15, 36);
            this.enterStudentNumberLbl.Name = "enterStudentNumberLbl";
            this.enterStudentNumberLbl.Size = new System.Drawing.Size(115, 13);
            this.enterStudentNumberLbl.TabIndex = 106;
            this.enterStudentNumberLbl.Text = "Enter Student Number:";
            // 
            // enterStudentNumberBtn
            // 
            this.enterStudentNumberBtn.Location = new System.Drawing.Point(248, 32);
            this.enterStudentNumberBtn.Name = "enterStudentNumberBtn";
            this.enterStudentNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.enterStudentNumberBtn.TabIndex = 125;
            this.enterStudentNumberBtn.Text = "Search";
            this.enterStudentNumberBtn.UseVisualStyleBackColor = true;
            this.enterStudentNumberBtn.Click += new System.EventHandler(this.enterStudentNumberBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(419, 589);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 34);
            this.exitBtn.TabIndex = 128;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetRentalBtn
            // 
            this.resetRentalBtn.Enabled = false;
            this.resetRentalBtn.Location = new System.Drawing.Point(246, 589);
            this.resetRentalBtn.Name = "resetRentalBtn";
            this.resetRentalBtn.Size = new System.Drawing.Size(90, 34);
            this.resetRentalBtn.TabIndex = 127;
            this.resetRentalBtn.Text = "Reset Form";
            this.resetRentalBtn.UseVisualStyleBackColor = true;
            this.resetRentalBtn.Click += new System.EventHandler(this.resetRentalBtn_Click);
            // 
            // processRentalBtn
            // 
            this.processRentalBtn.Enabled = false;
            this.processRentalBtn.Location = new System.Drawing.Point(75, 589);
            this.processRentalBtn.Name = "processRentalBtn";
            this.processRentalBtn.Size = new System.Drawing.Size(90, 34);
            this.processRentalBtn.TabIndex = 126;
            this.processRentalBtn.Text = "Process Rental";
            this.processRentalBtn.UseVisualStyleBackColor = true;
            this.processRentalBtn.Click += new System.EventHandler(this.processRentalBtn_Click);
            // 
            // tblStatusTableAdapter1
            // 
            this.tblStatusTableAdapter1.ClearBeforeFill = true;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 651);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetRentalBtn);
            this.Controls.Add(this.processRentalBtn);
            this.Controls.Add(this.enterStudentNumberBtn);
            this.Controls.Add(this.enterStudentNumberTbx);
            this.Controls.Add(this.enterStudentNumberLbl);
            this.Controls.Add(this.existingRentalsBtn);
            this.Controls.Add(this.updateStudentBtn);
            this.Controls.Add(this.accountBalanceGbx);
            this.Controls.Add(this.paymentSummaryGbx);
            this.Controls.Add(this.studentInformationGbx);
            this.Controls.Add(this.rentalItemsGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Equipment";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).EndInit();
            this.rentalItemsGbx.ResumeLayout(false);
            this.rentalItemsGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDgv)).EndInit();
            this.studentInformationGbx.ResumeLayout(false);
            this.studentInformationGbx.PerformLayout();
            this.paymentSummaryGbx.ResumeLayout(false);
            this.paymentSummaryGbx.PerformLayout();
            this.accountBalanceGbx.ResumeLayout(false);
            this.accountBalanceGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblEquipBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource1;
        private System.Windows.Forms.GroupBox rentalItemsGbx;
        private System.Windows.Forms.Button removeAllItemsBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.DataGridView rentalItemsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRentalClm;
        private System.Windows.Forms.TextBox itemQuantityTbx;
        private System.Windows.Forms.Label itemQuantityLbl;
        private System.Windows.Forms.Label itemNumberDashLbl;
        private System.Windows.Forms.TextBox itemNumberATbx;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.TextBox itemNumberBTbx;
        private System.Windows.Forms.GroupBox studentInformationGbx;
        private System.Windows.Forms.TextBox studentNumberTbx;
        private System.Windows.Forms.Label studentNumberLbl;
        private System.Windows.Forms.TextBox studentNameTbx;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.TextBox studentAddressTbx;
        private System.Windows.Forms.Label rentalDateDueLbl;
        private System.Windows.Forms.Label studentAddressLbl;
        private System.Windows.Forms.Label rentalDateOutLbl;
        private System.Windows.Forms.TextBox studentPhoneTbx;
        private System.Windows.Forms.Label studentPhoneLbl;
        private System.Windows.Forms.DateTimePicker rentalDateDueDpk;
        private System.Windows.Forms.TextBox studentCourseTbx;
        private System.Windows.Forms.Label studentCourseLbl;
        private System.Windows.Forms.DateTimePicker rentalDateOutDpk;
        private System.Windows.Forms.GroupBox paymentSummaryGbx;
        private System.Windows.Forms.Label paymentWaiveLbl;
        private System.Windows.Forms.CheckBox paymentHSTWaiveChbx;
        private System.Windows.Forms.CheckBox paymentSubtotalWaiveChbx;
        private System.Windows.Forms.TextBox paymentTotalTbx;
        private System.Windows.Forms.Label paymentTotalLbl;
        private System.Windows.Forms.TextBox paymentHSTTbx;
        private System.Windows.Forms.Label paymentHSTLbl;
        private System.Windows.Forms.TextBox paymentSubtotalTbx;
        private System.Windows.Forms.Label paymentSubtotalLbl;
        private System.Windows.Forms.TextBox paymentRentalDaysTbx;
        private System.Windows.Forms.Label paymentRentalDaysLbl;
        private System.Windows.Forms.GroupBox accountBalanceGbx;
        private System.Windows.Forms.TextBox outstandingFeeTbx;
        private System.Windows.Forms.Label outstandingFeeLbl;
        private System.Windows.Forms.RadioButton ignoreFeeChbx;
        private System.Windows.Forms.RadioButton deleteFeeChbx;
        private System.Windows.Forms.RadioButton payFeeChbx;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.Button existingRentalsBtn;
        private System.Windows.Forms.TextBox enterStudentNumberTbx;
        private System.Windows.Forms.Label enterStudentNumberLbl;
        private System.Windows.Forms.Button enterStudentNumberBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetRentalBtn;
        private System.Windows.Forms.Button processRentalBtn;
        private System.Windows.Forms.CheckBox orptChbx;
        private LUEquipmentDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter1;
    }
}