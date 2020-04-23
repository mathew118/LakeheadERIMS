namespace Lakehead_ERIMS
{
    partial class AdminMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.equipmentTab = new System.Windows.Forms.TabPage();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.locationsTab = new System.Windows.Forms.TabPage();
            this.staffTab = new System.Windows.Forms.TabPage();
            this.staffUsernameTbx = new System.Windows.Forms.TextBox();
            this.staffUsernameLbl = new System.Windows.Forms.Label();
            this.staffTypeLbl = new System.Windows.Forms.Label();
            this.staffTypeCbx = new System.Windows.Forms.ComboBox();
            this.staffFirstNameLbl = new System.Windows.Forms.Label();
            this.staffFirstNameTbx = new System.Windows.Forms.TextBox();
            this.staffLastNameLbl = new System.Windows.Forms.Label();
            this.staffLastNameTbx = new System.Windows.Forms.TextBox();
            this.staffLbx = new System.Windows.Forms.ListBox();
            this.statusTab = new System.Windows.Forms.TabPage();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.lUEquipmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEmployeeTableAdapter();
            this.adminTabControl.SuspendLayout();
            this.staffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(280, 306);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 40);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.equipmentTab);
            this.adminTabControl.Controls.Add(this.categoriesTab);
            this.adminTabControl.Controls.Add(this.locationsTab);
            this.adminTabControl.Controls.Add(this.staffTab);
            this.adminTabControl.Controls.Add(this.statusTab);
            this.adminTabControl.Controls.Add(this.suppliersTab);
            this.adminTabControl.Location = new System.Drawing.Point(12, 12);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(390, 272);
            this.adminTabControl.TabIndex = 3;
            this.adminTabControl.TabIndexChanged += new System.EventHandler(this.adminTabControl_TabIndexChanged);
            // 
            // equipmentTab
            // 
            this.equipmentTab.Location = new System.Drawing.Point(4, 22);
            this.equipmentTab.Name = "equipmentTab";
            this.equipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentTab.Size = new System.Drawing.Size(382, 246);
            this.equipmentTab.TabIndex = 0;
            this.equipmentTab.Text = "Equipment";
            this.equipmentTab.UseVisualStyleBackColor = true;
            // 
            // categoriesTab
            // 
            this.categoriesTab.Location = new System.Drawing.Point(4, 22);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesTab.Size = new System.Drawing.Size(382, 246);
            this.categoriesTab.TabIndex = 1;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.UseVisualStyleBackColor = true;
            // 
            // locationsTab
            // 
            this.locationsTab.Location = new System.Drawing.Point(4, 22);
            this.locationsTab.Name = "locationsTab";
            this.locationsTab.Size = new System.Drawing.Size(382, 246);
            this.locationsTab.TabIndex = 2;
            this.locationsTab.Text = "Locations";
            this.locationsTab.UseVisualStyleBackColor = true;
            // 
            // staffTab
            // 
            this.staffTab.Controls.Add(this.staffUsernameTbx);
            this.staffTab.Controls.Add(this.staffUsernameLbl);
            this.staffTab.Controls.Add(this.staffTypeLbl);
            this.staffTab.Controls.Add(this.staffTypeCbx);
            this.staffTab.Controls.Add(this.staffFirstNameLbl);
            this.staffTab.Controls.Add(this.staffFirstNameTbx);
            this.staffTab.Controls.Add(this.staffLastNameLbl);
            this.staffTab.Controls.Add(this.staffLastNameTbx);
            this.staffTab.Controls.Add(this.staffLbx);
            this.staffTab.Location = new System.Drawing.Point(4, 22);
            this.staffTab.Name = "staffTab";
            this.staffTab.Size = new System.Drawing.Size(382, 246);
            this.staffTab.TabIndex = 3;
            this.staffTab.Text = "Staff";
            this.staffTab.UseVisualStyleBackColor = true;
            // 
            // staffUsernameTbx
            // 
            this.staffUsernameTbx.Location = new System.Drawing.Point(264, 171);
            this.staffUsernameTbx.Name = "staffUsernameTbx";
            this.staffUsernameTbx.Size = new System.Drawing.Size(75, 20);
            this.staffUsernameTbx.TabIndex = 9;
            // 
            // staffUsernameLbl
            // 
            this.staffUsernameLbl.AutoSize = true;
            this.staffUsernameLbl.Location = new System.Drawing.Point(199, 174);
            this.staffUsernameLbl.Name = "staffUsernameLbl";
            this.staffUsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.staffUsernameLbl.TabIndex = 8;
            this.staffUsernameLbl.Text = "Username:";
            // 
            // staffTypeLbl
            // 
            this.staffTypeLbl.AutoSize = true;
            this.staffTypeLbl.Location = new System.Drawing.Point(199, 137);
            this.staffTypeLbl.Name = "staffTypeLbl";
            this.staffTypeLbl.Size = new System.Drawing.Size(59, 13);
            this.staffTypeLbl.TabIndex = 6;
            this.staffTypeLbl.Text = "Staff Type:";
            // 
            // staffTypeCbx
            // 
            this.staffTypeCbx.FormattingEnabled = true;
            this.staffTypeCbx.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.staffTypeCbx.Location = new System.Drawing.Point(264, 134);
            this.staffTypeCbx.Name = "staffTypeCbx";
            this.staffTypeCbx.Size = new System.Drawing.Size(75, 21);
            this.staffTypeCbx.TabIndex = 5;
            // 
            // staffFirstNameLbl
            // 
            this.staffFirstNameLbl.AutoSize = true;
            this.staffFirstNameLbl.Location = new System.Drawing.Point(18, 174);
            this.staffFirstNameLbl.Name = "staffFirstNameLbl";
            this.staffFirstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.staffFirstNameLbl.TabIndex = 4;
            this.staffFirstNameLbl.Text = "First Name:";
            // 
            // staffFirstNameTbx
            // 
            this.staffFirstNameTbx.Location = new System.Drawing.Point(83, 171);
            this.staffFirstNameTbx.Name = "staffFirstNameTbx";
            this.staffFirstNameTbx.Size = new System.Drawing.Size(75, 20);
            this.staffFirstNameTbx.TabIndex = 3;
            // 
            // staffLastNameLbl
            // 
            this.staffLastNameLbl.AutoSize = true;
            this.staffLastNameLbl.Location = new System.Drawing.Point(18, 137);
            this.staffLastNameLbl.Name = "staffLastNameLbl";
            this.staffLastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.staffLastNameLbl.TabIndex = 2;
            this.staffLastNameLbl.Text = "Last Name:";
            // 
            // staffLastNameTbx
            // 
            this.staffLastNameTbx.Location = new System.Drawing.Point(83, 134);
            this.staffLastNameTbx.Name = "staffLastNameTbx";
            this.staffLastNameTbx.Size = new System.Drawing.Size(75, 20);
            this.staffLastNameTbx.TabIndex = 1;
            // 
            // staffLbx
            // 
            this.staffLbx.DataSource = this.tblEmployeeBindingSource;
            this.staffLbx.DisplayMember = "Emp_UName";
            this.staffLbx.FormattingEnabled = true;
            this.staffLbx.Location = new System.Drawing.Point(3, 3);
            this.staffLbx.Name = "staffLbx";
            this.staffLbx.ScrollAlwaysVisible = true;
            this.staffLbx.Size = new System.Drawing.Size(376, 95);
            this.staffLbx.Sorted = true;
            this.staffLbx.TabIndex = 0;
            this.staffLbx.SelectedIndexChanged += new System.EventHandler(this.staffLbx_SelectedIndexChanged);
            // 
            // statusTab
            // 
            this.statusTab.Location = new System.Drawing.Point(4, 22);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(382, 246);
            this.statusTab.TabIndex = 4;
            this.statusTab.Text = "Status";
            this.statusTab.UseVisualStyleBackColor = true;
            // 
            // suppliersTab
            // 
            this.suppliersTab.Location = new System.Drawing.Point(4, 22);
            this.suppliersTab.Name = "suppliersTab";
            this.suppliersTab.Size = new System.Drawing.Size(382, 246);
            this.suppliersTab.TabIndex = 5;
            this.suppliersTab.Text = "Suppliers";
            this.suppliersTab.UseVisualStyleBackColor = true;
            // 
            // lUEquipmentDataSet
            // 
            this.lUEquipmentDataSet.DataSetName = "LUEquipmentDataSet";
            this.lUEquipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lUEquipmentDataSetBindingSource
            // 
            this.lUEquipmentDataSetBindingSource.DataSource = this.lUEquipmentDataSet;
            this.lUEquipmentDataSetBindingSource.Position = 0;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.lUEquipmentDataSetBindingSource;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 373);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.ShowIcon = false;
            this.Text = "Administrative Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.adminTabControl.ResumeLayout(false);
            this.staffTab.ResumeLayout(false);
            this.staffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage equipmentTab;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.TabPage locationsTab;
        private System.Windows.Forms.TabPage staffTab;
        private System.Windows.Forms.ListBox staffLbx;
        private System.Windows.Forms.TabPage statusTab;
        private System.Windows.Forms.TabPage suppliersTab;
        private System.Windows.Forms.Label staffFirstNameLbl;
        private System.Windows.Forms.TextBox staffFirstNameTbx;
        private System.Windows.Forms.Label staffLastNameLbl;
        private System.Windows.Forms.TextBox staffLastNameTbx;
        private System.Windows.Forms.TextBox staffUsernameTbx;
        private System.Windows.Forms.Label staffUsernameLbl;
        private System.Windows.Forms.Label staffTypeLbl;
        private System.Windows.Forms.ComboBox staffTypeCbx;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource;
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
    }
}