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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
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
            this.label2.Location = new System.Drawing.Point(49, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Equipment Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Equipment Number:";
            // 
            // dateOutPicker
            // 
            this.dateOutPicker.Location = new System.Drawing.Point(118, 272);
            this.dateOutPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateOutPicker.Name = "dateOutPicker";
            this.dateOutPicker.Size = new System.Drawing.Size(127, 20);
            this.dateOutPicker.TabIndex = 9;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.Location = new System.Drawing.Point(117, 304);
            this.DueDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(127, 20);
            this.DueDatePicker.TabIndex = 10;
            // 
            // studentFirstNameLabel
            // 
            this.studentFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentFirstNameLabel.Location = new System.Drawing.Point(150, 175);
            this.studentFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentFirstNameLabel.Name = "studentFirstNameLabel";
            this.studentFirstNameLabel.Size = new System.Drawing.Size(76, 19);
            this.studentFirstNameLabel.TabIndex = 11;
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberLabel.Location = new System.Drawing.Point(150, 233);
            this.studentNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(76, 19);
            this.studentNumberLabel.TabIndex = 12;
            // 
            // equipNameLabel
            // 
            this.equipNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipNameLabel.Location = new System.Drawing.Point(150, 335);
            this.equipNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipNameLabel.Name = "equipNameLabel";
            this.equipNameLabel.Size = new System.Drawing.Size(76, 19);
            this.equipNameLabel.TabIndex = 13;
            // 
            // equipNumberLabel
            // 
            this.equipNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipNumberLabel.Location = new System.Drawing.Point(150, 359);
            this.equipNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipNumberLabel.Name = "equipNumberLabel";
            this.equipNumberLabel.Size = new System.Drawing.Size(76, 19);
            this.equipNumberLabel.TabIndex = 14;
            // 
            // studentLastNameLabel
            // 
            this.studentLastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentLastNameLabel.Location = new System.Drawing.Point(150, 203);
            this.studentLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLastNameLabel.Name = "studentLastNameLabel";
            this.studentLastNameLabel.Size = new System.Drawing.Size(76, 19);
            this.studentLastNameLabel.TabIndex = 16;
            this.studentLastNameLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Student Last Name:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(377, 203);
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
            this.exitButton.Location = new System.Drawing.Point(374, 284);
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
            // editRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 395);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Rental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
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
    }
}