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
    public partial class RentForm : Form
    {
        public RentForm()
        {
            InitializeComponent();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table. You can move, or remove it, as needed.
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Equip_Numb FROM tblEquip WHERE Equip_Numb = '" + equipNumbTextBox.Text + "'";
            var dataAdpater = new OleDbDataAdapter(command.CommandText, cnn);

            var commandBuilder = new OleDbCommandBuilder(dataAdpater);
            var ds = new DataSet();
            dataAdpater.Fill(ds);
            rentItemGridView.ReadOnly = true;
            rentItemGridView.DataSource = ds.Tables[0];
            cnn.Close();
        }

        private void enterStudentNumberButton_Click(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_FName FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentFNameLabel.Text = command.ExecuteScalar().ToString();

            cnn.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
