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

       
            LUEquipmentDataSetTableAdapters.tblStudentTableAdapter studentTableAdapter = new LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            studentTableAdapter.Insert(newNumberTextBox.Text,newLastTextBox.Text,newFirstTextBox.Text,newAddressTextBox.Text,newCityTextBox.Text,provComboBox.Text,newPostalCodeTextBox.Text,NewPhoneTextBox.Text,newExtTextBox.Text,newEmailTextBox.Text, " ", " ", " ", " "," "," ",0,true);
            MessageBox.Show("Added student");
            

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchStudentbttn_Click(object sender, EventArgs e)
        {

            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            DataRow info;
            info = luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTextBox.Text + "'")[0];
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
       
        }

        private void updateStudentBttn_Click(object sender, EventArgs e)
        {
            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            DataRow id;
            id = luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTextBox.Text + "'")[0];
            string studentId = id[0].ToString();
            int intStudentId = Int32.Parse(studentId);
            float fee = (float)Convert.ToDouble(feeTextBox.Text);


            LUEquipmentDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter = new LUEquipmentDataSetTableAdapters.tblStudentTableAdapter();
            tblStudentTableAdapter.Update(numberInfoTextBox.Text, lastNameInfoTextBox.Text, fristNameInfoTextBox.Text, addressInfoTextBox.Text, cityInfoTextBox.Text, provInfoCombo.Text, postalInfoText.Text, phoneInfoTextBox.Text, extInfoTextBox.Text, emailInfoTextBox.Text, "", "", "", "", "", "", fee, true, intStudentId, studentNumberTextBox.Text, lastNameInfoTextBox.Text, fristNameInfoTextBox.Text, addressInfoTextBox.Text, cityInfoTextBox.Text, provInfoCombo.Text, postalInfoText.Text, phoneInfoTextBox.Text, extInfoTextBox.Text, emailInfoTextBox.Text, "", "", "", "", "", "", fee, true);
            MessageBox.Show("Updated");
            //LUEquipmentDataSetTableAdapters.tblStudentTableAdapter
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
