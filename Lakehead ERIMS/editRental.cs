using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lakehead_ERIMS
{
    public partial class editRental : Form
    {
        public editRental()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rentalLbx_Format(object sender, ListControlConvertEventArgs e)
        {
            if (luEquipmentDataSet1.tblStudent.Count == 0)
            {
                tblStudentTableAdapter1.Fill(luEquipmentDataSet1.tblStudent);
            }


            try
            {
                int studentID = int.Parse(((DataRowView)e.ListItem)[1].ToString());
                LUEquipmentDataSet.tblStudentRow invStudentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(studentID);

                e.Value += " - " + invStudentRow.Stu_FName + " " + invStudentRow.Stu_LName;
            }
            catch
            {
                //Display only invoice number if student is not found

            }
            
        }

        private void editRental_Load(object sender, EventArgs e)
        {
            tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

            if (luEquipmentDataSet1.tblStudent.Count == 0)
            {
                tblStudentTableAdapter1.Fill(luEquipmentDataSet1.tblStudent);
            }
        }

        private void RentalDpk_ValueChanged(object sender, EventArgs e)
        {
            //The DateTime.Today is so when the datepicker is opened it doesn't start at 1899 and instead starts at today.
            //Should rework

            DateTimePicker sendingDpk = (DateTimePicker)sender;

            if (sendingDpk.Value == DateTime.FromOADate(0))
            {
                sendingDpk.Format = DateTimePickerFormat.Custom;
                sendingDpk.CustomFormat = " ";
                sendingDpk.Value = DateTime.Today;
            }
            else if (sendingDpk.Value != DateTime.Today)
            {
                sendingDpk.Format = DateTimePickerFormat.Long;
            }

            RentalFieldChanged(sender, e);
        }

        private void RentalDpk_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker sendingDpk = (DateTimePicker)sender;

            if (sendingDpk.Value == DateTime.Today)
            {
                sendingDpk.Format = DateTimePickerFormat.Long;
                RentalFieldChanged(sender, e);
            }
        }

        private void RentalFieldChanged(object sender, EventArgs e)
        {
            updateRentalBtn.Enabled = true;
        }

        private void rentalLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LUEquipmentDataSet.tblRentalRow rentalRow;
            LUEquipmentDataSet.tblStudentRow studentRow;

            //Checks if listbox isn't empty
            if (rentalLbx.SelectedValue != null && rentalLbx.SelectedIndex != -1)
            {
                //Checks if query returns results and if so, assigns it to rentalRow
                if (this.luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalLbx.SelectedValue.ToString() + "'").Length > 0)
                {
                    rentalRow = (LUEquipmentDataSet.tblRentalRow)luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalLbx.SelectedValue.ToString() + "'")[0];

                    //Assigns values to textboxes
                    studentCourseTbx.Text = (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : string.Empty;

                    //Attempts to get student information
                    if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + ((!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : -1) + "'").Length > 0)
                    {
                        studentRow = (LUEquipmentDataSet.tblStudentRow)this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + rentalRow.Stu_ID + "'")[0];

                        studentNumberTbx.Text = (!studentRow.IsStu_NumberNull()) ? studentRow.Stu_Number : string.Empty;
                        studentNameTbx.Text = ((!studentRow.IsStu_FNameNull()) ? studentRow.Stu_FName : string.Empty) + " " + ((!studentRow.IsStu_LNameNull()) ? studentRow.Stu_LName : string.Empty);
                        studentAddressTbx.Text = (!studentRow.IsStu_LAddressNull()) ? studentRow.Stu_LAddress : string.Empty;
                        studentPhoneTbx.Text = (!studentRow.IsStu_LPhoneNull()) ? studentRow.Stu_LPhone : string.Empty;
                    }

                }
                else
                {
                    //No rental selected

                    MessageBox.Show("Error! Rental not found", "Error");
                }
            }
        }

        private void itemNumberTbx_TextChanged(object sender, EventArgs e)
        {
            int totalLength = itemNumberATbx.Text.Length + itemNumberBTbx.Text.Length;
            if (totalLength == 6)
            {
                //Add item

            }
        }
    }
}
