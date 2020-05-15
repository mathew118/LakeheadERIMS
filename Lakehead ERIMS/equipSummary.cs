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
    public partial class equipSummary : Form
    {
        string equipNumber;

        public equipSummary()
        {
            InitializeComponent();
        }

        private void equipSummary_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
        private void ClearLabel() {
            equipNumberLbl.Text ="";
            itemNameLabel.Text = "";
            studentNumberLabel.Text = "";
            studentNameLabel.Text = "";
            studentPhoneLabel.Text = "";
            dateDueLabel.Text = "";
            desc1Label.Text = "";
            desc2Label.Text = "";
            desc3Label.Text = "";
            manuLabel.Text = "";
            modelLabel.Text = "";
            serialLabel.Text = "";
            noteLbl.Text = "";
            nightLabel.Text = "";
            rentalFeeLabel.Text = "";
            statusLabel.Text = "";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow equipmentrow;


            ClearLabel(); 
            try
            {
                this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
                equipNumber = equipNumber1.Text + equipNumber2.Text;
                equipNumberLbl.Text = equipNumber;
                equipmentrow = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumber + "'")[0];
                itemNameLabel.Text = equipmentrow[2].ToString();
                desc1Label.Text = equipmentrow[3].ToString();
                desc2Label.Text = equipmentrow[4].ToString();
                desc3Label.Text = equipmentrow[5].ToString();
                manuLabel.Text = equipmentrow[6].ToString();
                modelLabel.Text = equipmentrow[7].ToString();
                serialLabel.Text = equipmentrow[8].ToString();
                noteLbl.Text = equipmentrow[16].ToString();//fixed Note listbox
                nightLabel.Text = equipmentrow[15].ToString();
                rentalFeeLabel.Text = equipmentrow[13].ToString();
                string statusID = equipmentrow[17].ToString();
                if (statusID == "1")
                {
                    statusLabel.Text = "Active";
                }
                else if (statusID == "2")
                {
                    statusLabel.Text = "Destroyed";
                }
                else if (statusID == "3")
                {
                    statusLabel.Text = "Retired";
                }
                else if (statusID == "4")
                {
                    statusLabel.Text = "Missing";
                }
                else if (statusID == "5")
                {
                    statusLabel.Text = "Scrapped for parts";
                }
                else if (statusID == "6")
                {
                    statusLabel.Text = "Retired";
                }
                else if (statusID == "7")
                {
                    statusLabel.Text = "Sold";
                }
                else if (statusID == "8")
                {
                    statusLabel.Text = "Unknown";
                }
                else if (statusID == "9")
                {
                    statusLabel.Text = "Out";
                    string EquipID = equipmentrow[0].ToString();
                    this.tblRentalTableAdapter1.Fill(this.lUEquipmentDataSet.tblRental);
                    DataRow rentalDS;
                    rentalDS = lUEquipmentDataSet.tblRental.Select("Equip_ID = '" + equipmentrow[0].ToString() + "'")[0];
                    dateDueLabel.Text = rentalDS[3].ToString();
                    string stuID = rentalDS[1].ToString();
                    this.tblStudentTableAdapter1.Fill(this.lUEquipmentDataSet.tblStudent);
                    DataRow info;
                    info = lUEquipmentDataSet.tblStudent.Select("Stu_ID = '" + stuID + "'")[0];
                    studentNumberLabel.Text = info[1].ToString();
                    studentNameLabel.Text = info[3].ToString() + " " + info[2].ToString(); //Student name now shows full name not just first name
                    studentPhoneLabel.Text = info[8].ToString();

                }
                else if (statusID == "10")
                {
                    statusLabel.Text = "Waiting Repaires";
                }
                else if (statusID == "11")
                {
                    statusLabel.Text = "Lost";
                }
            }
            catch
            {
                ClearLabel();
                MessageBox.Show("Invailid number","Error");
            }

            //clear item number textboxes, shift focus back to the top
            equipNumber1.Clear();
            equipNumber2.Clear();
            equipNumber1.Focus();
            //}
           // else
            //{
              //  MessageBox.Show("Invalid Number");
            //}
        }

        //automatically shift focus to the second textbox 
        private void equipNumber1_TextChanged(object sender, EventArgs e)
        {
            if (equipNumber1.Text.Length == 3)
            {
                equipNumber2.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ClearLabel();
            DataRow equipmentrow;
            try
            {
                this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);

                equipmentrow = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumberLbl.Text + "'")[0];
                //
                int indexOfEquipment = lUEquipmentDataSet.tblEquip.Rows.IndexOf(equipmentrow);
                indexOfEquipment++;

                if (indexOfEquipment <= lUEquipmentDataSet.tblEquip.Rows.Count)
                {
                    equipmentrow = lUEquipmentDataSet.tblEquip.Rows[indexOfEquipment];
                }

                equipNumberLbl.Text = equipmentrow[1].ToString();
                itemNameLabel.Text = equipmentrow[2].ToString();
                desc1Label.Text = equipmentrow[3].ToString();
                desc2Label.Text = equipmentrow[4].ToString();
                desc3Label.Text = equipmentrow[5].ToString();
                manuLabel.Text = equipmentrow[6].ToString();
                modelLabel.Text = equipmentrow[7].ToString();
                serialLabel.Text = equipmentrow[8].ToString();
                noteLbl.Text = equipmentrow[16].ToString();//fixed Note listbox
                nightLabel.Text = equipmentrow[15].ToString();
                rentalFeeLabel.Text = equipmentrow[13].ToString();
                string statusID = equipmentrow[17].ToString();
                if (statusID == "1")
                {
                    statusLabel.Text = "Active";
                }
                else if (statusID == "2")
                {
                    statusLabel.Text = "Destroyed";
                }
                else if (statusID == "3")
                {
                    statusLabel.Text = "Retired";
                }
                else if (statusID == "4")
                {
                    statusLabel.Text = "Missing";
                }
                else if (statusID == "5")
                {
                    statusLabel.Text = "Scrapped for parts";
                }
                else if (statusID == "6")
                {
                    statusLabel.Text = "Retired";
                }
                else if (statusID == "7")
                {
                    statusLabel.Text = "Sold";
                }
                else if (statusID == "8")
                {
                    statusLabel.Text = "Unknown";
                }
                else if (statusID == "9")
                {
                    statusLabel.Text = "Out";
                    string EquipID = equipmentrow[0].ToString();
                    this.tblRentalTableAdapter1.Fill(this.lUEquipmentDataSet.tblRental);
                    DataRow rentalDS;
                    rentalDS = lUEquipmentDataSet.tblRental.Select("Equip_ID = '" + equipmentrow[0].ToString() + "'")[0];
                    dateDueLabel.Text = rentalDS[3].ToString();
                    string stuID = rentalDS[1].ToString();
                    this.tblStudentTableAdapter1.Fill(this.lUEquipmentDataSet.tblStudent);
                    DataRow info;
                    info = lUEquipmentDataSet.tblStudent.Select("Stu_ID = '" + stuID + "'")[0];
                    studentNumberLabel.Text = info[1].ToString();
                    studentNameLabel.Text = info[3].ToString() + " " + info[2].ToString(); //Student name now shows full name not just first name
                    studentPhoneLabel.Text = info[8].ToString();

                }
                else if (statusID == "10")
                {
                    statusLabel.Text = "Waiting Repaires";
                }
                else if (statusID == "11")
                {
                    statusLabel.Text = "Lost";
                }
            }
            catch
            {
                ClearLabel();
                MessageBox.Show("Invailid number", "Error");
            }

            //clear item number textboxes, shift focus back to the top
            equipNumber1.Clear();
            equipNumber2.Clear();
            equipNumber1.Focus();
            //}
            // else
            //{
            //  MessageBox.Show("Invalid Number");
            //}
        }
    }
}
