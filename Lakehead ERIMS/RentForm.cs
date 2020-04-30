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
    public partial class form : Form
    {
        public form()
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
            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            DataRow info;
            info = luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTextBox.Text + "'")[0];
            studentNumberLabel.Text = info[1].ToString();
            studentFNameLabel.Text = info[3].ToString();
            studentLNameLabel.Text = info[2].ToString();
            studentAddressLabe.Text = info[4].ToString();
            studentPhone.Text = info[8].ToString();
         
            /*
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_FName FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentFNameLabel.Text = command.ExecuteScalar().ToString();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = cnn;
            command1.CommandText = "SELECT Stu_LName FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentLNameLabel.Text = command1.ExecuteScalar().ToString();

            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = cnn;
            command2.CommandText = "SELECT Stu_Number FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentNumberLabel.Text = command2.ExecuteScalar().ToString();

            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = cnn;
            command3.CommandText = "SELECT Stu_LAddress FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentAddressLabe.Text = command3.ExecuteScalar().ToString();

            OleDbCommand command4 = new OleDbCommand();
            command4.Connection = cnn;
            command4.CommandText = "SELECT Stu_LPhone FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            studentPhone.Text = command4.ExecuteScalar().ToString();

            OleDbCommand command5 = new OleDbCommand();
            command5.Connection = cnn;
            command5.CommandText = "SELECT Stu_Owe FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            feeTextBox.Text = command5.ExecuteScalar().ToString();

            cnn.Close();
            */
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
            DataRow equipmentrow;
            equipmentrow = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumbTextBox.Text + "'")[0];
            
            itemGridView.Rows.Add(itemGridView.Rows[x].Cells[0].Value = equipmentrow[1].ToString(), itemGridView.Rows[x].Cells[1].Value = equipmentrow[2].ToString(), itemGridView.Rows[x].Cells[2].Value = equipmentrow[13].ToString());
            x++;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemGridView.SelectedRows)
            {
                itemGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in itemGridView.Rows)
                {
                    try
                    {
                        itemGridView.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (itemGridView.Rows.Count > 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calcCost_Click(object sender, EventArgs e)
        {
            double finalCost;
            foreach (DataGridViewRow row in itemGridView.Rows)
            {

                int n = row.Index;
                string final = (Double.Parse(itemGridView.Rows[n].Cells[2].Value.ToString()).ToString());
                n++;

                MessageBox.Show(final);
                
               
            }

        }
    }
}
