namespace Lakehead_ERIMS
{
    partial class FeeDialog
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
            this.lateFeesGbx = new System.Windows.Forms.GroupBox();
            this.invoiceLateFeesTbx = new System.Windows.Forms.TextBox();
            this.accumulateLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.payLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.waiveLateFeesCbx = new System.Windows.Forms.RadioButton();
            this.invoiceLateFeesLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.invoiceNumberTbx = new System.Windows.Forms.TextBox();
            this.invoiceNumberLbl = new System.Windows.Forms.Label();
            this.tblRentalTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblRentalTableAdapter();
            this.tblStudentTableAdapter1 = new Lakehead_ERIMS.LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            this.luEquipmentDataSet1 = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.lateFeesGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lateFeesGbx
            // 
            this.lateFeesGbx.Controls.Add(this.invoiceLateFeesTbx);
            this.lateFeesGbx.Controls.Add(this.accumulateLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.payLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.waiveLateFeesCbx);
            this.lateFeesGbx.Controls.Add(this.invoiceLateFeesLbl);
            this.lateFeesGbx.Location = new System.Drawing.Point(11, 11);
            this.lateFeesGbx.Margin = new System.Windows.Forms.Padding(2);
            this.lateFeesGbx.Name = "lateFeesGbx";
            this.lateFeesGbx.Padding = new System.Windows.Forms.Padding(2);
            this.lateFeesGbx.Size = new System.Drawing.Size(243, 112);
            this.lateFeesGbx.TabIndex = 1;
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
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(179, 171);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 4;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // invoiceNumberTbx
            // 
            this.invoiceNumberTbx.Location = new System.Drawing.Point(72, 128);
            this.invoiceNumberTbx.MaxLength = 3;
            this.invoiceNumberTbx.Name = "invoiceNumberTbx";
            this.invoiceNumberTbx.ReadOnly = true;
            this.invoiceNumberTbx.Size = new System.Drawing.Size(173, 20);
            this.invoiceNumberTbx.TabIndex = 4;
            // 
            // invoiceNumberLbl
            // 
            this.invoiceNumberLbl.AutoSize = true;
            this.invoiceNumberLbl.Location = new System.Drawing.Point(22, 131);
            this.invoiceNumberLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invoiceNumberLbl.Name = "invoiceNumberLbl";
            this.invoiceNumberLbl.Size = new System.Drawing.Size(45, 13);
            this.invoiceNumberLbl.TabIndex = 5;
            this.invoiceNumberLbl.Text = "Invoice:";
            // 
            // tblRentalTableAdapter1
            // 
            this.tblRentalTableAdapter1.ClearBeforeFill = true;
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
            // FeeDialog
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 213);
            this.Controls.Add(this.invoiceNumberTbx);
            this.Controls.Add(this.invoiceNumberLbl);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.lateFeesGbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FeeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Fee Option";
            this.Load += new System.EventHandler(this.FeeDialog_Load);
            this.lateFeesGbx.ResumeLayout(false);
            this.lateFeesGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luEquipmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lateFeesGbx;
        private System.Windows.Forms.TextBox invoiceLateFeesTbx;
        private System.Windows.Forms.RadioButton accumulateLateFeesCbx;
        private System.Windows.Forms.RadioButton payLateFeesCbx;
        private System.Windows.Forms.RadioButton waiveLateFeesCbx;
        private System.Windows.Forms.Label invoiceLateFeesLbl;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox invoiceNumberTbx;
        private System.Windows.Forms.Label invoiceNumberLbl;
        private LUEquipmentDataSetTableAdapters.tblRentalTableAdapter tblRentalTableAdapter1;
        private LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter1;
        private LUEquipmentDataSet luEquipmentDataSet1;
    }
}