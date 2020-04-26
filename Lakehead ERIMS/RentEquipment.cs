using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lakehead_ERIMS
{
    public partial class RentEquipment : Form
    {
        
        public RentEquipment()
        {
            InitializeComponent();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBttn_Click(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_Number FROM tblStudent WHERE Stu_Number = '"+ studentNumberTextBox.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            var rentform = new RentForm();

            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                rentform.Show();
            }
            
            else
            {
                MessageBox.Show("Invalid Student Number");
            }
            cnn.Close();

        }
    }

}
