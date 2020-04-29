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
            this.exitBtn = new System.Windows.Forms.Button();
            this.returnEquipmentBtn = new System.Windows.Forms.Button();
            this.editRentalBtn = new System.Windows.Forms.Button();
            this.addUpdateStudentBtn = new System.Windows.Forms.Button();
            this.rentEquipmentBtn = new System.Windows.Forms.Button();
            this.equipmentSnapshotBtn = new System.Windows.Forms.Button();
            this.adminMenuTab = new System.Windows.Forms.TabPage();
            this.adminExitBtn = new System.Windows.Forms.Button();
            this.addUpdateEquipmentBtn = new System.Windows.Forms.Button();
            this.reportsMenuTab = new System.Windows.Forms.TabPage();
            this.outstandingAccountsBtn = new System.Windows.Forms.Button();
            this.reportsExitBtn = new System.Windows.Forms.Button();
            this.overdueRentalsBtn = new System.Windows.Forms.Button();
            this.equipmentInventoryBtn = new System.Windows.Forms.Button();
            this.equipmentHistoryBtn = new System.Windows.Forms.Button();
            this.equipmentOnLoanBtn = new System.Windows.Forms.Button();
            this.menuTabControl.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            this.adminMenuTab.SuspendLayout();
            this.reportsMenuTab.SuspendLayout();
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
            this.menuTabControl.Controls.Add(this.adminMenuTab);
            this.menuTabControl.Controls.Add(this.reportsMenuTab);
            this.menuTabControl.Location = new System.Drawing.Point(12, 54);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(428, 305);
            this.menuTabControl.TabIndex = 1;
            // 
            // mainMenuTab
            // 
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
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(0, 236);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(417, 40);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "E&xit Application";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // returnEquipmentBtn
            // 
            this.returnEquipmentBtn.Location = new System.Drawing.Point(0, 144);
            this.returnEquipmentBtn.Name = "returnEquipmentBtn";
            this.returnEquipmentBtn.Size = new System.Drawing.Size(417, 40);
            this.returnEquipmentBtn.TabIndex = 11;
            this.returnEquipmentBtn.Text = "Return &Equipment";
            this.returnEquipmentBtn.UseVisualStyleBackColor = true;
            // 
            // editRentalBtn
            // 
            this.editRentalBtn.Location = new System.Drawing.Point(0, 98);
            this.editRentalBtn.Name = "editRentalBtn";
            this.editRentalBtn.Size = new System.Drawing.Size(417, 40);
            this.editRentalBtn.TabIndex = 10;
            this.editRentalBtn.Text = "E&dit Rental";
            this.editRentalBtn.UseVisualStyleBackColor = true;
            // 
            // addUpdateStudentBtn
            // 
            this.addUpdateStudentBtn.Location = new System.Drawing.Point(0, 52);
            this.addUpdateStudentBtn.Name = "addUpdateStudentBtn";
            this.addUpdateStudentBtn.Size = new System.Drawing.Size(417, 40);
            this.addUpdateStudentBtn.TabIndex = 8;
            this.addUpdateStudentBtn.Text = "Add/&Update Student";
            this.addUpdateStudentBtn.UseVisualStyleBackColor = true;
            // 
            // rentEquipmentBtn
            // 
            this.rentEquipmentBtn.Location = new System.Drawing.Point(0, 190);
            this.rentEquipmentBtn.Name = "rentEquipmentBtn";
            this.rentEquipmentBtn.Size = new System.Drawing.Size(417, 40);
            this.rentEquipmentBtn.TabIndex = 9;
            this.rentEquipmentBtn.Text = "&Rent Equipment";
            this.rentEquipmentBtn.UseVisualStyleBackColor = true;
            // 
            // equipmentSnapshotBtn
            // 
            this.equipmentSnapshotBtn.Location = new System.Drawing.Point(0, 6);
            this.equipmentSnapshotBtn.Name = "equipmentSnapshotBtn";
            this.equipmentSnapshotBtn.Size = new System.Drawing.Size(417, 40);
            this.equipmentSnapshotBtn.TabIndex = 7;
            this.equipmentSnapshotBtn.Text = "Equipment &Snapshot";
            this.equipmentSnapshotBtn.UseVisualStyleBackColor = true;
            // 
            // adminMenuTab
            // 
            this.adminMenuTab.Controls.Add(this.adminExitBtn);
            this.adminMenuTab.Controls.Add(this.addUpdateEquipmentBtn);
            this.adminMenuTab.Location = new System.Drawing.Point(4, 22);
            this.adminMenuTab.Name = "adminMenuTab";
            this.adminMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminMenuTab.Size = new System.Drawing.Size(420, 279);
            this.adminMenuTab.TabIndex = 1;
            this.adminMenuTab.Text = "Administrative Menu";
            this.adminMenuTab.UseVisualStyleBackColor = true;
            // 
            // adminExitBtn
            // 
            this.adminExitBtn.Location = new System.Drawing.Point(0, 240);
            this.adminExitBtn.Name = "adminExitBtn";
            this.adminExitBtn.Size = new System.Drawing.Size(417, 33);
            this.adminExitBtn.TabIndex = 15;
            this.adminExitBtn.Text = "E&xit Application";
            this.adminExitBtn.UseVisualStyleBackColor = true;
            this.adminExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addUpdateEquipmentBtn
            // 
            this.addUpdateEquipmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.addUpdateEquipmentBtn.Location = new System.Drawing.Point(0, 6);
            this.addUpdateEquipmentBtn.Name = "addUpdateEquipmentBtn";
            this.addUpdateEquipmentBtn.Size = new System.Drawing.Size(417, 228);
            this.addUpdateEquipmentBtn.TabIndex = 9;
            this.addUpdateEquipmentBtn.Text = "Click here, redesign later..";
            this.addUpdateEquipmentBtn.UseVisualStyleBackColor = true;
            this.addUpdateEquipmentBtn.Click += new System.EventHandler(this.addUpdateEquipmentBtn_Click);
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
            this.reportsMenuTab.Text = "Adminstrative Reports";
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
            this.adminMenuTab.ResumeLayout(false);
            this.reportsMenuTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage adminMenuTab;
        private System.Windows.Forms.TabPage reportsMenuTab;
        private System.Windows.Forms.Button adminExitBtn;
        private System.Windows.Forms.Button addUpdateEquipmentBtn;
        private System.Windows.Forms.Button outstandingAccountsBtn;
        private System.Windows.Forms.Button reportsExitBtn;
        private System.Windows.Forms.Button overdueRentalsBtn;
        private System.Windows.Forms.Button equipmentInventoryBtn;
        private System.Windows.Forms.Button equipmentHistoryBtn;
        private System.Windows.Forms.Button equipmentOnLoanBtn;
    }
}

