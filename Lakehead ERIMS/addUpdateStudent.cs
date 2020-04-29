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

            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            DataRow info;
            MessageBox.Show(studentNumberTextBox.Text);
            info = luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTextBox.Text + "'")[1];
            lastNameInfoTextBox.Text = info[2].ToString();
            fristNameInfoTextBox.Text = info[3].ToString();
            numberInfoTextBox.Text = info[1].ToString();
            emailInfoTextBox.Text = info[10].ToString();
            addressInfoTextBox.Text = info[4].ToString();
            cityInfoTextBox.Text = info[5].ToString();
            provInfoCombo.Text = info[6].ToString();
            postalInfoText.Text = info[7].ToString();
            phoneInfoTextBox.Text = info[8].ToString();
            extInfoTextBox.Text = info[9].ToString();
            feeTextBox.Text = info[17].ToString();
            /*
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
            */
        }

        private void updateStudentBttn_Click(object sender, EventArgs e)
        {

            /*
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand commandInsert = new OleDbCommand();
            commandInsert.Connection = cnn;
            commandInsert.CommandText = "UPDATE tblStudent SET STU_LName = '" + lastNameInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert.ExecuteScalar();

            OleDbCommand commandInsert1 = new OleDbCommand();
            commandInsert1.Connection = cnn;
            commandInsert1.CommandText = "UPDATE tblStudent SET STU_FName = '" + fristNameInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert1.ExecuteScalar();

            OleDbCommand commandInsert2 = new OleDbCommand();
            commandInsert2.Connection = cnn;
            commandInsert2.CommandText = "UPDATE tblStudent SET STU_Number = '" + numberInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert2.ExecuteScalar();

            OleDbCommand commandInsert3 = new OleDbCommand();
            commandInsert3.Connection = cnn;
            commandInsert3.CommandText = "UPDATE tblStudent SET STU_LAddress = '" + addressInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert3.ExecuteScalar();

            OleDbCommand commandInsert4 = new OleDbCommand();
            commandInsert4.Connection = cnn;
            commandInsert4.CommandText = "UPDATE tblStudent SET STU_Email = '" + emailInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert4.ExecuteScalar();

            OleDbCommand commandInsert5 = new OleDbCommand();
            commandInsert5.Connection = cnn;
            commandInsert5.CommandText = "UPDATE tblStudent SET STU_LCity = '" + cityInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert5.ExecuteScalar();

            OleDbCommand commandInsert6 = new OleDbCommand();
            commandInsert6.Connection = cnn;
            commandInsert6.CommandText = "UPDATE tblStudent SET STU_LProvince = '" + provInfoCombo.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert6.ExecuteScalar();

            OleDbCommand commandInsert7 = new OleDbCommand();
            commandInsert7.Connection = cnn;
            commandInsert7.CommandText = "UPDATE tblStudent SET STU_LPCode = '" + postalInfoText.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert7.ExecuteScalar();

            OleDbCommand commandInsert8 = new OleDbCommand();
            commandInsert8.Connection = cnn;
            commandInsert8.CommandText = "UPDATE tblStudent SET STU_LPhone = '" + phoneInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert8.ExecuteScalar();

            OleDbCommand commandInsert9 = new OleDbCommand();
            commandInsert9.Connection = cnn;
            commandInsert9.CommandText = "UPDATE tblStudent SET STU_LExt = '" + extInfoTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert9.ExecuteScalar();

            OleDbCommand commandInsert10 = new OleDbCommand();
            commandInsert10.Connection = cnn;
            commandInsert10.CommandText = "UPDATE tblStudent SET STU_owe = '" + feeTextBox.Text + "' WHERE Stu_Number = '" + studentNumberTextBox.Text + "'";
            commandInsert10.ExecuteScalar();
            cnn.Close();
            */
        }
    }
}
