using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lakehead_ERIMS
{
    public partial class searchStudent : Form
    {
        public searchStudent()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();

            OleDbDataAdapter adapt = new OleDbDataAdapter("SELECT * FROM tblStudent WHERE Stu_LName like '" + lastNameSearchTextBox.Text + "'", cnn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            stuendtGridView.DataSource = dt;
            MessageBox.Show("Hello");
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchStudent_Load(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter("select * from tblStudent", cnn);
            DataSet set = new DataSet();
            adapt.Fill(set, "tblStudent");

            DataTable dt = new DataTable();
            
            stuendtGridView.DataSource = dt;
            cnn.Close();
        }
    }
}
