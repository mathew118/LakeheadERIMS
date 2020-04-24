namespace Lakehead_ERIMS
{
    partial class searchStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stuendtGridView = new System.Windows.Forms.DataGridView();
            this.lUEquipmentDataSet = new Lakehead_ERIMS.LUEquipmentDataSet();
            this.lUEquipmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stuendtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A Student Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // lastNameSearchTextBox
            // 
            this.lastNameSearchTextBox.Location = new System.Drawing.Point(172, 93);
            this.lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            this.lastNameSearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameSearchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(64, 135);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 30);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(204, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stuendtGridView
            // 
            this.stuendtGridView.AutoGenerateColumns = false;
            this.stuendtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuendtGridView.DataSource = this.lUEquipmentDataSetBindingSource;
            this.stuendtGridView.Location = new System.Drawing.Point(85, 194);
            this.stuendtGridView.Name = "stuendtGridView";
            this.stuendtGridView.RowTemplate.Height = 24;
            this.stuendtGridView.Size = new System.Drawing.Size(445, 196);
            this.stuendtGridView.TabIndex = 5;
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
            // searchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 423);
            this.Controls.Add(this.stuendtGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameSearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchStudent";
            this.Text = "searchStudent";
            this.Load += new System.EventHandler(this.searchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuendtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUEquipmentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView stuendtGridView;
        private System.Windows.Forms.BindingSource lUEquipmentDataSetBindingSource;
        private LUEquipmentDataSet lUEquipmentDataSet;
    }
}