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

        //Combine add and update sections
        //Implement ORPT checkbox

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

        private void addUpdateStudent_Shown(object sender, EventArgs e)
        {
            this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
            studentLbx.SelectedIndex = -1;
        }

        private void studentLbx_Format(object sender, ListControlConvertEventArgs e)
        {
            string studentFName = ((DataRowView)e.ListItem)[3].ToString();

            e.Value += ", " + studentFName;
        }

        private void studentLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEquipmentDataSet.tblStudentRow studentRow;

            //Checks if listbox isn't empty
            if (studentLbx.SelectedValue != null && studentLbx.SelectedIndex != -1)
            {
                //Checks if query returns results and if so, assigns it to studentRow
                if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + studentLbx.SelectedValue.ToString() + "'").Length == 1)
                {
                    studentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(int.Parse(studentLbx.SelectedValue.ToString()));

                    //Assigns row data to textboxes
                    studentLNameTbx.Text = studentRow.Stu_LName; //Cannot be null
                    studentFNameTbx.Text = studentRow.Stu_FName; //Cannot be null
                    studentNumberTbx.Text = studentRow.Stu_Number; //Cannot be null
                    studentEmailTbx.Text = (!studentRow.IsStu_EmailNull()) ? studentRow.Stu_Email : string.Empty;
                    studentAddressTbx.Text = (!studentRow.IsStu_LAddressNull()) ? studentRow.Stu_LAddress : string.Empty;
                    studentCityTbx.Text = (!studentRow.IsStu_LCityNull()) ? studentRow.Stu_LCity : string.Empty;
                    studentPostalTbx.Text = (!studentRow.IsStu_LPCodeNull()) ? studentRow.Stu_LPCode : string.Empty;
                    studentPhoneTbx.Text = (!studentRow.IsStu_LPhoneNull()) ? studentRow.Stu_LPhone : string.Empty;
                    studentExtTbx.Text = (!studentRow.IsStu_LExtNull()) ? studentRow.Stu_LExt : string.Empty;
                    studentPAddressTbx.Text = (!studentRow.IsStu_HAddressNull()) ? studentRow.Stu_HAddress : string.Empty;
                    studentPCityTbx.Text = (!studentRow.IsStu_HCityNull()) ? studentRow.Stu_HCity : string.Empty;
                    studentPPostalTbx.Text = (!studentRow.IsStu_HPCodeNull()) ? studentRow.Stu_HPCode : string.Empty;
                    studentPPhoneTbx.Text = (!studentRow.IsStu_HPhoneNull()) ? studentRow.Stu_HPhone : string.Empty;
                    studentFeesTbx.Text = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe.ToString("C") : string.Empty;                
                    studentORPTChbx.Checked = (!studentRow.IsStu_ORPTNull()) ? studentRow.Stu_ORPT : false;
                    studentNotesTbx.Text = (!studentRow.IsStu_NotesNull()) ? studentRow.Stu_Notes : string.Empty;

                    //Getting issues where empty province in database isn't null but instead empty
                    studentProvinceCbx.SelectedIndex = -1;
                    studentPProvinceCbx.SelectedIndex = -1;
                    if (!studentRow.IsStu_LProvinceNull())
                    {
                        if (!string.IsNullOrEmpty(studentRow.Stu_LProvince))
                        {
                            studentProvinceCbx.Text = studentRow.Stu_LProvince;
                        }
                    }

                    if (!studentRow.IsStu_HProvinceNull())
                    {
                        if (!string.IsNullOrEmpty(studentRow.Stu_HProvince))
                        {
                            studentPProvinceCbx.Text = studentRow.Stu_HProvince;
                        }                     
                    }                                                          

                    //Lock save button until changes are made
                    studentUpdateBtn.Enabled = false;
                }
                else
                {
                    //No student selected

                    MessageBox.Show("Error! Student not found", "Error");
                }
            }
        }

        private void studentAddNewBtn_Click(object sender, EventArgs e)
        {
            studentLbx.SelectedIndex = -1;
            studentLNameTbx.Clear();
            studentFNameTbx.Clear();
            studentNumberTbx.Clear();
            studentEmailTbx.Clear();
            studentAddressTbx.Clear();
            studentCityTbx.Clear();
            studentPostalTbx.Clear();
            studentPhoneTbx.Clear();
            studentExtTbx.Clear();
            studentPAddressTbx.Clear();
            studentPCityTbx.Clear();
            studentPPostalTbx.Clear();
            studentPPhoneTbx.Clear();
            studentFeesTbx.Clear();
            studentORPTChbx.Checked = false;
            studentNotesTbx.Clear();
            studentProvinceCbx.SelectedIndex = -1;
            studentPProvinceCbx.SelectedIndex = -1;

            studentUpdateBtn.Enabled = true;
        }
    }
}
