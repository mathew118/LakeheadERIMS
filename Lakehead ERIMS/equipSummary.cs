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
        
        public equipSummary()
        {
            InitializeComponent();
        }

        private void equipSummary_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow equipmentrow;

            //if (lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumber.Text + "'").Length == 1)
            //{
    
            
                this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
                equipmentrow = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumber.Text + "'")[0];
                itemNameLabel.Text = equipmentrow[2].ToString();
                desc1Label.Text = equipmentrow[3].ToString();
                desc2Label.Text = equipmentrow[4].ToString();
                desc3Label.Text = equipmentrow[5].ToString();
                manuLabel.Text = equipmentrow[6].ToString();
                modelLabel.Text = equipmentrow[7].ToString();
                serialLabel.Text = equipmentrow[8].ToString();
                notesListBox.Text = equipmentrow[16].ToString();
                nightLabel.Text = equipmentrow[15].ToString();
                rentalFeeLabel.Text = equipmentrow[13].ToString();
                string statusID = equipmentrow[17].ToString();
                if (statusID == "1")
                {
                    statusLabel.Text = "Active";
                }else if (statusID == "2"){
                    statusLabel.Text = "Destroyed";
                }else if (statusID == "3")
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
                studentNameLabel.Text = info[3].ToString();
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


            //}
           // else
            //{
              //  MessageBox.Show("Invalid Number");
            //}
           


            
          
        }

        private void equipNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
