namespace Lakehead_ERIMS
{
    partial class EquipInventory
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
            this.categoriesLbx = new System.Windows.Forms.ListBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.locationsLbx = new System.Windows.Forms.ListBox();
            this.tblLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusLbx = new System.Windows.Forms.ListBox();
            this.tblStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStatusTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStatusTableAdapter();
            this.tblCategoryTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter();
            this.tblLocationTableAdapter = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblLocationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printCategoryBtn = new System.Windows.Forms.Button();
            this.printEquipBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesLbx
            // 
            this.categoriesLbx.DataSource = this.tblCategoryBindingSource;
            this.categoriesLbx.DisplayMember = "Cat_Name";
            this.categoriesLbx.FormattingEnabled = true;
            this.categoriesLbx.Location = new System.Drawing.Point(75, 37);
            this.categoriesLbx.Name = "categoriesLbx";
            this.categoriesLbx.ScrollAlwaysVisible = true;
            this.categoriesLbx.Size = new System.Drawing.Size(376, 95);
            this.categoriesLbx.TabIndex = 12;
            this.categoriesLbx.ValueMember = "Cat_ID";
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // lUEquipmentDataSet
            // 
            this.lUEquipmentDataSet.DataSetName = "LUEquipmentDataSet";
            this.lUEquipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationsLbx
            // 
            this.locationsLbx.DataSource = this.tblLocationBindingSource;
            this.locationsLbx.DisplayMember = "Loc_Name";
            this.locationsLbx.FormattingEnabled = true;
            this.locationsLbx.Location = new System.Drawing.Point(75, 174);
            this.locationsLbx.Name = "locationsLbx";
            this.locationsLbx.ScrollAlwaysVisible = true;
            this.locationsLbx.Size = new System.Drawing.Size(376, 95);
            this.locationsLbx.TabIndex = 13;
            this.locationsLbx.ValueMember = "Loc_ID";
            // 
            // tblLocationBindingSource
            // 
            this.tblLocationBindingSource.DataMember = "tblLocation";
            this.tblLocationBindingSource.DataSource = this.lUEquipmentDataSet;
            // 
            // statusLbx
            // 
            this.statusLbx.DataSource = this.tblStatusBindingSource;
            this.statusLbx.DisplayMember = "Status_Name";
            this.statusLbx.FormattingEnabled = true;
            this.statusLbx.Location = new System.Drawing.Point(75, 316);
            this.statusLbx.Name = "statusLbx";
            this.statusLbx.ScrollAlwaysVisible = true;
            this.statusLbx.Size = new System.Drawing.Size(376, 95);
            this.statusLbx.TabIndex = 14;
            this.statusLbx.ValueMember = "Status_ID";
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
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tblLocationTableAdapter
            // 
            this.tblLocationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Status:";
            // 
            // printCategoryBtn
            // 
            this.printCategoryBtn.Location = new System.Drawing.Point(33, 439);
            this.printCategoryBtn.Name = "printCategoryBtn";
            this.printCategoryBtn.Size = new System.Drawing.Size(126, 23);
            this.printCategoryBtn.TabIndex = 18;
            this.printCategoryBtn.Text = "Print Category Report";
            this.printCategoryBtn.UseVisualStyleBackColor = true;
            this.printCategoryBtn.Click += new System.EventHandler(this.printCategoryBtn_Click);
            // 
            // printEquipBtn
            // 
            this.printEquipBtn.Location = new System.Drawing.Point(189, 439);
            this.printEquipBtn.Name = "printEquipBtn";
            this.printEquipBtn.Size = new System.Drawing.Size(127, 23);
            this.printEquipBtn.TabIndex = 19;
            this.printEquipBtn.Text = "Print Equipment Report";
            this.printEquipBtn.UseVisualStyleBackColor = true;
            this.printEquipBtn.Click += new System.EventHandler(this.printEquipBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(361, 439);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // EquipInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 503);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.printEquipBtn);
            this.Controls.Add(this.printCategoryBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLbx);
            this.Controls.Add(this.locationsLbx);
            this.Controls.Add(this.categoriesLbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EquipInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Inventory";
            this.Load += new System.EventHandler(this.EquipInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox categoriesLbx;
        private System.Windows.Forms.ListBox locationsLbx;
        private System.Windows.Forms.ListBox statusLbx;
        private LUEquipmentDataSet lUEquipmentDataSet;
        private System.Windows.Forms.BindingSource tblStatusBindingSource;
        private LUEquipmentDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private LUEquipmentDataSetTableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.BindingSource tblLocationBindingSource;
        private LUEquipmentDataSetTableAdapters.tblLocationTableAdapter tblLocationTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printCategoryBtn;
        private System.Windows.Forms.Button printEquipBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}