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
            this.components = new System.ComponentModel.Container();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.itemNumberDashLbl = new System.Windows.Forms.Label();
            this.itemNumberATbx = new System.Windows.Forms.TextBox();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.itemNumberBTbx = new System.Windows.Forms.TextBox();
            this.stillOutTbx = new System.Windows.Forms.TextBox();
            this.stillOutLbl = new System.Windows.Forms.Label();
            this.studentNameTbx = new System.Windows.Forms.TextBox();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.studentNumberTbx = new System.Windows.Forms.TextBox();
            this.studentNumberLbl = new System.Windows.Forms.Label();
            this.invoiceNumberTbx = new System.Windows.Forms.TextBox();
            this.invoiceNumberLbl = new System.Windows.Forms.Label();
            this.lateFeesGbx = new System.Windows.Forms.GroupBox();
            this.invoiceLateFeesTbx = new System.Windows.Forms.TextBox();
            this.accumulateLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.payLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.waiveLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.invoiceLateFeesLbl = new System.Windows.Forms.Label();
            this.itemsQueuedTbx = new System.Windows.Forms.TextBox();
            this.itemsQueuedLbl = new System.Windows.Forms.Label();
            this.statusCbx = new System.Windows.Forms.ComboBox();
            this.tblStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOutLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.description3Lbl = new System.Windows.Forms.Label();
            this.description3Tbx = new System.Windows.Forms.TextBox();
            this.description2Lbl = new System.Windows.Forms.Label();
            this.description2Tbx = new System.Windows.Forms.TextBox();
            this.description1Lbl = new System.Windows.Forms.Label();
            this.description1Tbx = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemNameTbx = new System.Windows.Forms.TextBox();
            this.dateDueLbl = new System.Windows.Forms.Label();
            this.accountBalanceTbx = new System.Windows.Forms.TextBox();
            this.accountBalanceLbl = new System.Windows.Forms.Label();
            this.tblStatusTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStatusTableAdapter();
            this.dateOutTbx = new System.Windows.Forms.TextBox();
            this.dateDueTbx = new System.Windows.Forms.TextBox();
            this.queueBtn = new System.Windows.Forms.Button();
            this.processReturnsBtn = new System.Windows.Forms.Button();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tblStatusTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            this.lateFeesGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(578, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Return Rented Equipment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemNumberDashLbl
            // 
            this.itemNumberDashLbl.AutoSize = true;
            this.itemNumberDashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberDashLbl.Location = new System.Drawing.Point(150, 69);
            this.itemNumberDashLbl.Name = "itemNumberDashLbl";
            this.itemNumberDashLbl.Size = new System.Drawing.Size(12, 15);
            this.itemNumberDashLbl.TabIndex = 71;
            this.itemNumberDashLbl.Text = "-";
            // 
            // itemNumberATbx
            // 
            this.itemNumberATbx.Location = new System.Drawing.Point(105, 68);
            this.itemNumberATbx.MaxLength = 3;
            this.itemNumberATbx.Name = "itemNumberATbx";
            this.itemNumberATbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberATbx.TabIndex = 0;
            this.itemNumberATbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
            this.itemNumberATbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoTabItemNum);
            // 
            // itemNumberLbl
            // 
            this.itemNumberLbl.AutoSize = true;
            this.itemNumberLbl.Location = new System.Drawing.Point(29, 71);
            this.itemNumberLbl.Name = "itemNumberLbl";
            this.itemNumberLbl.Size = new System.Drawing.Size(70, 13);
            this.itemNumberLbl.TabIndex = 70;
            this.itemNumberLbl.Text = "Item Number:";
            // 
            // itemNumberBTbx
            // 
            this.itemNumberBTbx.Location = new System.Drawing.Point(165, 68);
            this.itemNumberBTbx.MaxLength = 3;
            this.itemNumberBTbx.Name = "itemNumberBTbx";
            this.itemNumberBTbx.Size = new System.Drawing.Size(42, 20);
            this.itemNumberBTbx.TabIndex = 1;
            this.itemNumberBTbx.TextChanged += new System.EventHandler(this.itemNumberTbx_TextChanged);
            // 
            // stillOutTbx
            // 
            this.stillOutTbx.Location = new System.Drawing.Point(420, 146);
            this.stillOutTbx.MaxLength = 3;
            this.stillOutTbx.Name = "stillOutTbx";
            this.stillOutTbx.ReadOnly = true;
            this.stillOutTbx.Size = new System.Drawing.Size(148, 20);
            this.stillOutTbx.TabIndex = 13;
            // 
            // stillOutLbl
            // 
            this.stillOutLbl.AutoSize = true;
            this.stillOutLbl.Location = new System.Drawing.Point(368, 149);
            this.stillOutLbl.Name = "stillOutLbl";
            this.stillOutLbl.Size = new System.Drawing.Size(46, 13);
            this.stillOutLbl.TabIndex = 93;
            this.stillOutLbl.Text = "Still Out:";
            // 
            // studentNameTbx
            // 
            this.studentNameTbx.Location = new System.Drawing.Point(420, 120);
            this.studentNameTbx.MaxLength = 3;
            this.studentNameTbx.Name = "studentNameTbx";
            this.studentNameTbx.ReadOnly = true;
            this.studentNameTbx.Size = new System.Drawing.Size(148, 20);
            this.studentNameTbx.TabIndex = 12;
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.AutoSize = true;
            this.studentNameLbl.Location = new System.Drawing.Point(336, 123);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(78, 13);
            this.studentNameLbl.TabIndex = 91;
            this.studentNameLbl.Text = "Student Name:";
            // 
            // studentNumberTbx
            // 
            this.studentNumberTbx.Location = new System.Drawing.Point(420, 94);
            this.studentNumberTbx.MaxLength = 3;
            this.studentNumberTbx.Name = "studentNumberTbx";
            this.studentNumberTbx.ReadOnly = true;
            this.studentNumberTbx.Size = new System.Drawing.Size(148, 20);
            this.studentNumberTbx.TabIndex = 11;
            // 
            // studentNumberLbl
            // 
            this.studentNumberLbl.AutoSize = true;
            this.studentNumberLbl.Location = new System.Drawing.Point(327, 97);
            this.studentNumberLbl.Name = "studentNumberLbl";
            this.studentNumberLbl.Size = new System.Drawing.Size(87, 13);
            this.studentNumberLbl.TabIndex = 89;
            this.studentNumberLbl.Text = "Student Number:";
            // 
            // invoiceNumberTbx
            // 
            this.invoiceNumberTbx.Location = new System.Drawing.Point(420, 68);
            this.invoiceNumberTbx.MaxLength = 3;
            this.invoiceNumberTbx.Name = "invoiceNumberTbx";
            this.invoiceNumberTbx.ReadOnly = true;
            this.invoiceNumberTbx.Size = new System.Drawing.Size(148, 20);
            this.invoiceNumberTbx.TabIndex = 10;
            // 
            // invoiceNumberLbl
            // 
            this.invoiceNumberLbl.AutoSize = true;
            this.invoiceNumberLbl.Location = new System.Drawing.Point(329, 71);
            this.invoiceNumberLbl.Name = "invoiceNumberLbl";
            this.invoiceNumberLbl.Size = new System.Drawing.Size(85, 13);
            this.invoiceNumberLbl.TabIndex = 87;
            this.invoiceNumberLbl.Text = "Invoice Number:";
            // 
            // lateFeesGbx
            // 
            this.lateFeesGbx.Controls.Add(this.invoiceLateFeesTbx);
            this.lateFeesGbx.Controls.Add(this.accumulateLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.payLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.waiveLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.invoiceLateFeesLbl);
            this.lateFeesGbx.Location = new System.Drawing.Point(325, 197);
            this.lateFeesGbx.Margin = new System.Windows.Forms.Padding(2);
            this.lateFeesGbx.Name = "lateFeesGbx";
            this.lateFeesGbx.Padding = new System.Windows.Forms.Padding(2);
            this.lateFeesGbx.Size = new System.Drawing.Size(243, 112);
            this.lateFeesGbx.TabIndex = 15;
            this.lateFeesGbx.TabStop = false;
            this.lateFeesGbx.Text = "Late Fees";
            // 
            // invoiceLateFeesTbx
            // 
            this.invoiceLateFeesTbx.Location = new System.Drawing.Point(112, 21);
            this.invoiceLateFeesTbx.MaxLength = 3;
            this.invoiceLateFeesTbx.Name = "invoiceLateFeesTbx";
            this.invoiceLateFeesTbx.ReadOnly = true;
            this.invoiceLateFeesTbx.Size = new System.Drawing.Size(104, 20);
            this.invoiceLateFeesTbx.TabIndex = 0;
            // 
            // accumulateLateFeesCbx
            // 
            this.accumulateLateFeesCbx.AutoSize = true;
            this.accumulateLateFeesCbx.Location = new System.Drawing.Point(14, 88);
            this.accumulateLateFeesCbx.Margin = new System.Windows.Forms.Padding(2);
            this.accumulateLateFeesCbx.Name = "accumulateLateFeesCbx";
            this.accumulateLateFeesCbx.Size = new System.Drawing.Size(126, 17);
            this.accumulateLateFeesCbx.TabIndex = 3;
            this.accumulateLateFeesCbx.TabStop = true;
            this.accumulateLateFeesCbx.Text = "Accumulate Late Fee";
            this.accumulateLateFeesCbx.UseVisualStyleBackColor = true;
            // 
            // payLateFeesCbx
            // 
            this.payLateFeesCbx.AutoSize = true;
            this.payLateFeesCbx.Location = new System.Drawing.Point(14, 67);
            this.payLateFeesCbx.Margin = new System.Windows.Forms.Padding(2);
            this.payLateFeesCbx.Name = "payLateFeesCbx";
            this.payLateFeesCbx.Size = new System.Drawing.Size(93, 17);
            this.payLateFeesCbx.TabIndex = 2;
            this.payLateFeesCbx.TabStop = true;
            this.payLateFeesCbx.Text = "Pay Late Fees";
            this.payLateFeesCbx.UseVisualStyleBackColor = true;
            // 
            // waiveLateFeesCbx
            // 
            this.waiveLateFeesCbx.AutoSize = true;
            this.waiveLateFeesCbx.Location = new System.Drawing.Point(14, 46);
            this.waiveLateFeesCbx.Margin = new System.Windows.Forms.Padding(2);
            this.waiveLateFeesCbx.Name = "waiveLateFeesCbx";
            this.waiveLateFeesCbx.Size = new System.Drawing.Size(101, 17);
            this.waiveLateFeesCbx.TabIndex = 1;
            this.waiveLateFeesCbx.TabStop = true;
            this.waiveLateFeesCbx.Text = "Waive Late Fee";
            this.waiveLateFeesCbx.UseVisualStyleBackColor = true;
            // 
            // invoiceLateFeesLbl
            // 
            this.invoiceLateFeesLbl.AutoSize = true;
            this.invoiceLateFeesLbl.Location = new System.Drawing.Point(12, 24);
            this.invoiceLateFeesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invoiceLateFeesLbl.Name = "invoiceLateFeesLbl";
            this.invoiceLateFeesLbl.Size = new System.Drawing.Size(95, 13);
            this.invoiceLateFeesLbl.TabIndex = 0;
            this.invoiceLateFeesLbl.Text = "Invoice Late Fees:";
            // 
            // itemsQueuedTbx
            // 
            this.itemsQueuedTbx.Location = new System.Drawing.Point(105, 289);
            this.itemsQueuedTbx.MaxLength = 3;
            this.itemsQueuedTbx.Name = "itemsQueuedTbx";
            this.itemsQueuedTbx.ReadOnly = true;
            this.itemsQueuedTbx.Size = new System.Drawing.Size(150, 20);
            this.itemsQueuedTbx.TabIndex = 9;
            this.itemsQueuedTbx.Text = "0";
            // 
            // itemsQueuedLbl
            // 
            this.itemsQueuedLbl.AutoSize = true;
            this.itemsQueuedLbl.Location = new System.Drawing.Point(23, 292);
            this.itemsQueuedLbl.Name = "itemsQueuedLbl";
            this.itemsQueuedLbl.Size = new System.Drawing.Size(76, 13);
            this.itemsQueuedLbl.TabIndex = 95;
            this.itemsQueuedLbl.Text = "Items Queued:";
            // 
            // statusCbx
            // 
            this.statusCbx.DataSource = this.tblStatusBindingSource;
            this.statusCbx.DisplayMember = "Status_Name";
            this.statusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCbx.Enabled = false;
            this.statusCbx.FormattingEnabled = true;
            this.statusCbx.ItemHeight = 13;
            this.statusCbx.Location = new System.Drawing.Point(105, 210);
            this.statusCbx.Name = "statusCbx";
            this.statusCbx.Size = new System.Drawing.Size(150, 21);
            this.statusCbx.TabIndex = 6;
            this.statusCbx.ValueMember = "Status_ID";
            // 
            // tblStatusBindingSource
            // 
            this.tblStatusBindingSource.DataMember = "tblStatus";
            this.tblStatusBindingSource.DataSource = this.luEquipmentDataSet1;
            // 
            // dateOutLbl
            // 
            this.dateOutLbl.AutoSize = true;
            this.dateOutLbl.Location = new System.Drawing.Point(46, 240);
            this.dateOutLbl.Name = "dateOutLbl";
            this.dateOutLbl.Size = new System.Drawing.Size(53, 13);
            this.dateOutLbl.TabIndex = 107;
            this.dateOutLbl.Text = "Date Out:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(59, 213);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(40, 13);
            this.statusLbl.TabIndex = 106;
            this.statusLbl.Text = "Status:";
            // 
            // description3Lbl
            // 
            this.description3Lbl.AutoSize = true;
            this.description3Lbl.Location = new System.Drawing.Point(27, 187);
            this.description3Lbl.Name = "description3Lbl";
            this.description3Lbl.Size = new System.Drawing.Size(72, 13);
            this.description3Lbl.TabIndex = 105;
            this.description3Lbl.Text = "Description 3:";
            // 
            // description3Tbx
            // 
            this.description3Tbx.Location = new System.Drawing.Point(105, 184);
            this.description3Tbx.MaxLength = 30;
            this.description3Tbx.Name = "description3Tbx";
            this.description3Tbx.ReadOnly = true;
            this.description3Tbx.Size = new System.Drawing.Size(150, 20);
            this.description3Tbx.TabIndex = 5;
            // 
            // description2Lbl
            // 
            this.description2Lbl.AutoSize = true;
            this.description2Lbl.Location = new System.Drawing.Point(27, 161);
            this.description2Lbl.Name = "description2Lbl";
            this.description2Lbl.Size = new System.Drawing.Size(72, 13);
            this.description2Lbl.TabIndex = 104;
            this.description2Lbl.Text = "Description 2:";
            // 
            // description2Tbx
            // 
            this.description2Tbx.Location = new System.Drawing.Point(105, 158);
            this.description2Tbx.MaxLength = 30;
            this.description2Tbx.Name = "description2Tbx";
            this.description2Tbx.ReadOnly = true;
            this.description2Tbx.Size = new System.Drawing.Size(150, 20);
            this.description2Tbx.TabIndex = 4;
            // 
            // description1Lbl
            // 
            this.description1Lbl.AutoSize = true;
            this.description1Lbl.Location = new System.Drawing.Point(27, 136);
            this.description1Lbl.Name = "description1Lbl";
            this.description1Lbl.Size = new System.Drawing.Size(72, 13);
            this.description1Lbl.TabIndex = 103;
            this.description1Lbl.Text = "Description 1:";
            // 
            // description1Tbx
            // 
            this.description1Tbx.Location = new System.Drawing.Point(105, 132);
            this.description1Tbx.MaxLength = 30;
            this.description1Tbx.Name = "description1Tbx";
            this.description1Tbx.ReadOnly = true;
            this.description1Tbx.Size = new System.Drawing.Size(150, 20);
            this.description1Tbx.TabIndex = 3;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(34, 109);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(65, 13);
            this.itemNameLbl.TabIndex = 102;
            this.itemNameLbl.Text = "*Item Name:";
            // 
            // itemNameTbx
            // 
            this.itemNameTbx.Location = new System.Drawing.Point(105, 106);
            this.itemNameTbx.MaxLength = 30;
            this.itemNameTbx.Name = "itemNameTbx";
            this.itemNameTbx.ReadOnly = true;
            this.itemNameTbx.Size = new System.Drawing.Size(150, 20);
            this.itemNameTbx.TabIndex = 2;
            // 
            // dateDueLbl
            // 
            this.dateDueLbl.AutoSize = true;
            this.dateDueLbl.Location = new System.Drawing.Point(44, 266);
            this.dateDueLbl.Name = "dateDueLbl";
            this.dateDueLbl.Size = new System.Drawing.Size(56, 13);
            this.dateDueLbl.TabIndex = 109;
            this.dateDueLbl.Text = "Date Due:";
            // 
            // accountBalanceTbx
            // 
            this.accountBalanceTbx.Location = new System.Drawing.Point(420, 172);
            this.accountBalanceTbx.MaxLength = 3;
            this.accountBalanceTbx.Name = "accountBalanceTbx";
            this.accountBalanceTbx.ReadOnly = true;
            this.accountBalanceTbx.Size = new System.Drawing.Size(148, 20);
            this.accountBalanceTbx.TabIndex = 14;
            // 
            // accountBalanceLbl
            // 
            this.accountBalanceLbl.AutoSize = true;
            this.accountBalanceLbl.Location = new System.Drawing.Point(322, 175);
            this.accountBalanceLbl.Name = "accountBalanceLbl";
            this.accountBalanceLbl.Size = new System.Drawing.Size(92, 13);
            this.accountBalanceLbl.TabIndex = 111;
            this.accountBalanceLbl.Text = "Account Balance:";
            // 
            // tblStatusTableAdapter
            // 
            this.tblStatusTableAdapter.ClearBeforeFill = true;
            // 
            // dateOutTbx
            // 
            this.dateOutTbx.Location = new System.Drawing.Point(105, 237);
            this.dateOutTbx.MaxLength = 3;
            this.dateOutTbx.Name = "dateOutTbx";
            this.dateOutTbx.ReadOnly = true;
            this.dateOutTbx.Size = new System.Drawing.Size(150, 20);
            this.dateOutTbx.TabIndex = 7;
            // 
            // dateDueTbx
            // 
            this.dateDueTbx.Location = new System.Drawing.Point(106, 263);
            this.dateDueTbx.MaxLength = 3;
            this.dateDueTbx.Name = "dateDueTbx";
            this.dateDueTbx.ReadOnly = true;
            this.dateDueTbx.Size = new System.Drawing.Size(150, 20);
            this.dateDueTbx.TabIndex = 8;
            // 
            // queueBtn
            // 
            this.queueBtn.Enabled = false;
            this.queueBtn.Location = new System.Drawing.Point(70, 330);
            this.queueBtn.Name = "queueBtn";
            this.queueBtn.Size = new System.Drawing.Size(100, 34);
            this.queueBtn.TabIndex = 15;
            this.queueBtn.Text = "Queue Record";
            this.queueBtn.UseVisualStyleBackColor = true;
            this.queueBtn.Click += new System.EventHandler(this.queueBtn_Click);
            // 
            // processReturnsBtn
            // 
            this.processReturnsBtn.Enabled = false;
            this.processReturnsBtn.Location = new System.Drawing.Point(176, 330);
            this.processReturnsBtn.Name = "processReturnsBtn";
            this.processReturnsBtn.Size = new System.Drawing.Size(100, 34);
            this.processReturnsBtn.TabIndex = 16;
            this.processReturnsBtn.Text = "Process Returns";
            this.processReturnsBtn.UseVisualStyleBackColor = true;
            this.processReturnsBtn.Click += new System.EventHandler(this.processReturnsBtn_Click);
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.Enabled = false;
            this.clearItemBtn.Location = new System.Drawing.Point(282, 330);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(100, 34);
            this.clearItemBtn.TabIndex = 17;
            this.clearItemBtn.Text = "Clear Item";
            this.clearItemBtn.UseVisualStyleBackColor = true;
            this.clearItemBtn.Click += new System.EventHandler(this.clearItemBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(388, 330);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 34);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // tblStatusTableAdapter1
            // 
            this.tblStatusTableAdapter1.ClearBeforeFill = true;
            // 
            // ReturnEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearItemBtn);
            this.Controls.Add(this.processReturnsBtn);
            this.Controls.Add(this.queueBtn);
            this.Controls.Add(this.dateDueTbx);
            this.Controls.Add(this.dateOutTbx);
            this.Controls.Add(this.accountBalanceTbx);
            this.Controls.Add(this.accountBalanceLbl);
            this.Controls.Add(this.dateDueLbl);
            this.Controls.Add(this.statusCbx);
            this.Controls.Add(this.dateOutLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.description3Lbl);
            this.Controls.Add(this.description3Tbx);
            this.Controls.Add(this.description2Lbl);
            this.Controls.Add(this.description2Tbx);
            this.Controls.Add(this.description1Lbl);
            this.Controls.Add(this.description1Tbx);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.itemNameTbx);
            this.Controls.Add(this.itemsQueuedTbx);
            this.Controls.Add(this.itemsQueuedLbl);
            this.Controls.Add(this.lateFeesGbx);
            this.Controls.Add(this.stillOutTbx);
            this.Controls.Add(this.stillOutLbl);
            this.Controls.Add(this.studentNameTbx);
            this.Controls.Add(this.studentNameLbl);
            this.Controls.Add(this.studentNumberTbx);
            this.Controls.Add(this.studentNumberLbl);
            this.Controls.Add(this.invoiceNumberTbx);
            this.Controls.Add(this.invoiceNumberLbl);
            this.Controls.Add(this.itemNumberDashLbl);
            this.Controls.Add(this.itemNumberATbx);
            this.Controls.Add(this.itemNumberLbl);
            this.Controls.Add(this.itemNumberBTbx);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ReturnEquip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Equipment";
            this.Load += new System.EventHandler(this.ReturnEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            this.lateFeesGbx.ResumeLayout(false);
            this.lateFeesGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label itemNumberDashLbl;
        private System.Windows.Forms.TextBox itemNumberATbx;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.TextBox itemNumberBTbx;
        private System.Windows.Forms.TextBox stillOutTbx;
        private System.Windows.Forms.Label stillOutLbl;
        private System.Windows.Forms.TextBox studentNameTbx;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.TextBox studentNumberTbx;
        private System.Windows.Forms.Label studentNumberLbl;
        private System.Windows.Forms.TextBox invoiceNumberTbx;
        private System.Windows.Forms.Label invoiceNumberLbl;
        private System.Windows.Forms.GroupBox lateFeesGbx;
        private System.Windows.Forms.TextBox invoiceLateFeesTbx;
        private System.Windows.Forms.RadioButton accumulateLateFeesCbx;
        private System.Windows.Forms.RadioButton payLateFeesCbx;
        private System.Windows.Forms.RadioButton waiveLateFeesCbx;
        private System.Windows.Forms.Label invoiceLateFeesLbl;
        private System.Windows.Forms.TextBox itemsQueuedTbx;
        private System.Windows.Forms.Label itemsQueuedLbl;
        private System.Windows.Forms.ComboBox statusCbx;
        private System.Windows.Forms.Label dateOutLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label description3Lbl;
        private System.Windows.Forms.TextBox description3Tbx;
        private System.Windows.Forms.Label description2Lbl;
        private System.Windows.Forms.TextBox description2Tbx;
        private System.Windows.Forms.Label description1Lbl;
        private System.Windows.Forms.TextBox description1Tbx;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox itemNameTbx;
        private System.Windows.Forms.Label dateDueLbl;
        private System.Windows.Forms.TextBox accountBalanceTbx;
        private System.Windows.Forms.Label accountBalanceLbl;
        private System.Windows.Forms.BindingSource tblStatusBindingSource;
        private LUEquipmentDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter;
        private System.Windows.Forms.TextBox dateOutTbx;
        private System.Windows.Forms.TextBox dateDueTbx;
        private System.Windows.Forms.Button queueBtn;
        private System.Windows.Forms.Button processReturnsBtn;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.Button exitBtn;
        private LUEquipmentDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter1;
    }
}