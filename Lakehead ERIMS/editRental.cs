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

            Is equip nights calculated from the values in the rental table? or is it modified each time a
            rental is created or modified. (Pretty sure it is calculated manually instead of gathering all rental values
            because rental entries are deleted pretty often)

            Is all equipment, when brought back from a rental, have to be manually returned via "Return Equipment"? (Yes)

            Does return equipment remove the rental row? (Yes)

            How does it keep track of rental fees? Other fees, etc?
            Student has owes column but can have multiple rentals, how does it keep track of "other fees" for each?
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
            rentalLbx.DataSource = luEquipmentDataSet1.tblRental;
            uniqueInvoices.Clear();

            List<int> addedInvoices = new List<int>();

            //This may cause issues with massive rental databases
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
            paymentHSTTbx.Clear();
            paymentTotalTbx.Clear();
            //paymentSubtotalWaiveChbx.Checked = false;
            //paymentHSTWaiveChbx.Checked = false;
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
                studentCourseTbx.Enabled = true;
                rentalDateOutDpk.Enabled = true;
                rentalDateDueDpk.Enabled = true;
                paymentRentalDaysTbx.Enabled = true;
                paymentOtherFeesTbx.Enabled = true;
                voidRentalBtn.Enabled = true;

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
            else
            {
                studentCourseTbx.Enabled = false;
                rentalDateOutDpk.Enabled = false;
                rentalDateDueDpk.Enabled = false;
                paymentRentalDaysTbx.Enabled = false;
                paymentOtherFeesTbx.Enabled = false;
                updateRentalBtn.Enabled = false;
                voidRentalBtn.Enabled = false;
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
                if (luEquipmentDataSet1.tblStatus.Count == 0)
                {
                    tblStatusTableAdapter1.Fill(luEquipmentDataSet1.tblStatus);
                }

                //Add item
                try
                {
                    string equipNum = itemNumberATbx.Text + itemNumberBTbx.Text;

                    if(this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'").Length > 0)
                    {
                        int equipID = int.Parse(this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'")[0][0].ToString());
                        LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(equipID);

                        //Check if equipment is already in list
                        bool hasRow = false;
                        foreach(DataGridViewRow dgvRow in rentalItemsDgv.Rows)
                        {
                            if(dgvRow.Cells[0].Value.ToString() == equipmentRow.Equip_Number)
                            {
                                hasRow = true;
                            }
                        }

                        if (!hasRow)
                        {
                            //Check if equipment is available
                            if (equipmentRow.Status_ID == 1)
                            {
                                rentalItemsDgv.Rows.Add(equipmentRow.Equip_Number, equipmentRow.Equip_Name, equipmentRow.Equip_RentalPrice.ToString("C"));
                                updateRentalBtn.Enabled = true;
                            }
                            else
                            {
                                string equipmentStatus = luEquipmentDataSet1.tblStatus.FindByStatus_ID(equipmentRow.Status_ID).Status_Name;
                                MessageBox.Show("Equipment is not available.\nReason: " + equipmentStatus + ".", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Equipment already added to rental.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Equipment not found.", "Error");
                    }
                }
                catch
                {
                    MessageBox.Show("Equipment invalid.", "Error");
                }

                itemNumberATbx.Clear();
                itemNumberBTbx.Clear();
                itemNumberATbx.Focus();
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
                            ActiveForm.AcceptButton = null;
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

        private void AutoTabItemNum(object sender, KeyEventArgs e)
        {
            TextBox sendingTbx = (TextBox)sender;
            if (sendingTbx.Text.Length == sendingTbx.MaxLength)
            {
                sendingTbx.Parent.SelectNextControl(ActiveControl, true, true, true, true);
            }
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

        private void removeAllItemsBtn_Click(object sender, EventArgs e)
        {
            rentalItemsDgv.Rows.Clear();
            updateRentalBtn.Enabled = true;
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            if(rentalItemsDgv.SelectedRows != null && rentalItemsDgv.SelectedRows.Count > 0)
            {
                rentalItemsDgv.Rows.Remove(rentalItemsDgv.SelectedRows[0]);
                updateRentalBtn.Enabled = true;
            }
        }

        private void rentalItemsDgv_RowsChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            recalculateTotal();
        }

        private void rentalItemsDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rentalItemsDgv_RowsChanged(sender, new DataGridViewRowsAddedEventArgs(e.RowIndex, e.RowCount));
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

            //Get rental days
            if (rentalDateOutDpk.Value != DateTime.FromOADate(0) && rentalDateDueDpk.Value != DateTime.FromOADate(0))
            {
                if (rentalDateDueDpk.Value > rentalDateOutDpk.Value)
                {
                    int rentalDays = 0;
                    rentalDays = (int)(rentalDateDueDpk.Value - rentalDateOutDpk.Value).TotalDays;
                    paymentRentalDaysTbx.Text = rentalDays.ToString();
                }
                else
                {
                    paymentRentalDaysTbx.Text = "0";
                }
            }
            else
            {
                paymentRentalDaysTbx.Text = "0";
            }

            RentalFieldChanged(sender, e);
        }

        private void RentalDpk_CloseUp(object sender, EventArgs e)
        {
            //MessageBox.Show("USER changed date");

            DateTimePicker sendingDpk = (DateTimePicker)sender;

            if (sendingDpk.Value == DateTime.Today)
            {
                sendingDpk.Format = DateTimePickerFormat.Long;
                RentalFieldChanged(sender, e);
            }
        }

        private void rentalDaysTbxChanged(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("USER changed rental days");
            if (rentalDateOutDpk.Value != DateTime.FromOADate(0))
            {
                if (int.TryParse(paymentRentalDaysTbx.Text, out int rentalDays))
                {
                    if (rentalDays > 0)
                    {
                        try
                        {
                            DateTime newDate = rentalDateOutDpk.Value.AddDays(rentalDays);
                            rentalDateDueDpk.Value = newDate;
                        }
                        catch
                        {
                            MessageBox.Show("Date out of bounds.", "Error");
                        }                        
                    }
                }
            }
        }

        private void paymentChanged(object sender, EventArgs e)
        {
            recalculateTotal();
            updateRentalBtn.Enabled = true;
        }

        private void recalculateTotal()
        {
            itemQuantityTbx.Text = rentalItemsDgv.Rows.Count.ToString();

            //Calculate subtotal
            if (rentalItemsDgv.Rows.Count > 0 && paymentRentalDaysTbx.Text != string.Empty && !paymentSubtotalWaiveChbx.Checked)
            {
                if (int.TryParse(paymentRentalDaysTbx.Text, out int rentalDays))
                {
                    if (rentalDays >= 0)
                    {
                        double sub = 0;
                        foreach (DataGridViewRow row in rentalItemsDgv.Rows)
                        {
                            if (row.Cells[2].Value.ToString() != string.Empty)
                            {
                                if (double.TryParse(row.Cells[2].Value.ToString(), System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out double rentalPrice))
                                {
                                    sub += (rentalPrice * rentalDays);
                                }
                            }
                        }

                        if (double.TryParse(paymentOtherFeesTbx.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out double otherFees))
                        {
                            sub += otherFees;
                        }

                        paymentSubtotalTbx.Text = sub.ToString("C");
                    }
                }
            }
            else
            {
                paymentSubtotalTbx.Text = "$0.00";
            }


            //Recalculate total
            double total = 0;
            if (double.TryParse(paymentSubtotalTbx.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out double subTotal))
            {
                if (!paymentSubtotalWaiveChbx.Checked)
                {
                    total += subTotal;
                }
            }
            

            double HST = (!paymentHSTWaiveChbx.Checked) ? (total * 0.13) : 0;
            paymentHSTTbx.Text = HST.ToString("C");

            total += HST;
            paymentTotalTbx.Text = total.ToString("C");
        }

        private void voidRentalBtn_Click(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (rentalLbx.SelectedValue != null && rentalLbx.SelectedIndex != -1)
            {
                DataRow[] searchResults = this.luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalLbx.SelectedValue.ToString() + "'");
                if (searchResults.Length > 0)
                {
                    foreach(DataRow invoiceRow in searchResults)
                    {
                        LUEquipmentDataSet.tblRentalRow rentalRow = (LUEquipmentDataSet.tblRentalRow)invoiceRow;
                        LUEquipmentDataSet.tblEquipRow equipRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(rentalRow.Equip_ID);
                        tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);

                        equipRow.Status_ID = 1;
                        tblEquipTableAdapter1.Update(equipRow);
                    }

                    updateRentalList();
                    rentalLbx.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No invoice selected.", "Error");
                }
            }
        }

        private void updateRentalBtn_Click(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (rentalLbx.SelectedValue != null && rentalLbx.SelectedIndex != -1)
            {
                //Need to validate dates and course
                //Also need to check if any items were changed/added and add rental entries for those
                if (studentCourseTbx.Text.Length >= 20)
                {
                    MessageBox.Show("Course too long.", "Error");
                }
                else if (rentalDateOutDpk.Value == DateTime.FromOADate(0) || rentalDateDueDpk.Value == DateTime.FromOADate(0))
                {
                    MessageBox.Show("Date not set.", "Error");
                }
                else if (rentalDateOutDpk.Value > rentalDateDueDpk.Value)
                {
                    MessageBox.Show("Due date must be after date out.", "Error");
                }
                else
                {
                    DataRow[] searchResults = this.luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalLbx.SelectedValue.ToString() + "'");
                    if (searchResults.Length > 0)
                    {
                        List<int> existingItems = new List<int>();
                        LUEquipmentDataSet.tblRentalRow tempRow = (LUEquipmentDataSet.tblRentalRow)searchResults[0];
                        int? studentId = (!tempRow.IsStu_IDNull()) ? tempRow.Stu_ID : (int?)null;
                        int InvoiceNum = tempRow.Inv_Num;
                        string course = (studentCourseTbx.Text.Length > 0) ? studentCourseTbx.Text : null;

                        foreach (DataRow invoiceRow in searchResults)
                        {
                            LUEquipmentDataSet.tblRentalRow rentalRow = (LUEquipmentDataSet.tblRentalRow)invoiceRow;
                            rentalRow.Rent_Course = course;
                            rentalRow.Rent_DateOut = rentalDateOutDpk.Value;
                            rentalRow.Rent_DateDue = rentalDateDueDpk.Value;
                            existingItems.Add(rentalRow.Equip_ID);

                            tblRentalTableAdapter1.Update(rentalRow);
                        }

                        //Update items
                        foreach (DataGridViewRow row in rentalItemsDgv.Rows)
                        {
                            LUEquipmentDataSet.tblEquipRow equipRow = (LUEquipmentDataSet.tblEquipRow)luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + row.Cells[0].Value.ToString() + "'")[0];
                            int equipID = equipRow.Equip_ID;

                            if (existingItems.Contains(equipID))
                            {
                                //Item was not changed
                                existingItems.Remove(equipID);
                            }
                            else if (!existingItems.Contains(equipID)){
                                //Item was added
                                tblRentalTableAdapter1.Insert(Convert.ToInt16(equipID), studentId, rentalDateOutDpk.Value, rentalDateDueDpk.Value, course, InvoiceNum);
                                equipRow.Status_ID = 9;
                                tblEquipTableAdapter1.Update(equipRow);
                            }                                                      
                        }

                        //Whats left in existingItems are items that were removed
                        foreach(short equipNum in existingItems)
                        {
                            LUEquipmentDataSet.tblEquipRow equipRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(equipNum);
                            tblRentalTableAdapter1.Delete(equipNum, studentId, rentalDateOutDpk.Value, rentalDateDueDpk.Value, course, InvoiceNum);
                            equipRow.Status_ID = 1;
                            tblEquipTableAdapter1.Update(equipRow);
                        }

                        updateRentalList();

                        int lbxSearching = rentalLbx.FindString(InvoiceNum.ToString());
                        if(lbxSearching != -1)
                        {
                            rentalLbx.SetSelected(lbxSearching, true);
                        }
                        else
                        {
                            rentalLbx.SelectedIndex = -1;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No invoice selected.", "Error");
                    }
                }
            }
        }

        private void rentalSearchingTbx_Enter(object sender, EventArgs e)
        {
            Control sendingControl = (Control)sender;
            if (sendingControl.Focused)
            {
                ActiveForm.AcceptButton = rentalSearchingBtn;
            }
            else
            {
                ActiveForm.AcceptButton = null;
            }
        }
    }
}
 