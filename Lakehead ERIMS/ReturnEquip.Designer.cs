namespace Lakehead_ERIMS
{
    partial class ReturnEquip
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
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.waiveRadio = new System.Windows.Forms.RadioButton();
            this.payLateFee = new System.Windows.Forms.RadioButton();
            this.accumulateLatefee = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitBttn = new System.Windows.Forms.Button();
            this.clearItemBttn = new System.Windows.Forms.Button();
            this.returnBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.desc3Label = new System.Windows.Forms.Label();
            this.desc1Label = new System.Windows.Forms.Label();
            this.desc2Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateOutLabel = new System.Windows.Forms.Label();
            this.dateDueLabel = new System.Windows.Forms.Label();
            this.invoiceNumLabel = new System.Windows.Forms.Label();
            this.stuNumbLabel = new System.Windows.Forms.Label();
            this.stuNameLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.lateFeeLaebl = new System.Windows.Forms.Label();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(130, 33);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(71, 22);
            this.itemNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date due:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Invoice Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Student number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Student Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Account Balance:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lateFeeLaebl);
            this.groupBox1.Controls.Add(this.accumulateLatefee);
            this.groupBox1.Controls.Add(this.payLateFee);
            this.groupBox1.Controls.Add(this.waiveRadio);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(413, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Late Fees";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Late fee:";
            // 
            // waiveRadio
            // 
            this.waiveRadio.AutoSize = true;
            this.waiveRadio.Location = new System.Drawing.Point(52, 84);
            this.waiveRadio.Name = "waiveRadio";
            this.waiveRadio.Size = new System.Drawing.Size(125, 21);
            this.waiveRadio.TabIndex = 1;
            this.waiveRadio.TabStop = true;
            this.waiveRadio.Text = "Wave Late Fee";
            this.waiveRadio.UseVisualStyleBackColor = true;
            // 
            // payLateFee
            // 
            this.payLateFee.AutoSize = true;
            this.payLateFee.Location = new System.Drawing.Point(52, 108);
            this.payLateFee.Name = "payLateFee";
            this.payLateFee.Size = new System.Drawing.Size(104, 21);
            this.payLateFee.TabIndex = 2;
            this.payLateFee.TabStop = true;
            this.payLateFee.Text = "Pay late fee";
            this.payLateFee.UseVisualStyleBackColor = true;
            // 
            // accumulateLatefee
            // 
            this.accumulateLatefee.AutoSize = true;
            this.accumulateLatefee.Location = new System.Drawing.Point(52, 135);
            this.accumulateLatefee.Name = "accumulateLatefee";
            this.accumulateLatefee.Size = new System.Drawing.Size(153, 21);
            this.accumulateLatefee.TabIndex = 3;
            this.accumulateLatefee.TabStop = true;
            this.accumulateLatefee.Text = "Accumulate late fee";
            this.accumulateLatefee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.returnBttn);
            this.groupBox2.Controls.Add(this.clearItemBttn);
            this.groupBox2.Controls.Add(this.exitBttn);
            this.groupBox2.Location = new System.Drawing.Point(64, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(468, 21);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(86, 40);
            this.exitBttn.TabIndex = 0;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // clearItemBttn
            // 
            this.clearItemBttn.Location = new System.Drawing.Point(349, 20);
            this.clearItemBttn.Name = "clearItemBttn";
            this.clearItemBttn.Size = new System.Drawing.Size(106, 40);
            this.clearItemBttn.TabIndex = 1;
            this.clearItemBttn.Text = "Clear Item";
            this.clearItemBttn.UseVisualStyleBackColor = true;
            // 
            // returnBttn
            // 
            this.returnBttn.Location = new System.Drawing.Point(187, 21);
            this.returnBttn.Name = "returnBttn";
            this.returnBttn.Size = new System.Drawing.Size(120, 40);
            this.returnBttn.TabIndex = 2;
            this.returnBttn.Text = "Process Return";
            this.returnBttn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Equpiment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameLabel.Location = new System.Drawing.Point(117, 71);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(196, 26);
            this.itemNameLabel.TabIndex = 16;
            // 
            // desc3Label
            // 
            this.desc3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc3Label.Location = new System.Drawing.Point(117, 192);
            this.desc3Label.Name = "desc3Label";
            this.desc3Label.Size = new System.Drawing.Size(196, 26);
            this.desc3Label.TabIndex = 17;
            // 
            // desc1Label
            // 
            this.desc1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc1Label.Location = new System.Drawing.Point(117, 111);
            this.desc1Label.Name = "desc1Label";
            this.desc1Label.Size = new System.Drawing.Size(196, 26);
            this.desc1Label.TabIndex = 18;
            // 
            // desc2Label
            // 
            this.desc2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc2Label.Location = new System.Drawing.Point(117, 153);
            this.desc2Label.Name = "desc2Label";
            this.desc2Label.Size = new System.Drawing.Size(196, 26);
            this.desc2Label.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Destroyed",
            "Retired",
            "Missing",
            "Scrapped for Parts",
            "Retired",
            "Sold",
            "Unknown",
            "Out",
            "Waiting repairs",
            "Lost"});
            this.comboBox1.Location = new System.Drawing.Point(117, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // dateOutLabel
            // 
            this.dateOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutLabel.Location = new System.Drawing.Point(117, 257);
            this.dateOutLabel.Name = "dateOutLabel";
            this.dateOutLabel.Size = new System.Drawing.Size(196, 26);
            this.dateOutLabel.TabIndex = 21;
            // 
            // dateDueLabel
            // 
            this.dateDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateDueLabel.Location = new System.Drawing.Point(117, 290);
            this.dateDueLabel.Name = "dateDueLabel";
            this.dateDueLabel.Size = new System.Drawing.Size(196, 26);
            this.dateDueLabel.TabIndex = 22;
            // 
            // invoiceNumLabel
            // 
            this.invoiceNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceNumLabel.Location = new System.Drawing.Point(537, 55);
            this.invoiceNumLabel.Name = "invoiceNumLabel";
            this.invoiceNumLabel.Size = new System.Drawing.Size(196, 26);
            this.invoiceNumLabel.TabIndex = 23;
            // 
            // stuNumbLabel
            // 
            this.stuNumbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stuNumbLabel.Location = new System.Drawing.Point(537, 88);
            this.stuNumbLabel.Name = "stuNumbLabel";
            this.stuNumbLabel.Size = new System.Drawing.Size(196, 26);
            this.stuNumbLabel.TabIndex = 24;
            // 
            // stuNameLabel
            // 
            this.stuNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stuNameLabel.Location = new System.Drawing.Point(537, 119);
            this.stuNameLabel.Name = "stuNameLabel";
            this.stuNameLabel.Size = new System.Drawing.Size(196, 26);
            this.stuNameLabel.TabIndex = 25;
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountBalanceLabel.Location = new System.Drawing.Point(532, 162);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(196, 26);
            this.accountBalanceLabel.TabIndex = 27;
            // 
            // lateFeeLaebl
            // 
            this.lateFeeLaebl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lateFeeLaebl.Location = new System.Drawing.Point(95, 32);
            this.lateFeeLaebl.Name = "lateFeeLaebl";
            this.lateFeeLaebl.Size = new System.Drawing.Size(196, 26);
            this.lateFeeLaebl.TabIndex = 28;
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
            // tblEquipTableAdapter1
            // 
            this.tblEquipTableAdapter1.ClearBeforeFill = true;
            // 
            // tblRentalTableAdapter1
            // 
            this.tblRentalTableAdapter1.ClearBeforeFill = true;
            // 
            // ReturnEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.stuNameLabel);
            this.Controls.Add(this.stuNumbLabel);
            this.Controls.Add(this.invoiceNumLabel);
            this.Controls.Add(this.dateDueLabel);
            this.Controls.Add(this.dateOutLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.desc2Label);
            this.Controls.Add(this.desc1Label);
            this.Controls.Add(this.desc3Label);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNumberTextBox);
            this.Name = "ReturnEquip";
            this.Text = "ReturnEquip";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lateFeeLaebl;
        private System.Windows.Forms.RadioButton accumulateLatefee;
        private System.Windows.Forms.RadioButton payLateFee;
        private System.Windows.Forms.RadioButton waiveRadio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnBttn;
        private System.Windows.Forms.Button clearItemBttn;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label desc3Label;
        private System.Windows.Forms.Label desc1Label;
        private System.Windows.Forms.Label desc2Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dateOutLabel;
        private System.Windows.Forms.Label dateDueLabel;
        private System.Windows.Forms.Label invoiceNumLabel;
        private System.Windows.Forms.Label stuNumbLabel;
        private System.Windows.Forms.Label stuNameLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
    }
}