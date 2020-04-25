namespace Lakehead_ERIMS
{
    partial class RentEquipment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.enterBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Number:";
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Location = new System.Drawing.Point(226, 159);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(69, 22);
            this.studentNumberTextBox.TabIndex = 2;
            // 
            // enterBttn
            // 
            this.enterBttn.Location = new System.Drawing.Point(108, 219);
            this.enterBttn.Name = "enterBttn";
            this.enterBttn.Size = new System.Drawing.Size(83, 30);
            this.enterBttn.TabIndex = 3;
            this.enterBttn.Text = "Enter";
            this.enterBttn.UseVisualStyleBackColor = true;
            this.enterBttn.Click += new System.EventHandler(this.enterBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(280, 214);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(83, 40);
            this.exitBttn.TabIndex = 4;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // RentEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 286);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.enterBttn);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentEquipment";
            this.Text = "RentEquipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.Button enterBttn;
        private System.Windows.Forms.Button exitBttn;
    }
}