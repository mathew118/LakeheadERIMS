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
    public partial class addUpdateStudent : Form
    {
        public addUpdateStudent()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void provComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addStudentbttn_Click(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();

            OleDbCommand cmd = new OleDbCommand();

            string command = "insert into tblStudent(Stu_Number, Stu_LName, Stu_FName, Stu_LAddress,Stu_LCity, Stu_LProvince, Stu_LPCode, Stu_LPhone, Stu_LExt, Stu_Email) values('" + newNumberTextBox.Text + "','" + newLastTextBox.Text + "', '"+ newFirstTextBox.Text + "','"+ newAddressTextBox.Text + "', '" + newCityTextBox.Text + "' ,'" + provComboBox.Text + "','" + newPostalCodeTextBox.Text + "' ,'" + NewPhoneTextBox.Text + "','" + newExtTextBox.Text + "','" + newEmailTextBox.Text + "')";
          
            OleDbCommand cmdd = new OleDbCommand(command, cnn);
       
            cmdd.ExecuteNonQuery();
        
            MessageBox.Show("YAYA");

            cnn.Close();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchStudentbttn_Click(object sender, EventArgs e)
        {
            var search = new searchStudent();
            search.Show();
        }
    }
}
