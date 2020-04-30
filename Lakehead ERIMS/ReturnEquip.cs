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
        public ReturnEquip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            rental = luEquipmentDataSet1.tblRental.Select("Equip_ID = '" + equipId +"'")[0];
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

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
