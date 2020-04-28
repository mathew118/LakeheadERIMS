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
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_LName FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            lastNameInfoTextBox.Text = command.ExecuteScalar().ToString();

            OleDbCommand command1 = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_FName FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            fristNameInfoTextBox.Text = command.ExecuteScalar().ToString();

            OleDbCommand command2 = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Stu_LAddress FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            addressInfoTextBox.Text = command.ExecuteScalar().ToString();

            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = cnn;
            command3.CommandText = "SELECT Stu_Number FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            numberInfoTextBox.Text = command3.ExecuteScalar().ToString();

            OleDbCommand command4 = new OleDbCommand();
            command4.Connection = cnn;
            command4.CommandText = "SELECT Stu_Email FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            emailInfoTextBox.Text = command4.ExecuteScalar().ToString();

            OleDbCommand command5 = new OleDbCommand();
            command5.Connection = cnn;
            command5.CommandText = "SELECT Stu_LCity FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            cityInfoTextBox.Text = command5.ExecuteScalar().ToString();

            OleDbCommand command6 = new OleDbCommand();
            command6.Connection = cnn;
            command6.CommandText = "SELECT Stu_LProvince FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            provInfoCombo.Text = command6.ExecuteScalar().ToString();

            OleDbCommand command7 = new OleDbCommand();
            command7.Connection = cnn;
            command7.CommandText = "SELECT Stu_LPCode FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            postalInfoText.Text = command7.ExecuteScalar().ToString();

            OleDbCommand command8 = new OleDbCommand();
            command8.Connection = cnn;
            command8.CommandText = "SELECT Stu_LPhone FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            phoneInfoTextBox.Text = command8.ExecuteScalar().ToString();

            OleDbCommand command9 = new OleDbCommand();
            command9.Connection = cnn;
            command9.CommandText = "SELECT Stu_LExt FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            extInfoTextBox.Text = command9.ExecuteScalar().ToString();

            OleDbCommand command10 = new OleDbCommand();
            command10.Connection = cnn;
            command10.CommandText = "SELECT Stu_Owe FROM tblStudent WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            feeTextBox.Text = command10.ExecuteScalar().ToString();
            cnn.Close();
        }

        private void updateStudentBttn_Click(object sender, EventArgs e)
        {
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand commandInsert = new OleDbCommand();
            commandInsert.Connection = cnn;
            commandInsert.CommandText = "UPDATE tblStudent SET STU_LNAME = '" + lastNameInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert.ExecuteScalar();

            OleDbCommand commandInsert1 = new OleDbCommand();
            commandInsert1.Connection = cnn;
            commandInsert1.CommandText = "UPDATE tblStudent SET STU_FNAME = '" + fristNameInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert1.ExecuteScalar();
            cnn.Close();
        }
    }
}
