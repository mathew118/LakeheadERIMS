namespace Lakehead_ERIMS
{
    partial class addUpdateStudent
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
            this.formTitle = new System.Windows.Forms.Label();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblEquipTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.studentLbx = new System.Windows.Forms.ListBox();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoGbx = new System.Windows.Forms.GroupBox();
            this.studentLNameLbl = new System.Windows.Forms.Label();
            this.studentNumberLbl = new System.Windows.Forms.Label();
            this.studentEmailLbl = new System.Windows.Forms.Label();
            this.studentFNameLbl = new System.Windows.Forms.Label();
            this.studentEmailTbx = new System.Windows.Forms.TextBox();
            this.studentLNameTbx = new System.Windows.Forms.TextBox();
            this.studentNumberTbx = new System.Windows.Forms.TextBox();
            this.studentFNameTbx = new System.Windows.Forms.TextBox();
            this.localGbx = new System.Windows.Forms.GroupBox();
            this.studentAddressLbl = new System.Windows.Forms.Label();
            this.studentProvinceClearBtn = new System.Windows.Forms.Button();
            this.studentPhoneLbl = new System.Windows.Forms.Label();
            this.studentProvinceLbl = new System.Windows.Forms.Label();
            this.studentExtLbl = new System.Windows.Forms.Label();
            this.studentCityLbl = new System.Windows.Forms.Label();
            this.studentPostalLbl = new System.Windows.Forms.Label();
            this.studentProvinceCbx = new System.Windows.Forms.ComboBox();
            this.studentPostalTbx = new System.Windows.Forms.TextBox();
            this.studentPhoneTbx = new System.Windows.Forms.TextBox();
            this.studentCityTbx = new System.Windows.Forms.TextBox();
            this.studentExtTbx = new System.Windows.Forms.TextBox();
            this.studentAddressTbx = new System.Windows.Forms.TextBox();
            this.feesGbx = new System.Windows.Forms.GroupBox();
            this.clearFeesBtn = new System.Windows.Forms.Button();
            this.studentNotesLbl = new System.Windows.Forms.Label();
            this.studentNotesTbx = new System.Windows.Forms.TextBox();
            this.studentORPTChbx = new System.Windows.Forms.CheckBox();
            this.studentFeesTbx = new System.Windows.Forms.TextBox();
            this.studentFeesLbl = new System.Windows.Forms.Label();
            this.permanentGbx = new System.Windows.Forms.GroupBox();
            this.studentPProvinceClearBtn = new System.Windows.Forms.Button();
            this.studentPProvinceCbx = new System.Windows.Forms.ComboBox();
            this.studentPAddressLbl = new System.Windows.Forms.Label();
            this.studentPPhoneLbl = new System.Windows.Forms.Label();
            this.studentPProvinceLbl = new System.Windows.Forms.Label();
            this.studentPCityLbl = new System.Windows.Forms.Label();
            this.studentPPostallLbl = new System.Windows.Forms.Label();
            this.studentPPostalTbx = new System.Windows.Forms.TextBox();
            this.studentPPhoneTbx = new System.Windows.Forms.TextBox();
            this.studentPCityTbx = new System.Windows.Forms.TextBox();
            this.studentPAddressTbx = new System.Windows.Forms.TextBox();
            this.studentAddNewBtn = new System.Windows.Forms.Button();
            this.studentUpdateBtn = new System.Windows.Forms.Button();
            this.studentExitBtn = new System.Windows.Forms.Button();
            this.studentSearchingBtn = new System.Windows.Forms.Button();
            this.studentSearchingTbx = new System.Windows.Forms.TextBox();
            this.searchByNumberRbn = new System.Windows.Forms.RadioButton();
            this.searchByLNameRbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.infoGbx.SuspendLayout();
            this.localGbx.SuspendLayout();
            this.feesGbx.SuspendLayout();
            this.permanentGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(181, 9);
            this.formTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(223, 25);
            this.formTitle.TabIndex = 32;
            this.formTitle.Text = "Add/Update Student";
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
            // studentLbx
            // 
            this.studentLbx.DataSource = this.tblStudentBindingSource;
            this.studentLbx.DisplayMember = "Stu_LName";
            this.studentLbx.FormattingEnabled = true;
            this.studentLbx.Location = new System.Drawing.Point(15, 49);
            this.studentLbx.Name = "studentLbx";
            this.studentLbx.ScrollAlwaysVisible = true;
            this.studentLbx.Size = new System.Drawing.Size(554, 95);
            this.studentLbx.TabIndex = 47;
            this.studentLbx.ValueMember = "Stu_ID";
            this.studentLbx.SelectedIndexChanged += new System.EventHandler(this.studentLbx_SelectedIndexChanged);
            this.studentLbx.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.studentLbx_Format);
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.luEquipmentDataSet1;
            // 
            // infoGbx
            // 
            this.infoGbx.Controls.Add(this.studentLNameLbl);
            this.infoGbx.Controls.Add(this.studentNumberLbl);
            this.infoGbx.Controls.Add(this.studentEmailLbl);
            this.infoGbx.Controls.Add(this.studentFNameLbl);
            this.infoGbx.Controls.Add(this.studentEmailTbx);
            this.infoGbx.Controls.Add(this.studentLNameTbx);
            this.infoGbx.Controls.Add(this.studentNumberTbx);
            this.infoGbx.Controls.Add(this.studentFNameTbx);
            this.infoGbx.Location = new System.Drawing.Point(15, 202);
            this.infoGbx.Margin = new System.Windows.Forms.Padding(2);
            this.infoGbx.Name = "infoGbx";
            this.infoGbx.Padding = new System.Windows.Forms.Padding(2);
            this.infoGbx.Size = new System.Drawing.Size(275, 150);
            this.infoGbx.TabIndex = 106;
            this.infoGbx.TabStop = false;
            this.infoGbx.Text = "Student Information";
            // 
            // studentLNameLbl
            // 
            this.studentLNameLbl.AutoSize = true;
            this.studentLNameLbl.Location = new System.Drawing.Point(33, 44);
            this.studentLNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentLNameLbl.Name = "studentLNameLbl";
            this.studentLNameLbl.Size = new System.Drawing.Size(65, 13);
            this.studentLNameLbl.TabIndex = 91;
            this.studentLNameLbl.Text = "*Last Name:";
            // 
            // studentNumberLbl
            // 
            this.studentNumberLbl.AutoSize = true;
            this.studentNumberLbl.Location = new System.Drawing.Point(7, 20);
            this.studentNumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumberLbl.Name = "studentNumberLbl";
            this.studentNumberLbl.Size = new System.Drawing.Size(91, 13);
            this.studentNumberLbl.TabIndex = 90;
            this.studentNumberLbl.Text = "*Student Number:";
            // 
            // studentEmailLbl
            // 
            this.studentEmailLbl.AutoSize = true;
            this.studentEmailLbl.Location = new System.Drawing.Point(22, 92);
            this.studentEmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentEmailLbl.Name = "studentEmailLbl";
            this.studentEmailLbl.Size = new System.Drawing.Size(76, 13);
            this.studentEmailLbl.TabIndex = 93;
            this.studentEmailLbl.Text = "Email Address:";
            // 
            // studentFNameLbl
            // 
            this.studentFNameLbl.AutoSize = true;
            this.studentFNameLbl.Location = new System.Drawing.Point(34, 68);
            this.studentFNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentFNameLbl.Name = "studentFNameLbl";
            this.studentFNameLbl.Size = new System.Drawing.Size(64, 13);
            this.studentFNameLbl.TabIndex = 92;
            this.studentFNameLbl.Text = "*First Name:";
            // 
            // studentEmailTbx
            // 
            this.studentEmailTbx.Location = new System.Drawing.Point(102, 89);
            this.studentEmailTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentEmailTbx.MaxLength = 50;
            this.studentEmailTbx.Name = "studentEmailTbx";
            this.studentEmailTbx.Size = new System.Drawing.Size(164, 20);
            this.studentEmailTbx.TabIndex = 4;
            this.studentEmailTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentLNameTbx
            // 
            this.studentLNameTbx.Location = new System.Drawing.Point(102, 41);
            this.studentLNameTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentLNameTbx.MaxLength = 30;
            this.studentLNameTbx.Name = "studentLNameTbx";
            this.studentLNameTbx.Size = new System.Drawing.Size(164, 20);
            this.studentLNameTbx.TabIndex = 2;
            this.studentLNameTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentNumberTbx
            // 
            this.studentNumberTbx.Location = new System.Drawing.Point(102, 17);
            this.studentNumberTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentNumberTbx.MaxLength = 20;
            this.studentNumberTbx.Name = "studentNumberTbx";
            this.studentNumberTbx.Size = new System.Drawing.Size(164, 20);
            this.studentNumberTbx.TabIndex = 1;
            this.studentNumberTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            this.studentNumberTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericOnly);
            // 
            // studentFNameTbx
            // 
            this.studentFNameTbx.Location = new System.Drawing.Point(102, 65);
            this.studentFNameTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentFNameTbx.MaxLength = 30;
            this.studentFNameTbx.Name = "studentFNameTbx";
            this.studentFNameTbx.Size = new System.Drawing.Size(164, 20);
            this.studentFNameTbx.TabIndex = 3;
            this.studentFNameTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // localGbx
            // 
            this.localGbx.Controls.Add(this.studentAddressLbl);
            this.localGbx.Controls.Add(this.studentProvinceClearBtn);
            this.localGbx.Controls.Add(this.studentPhoneLbl);
            this.localGbx.Controls.Add(this.studentProvinceLbl);
            this.localGbx.Controls.Add(this.studentExtLbl);
            this.localGbx.Controls.Add(this.studentCityLbl);
            this.localGbx.Controls.Add(this.studentPostalLbl);
            this.localGbx.Controls.Add(this.studentProvinceCbx);
            this.localGbx.Controls.Add(this.studentPostalTbx);
            this.localGbx.Controls.Add(this.studentPhoneTbx);
            this.localGbx.Controls.Add(this.studentCityTbx);
            this.localGbx.Controls.Add(this.studentExtTbx);
            this.localGbx.Controls.Add(this.studentAddressTbx);
            this.localGbx.Location = new System.Drawing.Point(15, 356);
            this.localGbx.Margin = new System.Windows.Forms.Padding(2);
            this.localGbx.Name = "localGbx";
            this.localGbx.Padding = new System.Windows.Forms.Padding(2);
            this.localGbx.Size = new System.Drawing.Size(275, 150);
            this.localGbx.TabIndex = 107;
            this.localGbx.TabStop = false;
            this.localGbx.Text = "Local Address";
            // 
            // studentAddressLbl
            // 
            this.studentAddressLbl.AutoSize = true;
            this.studentAddressLbl.Location = new System.Drawing.Point(25, 20);
            this.studentAddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentAddressLbl.Name = "studentAddressLbl";
            this.studentAddressLbl.Size = new System.Drawing.Size(48, 13);
            this.studentAddressLbl.TabIndex = 94;
            this.studentAddressLbl.Text = "Address:";
            // 
            // studentProvinceClearBtn
            // 
            this.studentProvinceClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentProvinceClearBtn.Location = new System.Drawing.Point(246, 65);
            this.studentProvinceClearBtn.Name = "studentProvinceClearBtn";
            this.studentProvinceClearBtn.Size = new System.Drawing.Size(25, 20);
            this.studentProvinceClearBtn.TabIndex = 26;
            this.studentProvinceClearBtn.Text = "C";
            this.studentProvinceClearBtn.UseVisualStyleBackColor = true;
            this.studentProvinceClearBtn.Click += new System.EventHandler(this.studentProvinceClearBtn_Click);
            // 
            // studentPhoneLbl
            // 
            this.studentPhoneLbl.AutoSize = true;
            this.studentPhoneLbl.Location = new System.Drawing.Point(32, 117);
            this.studentPhoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPhoneLbl.Name = "studentPhoneLbl";
            this.studentPhoneLbl.Size = new System.Drawing.Size(41, 13);
            this.studentPhoneLbl.TabIndex = 98;
            this.studentPhoneLbl.Text = "Phone:";
            // 
            // studentProvinceLbl
            // 
            this.studentProvinceLbl.AutoSize = true;
            this.studentProvinceLbl.Location = new System.Drawing.Point(21, 69);
            this.studentProvinceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentProvinceLbl.Name = "studentProvinceLbl";
            this.studentProvinceLbl.Size = new System.Drawing.Size(52, 13);
            this.studentProvinceLbl.TabIndex = 96;
            this.studentProvinceLbl.Text = "Province:";
            // 
            // studentExtLbl
            // 
            this.studentExtLbl.AutoSize = true;
            this.studentExtLbl.Location = new System.Drawing.Point(168, 117);
            this.studentExtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentExtLbl.Name = "studentExtLbl";
            this.studentExtLbl.Size = new System.Drawing.Size(25, 13);
            this.studentExtLbl.TabIndex = 99;
            this.studentExtLbl.Text = "Ext:";
            // 
            // studentCityLbl
            // 
            this.studentCityLbl.AutoSize = true;
            this.studentCityLbl.Location = new System.Drawing.Point(46, 45);
            this.studentCityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentCityLbl.Name = "studentCityLbl";
            this.studentCityLbl.Size = new System.Drawing.Size(27, 13);
            this.studentCityLbl.TabIndex = 95;
            this.studentCityLbl.Text = "City:";
            // 
            // studentPostalLbl
            // 
            this.studentPostalLbl.AutoSize = true;
            this.studentPostalLbl.Location = new System.Drawing.Point(6, 93);
            this.studentPostalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPostalLbl.Name = "studentPostalLbl";
            this.studentPostalLbl.Size = new System.Drawing.Size(67, 13);
            this.studentPostalLbl.TabIndex = 97;
            this.studentPostalLbl.Text = "Postal Code:";
            // 
            // studentProvinceCbx
            // 
            this.studentProvinceCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentProvinceCbx.FormattingEnabled = true;
            this.studentProvinceCbx.Items.AddRange(new object[] {
            "ON",
            "MB",
            "SK",
            "AB",
            "BC",
            "YT",
            "NT",
            "QU",
            "NL",
            "PE",
            "NS",
            "NB",
            "NU"});
            this.studentProvinceCbx.Location = new System.Drawing.Point(77, 65);
            this.studentProvinceCbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentProvinceCbx.MaxLength = 2;
            this.studentProvinceCbx.Name = "studentProvinceCbx";
            this.studentProvinceCbx.Size = new System.Drawing.Size(164, 21);
            this.studentProvinceCbx.TabIndex = 7;
            this.studentProvinceCbx.SelectedIndexChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPostalTbx
            // 
            this.studentPostalTbx.Location = new System.Drawing.Point(77, 90);
            this.studentPostalTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPostalTbx.MaxLength = 6;
            this.studentPostalTbx.Name = "studentPostalTbx";
            this.studentPostalTbx.Size = new System.Drawing.Size(164, 20);
            this.studentPostalTbx.TabIndex = 8;
            this.studentPostalTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPhoneTbx
            // 
            this.studentPhoneTbx.Location = new System.Drawing.Point(77, 114);
            this.studentPhoneTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPhoneTbx.MaxLength = 10;
            this.studentPhoneTbx.Name = "studentPhoneTbx";
            this.studentPhoneTbx.Size = new System.Drawing.Size(87, 20);
            this.studentPhoneTbx.TabIndex = 9;
            this.studentPhoneTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentCityTbx
            // 
            this.studentCityTbx.Location = new System.Drawing.Point(77, 41);
            this.studentCityTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentCityTbx.MaxLength = 30;
            this.studentCityTbx.Name = "studentCityTbx";
            this.studentCityTbx.Size = new System.Drawing.Size(164, 20);
            this.studentCityTbx.TabIndex = 6;
            this.studentCityTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentExtTbx
            // 
            this.studentExtTbx.Location = new System.Drawing.Point(194, 114);
            this.studentExtTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentExtTbx.MaxLength = 4;
            this.studentExtTbx.Name = "studentExtTbx";
            this.studentExtTbx.Size = new System.Drawing.Size(47, 20);
            this.studentExtTbx.TabIndex = 10;
            this.studentExtTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentAddressTbx
            // 
            this.studentAddressTbx.Location = new System.Drawing.Point(77, 17);
            this.studentAddressTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentAddressTbx.MaxLength = 30;
            this.studentAddressTbx.Name = "studentAddressTbx";
            this.studentAddressTbx.Size = new System.Drawing.Size(164, 20);
            this.studentAddressTbx.TabIndex = 5;
            this.studentAddressTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // feesGbx
            // 
            this.feesGbx.Controls.Add(this.clearFeesBtn);
            this.feesGbx.Controls.Add(this.studentNotesLbl);
            this.feesGbx.Controls.Add(this.studentNotesTbx);
            this.feesGbx.Controls.Add(this.studentORPTChbx);
            this.feesGbx.Controls.Add(this.studentFeesTbx);
            this.feesGbx.Controls.Add(this.studentFeesLbl);
            this.feesGbx.Location = new System.Drawing.Point(294, 202);
            this.feesGbx.Margin = new System.Windows.Forms.Padding(2);
            this.feesGbx.Name = "feesGbx";
            this.feesGbx.Padding = new System.Windows.Forms.Padding(2);
            this.feesGbx.Size = new System.Drawing.Size(275, 150);
            this.feesGbx.TabIndex = 108;
            this.feesGbx.TabStop = false;
            this.feesGbx.Text = "Additional Information";
            // 
            // clearFeesBtn
            // 
            this.clearFeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFeesBtn.Location = new System.Drawing.Point(188, 16);
            this.clearFeesBtn.Name = "clearFeesBtn";
            this.clearFeesBtn.Size = new System.Drawing.Size(55, 21);
            this.clearFeesBtn.TabIndex = 106;
            this.clearFeesBtn.Text = "Clear";
            this.clearFeesBtn.UseVisualStyleBackColor = true;
            this.clearFeesBtn.Click += new System.EventHandler(this.clearFeesBtn_Click);
            // 
            // studentNotesLbl
            // 
            this.studentNotesLbl.AutoSize = true;
            this.studentNotesLbl.Location = new System.Drawing.Point(27, 72);
            this.studentNotesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNotesLbl.Name = "studentNotesLbl";
            this.studentNotesLbl.Size = new System.Drawing.Size(38, 13);
            this.studentNotesLbl.TabIndex = 100;
            this.studentNotesLbl.Text = "Notes:";
            // 
            // studentNotesTbx
            // 
            this.studentNotesTbx.Location = new System.Drawing.Point(30, 88);
            this.studentNotesTbx.MaxLength = 255;
            this.studentNotesTbx.Multiline = true;
            this.studentNotesTbx.Name = "studentNotesTbx";
            this.studentNotesTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentNotesTbx.Size = new System.Drawing.Size(217, 46);
            this.studentNotesTbx.TabIndex = 13;
            this.studentNotesTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentORPTChbx
            // 
            this.studentORPTChbx.AutoSize = true;
            this.studentORPTChbx.Location = new System.Drawing.Point(30, 41);
            this.studentORPTChbx.Name = "studentORPTChbx";
            this.studentORPTChbx.Size = new System.Drawing.Size(56, 17);
            this.studentORPTChbx.TabIndex = 12;
            this.studentORPTChbx.Text = "ORPT";
            this.studentORPTChbx.UseVisualStyleBackColor = true;
            this.studentORPTChbx.CheckedChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentFeesTbx
            // 
            this.studentFeesTbx.Location = new System.Drawing.Point(97, 17);
            this.studentFeesTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentFeesTbx.Name = "studentFeesTbx";
            this.studentFeesTbx.Size = new System.Drawing.Size(86, 20);
            this.studentFeesTbx.TabIndex = 11;
            this.studentFeesTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentFeesLbl
            // 
            this.studentFeesLbl.AutoSize = true;
            this.studentFeesLbl.Location = new System.Drawing.Point(27, 20);
            this.studentFeesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentFeesLbl.Name = "studentFeesLbl";
            this.studentFeesLbl.Size = new System.Drawing.Size(66, 13);
            this.studentFeesLbl.TabIndex = 99;
            this.studentFeesLbl.Text = "Fees Owing:";
            // 
            // permanentGbx
            // 
            this.permanentGbx.Controls.Add(this.studentPProvinceClearBtn);
            this.permanentGbx.Controls.Add(this.studentPProvinceCbx);
            this.permanentGbx.Controls.Add(this.studentPAddressLbl);
            this.permanentGbx.Controls.Add(this.studentPPhoneLbl);
            this.permanentGbx.Controls.Add(this.studentPProvinceLbl);
            this.permanentGbx.Controls.Add(this.studentPCityLbl);
            this.permanentGbx.Controls.Add(this.studentPPostallLbl);
            this.permanentGbx.Controls.Add(this.studentPPostalTbx);
            this.permanentGbx.Controls.Add(this.studentPPhoneTbx);
            this.permanentGbx.Controls.Add(this.studentPCityTbx);
            this.permanentGbx.Controls.Add(this.studentPAddressTbx);
            this.permanentGbx.Location = new System.Drawing.Point(294, 356);
            this.permanentGbx.Margin = new System.Windows.Forms.Padding(2);
            this.permanentGbx.Name = "permanentGbx";
            this.permanentGbx.Padding = new System.Windows.Forms.Padding(2);
            this.permanentGbx.Size = new System.Drawing.Size(275, 150);
            this.permanentGbx.TabIndex = 109;
            this.permanentGbx.TabStop = false;
            this.permanentGbx.Text = "Permanent Address";
            // 
            // studentPProvinceClearBtn
            // 
            this.studentPProvinceClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPProvinceClearBtn.Location = new System.Drawing.Point(246, 66);
            this.studentPProvinceClearBtn.Name = "studentPProvinceClearBtn";
            this.studentPProvinceClearBtn.Size = new System.Drawing.Size(25, 20);
            this.studentPProvinceClearBtn.TabIndex = 27;
            this.studentPProvinceClearBtn.Text = "C";
            this.studentPProvinceClearBtn.UseVisualStyleBackColor = true;
            this.studentPProvinceClearBtn.Click += new System.EventHandler(this.studentPProvinceClearBtn_Click);
            // 
            // studentPProvinceCbx
            // 
            this.studentPProvinceCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentPProvinceCbx.FormattingEnabled = true;
            this.studentPProvinceCbx.Items.AddRange(new object[] {
            "ON",
            "MB",
            "SK",
            "AB",
            "BC",
            "YT",
            "NT",
            "QU",
            "NL",
            "PE",
            "NS",
            "NB",
            "NU"});
            this.studentPProvinceCbx.Location = new System.Drawing.Point(77, 65);
            this.studentPProvinceCbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPProvinceCbx.MaxLength = 2;
            this.studentPProvinceCbx.Name = "studentPProvinceCbx";
            this.studentPProvinceCbx.Size = new System.Drawing.Size(164, 21);
            this.studentPProvinceCbx.TabIndex = 16;
            this.studentPProvinceCbx.SelectedIndexChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPAddressLbl
            // 
            this.studentPAddressLbl.AutoSize = true;
            this.studentPAddressLbl.Location = new System.Drawing.Point(25, 20);
            this.studentPAddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPAddressLbl.Name = "studentPAddressLbl";
            this.studentPAddressLbl.Size = new System.Drawing.Size(48, 13);
            this.studentPAddressLbl.TabIndex = 101;
            this.studentPAddressLbl.Text = "Address:";
            // 
            // studentPPhoneLbl
            // 
            this.studentPPhoneLbl.AutoSize = true;
            this.studentPPhoneLbl.Location = new System.Drawing.Point(32, 117);
            this.studentPPhoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPPhoneLbl.Name = "studentPPhoneLbl";
            this.studentPPhoneLbl.Size = new System.Drawing.Size(41, 13);
            this.studentPPhoneLbl.TabIndex = 105;
            this.studentPPhoneLbl.Text = "Phone:";
            // 
            // studentPProvinceLbl
            // 
            this.studentPProvinceLbl.AutoSize = true;
            this.studentPProvinceLbl.Location = new System.Drawing.Point(21, 69);
            this.studentPProvinceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPProvinceLbl.Name = "studentPProvinceLbl";
            this.studentPProvinceLbl.Size = new System.Drawing.Size(52, 13);
            this.studentPProvinceLbl.TabIndex = 103;
            this.studentPProvinceLbl.Text = "Province:";
            // 
            // studentPCityLbl
            // 
            this.studentPCityLbl.AutoSize = true;
            this.studentPCityLbl.Location = new System.Drawing.Point(46, 45);
            this.studentPCityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPCityLbl.Name = "studentPCityLbl";
            this.studentPCityLbl.Size = new System.Drawing.Size(27, 13);
            this.studentPCityLbl.TabIndex = 102;
            this.studentPCityLbl.Text = "City:";
            // 
            // studentPPostallLbl
            // 
            this.studentPPostallLbl.AutoSize = true;
            this.studentPPostallLbl.Location = new System.Drawing.Point(6, 93);
            this.studentPPostallLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentPPostallLbl.Name = "studentPPostallLbl";
            this.studentPPostallLbl.Size = new System.Drawing.Size(67, 13);
            this.studentPPostallLbl.TabIndex = 104;
            this.studentPPostallLbl.Text = "Postal Code:";
            // 
            // studentPPostalTbx
            // 
            this.studentPPostalTbx.Location = new System.Drawing.Point(77, 90);
            this.studentPPostalTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPPostalTbx.MaxLength = 6;
            this.studentPPostalTbx.Name = "studentPPostalTbx";
            this.studentPPostalTbx.Size = new System.Drawing.Size(164, 20);
            this.studentPPostalTbx.TabIndex = 17;
            this.studentPPostalTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPPhoneTbx
            // 
            this.studentPPhoneTbx.Location = new System.Drawing.Point(77, 114);
            this.studentPPhoneTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPPhoneTbx.MaxLength = 10;
            this.studentPPhoneTbx.Name = "studentPPhoneTbx";
            this.studentPPhoneTbx.Size = new System.Drawing.Size(164, 20);
            this.studentPPhoneTbx.TabIndex = 18;
            this.studentPPhoneTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPCityTbx
            // 
            this.studentPCityTbx.Location = new System.Drawing.Point(77, 41);
            this.studentPCityTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPCityTbx.MaxLength = 30;
            this.studentPCityTbx.Name = "studentPCityTbx";
            this.studentPCityTbx.Size = new System.Drawing.Size(164, 20);
            this.studentPCityTbx.TabIndex = 15;
            this.studentPCityTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentPAddressTbx
            // 
            this.studentPAddressTbx.Location = new System.Drawing.Point(77, 17);
            this.studentPAddressTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentPAddressTbx.MaxLength = 30;
            this.studentPAddressTbx.Name = "studentPAddressTbx";
            this.studentPAddressTbx.Size = new System.Drawing.Size(164, 20);
            this.studentPAddressTbx.TabIndex = 14;
            this.studentPAddressTbx.TextChanged += new System.EventHandler(this.studentFieldChanged);
            // 
            // studentAddNewBtn
            // 
            this.studentAddNewBtn.Location = new System.Drawing.Point(157, 525);
            this.studentAddNewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.studentAddNewBtn.Name = "studentAddNewBtn";
            this.studentAddNewBtn.Size = new System.Drawing.Size(87, 26);
            this.studentAddNewBtn.TabIndex = 19;
            this.studentAddNewBtn.Text = "Add New";
            this.studentAddNewBtn.UseVisualStyleBackColor = true;
            this.studentAddNewBtn.Click += new System.EventHandler(this.studentAddNewBtn_Click);
            // 
            // studentUpdateBtn
            // 
            this.studentUpdateBtn.Enabled = false;
            this.studentUpdateBtn.Location = new System.Drawing.Point(247, 525);
            this.studentUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.studentUpdateBtn.Name = "studentUpdateBtn";
            this.studentUpdateBtn.Size = new System.Drawing.Size(87, 26);
            this.studentUpdateBtn.TabIndex = 20;
            this.studentUpdateBtn.Text = "Save Changes";
            this.studentUpdateBtn.UseVisualStyleBackColor = true;
            this.studentUpdateBtn.Click += new System.EventHandler(this.studentUpdateBtn_Click);
            // 
            // studentExitBtn
            // 
            this.studentExitBtn.Location = new System.Drawing.Point(339, 525);
            this.studentExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.studentExitBtn.Name = "studentExitBtn";
            this.studentExitBtn.Size = new System.Drawing.Size(87, 26);
            this.studentExitBtn.TabIndex = 21;
            this.studentExitBtn.Text = "Exit";
            this.studentExitBtn.UseVisualStyleBackColor = true;
            this.studentExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // studentSearchingBtn
            // 
            this.studentSearchingBtn.Location = new System.Drawing.Point(515, 150);
            this.studentSearchingBtn.Name = "studentSearchingBtn";
            this.studentSearchingBtn.Size = new System.Drawing.Size(55, 21);
            this.studentSearchingBtn.TabIndex = 25;
            this.studentSearchingBtn.Text = "Search";
            this.studentSearchingBtn.UseVisualStyleBackColor = true;
            this.studentSearchingBtn.Click += new System.EventHandler(this.studentSearchingBtn_Click);
            // 
            // studentSearchingTbx
            // 
            this.studentSearchingTbx.Location = new System.Drawing.Point(346, 151);
            this.studentSearchingTbx.Margin = new System.Windows.Forms.Padding(2);
            this.studentSearchingTbx.MaxLength = 20;
            this.studentSearchingTbx.Name = "studentSearchingTbx";
            this.studentSearchingTbx.Size = new System.Drawing.Size(164, 20);
            this.studentSearchingTbx.TabIndex = 22;
            this.studentSearchingTbx.Enter += new System.EventHandler(this.studentEnterKeySearching);
            this.studentSearchingTbx.Leave += new System.EventHandler(this.studentEnterKeySearching);
            // 
            // searchByNumberRbn
            // 
            this.searchByNumberRbn.AutoSize = true;
            this.searchByNumberRbn.Location = new System.Drawing.Point(443, 176);
            this.searchByNumberRbn.Name = "searchByNumberRbn";
            this.searchByNumberRbn.Size = new System.Drawing.Size(117, 17);
            this.searchByNumberRbn.TabIndex = 23;
            this.searchByNumberRbn.Text = "By Student Number";
            this.searchByNumberRbn.UseVisualStyleBackColor = true;
            // 
            // searchByLNameRbn
            // 
            this.searchByLNameRbn.AutoSize = true;
            this.searchByLNameRbn.Checked = true;
            this.searchByLNameRbn.Location = new System.Drawing.Point(346, 176);
            this.searchByLNameRbn.Name = "searchByLNameRbn";
            this.searchByLNameRbn.Size = new System.Drawing.Size(91, 17);
            this.searchByLNameRbn.TabIndex = 24;
            this.searchByLNameRbn.TabStop = true;
            this.searchByLNameRbn.Text = "By Last Name";
            this.searchByLNameRbn.UseVisualStyleBackColor = true;
            // 
            // addUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 580);
            this.Controls.Add(this.searchByLNameRbn);
            this.Controls.Add(this.searchByNumberRbn);
            this.Controls.Add(this.studentSearchingTbx);
            this.Controls.Add(this.studentSearchingBtn);
            this.Controls.Add(this.studentAddNewBtn);
            this.Controls.Add(this.permanentGbx);
            this.Controls.Add(this.studentUpdateBtn);
            this.Controls.Add(this.feesGbx);
            this.Controls.Add(this.localGbx);
            this.Controls.Add(this.studentExitBtn);
            this.Controls.Add(this.infoGbx);
            this.Controls.Add(this.studentLbx);
            this.Controls.Add(this.formTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "addUpdateStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Update Students";
            this.Shown += new System.EventHandler(this.addUpdateStudent_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.infoGbx.ResumeLayout(false);
            this.infoGbx.PerformLayout();
            this.localGbx.ResumeLayout(false);
            this.localGbx.PerformLayout();
            this.feesGbx.ResumeLayout(false);
            this.feesGbx.PerformLayout();
            this.permanentGbx.ResumeLayout(false);
            this.permanentGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label formTitle;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter1;
        private System.Windows.Forms.ListBox studentLbx;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private System.Windows.Forms.GroupBox infoGbx;
        private System.Windows.Forms.Label studentLNameLbl;
        private System.Windows.Forms.Label studentNumberLbl;
        private System.Windows.Forms.Label studentEmailLbl;
        private System.Windows.Forms.Label studentFNameLbl;
        private System.Windows.Forms.TextBox studentEmailTbx;
        private System.Windows.Forms.TextBox studentLNameTbx;
        private System.Windows.Forms.TextBox studentNumberTbx;
        private System.Windows.Forms.TextBox studentFNameTbx;
        private System.Windows.Forms.GroupBox localGbx;
        private System.Windows.Forms.Label studentAddressLbl;
        private System.Windows.Forms.Label studentPhoneLbl;
        private System.Windows.Forms.Label studentProvinceLbl;
        private System.Windows.Forms.Label studentExtLbl;
        private System.Windows.Forms.Label studentCityLbl;
        private System.Windows.Forms.Label studentPostalLbl;
        private System.Windows.Forms.ComboBox studentProvinceCbx;
        private System.Windows.Forms.TextBox studentPostalTbx;
        private System.Windows.Forms.TextBox studentPhoneTbx;
        private System.Windows.Forms.TextBox studentCityTbx;
        private System.Windows.Forms.TextBox studentExtTbx;
        private System.Windows.Forms.TextBox studentAddressTbx;
        private System.Windows.Forms.GroupBox feesGbx;
        private System.Windows.Forms.CheckBox studentORPTChbx;
        private System.Windows.Forms.TextBox studentFeesTbx;
        private System.Windows.Forms.Label studentFeesLbl;
        private System.Windows.Forms.GroupBox permanentGbx;
        private System.Windows.Forms.Label studentPAddressLbl;
        private System.Windows.Forms.Label studentPPhoneLbl;
        private System.Windows.Forms.Label studentPProvinceLbl;
        private System.Windows.Forms.Label studentPCityLbl;
        private System.Windows.Forms.Label studentPPostallLbl;
        private System.Windows.Forms.TextBox studentPPostalTbx;
        private System.Windows.Forms.TextBox studentPPhoneTbx;
        private System.Windows.Forms.TextBox studentPCityTbx;
        private System.Windows.Forms.TextBox studentPAddressTbx;
        private System.Windows.Forms.Button studentAddNewBtn;
        private System.Windows.Forms.Button studentUpdateBtn;
        private System.Windows.Forms.Button studentExitBtn;
        private System.Windows.Forms.ComboBox studentPProvinceCbx;
        private System.Windows.Forms.Label studentNotesLbl;
        private System.Windows.Forms.TextBox studentNotesTbx;
        private System.Windows.Forms.Button studentSearchingBtn;
        private System.Windows.Forms.TextBox studentSearchingTbx;
        private System.Windows.Forms.RadioButton searchByNumberRbn;
        private System.Windows.Forms.RadioButton searchByLNameRbn;
        private System.Windows.Forms.Button studentProvinceClearBtn;
        private System.Windows.Forms.Button studentPProvinceClearBtn;
        private System.Windows.Forms.Button clearFeesBtn;
    }
}