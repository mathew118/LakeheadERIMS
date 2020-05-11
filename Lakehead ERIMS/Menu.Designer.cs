namespace Lakehead_ERIMS
{
    partial class Menu
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
            this.formTitleLbl = new System.Windows.Forms.Label();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.administrativeMenuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.returnEquipmentBtn = new System.Windows.Forms.Button();
            this.editRentalBtn = new System.Windows.Forms.Button();
            this.addUpdateStudentBtn = new System.Windows.Forms.Button();
            this.rentEquipmentBtn = new System.Windows.Forms.Button();
            this.equipmentSnapshotBtn = new System.Windows.Forms.Button();
            this.reportsMenuTab = new System.Windows.Forms.TabPage();
            this.outstandingAccountsBtn = new System.Windows.Forms.Button();
            this.reportsExitBtn = new System.Windows.Forms.Button();
            this.overdueRentalsBtn = new System.Windows.Forms.Button();
            this.equipmentInventoryBtn = new System.Windows.Forms.Button();
            this.equipmentHistoryBtn = new System.Windows.Forms.Button();
            this.equipmentOnLoanBtn = new System.Windows.Forms.Button();
            this.tblEquipTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblEquipTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.tblCategoryTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter();
            this.menuTabControl.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            this.reportsMenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitleLbl
            // 
            this.formTitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.formTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.formTitleLbl.Name = "formTitleLbl";
            this.formTitleLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.formTitleLbl.Size = new System.Drawing.Size(452, 371);
            this.formTitleLbl.TabIndex = 0;
            this.formTitleLbl.Text = "Lakehead ERIMS";
            this.formTitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.mainMenuTab);
            this.menuTabControl.Controls.Add(this.reportsMenuTab);
            this.menuTabControl.Location = new System.Drawing.Point(12, 54);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(428, 305);
            this.menuTabControl.TabIndex = 1;
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.Controls.Add(this.administrativeMenuBtn);
            this.mainMenuTab.Controls.Add(this.exitBtn);
            this.mainMenuTab.Controls.Add(this.returnEquipmentBtn);
            this.mainMenuTab.Controls.Add(this.editRentalBtn);
            this.mainMenuTab.Controls.Add(this.addUpdateStudentBtn);
            this.mainMenuTab.Controls.Add(this.rentEquipmentBtn);
            this.mainMenuTab.Controls.Add(this.equipmentSnapshotBtn);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 22);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTab.Size = new System.Drawing.Size(420, 279);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.UseVisualStyleBackColor = true;
            // 
            // administrativeMenuBtn
            // 
            this.administrativeMenuBtn.Location = new System.Drawing.Point(0, 201);
            this.administrativeMenuBtn.Name = "administrativeMenuBtn";
            this.administrativeMenuBtn.Size = new System.Drawing.Size(417, 33);
            this.administrativeMenuBtn.TabIndex = 13;
            this.administrativeMenuBtn.Text = "Administrative Menu";
            this.administrativeMenuBtn.UseVisualStyleBackColor = true;
            this.administrativeMenuBtn.Click += new System.EventHandler(this.administrativeMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(0, 240);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(417, 33);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit Application";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // returnEquipmentBtn
            // 
            this.returnEquipmentBtn.Location = new System.Drawing.Point(0, 45);
            this.returnEquipmentBtn.Name = "returnEquipmentBtn";
            this.returnEquipmentBtn.Size = new System.Drawing.Size(417, 33);
            this.returnEquipmentBtn.TabIndex = 11;
            this.returnEquipmentBtn.Text = "Return Equipment";
            this.returnEquipmentBtn.UseVisualStyleBackColor = true;
            this.returnEquipmentBtn.Click += new System.EventHandler(this.returnEquipmentBtn_Click);
            // 
            // editRentalBtn
            // 
            this.editRentalBtn.Location = new System.Drawing.Point(0, 84);
            this.editRentalBtn.Name = "editRentalBtn";
            this.editRentalBtn.Size = new System.Drawing.Size(417, 33);
            this.editRentalBtn.TabIndex = 10;
            this.editRentalBtn.Text = "Edit Rental";
            this.editRentalBtn.UseVisualStyleBackColor = true;
            this.editRentalBtn.Click += new System.EventHandler(this.editRentalBtn_Click);
            // 
            // addUpdateStudentBtn
            // 
            this.addUpdateStudentBtn.Location = new System.Drawing.Point(0, 123);
            this.addUpdateStudentBtn.Name = "addUpdateStudentBtn";
            this.addUpdateStudentBtn.Size = new System.Drawing.Size(417, 33);
            this.addUpdateStudentBtn.TabIndex = 8;
            this.addUpdateStudentBtn.Text = "Add/Update Student";
            this.addUpdateStudentBtn.UseVisualStyleBackColor = true;
            this.addUpdateStudentBtn.Click += new System.EventHandler(this.addUpdateStudentBtn_Click);
            // 
            // rentEquipmentBtn
            // 
            this.rentEquipmentBtn.Location = new System.Drawing.Point(0, 6);
            this.rentEquipmentBtn.Name = "rentEquipmentBtn";
            this.rentEquipmentBtn.Size = new System.Drawing.Size(417, 33);
            this.rentEquipmentBtn.TabIndex = 9;
            this.rentEquipmentBtn.Text = "Rent Equipment";
            this.rentEquipmentBtn.UseVisualStyleBackColor = true;
            this.rentEquipmentBtn.Click += new System.EventHandler(this.rentEquipmentBtn_Click);
            // 
            // equipmentSnapshotBtn
            // 
            this.equipmentSnapshotBtn.Location = new System.Drawing.Point(0, 162);
            this.equipmentSnapshotBtn.Name = "equipmentSnapshotBtn";
            this.equipmentSnapshotBtn.Size = new System.Drawing.Size(417, 33);
            this.equipmentSnapshotBtn.TabIndex = 7;
            this.equipmentSnapshotBtn.Text = "Equipment Snapshot";
            this.equipmentSnapshotBtn.UseVisualStyleBackColor = true;
            this.equipmentSnapshotBtn.Click += new System.EventHandler(this.equipmentSnapshotBtn_Click);
            // 
            // reportsMenuTab
            // 
            this.reportsMenuTab.Controls.Add(this.outstandingAccountsBtn);
            this.reportsMenuTab.Controls.Add(this.reportsExitBtn);
            this.reportsMenuTab.Controls.Add(this.overdueRentalsBtn);
            this.reportsMenuTab.Controls.Add(this.equipmentInventoryBtn);
            this.reportsMenuTab.Controls.Add(this.equipmentHistoryBtn);
            this.reportsMenuTab.Controls.Add(this.equipmentOnLoanBtn);
            this.reportsMenuTab.Location = new System.Drawing.Point(4, 22);
            this.reportsMenuTab.Name = "reportsMenuTab";
            this.reportsMenuTab.Size = new System.Drawing.Size(420, 279);
            this.reportsMenuTab.TabIndex = 2;
            this.reportsMenuTab.Text = "Administrative Reports";
            this.reportsMenuTab.UseVisualStyleBackColor = true;
            // 
            // outstandingAccountsBtn
            // 
            this.outstandingAccountsBtn.Location = new System.Drawing.Point(0, 144);
            this.outstandingAccountsBtn.Name = "outstandingAccountsBtn";
            this.outstandingAccountsBtn.Size = new System.Drawing.Size(417, 40);
            this.outstandingAccountsBtn.TabIndex = 11;
            this.outstandingAccountsBtn.Text = "&Overdue Balances";
            this.outstandingAccountsBtn.UseVisualStyleBackColor = true;
            this.outstandingAccountsBtn.Click += new System.EventHandler(this.outstandingAccountsBtn_Click);
            // 
            // reportsExitBtn
            // 
            this.reportsExitBtn.Location = new System.Drawing.Point(0, 236);
            this.reportsExitBtn.Name = "reportsExitBtn";
            this.reportsExitBtn.Size = new System.Drawing.Size(417, 40);
            this.reportsExitBtn.TabIndex = 13;
            this.reportsExitBtn.Text = "E&xit Application";
            this.reportsExitBtn.UseVisualStyleBackColor = true;
            this.reportsExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // overdueRentalsBtn
            // 
            this.overdueRentalsBtn.Location = new System.Drawing.Point(0, 190);
            this.overdueRentalsBtn.Name = "overdueRentalsBtn";
            this.overdueRentalsBtn.Size = new System.Drawing.Size(417, 40);
            this.overdueRentalsBtn.TabIndex = 12;
            this.overdueRentalsBtn.Text = "Overdue &Rentals";
            this.overdueRentalsBtn.UseVisualStyleBackColor = true;
            this.overdueRentalsBtn.Click += new System.EventHandler(this.overdueRentalsBtn_Click);
            // 
            // equipmentInventoryBtn
            // 
            this.equipmentInventoryBtn.Location = new System.Drawing.Point(0, 52);
            this.equipmentInventoryBtn.Name = "equipmentInventoryBtn";
            this.equipmentInventoryBtn.Size = new System.Drawing.Size(417, 40);
            this.equipmentInventoryBtn.TabIndex = 9;
            this.equipmentInventoryBtn.Text = "&Equipment Inventory";
            this.equipmentInventoryBtn.UseVisualStyleBackColor = true;
            this.equipmentInventoryBtn.Click += new System.EventHandler(this.equipmentInventoryBtn_Click);
            // 
            // equipmentHistoryBtn
            // 
            this.equipmentHistoryBtn.Location = new System.Drawing.Point(0, 98);
            this.equipmentHistoryBtn.Name = "equipmentHistoryBtn";
            this.equipmentHistoryBtn.Size = new System.Drawing.Size(417, 40);
            this.equipmentHistoryBtn.TabIndex = 10;
            this.equipmentHistoryBtn.Text = "Equipment &History";
            this.equipmentHistoryBtn.UseVisualStyleBackColor = true;
            this.equipmentHistoryBtn.Click += new System.EventHandler(this.equipmentHistoryBtn_Click);
            // 
            // equipmentOnLoanBtn
            // 
            this.equipmentOnLoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.equipmentOnLoanBtn.Location = new System.Drawing.Point(0, 6);
            this.equipmentOnLoanBtn.Name = "equipmentOnLoanBtn";
            this.equipmentOnLoanBtn.Size = new System.Drawing.Size(417, 40);
            this.equipmentOnLoanBtn.TabIndex = 8;
            this.equipmentOnLoanBtn.Text = "Equipment On &Loan";
            this.equipmentOnLoanBtn.UseVisualStyleBackColor = true;
            this.equipmentOnLoanBtn.Click += new System.EventHandler(this.equipmentOnLoanBtn_Click);
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
            // tblCategoryTableAdapter1
            // 
            this.tblCategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 371);
            this.Controls.Add(this.menuTabControl);
            this.Controls.Add(this.formTitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Equipment Room Inventory Management System";
            this.menuTabControl.ResumeLayout(false);
            this.mainMenuTab.ResumeLayout(false);
            this.reportsMenuTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label formTitleLbl;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage mainMenuTab;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button returnEquipmentBtn;
        private System.Windows.Forms.Button editRentalBtn;
        private System.Windows.Forms.Button addUpdateStudentBtn;
        private System.Windows.Forms.Button rentEquipmentBtn;
        private System.Windows.Forms.Button equipmentSnapshotBtn;
        private System.Windows.Forms.TabPage reportsMenuTab;
        private System.Windows.Forms.Button outstandingAccountsBtn;
        private System.Windows.Forms.Button reportsExitBtn;
        private System.Windows.Forms.Button overdueRentalsBtn;
        private System.Windows.Forms.Button equipmentInventoryBtn;
        private System.Windows.Forms.Button equipmentHistoryBtn;
        private System.Windows.Forms.Button equipmentOnLoanBtn;
        private LUEquipmentDataSetTableAdapters.tblEquipTableAdapter tblEquipTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
        private LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter1;
        private System.Windows.Forms.Button administrativeMenuBtn;
    }
}

