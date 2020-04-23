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
            this.addBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.equipmentTab = new System.Windows.Forms.TabPage();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.locationsTab = new System.Windows.Forms.TabPage();
            this.locationsLocationNameLbl = new System.Windows.Forms.Label();
            this.locationsLocationNameTbx = new System.Windows.Forms.TextBox();
            this.locationsLbx = new System.Windows.Forms.ListBox();
            this.tblLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
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
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTab = new System.Windows.Forms.TabPage();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.tblEmployeeTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEmployeeTableAdapter();
            this.tblLocationTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblLocationTableAdapter();
            this.categoriesLbx = new System.Windows.Forms.ListBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoryTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter();
            this.categoriesCategoryNameLbl = new System.Windows.Forms.Label();
            this.categoriesCategoryNameTbx = new System.Windows.Forms.TextBox();
            this.categoriesStartRangeLbl = new System.Windows.Forms.Label();
            this.categoriesStartRangeATbx = new System.Windows.Forms.TextBox();
            this.categoriesEndRangeLbl = new System.Windows.Forms.Label();
            this.categoriesEndRangeATbx = new System.Windows.Forms.TextBox();
            this.categoriesStartRangeBTbx = new System.Windows.Forms.TextBox();
            this.categoriesEndRangeBTbx = new System.Windows.Forms.TextBox();
            this.equipmentLbx = new System.Windows.Forms.ListBox();
            this.equipmentItemNameLbl = new System.Windows.Forms.Label();
            this.equipmentItemNameTbx = new System.Windows.Forms.TextBox();
            this.equipmentItemNumberSearchBTbx = new System.Windows.Forms.TextBox();
            this.equipmentItemNumberSearchLbl = new System.Windows.Forms.Label();
            this.equipmentItemNumberSearchATbx = new System.Windows.Forms.TextBox();
            this.equipmentItemNumberSearchBtn = new System.Windows.Forms.Button();
            this.tblEquipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.statusLbx = new System.Windows.Forms.ListBox();
            this.tblStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStatusTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStatusTableAdapter();
            this.statusNameLbl = new System.Windows.Forms.Label();
            this.statusNameTbx = new System.Windows.Forms.TextBox();
            this.suppliersLbx = new System.Windows.Forms.ListBox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSupplierTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblSupplierTableAdapter();
            this.suppliersNameLbl = new System.Windows.Forms.Label();
            this.suppliersNameTbx = new System.Windows.Forms.TextBox();
            this.adminTabControl.SuspendLayout();
            this.equipmentTab.SuspendLayout();
            this.categoriesTab.SuspendLayout();
            this.locationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            this.staffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).BeginInit();
            this.statusTab.SuspendLayout();
            this.suppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(40, 306);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 40);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(160, 306);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 40);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            // 
            // equipmentTab
            // 
            this.equipmentTab.Controls.Add(this.equipmentItemNumberSearchBtn);
            this.equipmentTab.Controls.Add(this.equipmentItemNumberSearchBTbx);
            this.equipmentTab.Controls.Add(this.equipmentItemNumberSearchLbl);
            this.equipmentTab.Controls.Add(this.equipmentItemNumberSearchATbx);
            this.equipmentTab.Controls.Add(this.equipmentItemNameLbl);
            this.equipmentTab.Controls.Add(this.equipmentItemNameTbx);
            this.equipmentTab.Controls.Add(this.equipmentLbx);
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
            this.categoriesTab.Controls.Add(this.categoriesEndRangeBTbx);
            this.categoriesTab.Controls.Add(this.categoriesStartRangeBTbx);
            this.categoriesTab.Controls.Add(this.categoriesEndRangeLbl);
            this.categoriesTab.Controls.Add(this.categoriesEndRangeATbx);
            this.categoriesTab.Controls.Add(this.categoriesStartRangeLbl);
            this.categoriesTab.Controls.Add(this.categoriesStartRangeATbx);
            this.categoriesTab.Controls.Add(this.categoriesCategoryNameLbl);
            this.categoriesTab.Controls.Add(this.categoriesCategoryNameTbx);
            this.categoriesTab.Controls.Add(this.categoriesLbx);
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
            this.locationsTab.Controls.Add(this.locationsLocationNameLbl);
            this.locationsTab.Controls.Add(this.locationsLocationNameTbx);
            this.locationsTab.Controls.Add(this.locationsLbx);
            this.locationsTab.Location = new System.Drawing.Point(4, 22);
            this.locationsTab.Name = "locationsTab";
            this.locationsTab.Size = new System.Drawing.Size(382, 246);
            this.locationsTab.TabIndex = 2;
            this.locationsTab.Text = "Locations";
            this.locationsTab.UseVisualStyleBackColor = true;
            // 
            // locationsLocationNameLbl
            // 
            this.locationsLocationNameLbl.AutoSize = true;
            this.locationsLocationNameLbl.Location = new System.Drawing.Point(18, 137);
            this.locationsLocationNameLbl.Name = "locationsLocationNameLbl";
            this.locationsLocationNameLbl.Size = new System.Drawing.Size(82, 13);
            this.locationsLocationNameLbl.TabIndex = 12;
            this.locationsLocationNameLbl.Text = "Location Name:";
            // 
            // locationsLocationNameTbx
            // 
            this.locationsLocationNameTbx.Location = new System.Drawing.Point(106, 134);
            this.locationsLocationNameTbx.Name = "locationsLocationNameTbx";
            this.locationsLocationNameTbx.Size = new System.Drawing.Size(185, 20);
            this.locationsLocationNameTbx.TabIndex = 11;
            this.locationsLocationNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // locationsLbx
            // 
            this.locationsLbx.DataSource = this.tblLocationBindingSource;
            this.locationsLbx.DisplayMember = "Loc_Name";
            this.locationsLbx.FormattingEnabled = true;
            this.locationsLbx.Location = new System.Drawing.Point(3, 3);
            this.locationsLbx.Name = "locationsLbx";
            this.locationsLbx.ScrollAlwaysVisible = true;
            this.locationsLbx.Size = new System.Drawing.Size(376, 95);
            this.locationsLbx.TabIndex = 10;
            this.locationsLbx.ValueMember = "Loc_ID";
            this.locationsLbx.SelectedIndexChanged += new System.EventHandler(this.locationsLbx_SelectedIndexChanged);
            // 
            // tblLocationBindingSource
            // 
            this.tblLocationBindingSource.DataMember = "tblLocation";
            this.tblLocationBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // lUEquipmentDataSet
            // 
            this.lUEquipmentDataSet.DataSetName = "LUEquipmentDataSet";
            this.lUEquipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.staffUsernameTbx.Size = new System.Drawing.Size(90, 20);
            this.staffUsernameTbx.TabIndex = 9;
            this.staffUsernameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
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
            this.staffTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffTypeCbx.FormattingEnabled = true;
            this.staffTypeCbx.Items.AddRange(new object[] {
            "Administrator",
            "Employee"});
            this.staffTypeCbx.Location = new System.Drawing.Point(264, 134);
            this.staffTypeCbx.Name = "staffTypeCbx";
            this.staffTypeCbx.Size = new System.Drawing.Size(90, 21);
            this.staffTypeCbx.TabIndex = 5;
            this.staffTypeCbx.SelectedIndexChanged += new System.EventHandler(this.adminFieldChanged);
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
            this.staffFirstNameTbx.Size = new System.Drawing.Size(90, 20);
            this.staffFirstNameTbx.TabIndex = 3;
            this.staffFirstNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
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
            this.staffLastNameTbx.Size = new System.Drawing.Size(90, 20);
            this.staffLastNameTbx.TabIndex = 1;
            this.staffLastNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
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
            this.staffLbx.TabIndex = 0;
            this.staffLbx.ValueMember = "Emp_ID";
            this.staffLbx.SelectedIndexChanged += new System.EventHandler(this.staffLbx_SelectedIndexChanged);
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.lUEquipmentDataSetBindingSource;
            // 
            // lUEquipmentDataSetBindingSource
            // 
            this.lUEquipmentDataSetBindingSource.DataSource = this.lUEquipmentDataSet;
            this.lUEquipmentDataSetBindingSource.Position = 0;
            // 
            // statusTab
            // 
            this.statusTab.Controls.Add(this.statusNameLbl);
            this.statusTab.Controls.Add(this.statusNameTbx);
            this.statusTab.Controls.Add(this.statusLbx);
            this.statusTab.Location = new System.Drawing.Point(4, 22);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(382, 246);
            this.statusTab.TabIndex = 4;
            this.statusTab.Text = "Status";
            this.statusTab.UseVisualStyleBackColor = true;
            // 
            // suppliersTab
            // 
            this.suppliersTab.Controls.Add(this.suppliersNameLbl);
            this.suppliersTab.Controls.Add(this.suppliersNameTbx);
            this.suppliersTab.Controls.Add(this.suppliersLbx);
            this.suppliersTab.Location = new System.Drawing.Point(4, 22);
            this.suppliersTab.Name = "suppliersTab";
            this.suppliersTab.Size = new System.Drawing.Size(382, 246);
            this.suppliersTab.TabIndex = 5;
            this.suppliersTab.Text = "Suppliers";
            this.suppliersTab.UseVisualStyleBackColor = true;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tblLocationTableAdapter
            // 
            this.tblLocationTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesLbx
            // 
            this.categoriesLbx.DataSource = this.tblCategoryBindingSource;
            this.categoriesLbx.DisplayMember = "Cat_Name";
            this.categoriesLbx.FormattingEnabled = true;
            this.categoriesLbx.Location = new System.Drawing.Point(3, 3);
            this.categoriesLbx.Name = "categoriesLbx";
            this.categoriesLbx.ScrollAlwaysVisible = true;
            this.categoriesLbx.Size = new System.Drawing.Size(376, 95);
            this.categoriesLbx.TabIndex = 11;
            this.categoriesLbx.ValueMember = "Cat_ID";
            this.categoriesLbx.SelectedIndexChanged += new System.EventHandler(this.categoriesLbx_SelectedIndexChanged);
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesCategoryNameLbl
            // 
            this.categoriesCategoryNameLbl.AutoSize = true;
            this.categoriesCategoryNameLbl.Location = new System.Drawing.Point(18, 137);
            this.categoriesCategoryNameLbl.Name = "categoriesCategoryNameLbl";
            this.categoriesCategoryNameLbl.Size = new System.Drawing.Size(83, 13);
            this.categoriesCategoryNameLbl.TabIndex = 14;
            this.categoriesCategoryNameLbl.Text = "Category Name:";
            // 
            // categoriesCategoryNameTbx
            // 
            this.categoriesCategoryNameTbx.Location = new System.Drawing.Point(106, 134);
            this.categoriesCategoryNameTbx.Name = "categoriesCategoryNameTbx";
            this.categoriesCategoryNameTbx.Size = new System.Drawing.Size(185, 20);
            this.categoriesCategoryNameTbx.TabIndex = 13;
            this.categoriesCategoryNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // categoriesStartRangeLbl
            // 
            this.categoriesStartRangeLbl.AutoSize = true;
            this.categoriesStartRangeLbl.Location = new System.Drawing.Point(33, 163);
            this.categoriesStartRangeLbl.Name = "categoriesStartRangeLbl";
            this.categoriesStartRangeLbl.Size = new System.Drawing.Size(67, 13);
            this.categoriesStartRangeLbl.TabIndex = 16;
            this.categoriesStartRangeLbl.Text = "Start Range:";
            // 
            // categoriesStartRangeATbx
            // 
            this.categoriesStartRangeATbx.Location = new System.Drawing.Point(106, 160);
            this.categoriesStartRangeATbx.Name = "categoriesStartRangeATbx";
            this.categoriesStartRangeATbx.Size = new System.Drawing.Size(89, 20);
            this.categoriesStartRangeATbx.TabIndex = 15;
            this.categoriesStartRangeATbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // categoriesEndRangeLbl
            // 
            this.categoriesEndRangeLbl.AutoSize = true;
            this.categoriesEndRangeLbl.Location = new System.Drawing.Point(36, 189);
            this.categoriesEndRangeLbl.Name = "categoriesEndRangeLbl";
            this.categoriesEndRangeLbl.Size = new System.Drawing.Size(64, 13);
            this.categoriesEndRangeLbl.TabIndex = 18;
            this.categoriesEndRangeLbl.Text = "End Range:";
            // 
            // categoriesEndRangeATbx
            // 
            this.categoriesEndRangeATbx.Location = new System.Drawing.Point(106, 186);
            this.categoriesEndRangeATbx.Name = "categoriesEndRangeATbx";
            this.categoriesEndRangeATbx.Size = new System.Drawing.Size(89, 20);
            this.categoriesEndRangeATbx.TabIndex = 17;
            this.categoriesEndRangeATbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // categoriesStartRangeBTbx
            // 
            this.categoriesStartRangeBTbx.Location = new System.Drawing.Point(201, 160);
            this.categoriesStartRangeBTbx.Name = "categoriesStartRangeBTbx";
            this.categoriesStartRangeBTbx.Size = new System.Drawing.Size(89, 20);
            this.categoriesStartRangeBTbx.TabIndex = 19;
            this.categoriesStartRangeBTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // categoriesEndRangeBTbx
            // 
            this.categoriesEndRangeBTbx.Location = new System.Drawing.Point(201, 186);
            this.categoriesEndRangeBTbx.Name = "categoriesEndRangeBTbx";
            this.categoriesEndRangeBTbx.Size = new System.Drawing.Size(89, 20);
            this.categoriesEndRangeBTbx.TabIndex = 20;
            this.categoriesEndRangeBTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // equipmentLbx
            // 
            this.equipmentLbx.DataSource = this.tblEquipBindingSource;
            this.equipmentLbx.DisplayMember = "Equip_Name";
            this.equipmentLbx.FormattingEnabled = true;
            this.equipmentLbx.Location = new System.Drawing.Point(3, 3);
            this.equipmentLbx.Name = "equipmentLbx";
            this.equipmentLbx.ScrollAlwaysVisible = true;
            this.equipmentLbx.Size = new System.Drawing.Size(376, 95);
            this.equipmentLbx.TabIndex = 12;
            this.equipmentLbx.ValueMember = "Equip_ID";
            this.equipmentLbx.SelectedIndexChanged += new System.EventHandler(this.equipmentLbx_SelectedIndexChanged);
            // 
            // equipmentItemNameLbl
            // 
            this.equipmentItemNameLbl.AutoSize = true;
            this.equipmentItemNameLbl.Location = new System.Drawing.Point(6, 135);
            this.equipmentItemNameLbl.Name = "equipmentItemNameLbl";
            this.equipmentItemNameLbl.Size = new System.Drawing.Size(61, 13);
            this.equipmentItemNameLbl.TabIndex = 16;
            this.equipmentItemNameLbl.Text = "Item Name:";
            // 
            // equipmentItemNameTbx
            // 
            this.equipmentItemNameTbx.Location = new System.Drawing.Point(73, 132);
            this.equipmentItemNameTbx.Name = "equipmentItemNameTbx";
            this.equipmentItemNameTbx.Size = new System.Drawing.Size(95, 20);
            this.equipmentItemNameTbx.TabIndex = 15;
            // 
            // equipmentItemNumberSearchBTbx
            // 
            this.equipmentItemNumberSearchBTbx.Location = new System.Drawing.Point(140, 100);
            this.equipmentItemNumberSearchBTbx.Name = "equipmentItemNumberSearchBTbx";
            this.equipmentItemNumberSearchBTbx.Size = new System.Drawing.Size(55, 20);
            this.equipmentItemNumberSearchBTbx.TabIndex = 22;
            // 
            // equipmentItemNumberSearchLbl
            // 
            this.equipmentItemNumberSearchLbl.AutoSize = true;
            this.equipmentItemNumberSearchLbl.Location = new System.Drawing.Point(6, 103);
            this.equipmentItemNumberSearchLbl.Name = "equipmentItemNumberSearchLbl";
            this.equipmentItemNumberSearchLbl.Size = new System.Drawing.Size(70, 13);
            this.equipmentItemNumberSearchLbl.TabIndex = 21;
            this.equipmentItemNumberSearchLbl.Text = "Item Number:";
            // 
            // equipmentItemNumberSearchATbx
            // 
            this.equipmentItemNumberSearchATbx.Location = new System.Drawing.Point(79, 100);
            this.equipmentItemNumberSearchATbx.Name = "equipmentItemNumberSearchATbx";
            this.equipmentItemNumberSearchATbx.Size = new System.Drawing.Size(55, 20);
            this.equipmentItemNumberSearchATbx.TabIndex = 20;
            // 
            // equipmentItemNumberSearchBtn
            // 
            this.equipmentItemNumberSearchBtn.Location = new System.Drawing.Point(201, 100);
            this.equipmentItemNumberSearchBtn.Name = "equipmentItemNumberSearchBtn";
            this.equipmentItemNumberSearchBtn.Size = new System.Drawing.Size(53, 20);
            this.equipmentItemNumberSearchBtn.TabIndex = 23;
            this.equipmentItemNumberSearchBtn.Text = "Search";
            this.equipmentItemNumberSearchBtn.UseVisualStyleBackColor = true;
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
            // statusLbx
            // 
            this.statusLbx.DataSource = this.tblStatusBindingSource;
            this.statusLbx.DisplayMember = "Status_Name";
            this.statusLbx.FormattingEnabled = true;
            this.statusLbx.Location = new System.Drawing.Point(3, 3);
            this.statusLbx.Name = "statusLbx";
            this.statusLbx.ScrollAlwaysVisible = true;
            this.statusLbx.Size = new System.Drawing.Size(376, 95);
            this.statusLbx.TabIndex = 1;
            this.statusLbx.ValueMember = "Status_ID";
            this.statusLbx.SelectedIndexChanged += new System.EventHandler(this.statusLbx_SelectedIndexChanged);
            // 
            // tblStatusBindingSource
            // 
            this.tblStatusBindingSource.DataMember = "tblStatus";
            this.tblStatusBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // tblStatusTableAdapter
            // 
            this.tblStatusTableAdapter.ClearBeforeFill = true;
            // 
            // statusNameLbl
            // 
            this.statusNameLbl.AutoSize = true;
            this.statusNameLbl.Location = new System.Drawing.Point(29, 137);
            this.statusNameLbl.Name = "statusNameLbl";
            this.statusNameLbl.Size = new System.Drawing.Size(71, 13);
            this.statusNameLbl.TabIndex = 14;
            this.statusNameLbl.Text = "Status Name:";
            // 
            // statusNameTbx
            // 
            this.statusNameTbx.Location = new System.Drawing.Point(106, 134);
            this.statusNameTbx.Name = "statusNameTbx";
            this.statusNameTbx.Size = new System.Drawing.Size(185, 20);
            this.statusNameTbx.TabIndex = 13;
            this.statusNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // suppliersLbx
            // 
            this.suppliersLbx.DataSource = this.tblSupplierBindingSource;
            this.suppliersLbx.DisplayMember = "Supp_Name";
            this.suppliersLbx.FormattingEnabled = true;
            this.suppliersLbx.Location = new System.Drawing.Point(3, 3);
            this.suppliersLbx.Name = "suppliersLbx";
            this.suppliersLbx.ScrollAlwaysVisible = true;
            this.suppliersLbx.Size = new System.Drawing.Size(376, 95);
            this.suppliersLbx.TabIndex = 2;
            this.suppliersLbx.ValueMember = "Supp_ID";
            this.suppliersLbx.SelectedIndexChanged += new System.EventHandler(this.suppliersLbx_SelectedIndexChanged);
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersNameLbl
            // 
            this.suppliersNameLbl.AutoSize = true;
            this.suppliersNameLbl.Location = new System.Drawing.Point(21, 137);
            this.suppliersNameLbl.Name = "suppliersNameLbl";
            this.suppliersNameLbl.Size = new System.Drawing.Size(79, 13);
            this.suppliersNameLbl.TabIndex = 14;
            this.suppliersNameLbl.Text = "Supplier Name:";
            // 
            // suppliersNameTbx
            // 
            this.suppliersNameTbx.Location = new System.Drawing.Point(106, 134);
            this.suppliersNameTbx.Name = "suppliersNameTbx";
            this.suppliersNameTbx.Size = new System.Drawing.Size(185, 20);
            this.suppliersNameTbx.TabIndex = 13;
            this.suppliersNameTbx.TextChanged += new System.EventHandler(this.adminFieldChanged);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 373);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.ShowIcon = false;
            this.Text = "Administrative Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.adminTabControl.ResumeLayout(false);
            this.equipmentTab.ResumeLayout(false);
            this.equipmentTab.PerformLayout();
            this.categoriesTab.ResumeLayout(false);
            this.categoriesTab.PerformLayout();
            this.locationsTab.ResumeLayout(false);
            this.locationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            this.staffTab.ResumeLayout(false);
            this.staffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).EndInit();
            this.statusTab.ResumeLayout(false);
            this.statusTab.PerformLayout();
            this.suppliersTab.ResumeLayout(false);
            this.suppliersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button saveBtn;
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
        private System.Windows.Forms.Label locationsLocationNameLbl;
        private System.Windows.Forms.TextBox locationsLocationNameTbx;
        private System.Windows.Forms.ListBox locationsLbx;
        private System.Windows.Forms.BindingSource tblLocationBindingSource;
        private LUEquipmentDataSetTableAdapters.tblLocationTableAdapter tblLocationTableAdapter;
        private System.Windows.Forms.ListBox categoriesLbx;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.Label categoriesEndRangeLbl;
        private System.Windows.Forms.TextBox categoriesEndRangeATbx;
        private System.Windows.Forms.Label categoriesStartRangeLbl;
        private System.Windows.Forms.TextBox categoriesStartRangeATbx;
        private System.Windows.Forms.Label categoriesCategoryNameLbl;
        private System.Windows.Forms.TextBox categoriesCategoryNameTbx;
        private System.Windows.Forms.TextBox categoriesEndRangeBTbx;
        private System.Windows.Forms.TextBox categoriesStartRangeBTbx;
        private System.Windows.Forms.Button equipmentItemNumberSearchBtn;
        private System.Windows.Forms.TextBox equipmentItemNumberSearchBTbx;
        private System.Windows.Forms.Label equipmentItemNumberSearchLbl;
        private System.Windows.Forms.TextBox equipmentItemNumberSearchATbx;
        private System.Windows.Forms.Label equipmentItemNameLbl;
        private System.Windows.Forms.TextBox equipmentItemNameTbx;
        private System.Windows.Forms.ListBox equipmentLbx;
        private System.Windows.Forms.BindingSource tblEquipBindingSource;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter;
        private System.Windows.Forms.ListBox statusLbx;
        private System.Windows.Forms.BindingSource tblStatusBindingSource;
        private LUEquipmentDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter;
        private System.Windows.Forms.Label statusNameLbl;
        private System.Windows.Forms.TextBox statusNameTbx;
        private System.Windows.Forms.ListBox suppliersLbx;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private LUEquipmentDataSetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private System.Windows.Forms.Label suppliersNameLbl;
        private System.Windows.Forms.TextBox suppliersNameTbx;
    }
}