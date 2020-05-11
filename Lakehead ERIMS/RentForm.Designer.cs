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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rentItem = new System.Windows.Forms.GroupBox();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equipNumbTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lUEquipmentDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.dateRentedPicker = new System.Windows.Forms.DateTimePicker();
            this.dateDuePicker = new System.Windows.Forms.DateTimePicker();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.studentFNameLabel = new System.Windows.Forms.Label();
            this.studentAddressLabe = new System.Windows.Forms.Label();
            this.studentPhone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enterStudentNumberButton = new System.Windows.Forms.Button();
            this.studentLNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calcCost = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.hstLabel = new System.Windows.Forms.Label();
            this.waiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.payFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.ignoreRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.lUEquipmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.rentalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "New Rental";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date Rented:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Due:";
            // 
            // rentItem
            // 
            this.rentItem.Controls.Add(this.itemGridView);
            this.rentItem.Controls.Add(this.removeButton);
            this.rentItem.Controls.Add(this.deleteButton);
            this.rentItem.Controls.Add(this.addButton);
            this.rentItem.Controls.Add(this.equipNumbTextBox);
            this.rentItem.Controls.Add(this.label9);
            this.rentItem.Location = new System.Drawing.Point(25, 371);
            this.rentItem.Margin = new System.Windows.Forms.Padding(2);
            this.rentItem.Name = "rentItem";
            this.rentItem.Padding = new System.Windows.Forms.Padding(2);
            this.rentItem.Size = new System.Drawing.Size(384, 272);
            this.rentItem.TabIndex = 8;
            this.rentItem.TabStop = false;
            this.rentItem.Text = "Rent Items";
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.colName,
            this.Price});
            this.itemGridView.Location = new System.Drawing.Point(33, 68);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(292, 131);
            this.itemGridView.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(209, 227);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(92, 29);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove All";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(109, 226);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 31);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 224);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equipNumbTextBox
            // 
            this.equipNumbTextBox.Location = new System.Drawing.Point(164, 33);
            this.equipNumbTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipNumbTextBox.Name = "equipNumbTextBox";
            this.equipNumbTextBox.Size = new System.Drawing.Size(63, 20);
            this.equipNumbTextBox.TabIndex = 2;
            this.equipNumbTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Enter Equipment Number:";
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
            // dateRentedPicker
            // 
            this.dateRentedPicker.Location = new System.Drawing.Point(115, 299);
            this.dateRentedPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateRentedPicker.Name = "dateRentedPicker";
            this.dateRentedPicker.Size = new System.Drawing.Size(122, 20);
            this.dateRentedPicker.TabIndex = 9;
            // 
            // dateDuePicker
            // 
            this.dateDuePicker.Location = new System.Drawing.Point(115, 322);
            this.dateDuePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDuePicker.Name = "dateDuePicker";
            this.dateDuePicker.Size = new System.Drawing.Size(122, 20);
            this.dateDuePicker.TabIndex = 10;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentNumberLabel.Location = new System.Drawing.Point(151, 174);
            this.studentNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(119, 15);
            this.studentNumberLabel.TabIndex = 11;
            this.studentNumberLabel.Text = "                 ";
            // 
            // studentFNameLabel
            // 
            this.studentFNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentFNameLabel.Location = new System.Drawing.Point(151, 192);
            this.studentFNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentFNameLabel.Name = "studentFNameLabel";
            this.studentFNameLabel.Size = new System.Drawing.Size(119, 15);
            this.studentFNameLabel.TabIndex = 16;
            this.studentFNameLabel.Text = "                 ";
            // 
            // studentAddressLabe
            // 
            this.studentAddressLabe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentAddressLabe.Location = new System.Drawing.Point(151, 245);
            this.studentAddressLabe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentAddressLabe.Name = "studentAddressLabe";
            this.studentAddressLabe.Size = new System.Drawing.Size(119, 15);
            this.studentAddressLabe.TabIndex = 17;
            this.studentAddressLabe.Text = "                 ";
            // 
            // studentPhone
            // 
            this.studentPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentPhone.Location = new System.Drawing.Point(151, 269);
            this.studentPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(119, 15);
            this.studentPhone.TabIndex = 18;
            this.studentPhone.Text = "                 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Enter Student Number:";
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Location = new System.Drawing.Point(173, 28);
            this.studentNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(70, 20);
            this.studentNumberTextBox.TabIndex = 21;
            this.studentNumberTextBox.TextChanged += new System.EventHandler(this.studentNumberTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enterStudentNumberButton);
            this.groupBox2.Controls.Add(this.studentNumberTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(45, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(310, 108);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Student Number";
            // 
            // enterStudentNumberButton
            // 
            this.enterStudentNumberButton.Location = new System.Drawing.Point(44, 68);
            this.enterStudentNumberButton.Margin = new System.Windows.Forms.Padding(2);
            this.enterStudentNumberButton.Name = "enterStudentNumberButton";
            this.enterStudentNumberButton.Size = new System.Drawing.Size(170, 28);
            this.enterStudentNumberButton.TabIndex = 22;
            this.enterStudentNumberButton.Text = "Enter";
            this.enterStudentNumberButton.UseVisualStyleBackColor = true;
            this.enterStudentNumberButton.Click += new System.EventHandler(this.enterStudentNumberButton_Click);
            // 
            // studentLNameLabel
            // 
            this.studentLNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentLNameLabel.Location = new System.Drawing.Point(151, 217);
            this.studentLNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLNameLabel.Name = "studentLNameLabel";
            this.studentLNameLabel.Size = new System.Drawing.Size(119, 15);
            this.studentLNameLabel.TabIndex = 24;
            this.studentLNameLabel.Text = "                 ";
            this.studentLNameLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 217);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Student Last Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calcCost);
            this.groupBox3.Controls.Add(this.totalLabel);
            this.groupBox3.Controls.Add(this.hstLabel);
            this.groupBox3.Controls.Add(this.waiveCheckBox);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.subtotalLabel);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(424, 344);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(302, 241);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Summary";
            // 
            // calcCost
            // 
            this.calcCost.Location = new System.Drawing.Point(94, 176);
            this.calcCost.Margin = new System.Windows.Forms.Padding(2);
            this.calcCost.Name = "calcCost";
            this.calcCost.Size = new System.Drawing.Size(127, 33);
            this.calcCost.TabIndex = 11;
            this.calcCost.Text = "Calculate Cost";
            this.calcCost.UseVisualStyleBackColor = true;
            this.calcCost.Click += new System.EventHandler(this.calcCost_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(143, 124);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 14);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "    ";
            // 
            // hstLabel
            // 
            this.hstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hstLabel.Location = new System.Drawing.Point(143, 89);
            this.hstLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hstLabel.Name = "hstLabel";
            this.hstLabel.Size = new System.Drawing.Size(41, 14);
            this.hstLabel.TabIndex = 9;
            this.hstLabel.Text = "    ";
            // 
            // waiveCheckBox
            // 
            this.waiveCheckBox.AutoSize = true;
            this.waiveCheckBox.Location = new System.Drawing.Point(202, 54);
            this.waiveCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.waiveCheckBox.Name = "waiveCheckBox";
            this.waiveCheckBox.Size = new System.Drawing.Size(57, 17);
            this.waiveCheckBox.TabIndex = 8;
            this.waiveCheckBox.Text = "Waive";
            this.waiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 125);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Total:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 89);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "HST:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(143, 54);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(41, 14);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.Text = "    ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Subtotal:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteFeeRadioButton);
            this.groupBox4.Controls.Add(this.payFeeRadioButton);
            this.groupBox4.Controls.Add(this.ignoreRadioButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.feeTextBox);
            this.groupBox4.Location = new System.Drawing.Point(432, 93);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(293, 211);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Balance";
            // 
            // deleteFeeRadioButton
            // 
            this.deleteFeeRadioButton.AutoSize = true;
            this.deleteFeeRadioButton.Location = new System.Drawing.Point(64, 175);
            this.deleteFeeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteFeeRadioButton.Name = "deleteFeeRadioButton";
            this.deleteFeeRadioButton.Size = new System.Drawing.Size(77, 17);
            this.deleteFeeRadioButton.TabIndex = 4;
            this.deleteFeeRadioButton.TabStop = true;
            this.deleteFeeRadioButton.Text = "Delete Fee";
            this.deleteFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // payFeeRadioButton
            // 
            this.payFeeRadioButton.AutoSize = true;
            this.payFeeRadioButton.Location = new System.Drawing.Point(64, 145);
            this.payFeeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.payFeeRadioButton.Name = "payFeeRadioButton";
            this.payFeeRadioButton.Size = new System.Drawing.Size(64, 17);
            this.payFeeRadioButton.TabIndex = 3;
            this.payFeeRadioButton.TabStop = true;
            this.payFeeRadioButton.Text = "Pay Fee";
            this.payFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ignoreRadioButton
            // 
            this.ignoreRadioButton.AutoSize = true;
            this.ignoreRadioButton.Checked = true;
            this.ignoreRadioButton.Location = new System.Drawing.Point(64, 111);
            this.ignoreRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ignoreRadioButton.Name = "ignoreRadioButton";
            this.ignoreRadioButton.Size = new System.Drawing.Size(76, 17);
            this.ignoreRadioButton.TabIndex = 2;
            this.ignoreRadioButton.TabStop = true;
            this.ignoreRadioButton.Text = "Ignore Fee";
            this.ignoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Outstanding Fee:";
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(148, 50);
            this.feeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(66, 20);
            this.feeTextBox.TabIndex = 0;
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
            // luEquipmentDataSet1
            // 
            this.luEquipmentDataSet1.DataSetName = "LUEquipmentDataSet";
            this.luEquipmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalButton
            // 
            this.rentalButton.Location = new System.Drawing.Point(439, 602);
            this.rentalButton.Margin = new System.Windows.Forms.Padding(2);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(95, 25);
            this.rentalButton.TabIndex = 27;
            this.rentalButton.Text = "Process Rental";
            this.rentalButton.UseVisualStyleBackColor = true;
            this.rentalButton.Click += new System.EventHandler(this.rentalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(574, 599);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 28);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 657);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rentalButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.studentLNameLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.studentPhone);
            this.Controls.Add(this.studentAddressLabe);
            this.Controls.Add(this.studentFNameLabel);
            this.Controls.Add(this.studentNumberLabel);
            this.Controls.Add(this.dateDuePicker);
            this.Controls.Add(this.dateRentedPicker);
            this.Controls.Add(this.rentItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RentForm";
            this.Text = "Rent Equipment";
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.rentItem.ResumeLayout(false);
            this.rentItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox rentItem;
        private System.Windows.Forms.TextBox equipNumbTextBox;
        private System.Windows.Forms.Label label9;
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblEquipBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateRentedPicker;
        private System.Windows.Forms.DateTimePicker dateDuePicker;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.Label studentFNameLabel;
        private System.Windows.Forms.Label studentAddressLabe;
        private System.Windows.Forms.Label studentPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button enterStudentNumberButton;
        private System.Windows.Forms.Label studentLNameLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label hstLabel;
        private System.Windows.Forms.CheckBox waiveCheckBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton deleteFeeRadioButton;
        private System.Windows.Forms.RadioButton payFeeRadioButton;
        private System.Windows.Forms.RadioButton ignoreRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView itemGridView;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private System.Windows.Forms.Button calcCost;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource1;
        private System.Windows.Forms.Button rentalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}