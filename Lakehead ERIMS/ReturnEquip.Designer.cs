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
            this.lateFeeLaebl = new System.Windows.Forms.Label();
            this.accumulateLatefee = new System.Windows.Forms.RadioButton();
            this.payLateFee = new System.Windows.Forms.RadioButton();
            this.waiveRadio = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.returnBttn = new System.Windows.Forms.Button();
            this.clearItemBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
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
            this.itemNumberTextBox.Location = new System.Drawing.Point(98, 27);
            this.itemNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(54, 20);
            this.itemNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date due:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Invoice Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Student number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Student Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 132);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(310, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 143);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Late Fees";
            // 
            // lateFeeLaebl
            // 
            this.lateFeeLaebl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lateFeeLaebl.Location = new System.Drawing.Point(71, 26);
            this.lateFeeLaebl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lateFeeLaebl.Name = "lateFeeLaebl";
            this.lateFeeLaebl.Size = new System.Drawing.Size(148, 22);
            this.lateFeeLaebl.TabIndex = 28;
            // 
            // accumulateLatefee
            // 
            this.accumulateLatefee.AutoSize = true;
            this.accumulateLatefee.Location = new System.Drawing.Point(39, 110);
            this.accumulateLatefee.Margin = new System.Windows.Forms.Padding(2);
            this.accumulateLatefee.Name = "accumulateLatefee";
            this.accumulateLatefee.Size = new System.Drawing.Size(119, 17);
            this.accumulateLatefee.TabIndex = 3;
            this.accumulateLatefee.TabStop = true;
            this.accumulateLatefee.Text = "Accumulate late fee";
            this.accumulateLatefee.UseVisualStyleBackColor = true;
            // 
            // payLateFee
            // 
            this.payLateFee.AutoSize = true;
            this.payLateFee.Location = new System.Drawing.Point(39, 88);
            this.payLateFee.Margin = new System.Windows.Forms.Padding(2);
            this.payLateFee.Name = "payLateFee";
            this.payLateFee.Size = new System.Drawing.Size(81, 17);
            this.payLateFee.TabIndex = 2;
            this.payLateFee.TabStop = true;
            this.payLateFee.Text = "Pay late fee";
            this.payLateFee.UseVisualStyleBackColor = true;
            // 
            // waiveRadio
            // 
            this.waiveRadio.AutoSize = true;
            this.waiveRadio.Location = new System.Drawing.Point(39, 68);
            this.waiveRadio.Margin = new System.Windows.Forms.Padding(2);
            this.waiveRadio.Name = "waiveRadio";
            this.waiveRadio.Size = new System.Drawing.Size(99, 17);
            this.waiveRadio.TabIndex = 1;
            this.waiveRadio.TabStop = true;
            this.waiveRadio.Text = "Wave Late Fee";
            this.waiveRadio.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Late fee:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.returnBttn);
            this.groupBox2.Controls.Add(this.clearItemBttn);
            this.groupBox2.Controls.Add(this.exitBttn);
            this.groupBox2.Location = new System.Drawing.Point(48, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(462, 57);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Equpiment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnBttn
            // 
            this.returnBttn.Location = new System.Drawing.Point(140, 17);
            this.returnBttn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBttn.Name = "returnBttn";
            this.returnBttn.Size = new System.Drawing.Size(90, 32);
            this.returnBttn.TabIndex = 2;
            this.returnBttn.Text = "Process Return";
            this.returnBttn.UseVisualStyleBackColor = true;
            this.returnBttn.Click += new System.EventHandler(this.returnBttn_Click);
            // 
            // clearItemBttn
            // 
            this.clearItemBttn.Location = new System.Drawing.Point(262, 16);
            this.clearItemBttn.Margin = new System.Windows.Forms.Padding(2);
            this.clearItemBttn.Name = "clearItemBttn";
            this.clearItemBttn.Size = new System.Drawing.Size(80, 32);
            this.clearItemBttn.TabIndex = 1;
            this.clearItemBttn.Text = "Clear Item";
            this.clearItemBttn.UseVisualStyleBackColor = true;
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(351, 17);
            this.exitBttn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(64, 32);
            this.exitBttn.TabIndex = 0;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameLabel.Location = new System.Drawing.Point(88, 58);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(148, 22);
            this.itemNameLabel.TabIndex = 16;
            // 
            // desc3Label
            // 
            this.desc3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc3Label.Location = new System.Drawing.Point(88, 156);
            this.desc3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desc3Label.Name = "desc3Label";
            this.desc3Label.Size = new System.Drawing.Size(148, 22);
            this.desc3Label.TabIndex = 17;
            // 
            // desc1Label
            // 
            this.desc1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc1Label.Location = new System.Drawing.Point(88, 90);
            this.desc1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desc1Label.Name = "desc1Label";
            this.desc1Label.Size = new System.Drawing.Size(148, 22);
            this.desc1Label.TabIndex = 18;
            // 
            // desc2Label
            // 
            this.desc2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc2Label.Location = new System.Drawing.Point(88, 124);
            this.desc2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desc2Label.Name = "desc2Label";
            this.desc2Label.Size = new System.Drawing.Size(148, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(88, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // dateOutLabel
            // 
            this.dateOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutLabel.Location = new System.Drawing.Point(88, 209);
            this.dateOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOutLabel.Name = "dateOutLabel";
            this.dateOutLabel.Size = new System.Drawing.Size(148, 22);
            this.dateOutLabel.TabIndex = 21;
            // 
            // dateDueLabel
            // 
            this.dateDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateDueLabel.Location = new System.Drawing.Point(88, 236);
            this.dateDueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDueLabel.Name = "dateDueLabel";
            this.dateDueLabel.Size = new System.Drawing.Size(148, 22);
            this.dateDueLabel.TabIndex = 22;
            // 
            // invoiceNumLabel
            // 
            this.invoiceNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceNumLabel.Location = new System.Drawing.Point(403, 45);
            this.invoiceNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invoiceNumLabel.Name = "invoiceNumLabel";
            this.invoiceNumLabel.Size = new System.Drawing.Size(148, 22);
            this.invoiceNumLabel.TabIndex = 23;
            // 
            // stuNumbLabel
            // 
            this.stuNumbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stuNumbLabel.Location = new System.Drawing.Point(403, 72);
            this.stuNumbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stuNumbLabel.Name = "stuNumbLabel";
            this.stuNumbLabel.Size = new System.Drawing.Size(148, 22);
            this.stuNumbLabel.TabIndex = 24;
            // 
            // stuNameLabel
            // 
            this.stuNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stuNameLabel.Location = new System.Drawing.Point(403, 97);
            this.stuNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stuNameLabel.Name = "stuNameLabel";
            this.stuNameLabel.Size = new System.Drawing.Size(148, 22);
            this.stuNameLabel.TabIndex = 25;
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountBalanceLabel.Location = new System.Drawing.Point(399, 132);
            this.accountBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(148, 22);
            this.accountBalanceLabel.TabIndex = 27;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 441);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ReturnEquip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Equipment";
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