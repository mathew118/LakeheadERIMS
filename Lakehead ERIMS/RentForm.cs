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
    public partial class RentForm : Form
    {
        //It seems Stu_Owes only keeps track of late fees.
        public RentForm()
        {
            InitializeComponent();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table. You can move, or remove it, as needed.
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
            this.tblStudentTableAdapter1.Fill(this.lUEquipmentDataSet.tblStudent);
           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterStudentNumberBtn_Click(object sender, EventArgs e)
        {
            if (enterStudentNumberTbx.Text.Length > 0)
            {
                //Attempts to get student information
                if (this.lUEquipmentDataSet.tblStudent.Select("Stu_Number = '" + enterStudentNumberTbx.Text + "'").Length > 0)
                {
                    EnableFields(true);
                    ActiveForm.AcceptButton = null;
                    this.ActiveControl = studentCourseTbx;
                    rentalItemsDgv.Rows.Clear();
                    studentCourseTbx.Clear();
                    LUEquipmentDataSet.tblStudentRow studentRow = (LUEquipmentDataSet.tblStudentRow)this.lUEquipmentDataSet.tblStudent.Select("Stu_Number = '" + enterStudentNumberTbx.Text + "'")[0];

                    studentNumberTbx.Text = (!studentRow.IsStu_NumberNull()) ? studentRow.Stu_Number : string.Empty;
                    studentNameTbx.Text = ((!studentRow.IsStu_FNameNull()) ? studentRow.Stu_FName : string.Empty) + " " + ((!studentRow.IsStu_LNameNull()) ? studentRow.Stu_LName : string.Empty);
                    studentAddressTbx.Text = (!studentRow.IsStu_LAddressNull()) ? studentRow.Stu_LAddress : string.Empty;
                    studentPhoneTbx.Text = (!studentRow.IsStu_LPhoneNull()) ? studentRow.Stu_LPhone : string.Empty;
                    orptChbx.Checked = (!studentRow.IsStu_ORPTNull()) ? studentRow.Stu_ORPT : false;

                    rentalDateOutDpk.Value = DateTime.Today;
                    rentalDateDueDpk.Value = DateTime.Today.AddDays(1);
                    rentalDateOutDpk.Format = DateTimePickerFormat.Long;
                    rentalDateDueDpk.Format = DateTimePickerFormat.Long;

                    outstandingFeeTbx.Text = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe.ToString("C") : "$0.00";
                }
                else
                {
                    MessageBox.Show("Student not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid student number.", "Error");
            }

            enterStudentNumberTbx.Clear();
            
        }

        private void EnableFields(bool enabled)
        {
            studentNumberTbx.Enabled = enabled;
            studentNameTbx.Enabled = enabled;
            studentAddressTbx.Enabled = enabled;
            studentPhoneTbx.Enabled = enabled;
            studentCourseTbx.Enabled = enabled;
            rentalDateOutDpk.Enabled = enabled;
            rentalDateDueDpk.Enabled = enabled;
            itemNumberATbx.Enabled = enabled;
            itemNumberBTbx.Enabled = enabled;
            itemQuantityTbx.Enabled = enabled;
            outstandingFeeTbx.Enabled = enabled;
            ignoreFeeChbx.Enabled = enabled;
            payFeeChbx.Enabled = enabled;
            deleteFeeChbx.Enabled = enabled;
            paymentRentalDaysTbx.Enabled = enabled;
            paymentSubtotalTbx.Enabled = enabled;
            paymentHSTTbx.Enabled = enabled;
            paymentTotalTbx.Enabled = enabled;
            paymentHSTWaiveChbx.Enabled = enabled;
            paymentSubtotalWaiveChbx.Enabled = enabled;
            processRentalBtn.Enabled = enabled;
            resetRentalBtn.Enabled = enabled;
            orptChbx.Enabled = enabled;
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            addUpdateStudent studentForm = new addUpdateStudent();
            studentForm.ShowDialog();
            resetRentalBtn_Click(sender, e);
            tblStudentTableAdapter1.Fill(lUEquipmentDataSet.tblStudent);
        }

        private void rentalDateDpk_ValueChanged(object sender, EventArgs e)
        {
            if(rentalDateOutDpk.Value < rentalDateDueDpk.Value)
            {
                paymentRentalDaysTbx.Text = ((int)(rentalDateDueDpk.Value - rentalDateOutDpk.Value).TotalDays).ToString();
            }
            else
            {
                paymentRentalDaysTbx.Text = "0";
            }

            recalculateTotal();
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

        private void itemNumberTbx_TextChanged(object sender, EventArgs e)
        {
            int totalLength = itemNumberATbx.Text.Length + itemNumberBTbx.Text.Length;
            if (totalLength == 6)
            {
                if (lUEquipmentDataSet.tblEquip.Count == 0)
                {
                    tblEquipTableAdapter.Fill(lUEquipmentDataSet.tblEquip);
                }
                if (lUEquipmentDataSet.tblStatus.Count == 0)
                {
                    tblStatusTableAdapter1.Fill(lUEquipmentDataSet.tblStatus);
                }

                //Add item
                try
                {
                    string equipNum = itemNumberATbx.Text + itemNumberBTbx.Text;

                    if (this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNum + "'").Length > 0)
                    {
                        int equipID = int.Parse(this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNum + "'")[0][0].ToString());
                        LUEquipmentDataSet.tblEquipRow equipmentRow = lUEquipmentDataSet.tblEquip.FindByEquip_ID(equipID);

                        //Check if equipment is already in list
                        bool hasRow = false;
                        foreach (DataGridViewRow dgvRow in rentalItemsDgv.Rows)
                        {
                            if (dgvRow.Cells[0].Value.ToString() == equipmentRow.Equip_Number)
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
                                processRentalBtn.Enabled = true;
                            }
                            else
                            {
                                string equipmentStatus = lUEquipmentDataSet.tblStatus.FindByStatus_ID(equipmentRow.Status_ID).Status_Name;
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

        private void rentalItemsDgv_RowsChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            recalculateTotal();

            removeAllItemsBtn.Enabled = true;
        }

        private void rentalItemsDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            rentalItemsDgv_RowsChanged(sender, new DataGridViewRowsAddedEventArgs(e.RowIndex, e.RowCount));

            if(rentalItemsDgv.Rows.Count == 0)
            {
                removeAllItemsBtn.Enabled = false;
            }
        }

        private void rentalItemsDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (rentalItemsDgv.SelectedRows.Count == 1)
            {
                deleteItemBtn.Enabled = true;
            }
            else
            {
                deleteItemBtn.Enabled = false;
            }
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

        private void paymentChanged(object sender, EventArgs e)
        {
            recalculateTotal();
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

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            if (rentalItemsDgv.SelectedRows != null && rentalItemsDgv.SelectedRows.Count > 0)
            {
                rentalItemsDgv.Rows.Remove(rentalItemsDgv.SelectedRows[0]);
            }
        }

        private void removeAllItemsBtn_Click(object sender, EventArgs e)
        {
            rentalItemsDgv.Rows.Clear();
        }

        private void rentalSearchingTbx_Enter(object sender, EventArgs e)
        {
            try
            {
                Control sendingControl = (Control)sender;
                if (this.ActiveControl == sendingControl)
                {
                    ActiveForm.AcceptButton = enterStudentNumberBtn;
                }
                else
                {
                    ActiveForm.AcceptButton = null;
                }
            }
            catch
            {

            }
        }

        private void resetRentalBtn_Click(object sender, EventArgs e)
        {
            EnableFields(false);


            studentNumberTbx.Clear();
            studentNameTbx.Clear();
            studentAddressTbx.Clear();
            studentPhoneTbx.Clear();
            studentCourseTbx.Clear();
            rentalDateOutDpk.Format = DateTimePickerFormat.Custom;
            rentalDateDueDpk.Format = DateTimePickerFormat.Custom;
            itemNumberATbx.Clear();
            itemNumberBTbx.Clear();
            itemQuantityTbx.Text = "0";
            outstandingFeeTbx.Text = "$0.00";
            ignoreFeeChbx.Checked = false;
            payFeeChbx.Checked = false;
            deleteFeeChbx.Checked = false;
            //paymentRentalDaysTbx.Clear();
            paymentRentalDaysTbx.Text = "1";
            paymentSubtotalTbx.Text = "$0.00";
            paymentHSTTbx.Text = "$0.00";
            paymentTotalTbx.Text = "$0.00";
            paymentHSTWaiveChbx.Checked = false;
            paymentSubtotalWaiveChbx.Checked = false;
            orptChbx.Checked = false;
            rentalItemsDgv.Rows.Clear();

            this.ActiveControl = enterStudentNumberTbx;
        }

        private void processRentalBtn_Click(object sender, EventArgs e)
        {
            //if(lUEquipmentDataSet.tblRental.Rows.Count == 0)
            //{
                tblRentalTableAdapter1.Fill(lUEquipmentDataSet.tblRental);
            //}

            if(rentalItemsDgv.Rows.Count > 0)
            {
                if(int.TryParse(paymentRentalDaysTbx.Text, out int rentalDays))
                {
                    if(rentalDays > 0)
                    {
                        if((outstandingFeeTbx.Text != (0).ToString("C") && (payFeeChbx.Checked || ignoreFeeChbx.Checked || deleteFeeChbx.Checked)) || (outstandingFeeTbx.Text == (0).ToString("C")))
                        {
                            //Get largest invoice number
                            //Sort rental table by invoice number then grab the highest index?
                            lUEquipmentDataSet.tblRental.DefaultView.Sort = "Inv_Num";
                            DataTable sortedRentals = lUEquipmentDataSet.tblRental.DefaultView.ToTable();
                            int invoiceNum = int.Parse(sortedRentals.Rows[sortedRentals.Rows.Count - 1][5].ToString()) + 1;

                            while(this.lUEquipmentDataSet.tblRental.Select("Inv_Num = '" + invoiceNum + "'").Length > 0)
                            {
                                invoiceNum++;
                            }

                            //Get student ID
                            LUEquipmentDataSet.tblStudentRow studentRow = (LUEquipmentDataSet.tblStudentRow)this.lUEquipmentDataSet.tblStudent.Select("Stu_Number = '" + studentNumberTbx.Text + "'")[0];
                            int studentId = studentRow.Stu_ID;

                            //Create rental
                            foreach (DataGridViewRow row in rentalItemsDgv.Rows)
                            {
                                LUEquipmentDataSet.tblEquipRow equipRow = (LUEquipmentDataSet.tblEquipRow)lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + row.Cells[0].Value.ToString() + "'")[0];
                                int equipID = equipRow.Equip_ID;

                                tblRentalTableAdapter1.Insert(Convert.ToInt16(equipID), studentId, rentalDateOutDpk.Value, rentalDateDueDpk.Value, studentCourseTbx.Text, invoiceNum);
                                equipRow.Status_ID = 9;
                                tblEquipTableAdapter.Update(equipRow);
                            }

                            //Modify existing fees based on option selected
                            if (outstandingFeeTbx.Text != (0).ToString("C"))
                            {
                                if (payFeeChbx.Checked || deleteFeeChbx.Checked)
                                {
                                    studentRow.Stu_Owe = 0;
                                    tblStudentTableAdapter1.Update(studentRow);
                                    tblStudentTableAdapter1.Fill(lUEquipmentDataSet.tblStudent);
                                }
                            }

                            printRentalForm(invoiceNum);

                            MessageBox.Show("Rental Processed.", "Success");
                            resetRentalBtn_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Outstanding fees exist, an option must be selected.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rental days must be greater than 0.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Rental date is invalid.", "Error");
                }
            }
            else
            {
                MessageBox.Show("No items added to rental.", "Error");
            }
        }

        private void existingRentalsBtn_Click(object sender, EventArgs e)
        {
            if (studentNumberTbx.Text != string.Empty)
            {
                int studentNum = Convert.ToInt32(studentNumberTbx.Text);
                string strCriteria = "Stu_Number ='" + studentNum + "'";
                Microsoft.Office.Interop.Access.Application oAccess = new Microsoft.Office.Interop.Access.Application();
                oAccess.Visible = true;
                oAccess.OpenCurrentDatabase(System.IO.Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
                //this report is opened in Access and ready to print
                oAccess.DoCmd.OpenReport("rptOnLoan", Microsoft.Office.Interop.Access.AcView.acViewPreview, //View
                    System.Reflection.Missing.Value, //FilterName
                    strCriteria //where condition
                    );

                

            }
            else
            {
                MessageBox.Show("No student selected.", "Error");
            }
        }

        private void printRentalForm(int invoiceNumber)
        {
            try
            {
                var oAccess = new Microsoft.Office.Interop.Access.Application();
                
                //oAccess.Visible = false;
                oAccess.OpenCurrentDatabase(System.IO.Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);         

                oAccess.DoCmd.OpenReport(
                   "rptRental", //ReportName
                   Microsoft.Office.Interop.Access.AcView.acViewPreview, //View
                   System.Reflection.Missing.Value, //FilterName
                   ("[Inv_Num]=" + invoiceNumber) //WhereCondition
                );

                // Print 2 copies of the active object: 
                oAccess.DoCmd.PrintOut(
                   Microsoft.Office.Interop.Access.AcPrintRange.acPrintAll, //PrintRange
                   System.Reflection.Missing.Value, //PageFrom
                   System.Reflection.Missing.Value, //PageTo
                   Microsoft.Office.Interop.Access.AcPrintQuality.acHigh, //PrintQuality
                   2, //Copies
                   false //CollateCopies
                );

                oAccess.Quit(Microsoft.Office.Interop.Access.AcQuitOption.acQuitSaveNone);

            }
            catch
            {
                MessageBox.Show("Error printing rental agreement forms.", "Error");
            }
        }
    }
}
