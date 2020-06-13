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
    public partial class ReturnEquip : Form
    {

        //Stu_Owes and Equip_Nights should be calculated and added when equipment is returned

        public List<int> queuedItems = new List<int>();
        public int currentItem = -1;

        public ReturnEquip()
        {
            InitializeComponent();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ReturnEquip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luEquipmentDataSet1.tblStatus' table. You can move, or remove it, as needed.
            this.tblStatusTableAdapter.Fill(this.luEquipmentDataSet1.tblStatus);
        }

        private void AutoTabItemNum(object sender, KeyEventArgs e)
        {
            TextBox sendingTbx = (TextBox)sender;
            if (sendingTbx.Text.Length == sendingTbx.MaxLength)
            {
                sendingTbx.Parent.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void itemNumberTbx_TextChanged(object sender, EventArgs e)
        {
            int totalLength = itemNumberATbx.Text.Length + itemNumberBTbx.Text.Length;
            if (totalLength == 6)
            {
                if (luEquipmentDataSet1.tblEquip.Count == 0)
                {
                    tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);
                }
                if (luEquipmentDataSet1.tblStatus.Count == 0)
                {
                    tblStatusTableAdapter1.Fill(luEquipmentDataSet1.tblStatus);
                }
                if (luEquipmentDataSet1.tblRental.Count == 0)
                {
                    tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);
                }
                if (luEquipmentDataSet1.tblStudent.Count == 0)
                {
                    tblStudentTableAdapter1.Fill(luEquipmentDataSet1.tblStudent);
                }

                //Add item
                try
                {
                    string equipNum = itemNumberATbx.Text + itemNumberBTbx.Text;

                    if (this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'").Length > 0)
                    {                      
                        int equipID = int.Parse(this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNum + "'")[0][0].ToString());
                        currentItem = equipID;
                        LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(equipID);

                        if (this.luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + equipID + "'").Length > 0)
                        {
                            LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(equipID), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + equipID + "'")[0][5].ToString()));
                            itemNameTbx.Text = equipmentRow.Equip_Name;
                            description1Tbx.Text = (!equipmentRow.IsEquip_Descrip1Null()) ? equipmentRow.Equip_Descrip1 : string.Empty;
                            description2Tbx.Text = (!equipmentRow.IsEquip_Descrip2Null()) ? equipmentRow.Equip_Descrip2 : string.Empty;
                            description3Tbx.Text = (!equipmentRow.IsEquip_Descrip3Null()) ? equipmentRow.Equip_Descrip3 : string.Empty;
                            dateOutTbx.Text = (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut.ToLongDateString() : string.Empty;
                            dateDueTbx.Text = (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue.ToLongDateString() : string.Empty;
                            invoiceNumberTbx.Text = rentalRow.Inv_Num.ToString();
                            //queueBtn.Enabled = true;

                            //Try to get student info
                            if (!rentalRow.IsStu_IDNull())
                            {
                                if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + rentalRow.Stu_ID + "'").Length > 0)
                                {
                                    LUEquipmentDataSet.tblStudentRow studentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(rentalRow.Stu_ID);
                                    studentNameTbx.Text = studentRow.Stu_FName + " " + studentRow.Stu_LName;
                                    studentNumberTbx.Text = studentRow.Stu_Number;
                                    accountBalanceTbx.Text = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe.ToString("C") : "$0.00";
                                }
                            }

                            //Get remaining rentals
                            
                            DataRow[] invoiceRentals = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalRow.Inv_Num + "'");
                            
                            int remainingInvoices = 0;
                            foreach(DataRow invoiceRental in invoiceRentals)
                            {
                                int invoiceEquipId = int.Parse(invoiceRental[0].ToString());
                                if (!queuedItems.Contains(invoiceEquipId))
                                {
                                    remainingInvoices++;
                                }
                            }                            
                            stillOutTbx.Text = remainingInvoices.ToString();
                            
                            //int remainingInvoices = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalRow.Inv_Num + "'").Length;
                            //stillOutTbx.Text = remainingInvoices.ToString();

                            if (!queuedItems.Contains(equipID))
                            {
                                queueBtn.Enabled = true;
                            }
                            statusCbx.Enabled = true;
                            //clearItemBtn.Enabled = true;

                            DateTime dateOutDte = (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : DateTime.Today;
                            DateTime dateDueDte = (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : DateTime.Today.AddDays(1);

                            if(DateTime.Today > dateDueDte)
                            {
                                int daysLate = (int)(DateTime.Today - dateDueDte).TotalDays;
                                if(daysLate > 0)
                                {
                                    invoiceLateFeesTbx.Text = (daysLate * 5).ToString("C");
                                }
                                else
                                {
                                    invoiceLateFeesTbx.Text = (0).ToString("C");
                                }
                            }
                            else
                            {
                                invoiceLateFeesTbx.Text = (0).ToString("C");
                            }

                            waiveLateFeesCbx.Text = "Rentals remaining in current invoice.";
                            waiveLateFeesCbx.Checked = true;
                            payLateFeesCbx.Enabled = false;
                            accumulateLateFeesCbx.Enabled = false;

                            if (remainingInvoices <= 1 && queueBtn.Enabled)
                            {
                                //Do invoice late fees here
                                waiveLateFeesCbx.Text = "Waive Late Fee";
                                waiveLateFeesCbx.Checked = false;
                                payLateFeesCbx.Enabled = true;
                                accumulateLateFeesCbx.Enabled = true;
                            }                           
                        }
                        else
                        {
                            MessageBox.Show("Rental not found", "Error");
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

        private void queueBtn_Click(object sender, EventArgs e)
        {
            
            if(currentItem != -1)
            {
                /*
                if (invoiceLateFeesTbx.Text != (0).ToString("C") && waiveLateFeesCbx.Text != "Rentals remaining in current invoice.")
                {
                    if(waiveLateFeesCbx.Checked || payLateFeesCbx.Checked || accumulateLateFeesCbx.Checked)
                    {
                        if (accumulateLateFeesCbx.Checked)
                        {
                            if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + studentNumberTbx.Text + "'").Length > 0)
                            {
                                LUEquipmentDataSet.tblStudentRow studentRow = luEquipmentDataSet1.tblStudent.FindByStu_ID(int.Parse(studentNumberTbx.Text));
                                float stuOwes = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe : 0;

                                stuOwes += float.Parse(invoiceLateFeesTbx.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo);

                                //studentRow.Stu_Owe = stuOwes;
                                //tblStudentTableAdapter1.Update(studentRow);
                            }
                            else
                            {
                                MessageBox.Show("Student not found, late fee not added.", "Error");
                            }
                        }
                        queuedItems.Add(currentItem);
                        queueBtn.Enabled = false;
                        processReturnsBtn.Enabled = true;
                        itemsQueuedTbx.Text = queuedItems.Count.ToString();
                        clearItemBtn_Click(sender, e);
                        this.ActiveControl = itemNumberATbx;
                        currentItem = -1;
                    }
                    else
                    {
                        MessageBox.Show("Please select an option for handling the late fee.", "Error");
                    }
                }
                else
                {
                */
                if (!queuedItems.Contains(currentItem))
                {
                    queuedItems.Add(currentItem);
                    clearItemBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Item already queued.", "Error");
                }

                queueBtn.Enabled = false;
                processReturnsBtn.Enabled = true;
                itemsQueuedTbx.Text = queuedItems.Count.ToString();
                clearItemBtn_Click(sender, e);
                this.ActiveControl = itemNumberATbx;
                currentItem = -1;

                //}  
            } 
            
        }

        private void processReturnsBtn_Click(object sender, EventArgs e)
        {
            /*
            if(queuedItems.Count > 0)
            {
                foreach(int item in queuedItems)
                {
                    if(luEquipmentDataSet1.tblEquip.Select("Equip_ID = '" + item + "'").Length > 0 && luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + item + "'").Length > 0)
                    {
                        LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(item);
                        equipmentRow.Status_ID = short.Parse(statusCbx.SelectedValue.ToString());
                        tblEquipTableAdapter1.Update(equipmentRow);
                        tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);


                        LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(item), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + item + "'")[0][5].ToString()));
                        tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);
                        tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);
                    }
                    else
                    {
                        MessageBox.Show("Item " + item + " either does not exist, or a rental containing that item does not exist.", "Error");
                    }
                }

                processReturnsBtn.Enabled = false;
                ClearFields();
            }
            else
            {
                MessageBox.Show("No invoices to process.", "Error");
            }
            */

            foreach (int item in queuedItems)
            {
                if(item != -1)
                {
                    LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(item);
                    LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(item), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + item + "'")[0][5].ToString()));

                    int inv = rentalRow.Inv_Num;
                    int stuId = rentalRow.Stu_ID;
                    DateTime dateOutDte = (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : DateTime.Today;
                    DateTime dateDueDte = (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : DateTime.Today.AddDays(1);

                    int equipNights = (!equipmentRow.IsEquip_NightsNull()) ? equipmentRow.Equip_Nights : 0;
                    equipNights += (int)(DateTime.Today - rentalRow.Rent_DateOut).TotalDays;
                    equipmentRow.Equip_Nights = equipNights;
                    equipmentRow.Status_ID = short.Parse(statusCbx.SelectedValue.ToString());
                    tblEquipTableAdapter1.Update(equipmentRow);
                    tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);



                    tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);
                    tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

                    if (luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + inv + "'").Length == 0 && DateTime.Today > dateDueDte){
                        int daysLate = (int)(DateTime.Today - dateDueDte).TotalDays;
                        if (daysLate > 0) {

                            //Last item in invoice and is late.
                            FeeDialog lateFeeDialog = new FeeDialog(inv, (daysLate * 5), stuId);
                            while (!lateFeeDialog.handled)
                            {
                                lateFeeDialog.ShowDialog();
                            }

                        }
                    }

                }
            }

            processReturnsBtn.Enabled = false;
            ClearFields();
            clearItemBtn_Click(sender, e);
            this.ActiveControl = itemNumberATbx;
            currentItem = -1;
            MessageBox.Show("Items returned", "Success");

            /*
            if (currentItem != -1)
            {
                if (luEquipmentDataSet1.tblEquip.Select("Equip_ID = '" + currentItem + "'").Length > 0 && luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + currentItem + "'").Length > 0)
                {
                    if (invoiceLateFeesTbx.Text != (0).ToString("C") && waiveLateFeesCbx.Text != "Rentals remaining in current invoice.")
                    {
                        if (waiveLateFeesCbx.Checked || payLateFeesCbx.Checked || accumulateLateFeesCbx.Checked)
                        {
                            if (accumulateLateFeesCbx.Checked)
                            {
                                if (this.luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTbx.Text + "'").Length > 0)
                                {
                                    LUEquipmentDataSet.tblStudentRow studentRow = (LUEquipmentDataSet.tblStudentRow)luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTbx.Text + "'")[0];
                                    float stuOwes = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe : 0;

                                    stuOwes += float.Parse(invoiceLateFeesTbx.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo);

                                    studentRow.Stu_Owe = stuOwes;
                                    tblStudentTableAdapter1.Update(studentRow);

                                    LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(currentItem);
                                    LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(currentItem), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + currentItem + "'")[0][5].ToString()));
                                    int equipNights = (!equipmentRow.IsEquip_NightsNull()) ? equipmentRow.Equip_Nights : 0;
                                    equipNights += (int)(DateTime.Today - rentalRow.Rent_DateOut).TotalDays;
                                    equipmentRow.Equip_Nights = equipNights;
                                    equipmentRow.Status_ID = short.Parse(statusCbx.SelectedValue.ToString());
                                    tblEquipTableAdapter1.Update(equipmentRow);
                                    tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);


                                    
                                    tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);
                                    tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

                                    processReturnsBtn.Enabled = false;
                                    ClearFields();
                                    clearItemBtn_Click(sender, e);
                                    this.ActiveControl = itemNumberATbx;
                                    currentItem = -1;
                                    MessageBox.Show("Item returned.", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("Student not found, late fee not added.", "Error");
                                }
                            }
                            else
                            {
                                LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(currentItem);
                                LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(currentItem), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + currentItem + "'")[0][5].ToString()));
                                int equipNights = (!equipmentRow.IsEquip_NightsNull()) ? equipmentRow.Equip_Nights : 0;
                                equipNights += (int)(DateTime.Today - rentalRow.Rent_DateOut).TotalDays;
                                equipmentRow.Equip_Nights = equipNights;
                                equipmentRow.Status_ID = short.Parse(statusCbx.SelectedValue.ToString());
                                tblEquipTableAdapter1.Update(equipmentRow);
                                tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);


                                
                                tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);
                                tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

                                processReturnsBtn.Enabled = false;
                                ClearFields();
                                clearItemBtn_Click(sender, e);
                                this.ActiveControl = itemNumberATbx;
                                currentItem = -1;
                                MessageBox.Show("Item returned");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select an option for handling the late fee.", "Error");
                        }
                    }

                    else
                    {
                        LUEquipmentDataSet.tblEquipRow equipmentRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(currentItem);
                        LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(Convert.ToInt16(currentItem), int.Parse(luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + currentItem + "'")[0][5].ToString()));
                        int equipNights = (!equipmentRow.IsEquip_NightsNull()) ? equipmentRow.Equip_Nights : 0;
                        equipNights += (int)(DateTime.Today - rentalRow.Rent_DateOut).TotalDays;
                        equipmentRow.Equip_Nights = equipNights;
                        equipmentRow.Status_ID = short.Parse(statusCbx.SelectedValue.ToString());
                        tblEquipTableAdapter1.Update(equipmentRow);
                        tblEquipTableAdapter1.Fill(luEquipmentDataSet1.tblEquip);


                        
                        tblRentalTableAdapter1.Delete(rentalRow.Equip_ID, (!rentalRow.IsStu_IDNull()) ? rentalRow.Stu_ID : (int?)null, (!rentalRow.IsRent_DateOutNull()) ? rentalRow.Rent_DateOut : (DateTime?)null, (!rentalRow.IsRent_DateDueNull()) ? rentalRow.Rent_DateDue : (DateTime?)null, (!rentalRow.IsRent_CourseNull()) ? rentalRow.Rent_Course : null, rentalRow.Inv_Num);
                        tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

                        processReturnsBtn.Enabled = false;
                        ClearFields();
                        clearItemBtn_Click(sender, e);
                        this.ActiveControl = itemNumberATbx;
                        currentItem = -1;
                        MessageBox.Show("Item returned");
                    }
                }
                else
                {
                    MessageBox.Show("Item " + currentItem + " either does not exist, or a rental containing that item does not exist.", "Error");
                }

                
            }
            */
        }

        public void ClearFields()
        {
            itemNameTbx.Clear();
            description1Tbx.Clear();
            description2Tbx.Clear();
            description3Tbx.Clear();
            statusCbx.Enabled = false;
            dateOutTbx.Clear();
            dateDueTbx.Clear();
            invoiceNumberTbx.Clear();
            studentNumberTbx.Clear();
            studentNameTbx.Clear();
            stillOutTbx.Clear();
            accountBalanceTbx.Clear();
            invoiceLateFeesTbx.Clear();
            queuedItems.Clear();
            itemsQueuedTbx.Text = queuedItems.Count.ToString();
            clearItemBtn.Enabled = false;
            queueBtn.Enabled = false;
            currentItem = -1;
            accumulateLateFeesCbx.Checked = false;
            payLateFeesCbx.Checked = false;
            waiveLateFeesCbx.Checked = false;
        }

        private void clearItemBtn_Click(object sender, EventArgs e)
        {
            itemNameTbx.Clear();
            description1Tbx.Clear();
            description2Tbx.Clear();
            description3Tbx.Clear();
            statusCbx.Enabled = false;
            dateOutTbx.Clear();
            dateDueTbx.Clear();
            invoiceNumberTbx.Clear();
            studentNumberTbx.Clear();
            studentNameTbx.Clear();
            stillOutTbx.Clear();
            accountBalanceTbx.Clear();
            invoiceLateFeesTbx.Clear();
            //clearItemBtn.Enabled = false;
            queueBtn.Enabled = false;
            currentItem = -1;
            accumulateLateFeesCbx.Checked = false;
            payLateFeesCbx.Checked = false;
            waiveLateFeesCbx.Checked = false;
        }

        private void clearQueueBtn_Click(object sender, EventArgs e)
        {
            clearItemBtn_Click(sender, e);
            processReturnsBtn.Enabled = false;
            clearItemBtn.Enabled = false;           
            queuedItems.Clear();
            itemsQueuedTbx.Text = queuedItems.Count.ToString();
        }
    }
}
