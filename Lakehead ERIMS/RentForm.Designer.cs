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
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equipNumbTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tblEquipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Equip_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equip_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equip_RentalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.equipNumbTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(33, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 335);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(343, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 33);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(382, 138);
            this.dataGridView1.TabIndex = 7;
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(27, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 53);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equipNumbTextBox
            // 
            this.equipNumbTextBox.Location = new System.Drawing.Point(218, 41);
            this.equipNumbTextBox.Name = "equipNumbTextBox";
            this.equipNumbTextBox.Size = new System.Drawing.Size(83, 22);
            this.equipNumbTextBox.TabIndex = 2;
            this.equipNumbTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Enter Equipment Number:";
            // 
            // tblEquipBindingSource
            // 
            this.tblEquipBindingSource.DataMember = "tblEquip";
            this.tblEquipBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // lUEquipmentDataSet
            // 
            this.lUEquipmentDataSet.DataSetName = "LUEquipmentDataSet";
            this.lUEquipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEquipTableAdapter
            // 
            this.tblEquipTableAdapter.ClearBeforeFill = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalLabel);
            this.groupBox3.Controls.Add(this.hstLabel);
            this.groupBox3.Controls.Add(this.waiveCheckBox);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.subtotalLabel);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(889, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 297);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Summary";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(191, 153);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 17);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "    ";
            // 
            // hstLabel
            // 
            this.hstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hstLabel.Location = new System.Drawing.Point(191, 109);
            this.hstLabel.Name = "hstLabel";
            this.hstLabel.Size = new System.Drawing.Size(54, 17);
            this.hstLabel.TabIndex = 9;
            this.hstLabel.Text = "    ";
            // 
            // waiveCheckBox
            // 
            this.waiveCheckBox.AutoSize = true;
            this.waiveCheckBox.Location = new System.Drawing.Point(269, 66);
            this.waiveCheckBox.Name = "waiveCheckBox";
            this.waiveCheckBox.Size = new System.Drawing.Size(69, 21);
            this.waiveCheckBox.TabIndex = 8;
            this.waiveCheckBox.Text = "Waive";
            this.waiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(53, 154);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 7;
            this.label24.Text = "Total:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "HST:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalLabel.Location = new System.Drawing.Point(191, 66);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(54, 17);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.Text = "    ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
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
            this.groupBox4.Location = new System.Drawing.Point(900, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 260);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Balance";
            // 
            // deleteFeeRadioButton
            // 
            this.deleteFeeRadioButton.AutoSize = true;
            this.deleteFeeRadioButton.Location = new System.Drawing.Point(86, 215);
            this.deleteFeeRadioButton.Name = "deleteFeeRadioButton";
            this.deleteFeeRadioButton.Size = new System.Drawing.Size(98, 21);
            this.deleteFeeRadioButton.TabIndex = 4;
            this.deleteFeeRadioButton.TabStop = true;
            this.deleteFeeRadioButton.Text = "Delete Fee";
            this.deleteFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // payFeeRadioButton
            // 
            this.payFeeRadioButton.AutoSize = true;
            this.payFeeRadioButton.Location = new System.Drawing.Point(86, 178);
            this.payFeeRadioButton.Name = "payFeeRadioButton";
            this.payFeeRadioButton.Size = new System.Drawing.Size(81, 21);
            this.payFeeRadioButton.TabIndex = 3;
            this.payFeeRadioButton.TabStop = true;
            this.payFeeRadioButton.Text = "Pay Fee";
            this.payFeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ignoreRadioButton
            // 
            this.ignoreRadioButton.AutoSize = true;
            this.ignoreRadioButton.Location = new System.Drawing.Point(86, 137);
            this.ignoreRadioButton.Name = "ignoreRadioButton";
            this.ignoreRadioButton.Size = new System.Drawing.Size(97, 21);
            this.ignoreRadioButton.TabIndex = 2;
            this.ignoreRadioButton.TabStop = true;
            this.ignoreRadioButton.Text = "Ignore Fee";
            this.ignoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Outstanding Fee:";
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(198, 61);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(86, 22);
            this.feeTextBox.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equip_Number,
            this.Equip_Name,
            this.Equip_RentalPrice});
            this.dataGridView2.Location = new System.Drawing.Point(513, 529);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(370, 139);
            this.dataGridView2.TabIndex = 27;
            // 
            // Equip_Number
            // 
            this.Equip_Number.HeaderText = "Equip_Number";
            this.Equip_Number.Name = "Equip_Number";
            // 
            // Equip_Name
            // 
            this.Equip_Name.HeaderText = "Equip_Name";
            this.Equip_Name.Name = "Equip_Name";
            // 
            // Equip_RentalPrice
            // 
            this.Equip_RentalPrice.HeaderText = "Equip_RentalPrice";
            this.Equip_RentalPrice.Name = "Equip_RentalPrice";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 861);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox equipNumbTextBox;
        private System.Windows.Forms.Label label9;
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblEquipBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equip_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equip_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equip_RentalPrice;
    }
}