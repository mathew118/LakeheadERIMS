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
        public List<int> queuedItems = new List<int>();
        public int currentItem = -1;

        public ReturnEquip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblEquipTableAdapter1.Fill(this.luEquipmentDataSet1.tblEquip);
                DataRow equip;
                equip = luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + itemNumberTextBox.Text + "'")[0];
                itemNameLabel.Text = equip[2].ToString();
                desc1Label.Text = equip[3].ToString();
                desc2Label.Text = equip[4].ToString();
                desc3Label.Text = equip[5].ToString();
                string status = equip[17].ToString();
                string equipId = equip[0].ToString();

                if (status == "1")
                {
                    comboBox1.Text = "Active";
                }
                else if (status == "2")
                {
                    comboBox1.Text = "Destroyed";
                }
                else if (status == "3")
                {
                    comboBox1.Text = "Retired";
                }
                else if (status == "4")
                {
                    comboBox1.Text = "Missing";
                }
                else if (status == "5")
                {
                    comboBox1.Text = "Scrapped for parts";
                }
                else if (status == "6")
                {
                    comboBox1.Text = "Retired";
                }
                else if (status == "7")
                {
                    comboBox1.Text = "Sold";
                }
                else if (status == "8")
                {
                    comboBox1.Text = "Unknown";
                }
                else if (status == "9")
                {
                    comboBox1.Text = "Out";
                }
                else if (status == "10")
                {
                    comboBox1.Text = "Waiting for repairs";
                }
                else if (status == "11")
                {
                    comboBox1.Text = "Lost";
                }
                this.tblRentalTableAdapter1.Fill(this.luEquipmentDataSet1.tblRental);
                DataRow rental;
                rental = luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + equipId + "'")[0];
                dateOutLabel.Text = rental[2].ToString();
                dateDueLabel.Text = rental[3].ToString();
                invoiceNumLabel.Text = rental[5].ToString();
                string studentID = rental[1].ToString();
                this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
                DataRow student;
                student = luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + studentID + "'")[0];
                stuNumbLabel.Text = student[1].ToString();
                stuNameLabel.Text = student[3].ToString() + student[2].ToString();
                accountBalanceLabel.Text = student[17].ToString();
            }
            catch
            {
                MessageBox.Show("Number not found");
            }
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow equipmentByItemNum = luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + itemNumberTextBox.Text + "'")[0];
                int itemID = int.Parse(equipmentByItemNum[0].ToString());
                LUEquipmentDataSet.tblEquipRow equipRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(itemID);
                equipRow.Status_ID = 1;
                tblEquipTableAdapter1.Update(equipRow);
                MessageBox.Show("Item returned");
            }
            catch
            {
                MessageBox.Show("Error");
            }
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

                            //Get total rentals
                            stillOutTbx.Text = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + rentalRow.Inv_Num + "'").Length.ToString();

                            if (!queuedItems.Contains(equipID))
                            {
                                queueBtn.Enabled = true;
                            }
                            statusCbx.Enabled = true;
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
                queuedItems.Add(currentItem);
                queueBtn.Enabled = false;
                processReturnsBtn.Enabled = true;
                itemsQueuedTbx.Text = queuedItems.Count.ToString();

            }
            currentItem = -1;
        }

        private void processReturnsBtn_Click(object sender, EventArgs e)
        {
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
            itemsQueuedTbx.Text = 0;
        }
    }
}
