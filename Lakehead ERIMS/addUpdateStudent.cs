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

            tblStudentTableAdapter1.Insert(newNumberTextBox.Text, newLastTextBox.Text, newFirstTextBox.Text, newAddressTextBox.Text, newCityTextBox.Text, provComboBox.Text, newPostalCodeTextBox.Text, NewPhoneTextBox.Text, newExtTextBox.Text, newEmailTextBox.Text, " ", " ", " ", " ", " ", " ", 0, true);
            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            MessageBox.Show("Added student");

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchStudentbttn_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Student Number not found");
            }
       
        }

        private void updateStudentBttn_Click(object sender, EventArgs e)
        {

            int stuNumber = Convert.ToInt32(studentNumberTextBox);

            LUEquipmentDataSet.tblStudentRow studentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(stuNumber);
            studentRow.Stu_Email = emailInfoTextBox.Text;
            studentRow.Stu_FName = fristNameInfoTextBox.Text;
            studentRow.Stu_LName = lastNameInfoTextBox.Text;
            studentRow.Stu_LAddress = addressInfoTextBox.Text;
            studentRow.Stu_LCity = cityInfoTextBox.Text;
            studentRow.Stu_LProvince = provComboBox.Text;
            studentRow.Stu_LPCode = postalInfoText.Text;
            studentRow.Stu_LPhone = phoneInfoTextBox.Text;
            studentRow.Stu_LExt = extInfoTextBox.Text;
            float fees = float.Parse(feeTextBox.Text);
            studentRow.Stu_Owe = fees;
            MessageBox.Show("Updated Successfully");
            tblStudentTableAdapter1.Update(studentRow);

            
        }
    }
}
