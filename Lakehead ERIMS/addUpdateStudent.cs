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

        private void studentSearchingBtn_Click(object sender, EventArgs e)
        {
            string searchCriteria = studentSearchingTbx.Text.Trim();

            if (studentLbx.Items.Count > 0)
            {
                if (searchCriteria.Length > 0)
                {
                    string searchColumn = (searchByLNameRbn.Checked) ? "Stu_LName" : "Stu_Number";                   
                    DataRow[] searchResults = this.luEquipmentDataSet1.tblStudent.Select(searchColumn + " = '" + searchCriteria + "'");

                    //Multiple students with same last name can be found.
                    if (searchResults.Length > 0)
                    {
                        string studentLbxFormat = searchResults[0][2].ToString() + ", " + searchResults[0][3].ToString();
                        int studentListboxIndex = studentLbx.FindStringExact(studentLbxFormat);
                        if (studentListboxIndex != -1)
                        {
                            studentLbx.SetSelected(studentListboxIndex, true);
                        }
                        else
                        {
                            MessageBox.Show("Student not found in list.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student not found.", "Error");
                    }                                    
                }
                else
                {
                    MessageBox.Show("Please enter search criteria.", "Error");
                }
            }
            studentSearchingTbx.Clear();
        }

        private void HandleNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void studentFieldChanged(object sender, EventArgs e)
        {
            studentUpdateBtn.Enabled = true;

        }

        private void studentUpdateBtn_Click(object sender, EventArgs e)
        {
            string newStudentNum = studentNumberTbx.Text.Trim();
            string newLastName = studentLNameTbx.Text.Trim();
            string newFirstName = studentFNameTbx.Text.Trim();
            string newEmail = studentEmailTbx.Text.Trim();
            string newLAddress = studentAddressTbx.Text.Trim();
            string newPAddress = studentPAddressTbx.Text.Trim();
            string newLCity = studentCityTbx.Text.Trim();
            string newPCity = studentPCityTbx.Text.Trim();
            string newLPostal = studentPostalTbx.Text.Trim();
            string newPPostal = studentPPostalTbx.Text.Trim();
            string newLPhone = studentPhoneTbx.Text.Trim();
            string newPPhone = studentPPhoneTbx.Text.Trim();
            string newExt = studentExtTbx.Text.Trim();
            string newLProvince = studentProvinceCbx.Text.Trim();
            string newPProvince = studentPProvinceCbx.Text.Trim();
            string newNotes = studentNotesTbx.Text.Trim();
            float newFees = -1;         
            bool newORPT = studentORPTChbx.Checked;

            //Validate Fields
            if (newStudentNum.Length < 1 || !int.TryParse(newStudentNum, out int tempItemNum))
            {
                MessageBox.Show("Student number is invalid.", "Error");
                studentNumberTbx.Clear();
            }
            //If a student with the same number exists and you're adding new, or a student with the same number exists and you're not editing that same student, show an error
            else if ((this.luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + newStudentNum + "'").Length > 0) && (studentLbx.SelectedIndex == -1 || (studentLbx.SelectedIndex != -1 && luEquipmentDataSet1.tblStudent.FindByStu_ID(int.Parse(studentLbx.SelectedValue.ToString())).Stu_Number != newStudentNum)))
            {
                MessageBox.Show("A student with that student number already exists.", "Error");
                studentNumberTbx.Clear();
            }
            else if (newLastName.Length < 1)
            {
                MessageBox.Show("Last name is invalid.", "Error");
                studentLNameTbx.Clear();
            }
            else if (newFirstName.Length < 1)
            {
                MessageBox.Show("First name is invalid.", "Error");
                studentFNameTbx.Clear();
            }
            else if (studentFeesTbx.Text.Trim().Length != 0 && !float.TryParse(studentFeesTbx.Text.Trim(), System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out newFees))
            {
                MessageBox.Show("Fees owing is invalid.", "Error");
                studentFeesTbx.Clear();
            }
            else
            {
                //Update
                if (studentLbx.SelectedIndex != -1)
                {
                    int studentID = -1;
                    int.TryParse(studentLbx.SelectedValue.ToString(), out studentID);
                    int studentListboxIndex = studentLbx.SelectedIndex;

                    if (studentID != -1)
                    {
                        LUEquipmentDataSet.tblStudentRow studentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(studentID);

                        if (!string.IsNullOrEmpty(newEmail)) { studentRow.Stu_Email = newEmail; } else { studentRow.SetStu_EmailNull(); }
                        if (!string.IsNullOrEmpty(newLAddress)) { studentRow.Stu_LAddress = newLAddress; } else { studentRow.SetStu_LAddressNull(); }
                        if (!string.IsNullOrEmpty(newPAddress)) { studentRow.Stu_HAddress = newPAddress; } else { studentRow.SetStu_HAddressNull(); }
                        if (!string.IsNullOrEmpty(newLCity)) { studentRow.Stu_LCity = newLCity; } else { studentRow.SetStu_LCityNull(); }
                        if (!string.IsNullOrEmpty(newPCity)) { studentRow.Stu_HCity = newPCity; } else { studentRow.SetStu_HCityNull(); }
                        if (!string.IsNullOrEmpty(newLPostal)) { studentRow.Stu_LPCode = newLPostal; } else { studentRow.SetStu_LPCodeNull(); }
                        if (!string.IsNullOrEmpty(newPPostal)) { studentRow.Stu_HPCode = newPPostal; } else { studentRow.SetStu_HPCodeNull(); }
                        if (!string.IsNullOrEmpty(newLPhone)) { studentRow.Stu_LPhone = newLPhone; } else { studentRow.SetStu_LPhoneNull(); }
                        if (!string.IsNullOrEmpty(newPPhone)) { studentRow.Stu_HPhone = newPPhone; } else { studentRow.SetStu_HPhoneNull(); }
                        if (!string.IsNullOrEmpty(newExt)) { studentRow.Stu_LExt = newExt; } else { studentRow.SetStu_LExtNull(); }
                        if (!string.IsNullOrEmpty(newLProvince)) { studentRow.Stu_LProvince = newLProvince; } else { studentRow.SetStu_LProvinceNull(); }
                        if (!string.IsNullOrEmpty(newPProvince)) { studentRow.Stu_HProvince = newPProvince; } else { studentRow.SetStu_HProvinceNull(); }
                        if (!string.IsNullOrEmpty(newNotes)) { studentRow.Stu_Notes = newNotes; } else { studentRow.SetStu_NotesNull(); }
                        if (newFees != -1) { studentRow.Stu_Owe = newFees; } else { studentRow.SetStu_OweNull(); }
                        studentRow.Stu_ORPT = newORPT;
                        studentRow.Stu_Number = newStudentNum;
                        studentRow.Stu_LName = newLastName;
                        studentRow.Stu_FName = newFirstName;

                        tblStudentTableAdapter1.Update(studentRow);
                        this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);

                        //Maintain current row selection
                        studentListboxIndex = studentLbx.FindStringExact(newLastName + ", " + newFirstName);
                        if (studentListboxIndex != -1)
                        {
                            studentLbx.SetSelected(studentListboxIndex, true);
                        }
                        studentUpdateBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Student does not exist.", "Error");
                    }
                }
                //Add New
                else
                {
                    tblStudentTableAdapter1.Insert(newStudentNum, newLastName, newFirstName, (!string.IsNullOrEmpty(newLAddress)) ? newLAddress : null, (!string.IsNullOrEmpty(newLCity)) ? newLCity : null, (!string.IsNullOrEmpty(newLProvince)) ? newLProvince : null, (!string.IsNullOrEmpty(newLPostal)) ? newLPostal : null, (!string.IsNullOrEmpty(newLPhone)) ? newLPhone : null, (!string.IsNullOrEmpty(newExt)) ? newExt : null, (!string.IsNullOrEmpty(newEmail)) ? newEmail : null, (!string.IsNullOrEmpty(newPAddress)) ? newPAddress : null, (!string.IsNullOrEmpty(newPCity)) ? newPCity : null, (!string.IsNullOrEmpty(newPProvince)) ? newPProvince : null, (!string.IsNullOrEmpty(newPPostal)) ? newPPostal : null, (!string.IsNullOrEmpty(newPPhone)) ? newPPhone : null, (!string.IsNullOrEmpty(newNotes)) ? newNotes : null, (newFees != -1) ? newFees : (float?)null, newORPT);
                    this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);

                    //Maintain current row selection
                    int studentListboxIndex = studentLbx.FindStringExact(newLastName + ", " + newFirstName);
                    if (studentListboxIndex != -1)
                    {
                        studentLbx.SetSelected(studentListboxIndex, true);
                    }
                    studentUpdateBtn.Enabled = false;
                }
            }           
        }
    }
}
