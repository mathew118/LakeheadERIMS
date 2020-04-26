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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.equipNumbTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rentItemGridView = new System.Windows.Forms.DataGridView();
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.equipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDescrip1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDescrip2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDescrip3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipDatePurchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipPONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipRentalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipLateFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.studentFNameLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enterStudentNumberButton = new System.Windows.Forms.Button();
            this.studentLNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "New Rental";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rentItemGridView);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.equipNumbTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(33, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 335);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // equipNumbTextBox
            // 
            this.equipNumbTextBox.Location = new System.Drawing.Point(107, 38);
            this.equipNumbTextBox.Name = "equipNumbTextBox";
            this.equipNumbTextBox.Size = new System.Drawing.Size(83, 22);
            this.equipNumbTextBox.TabIndex = 2;
            this.equipNumbTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // rentItemGridView
            // 
            this.rentItemGridView.AutoGenerateColumns = false;
            this.rentItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipIDDataGridViewTextBoxColumn,
            this.equipNumberDataGridViewTextBoxColumn,
            this.equipNameDataGridViewTextBoxColumn,
            this.equipDescrip1DataGridViewTextBoxColumn,
            this.equipDescrip2DataGridViewTextBoxColumn,
            this.equipDescrip3DataGridViewTextBoxColumn,
            this.equipManufacturerDataGridViewTextBoxColumn,
            this.equipModelDataGridViewTextBoxColumn,
            this.equipSerialDataGridViewTextBoxColumn,
            this.suppIDDataGridViewTextBoxColumn,
            this.equipDatePurchDataGridViewTextBoxColumn,
            this.equipPriceDataGridViewTextBoxColumn,
            this.equipPONumberDataGridViewTextBoxColumn,
            this.equipRentalPriceDataGridViewTextBoxColumn,
            this.equipLateFeeDataGridViewTextBoxColumn,
            this.equipNightsDataGridViewTextBoxColumn,
            this.equipNotesDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.locIDDataGridViewTextBoxColumn});
            this.rentItemGridView.DataSource = this.tblEquipBindingSource;
            this.rentItemGridView.Location = new System.Drawing.Point(44, 76);
            this.rentItemGridView.Name = "rentItemGridView";
            this.rentItemGridView.RowTemplate.Height = 24;
            this.rentItemGridView.Size = new System.Drawing.Size(334, 155);
            this.rentItemGridView.TabIndex = 4;
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
            // equipIDDataGridViewTextBoxColumn
            // 
            this.equipIDDataGridViewTextBoxColumn.DataPropertyName = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.HeaderText = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.Name = "equipIDDataGridViewTextBoxColumn";
            this.equipIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipNumberDataGridViewTextBoxColumn
            // 
            this.equipNumberDataGridViewTextBoxColumn.DataPropertyName = "Equip_Number";
            this.equipNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.equipNumberDataGridViewTextBoxColumn.Name = "equipNumberDataGridViewTextBoxColumn";
            // 
            // equipNameDataGridViewTextBoxColumn
            // 
            this.equipNameDataGridViewTextBoxColumn.DataPropertyName = "Equip_Name";
            this.equipNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.equipNameDataGridViewTextBoxColumn.Name = "equipNameDataGridViewTextBoxColumn";
            // 
            // equipDescrip1DataGridViewTextBoxColumn
            // 
            this.equipDescrip1DataGridViewTextBoxColumn.DataPropertyName = "Equip_Descrip1";
            this.equipDescrip1DataGridViewTextBoxColumn.HeaderText = "Equip_Descrip1";
            this.equipDescrip1DataGridViewTextBoxColumn.Name = "equipDescrip1DataGridViewTextBoxColumn";
            this.equipDescrip1DataGridViewTextBoxColumn.Visible = false;
            // 
            // equipDescrip2DataGridViewTextBoxColumn
            // 
            this.equipDescrip2DataGridViewTextBoxColumn.DataPropertyName = "Equip_Descrip2";
            this.equipDescrip2DataGridViewTextBoxColumn.HeaderText = "Equip_Descrip2";
            this.equipDescrip2DataGridViewTextBoxColumn.Name = "equipDescrip2DataGridViewTextBoxColumn";
            this.equipDescrip2DataGridViewTextBoxColumn.Visible = false;
            // 
            // equipDescrip3DataGridViewTextBoxColumn
            // 
            this.equipDescrip3DataGridViewTextBoxColumn.DataPropertyName = "Equip_Descrip3";
            this.equipDescrip3DataGridViewTextBoxColumn.HeaderText = "Equip_Descrip3";
            this.equipDescrip3DataGridViewTextBoxColumn.Name = "equipDescrip3DataGridViewTextBoxColumn";
            this.equipDescrip3DataGridViewTextBoxColumn.Visible = false;
            // 
            // equipManufacturerDataGridViewTextBoxColumn
            // 
            this.equipManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Equip_Manufacturer";
            this.equipManufacturerDataGridViewTextBoxColumn.HeaderText = "Equip_Manufacturer";
            this.equipManufacturerDataGridViewTextBoxColumn.Name = "equipManufacturerDataGridViewTextBoxColumn";
            this.equipManufacturerDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipModelDataGridViewTextBoxColumn
            // 
            this.equipModelDataGridViewTextBoxColumn.DataPropertyName = "Equip_Model";
            this.equipModelDataGridViewTextBoxColumn.HeaderText = "Equip_Model";
            this.equipModelDataGridViewTextBoxColumn.Name = "equipModelDataGridViewTextBoxColumn";
            this.equipModelDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipSerialDataGridViewTextBoxColumn
            // 
            this.equipSerialDataGridViewTextBoxColumn.DataPropertyName = "Equip_Serial";
            this.equipSerialDataGridViewTextBoxColumn.HeaderText = "Equip_Serial";
            this.equipSerialDataGridViewTextBoxColumn.Name = "equipSerialDataGridViewTextBoxColumn";
            this.equipSerialDataGridViewTextBoxColumn.Visible = false;
            // 
            // suppIDDataGridViewTextBoxColumn
            // 
            this.suppIDDataGridViewTextBoxColumn.DataPropertyName = "Supp_ID";
            this.suppIDDataGridViewTextBoxColumn.HeaderText = "Supp_ID";
            this.suppIDDataGridViewTextBoxColumn.Name = "suppIDDataGridViewTextBoxColumn";
            this.suppIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipDatePurchDataGridViewTextBoxColumn
            // 
            this.equipDatePurchDataGridViewTextBoxColumn.DataPropertyName = "Equip_DatePurch";
            this.equipDatePurchDataGridViewTextBoxColumn.HeaderText = "Equip_DatePurch";
            this.equipDatePurchDataGridViewTextBoxColumn.Name = "equipDatePurchDataGridViewTextBoxColumn";
            this.equipDatePurchDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipPriceDataGridViewTextBoxColumn
            // 
            this.equipPriceDataGridViewTextBoxColumn.DataPropertyName = "Equip_Price";
            this.equipPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.equipPriceDataGridViewTextBoxColumn.Name = "equipPriceDataGridViewTextBoxColumn";
            this.equipPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipPONumberDataGridViewTextBoxColumn
            // 
            this.equipPONumberDataGridViewTextBoxColumn.DataPropertyName = "Equip_PONumber";
            this.equipPONumberDataGridViewTextBoxColumn.HeaderText = "Equip_PONumber";
            this.equipPONumberDataGridViewTextBoxColumn.Name = "equipPONumberDataGridViewTextBoxColumn";
            this.equipPONumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipRentalPriceDataGridViewTextBoxColumn
            // 
            this.equipRentalPriceDataGridViewTextBoxColumn.DataPropertyName = "Equip_RentalPrice";
            this.equipRentalPriceDataGridViewTextBoxColumn.HeaderText = "Rental Price";
            this.equipRentalPriceDataGridViewTextBoxColumn.Name = "equipRentalPriceDataGridViewTextBoxColumn";
            // 
            // equipLateFeeDataGridViewTextBoxColumn
            // 
            this.equipLateFeeDataGridViewTextBoxColumn.DataPropertyName = "Equip_LateFee";
            this.equipLateFeeDataGridViewTextBoxColumn.HeaderText = "Equip_LateFee";
            this.equipLateFeeDataGridViewTextBoxColumn.Name = "equipLateFeeDataGridViewTextBoxColumn";
            this.equipLateFeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipNightsDataGridViewTextBoxColumn
            // 
            this.equipNightsDataGridViewTextBoxColumn.DataPropertyName = "Equip_Nights";
            this.equipNightsDataGridViewTextBoxColumn.HeaderText = "Equip_Nights";
            this.equipNightsDataGridViewTextBoxColumn.Name = "equipNightsDataGridViewTextBoxColumn";
            this.equipNightsDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipNotesDataGridViewTextBoxColumn
            // 
            this.equipNotesDataGridViewTextBoxColumn.DataPropertyName = "Equip_Notes";
            this.equipNotesDataGridViewTextBoxColumn.HeaderText = "Equip_Notes";
            this.equipNotesDataGridViewTextBoxColumn.Name = "equipNotesDataGridViewTextBoxColumn";
            this.equipNotesDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // locIDDataGridViewTextBoxColumn
            // 
            this.locIDDataGridViewTextBoxColumn.DataPropertyName = "Loc_ID";
            this.locIDDataGridViewTextBoxColumn.HeaderText = "Loc_ID";
            this.locIDDataGridViewTextBoxColumn.Name = "locIDDataGridViewTextBoxColumn";
            this.locIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 387);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 420);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.AutoSize = true;
            this.studentNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentNumberLabel.Location = new System.Drawing.Point(201, 214);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(78, 19);
            this.studentNumberLabel.TabIndex = 11;
            this.studentNumberLabel.Text = "                 ";
            // 
            // studentFNameLabel
            // 
            this.studentFNameLabel.AutoSize = true;
            this.studentFNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentFNameLabel.Location = new System.Drawing.Point(201, 236);
            this.studentFNameLabel.Name = "studentFNameLabel";
            this.studentFNameLabel.Size = new System.Drawing.Size(78, 19);
            this.studentFNameLabel.TabIndex = 16;
            this.studentFNameLabel.Text = "                 ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(201, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "                 ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(201, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 19);
            this.label18.TabIndex = 18;
            this.label18.Text = "                 ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(201, 362);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "                 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Enter Student Number:";
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Location = new System.Drawing.Point(231, 35);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(92, 22);
            this.studentNumberTextBox.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enterStudentNumberButton);
            this.groupBox2.Controls.Add(this.studentNumberTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(60, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 133);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Student Number";
            // 
            // enterStudentNumberButton
            // 
            this.enterStudentNumberButton.Location = new System.Drawing.Point(58, 84);
            this.enterStudentNumberButton.Name = "enterStudentNumberButton";
            this.enterStudentNumberButton.Size = new System.Drawing.Size(226, 35);
            this.enterStudentNumberButton.TabIndex = 22;
            this.enterStudentNumberButton.Text = "Enter";
            this.enterStudentNumberButton.UseVisualStyleBackColor = true;
            this.enterStudentNumberButton.Click += new System.EventHandler(this.enterStudentNumberButton_Click);
            // 
            // studentLNameLabel
            // 
            this.studentLNameLabel.AutoSize = true;
            this.studentLNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentLNameLabel.Location = new System.Drawing.Point(201, 267);
            this.studentLNameLabel.Name = "studentLNameLabel";
            this.studentLNameLabel.Size = new System.Drawing.Size(78, 19);
            this.studentLNameLabel.TabIndex = 24;
            this.studentLNameLabel.Text = "                 ";
            this.studentLNameLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Student Last Name:";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 861);
            this.Controls.Add(this.studentLNameLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.studentFNameLabel);
            this.Controls.Add(this.studentNumberLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView rentItemGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox equipNumbTextBox;
        private System.Windows.Forms.Label label9;
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblEquipBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDescrip1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDescrip2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDescrip3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipDatePurchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipPONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipRentalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipLateFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.Label studentFNameLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button enterStudentNumberButton;
        private System.Windows.Forms.Label studentLNameLabel;
        private System.Windows.Forms.Label label13;
    }
}