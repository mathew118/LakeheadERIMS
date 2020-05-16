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

        /*
            Voiding seems to make the invoice number no longer valid? removes the rental entry?
            Quantity seems to display the total number of rentals, not the quantity of a particular item
            Entering an item number adds the equipment to the rental list
            Waiving subtotal pretty much makes the rental free (It calculates into the tax)

            Is equip nights calculated from the values in the rental table? or is it modified each time a
            rental is created or modified

            Set textbox max lengths
            tab index
            item number autotabbing
            How does it keep track of waives?
        */


        public LUEquipmentDataSet.tblRentalDataTable uniqueInvoices = new LUEquipmentDataSet.tblRentalDataTable();

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

        private void editRental_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (luEquipmentDataSet1.tblStudent.Count == 0)
            {
                tblStudentTableAdapter1.Fill(luEquipmentDataSet1.tblStudent);
            }

            updateRentalList();
            rentalLbx.SelectedIndex = -1;
        }

        private void updateRentalList()
        {
            tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);
            uniqueInvoices.Clear();

            List<int> addedInvoices = new List<int>();
            foreach (LUEquipmentDataSet.tblRentalRow rentalRow in luEquipmentDataSet1.tblRental)
            {
                if (!addedInvoices.Contains(rentalRow.Inv_Num))
                {
                    addedInvoices.Add(rentalRow.Inv_Num);
                    uniqueInvoices.ImportRow(rentalRow);
                }
            }

            uniqueInvoices.DefaultView.Sort = "Inv_Num";
            rentalLbx.DataSource = uniqueInvoices;
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

        private void clearFields()
        {
            studentCourseTbx.Clear();
            rentalDateDueDpk.Value = DateTime.FromOADate(0);
            rentalDateOutDpk.Value = DateTime.FromOADate(0);
            studentNumberTbx.Clear();
            studentNameTbx.Clear();
            studentAddressTbx.Clear();
            studentPhoneTbx.Clear();
            itemNumberATbx.Clear();
            itemNumberBTbx.Clear();
            itemQuantityTbx.Clear();
            paymentRentalDaysTbx.Clear();
            paymentOtherFeesTbx.Clear();
            paymentSubtotalTbx.Clear();
            paymentPSTTbx.Clear();
            paymentGSTTbx.Clear();
            paymentTotalTbx.Clear();
            paymentSubtotalWaiveChbx.Checked = false;
            paymentPSTWaiveChbx.Checked = false;
            paymentGSTWaiveChbx.Checked = false;
            rentalItemsDgv.Rows.Clear();
            removeAllItemsBtn.Enabled = false;
            deleteItemBtn.Enabled = false;
            itemNumberATbx.Enabled = false;
            itemNumberBTbx.Enabled = false;
        }

        private void rentalLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFields();

            LUEquipmentDataSet.tblRentalRow rentalRow;
            LUEquipmentDataSet.tblStudentRow studentRow;

            //Checks if listbox isn't empty
            if (rentalLbx.SelectedValue != null && rentalLbx.SelectedIndex != -1)
            {
                //Checks if query returns results and if so, assigns it to rentalRow
                DataRow[] searchResults = this.luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalLbx.SelectedValue.ToString() + "'");
                if (searchResults.Length > 0)
                {
                    rentalRow = (LUEquipmentDataSet.tblRentalRow)searchResults[0];

                    //Assigns values to textboxes
                    studentCourseTbx.Text = (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : string.Empty;
                    rentalDateDueDpk.Value = (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : DateTime.FromOADate(0);
                    rentalDateOutDpk.Value = (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : DateTime.FromOADate(0);

                    if(rentalDateDueDpk.Value == DateTime.FromOADate(0)) { rentalDateDueDpk.Format = DateTimePickerFormat.Custom; } else { rentalDateDueDpk.Format = DateTimePickerFormat.Long; }
                    if (rentalDateOutDpk.Value == DateTime.FromOADate(0)) { rentalDateOutDpk.Format = DateTimePickerFormat.Custom; } else { rentalDateOutDpk.Format = DateTimePickerFormat.Long; }

                    //Attempts to get student information
                    if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + ((!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : -1) + "'").Length > 0)
                    {
                        studentRow = (LUEquipmentDataSet.tblStudentRow)this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + rentalRow.Stu_ID + "'")[0];

                        studentNumberTbx.Text = (!studentRow.IsStu_NumberNull()) ? studentRow.Stu_Number : string.Empty;
                        studentNameTbx.Text = ((!studentRow.IsStu_FNameNull()) ? studentRow.Stu_FName : string.Empty) + " " + ((!studentRow.IsStu_LNameNull()) ? studentRow.Stu_LName : string.Empty);
                        studentAddressTbx.Text = (!studentRow.IsStu_LAddressNull()) ? studentRow.Stu_LAddress : string.Empty;
                        studentPhoneTbx.Text = (!studentRow.IsStu_LPhoneNull()) ? studentRow.Stu_LPhone : string.Empty;
                    }

                    //Get items
                    if(luEquipmentDataSet1.tblEquip.Count == 0)
                    {
                        tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);
                    }

                    itemQuantityTbx.Text = searchResults.Length.ToString();
                    removeAllItemsBtn.Enabled = true;
                    itemNumberATbx.Enabled = true;
                    itemNumberBTbx.Enabled = true;
                    foreach (DataRow row in searchResults)
                    {
                        try
                        {
                            LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(int.Parse(row[0].ToString()));                           
                            rentalItemsDgv.Rows.Add(equipmentRow.Equip_Number, equipmentRow.Equip_Name, equipmentRow.Equip_RentalPrice.ToString("C"));                          
                        }
                        catch
                        {
                            //Equip ID doesn't match any item in tblEquip
                            rentalItemsDgv.Rows.Add(row[0].ToString() + " (ID)", "Equipment Not Found", "");
                        }
                    }

                    updateRentalBtn.Enabled = false;
                    rentalItemsDgv.ClearSelection();

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
            if (totalLength == 6 && rentalLbx.SelectedIndex != -1)
            {
                if (luEquipmentDataSet1.tblEquip.Count == 0)
                {
                    tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);
                }

                //Add item
                try
                {
                    string equipNum = itemNumberATbx.Text + itemNumberBTbx.Text;
                    MessageBox.Show(equipNum);

                    if(this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'").Length > 0)
                    {
                        int equipID = int.Parse(this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'")[0][0].ToString());
                        LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(equipID);

                        rentalItemsDgv.Rows.Add(equipmentRow.Equip_Number, equipmentRow.Equip_Name, equipmentRow.Equip_RentalPrice.ToString("C"));

                        updateRentalBtn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Equipment not found.", "Error");
                    }
                }
                catch
                {
                    MessageBox.Show("Equipment not found.", "Error");
                }

                itemNumberATbx.Clear();
                itemNumberBTbx.Clear();
            }
        }

        private void rentalSearchingBtn_Click(object sender, EventArgs e)
        {
            string searchCriteria = rentalSearchingTbx.Text.Trim();

            if (rentalLbx.Items.Count > 0)
            {
                if (searchCriteria.Length > 0)
                {
                    DataRow[] searchResults = new DataRow[0];

                    if (searchByInvoiceRbn.Checked)
                    {
                        searchResults = this.luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + searchCriteria + "'");
                    }
                    else
                    {
                        DataRow[] studentData = this.luEquipmentDataSet1.tblStudent.Select("Stu_LName = '" + searchCriteria + "'");
                        if(studentData.Length > 0)
                        {
                            //Loops through students until either one is found that rented equipment or no students with that last name are left
                            for (int i = 0; i < studentData.Length; i++)
                            {
                                searchResults = this.luEquipmentDataSet1.tblRental.Select("Stu_ID = '" + studentData[i][0].ToString() + "'");

                                if(searchResults.Length > 0)
                                {
                                    break;
                                }
                            }                        
                        }
                    }

                    if(searchResults.Length > 0)
                    {
                        DataRow[] studentInfo = this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + searchResults[0][1] + "'");


                        string rentalLbxFormat = (studentInfo.Length > 0) ? searchResults[0][5].ToString() + " - " + studentInfo[0][3].ToString() + " " + studentInfo[0][2].ToString() : searchResults[0][5].ToString();
                        int rentalListboxIndex = rentalLbx.FindStringExact(rentalLbxFormat);
                        if (rentalListboxIndex != -1)
                        {
                            rentalLbx.SetSelected(rentalListboxIndex, true);
                        }
                        else
                        {
                            MessageBox.Show("Rental not found in list.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rental not found.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter search criteria.", "Error");
                }
            }
            rentalSearchingTbx.Clear();
        }

        private void rentalItemsDgv_SelectionChanged(object sender, EventArgs e)
        {
            if(rentalItemsDgv.SelectedRows.Count == 1)
            {
                deleteItemBtn.Enabled = true;
            }
            else
            {
                deleteItemBtn.Enabled = false;
            }
        }
    }
}
 