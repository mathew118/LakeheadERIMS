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

        private void addButton_Click(object sender, EventArgs e)
        {
          
            foreach(DataGridViewRow dr in dataGridView1.SelectedRows.OfType<DataGridViewRow>().ToArray())
            {
                dataGridView1.Rows.Remove(dr);
                dataGridView2.Rows.Add(dr);
            }


        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand commandNumber = new OleDbCommand();
            commandNumber.Connection = cnn;
            string select = "SELECT Equip_Number FROM tblEquip WHERE Equip_Number = '" + equipNumbTextBox.Text + "'";
            commandNumber.CommandText = "SELECT Equip_Number, Equip_Name, Equip_RentalPrice FROM tblEquip WHERE Equip_Number = '" + equipNumbTextBox.Text + "'";
            OleDbCommand commandName = new OleDbCommand();
            commandName.Connection = cnn;
            commandName.CommandText = "SELECT Equip_Name FROM tblEquip WHERE Equip_Number = '" + equipNumbTextBox.Text + "'";
            OleDbCommand commandRental = new OleDbCommand();
            commandRental.Connection = cnn;
            commandRental.CommandText = "SELECT Equip_RentalPrice FROM tblEquip WHERE Equip_Number = '" + equipNumbTextBox.Text + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commandNumber);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            


            cnn.Close();
        }
    }
}
