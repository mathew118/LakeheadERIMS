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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblRentalTableAdapter1.Fill(this.luEquipmentDataSet1.tblRental);
                DataRow rental;
                rental = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + invoiceNumberTextbox.Text + "'")[0];
                dateOutPicker.Text = rental[2].ToString();
                DueDatePicker.Text = rental[3].ToString();
                string stu_ID = rental[1].ToString();
                this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
                DataRow student;
                student = luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + stu_ID + "'")[0];
                studentFirstNameLabel.Text = student[3].ToString();
                studentLastNameLabel.Text = student[2].ToString();
                studentNumberLabel.Text = student[1].ToString();
                string equipID = rental[0].ToString();
                this.tblEquipTableAdapter1.Fill(this.luEquipmentDataSet1.tblEquip);
                DataRow equip;
                equip = luEquipmentDataSet1.tblEquip.Select("Equip_ID = '" + equipID + "'")[0];
                equipNameLabel.Text = equip[2].ToString();
                equipNumberLabel.Text = equip[1].ToString();
            }
            catch
            {
                MessageBox.Show("Invoice number not found");
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            /*
            this.tblRentalTableAdapter1.Fill(this.luEquipmentDataSet1.tblRental);
            DataRow rental;
            rental = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + invoiceNumberTextbox.Text + "'")[0];
            int stuID = Int32.Parse(rental[1].ToString());
            DateTime datetime = DateTime.Parse(dateOutPicker.Text);
            DateTime datetimeDue = DateTime.Parse(DueDatePicker.Text);
            short st = Convert.ToInt16(rental[5].ToString());
            DateTime oldDate = DateTime.Parse(rental[2].ToString());
            DateTime oldDate2 = DateTime.Parse(rental[3].ToString());
            int invoice = int.Parse(rental[5].ToString());
            tblRentalTableAdapter1.Update(stuID, datetime, datetimeDue, rental[4].ToString(), st, stuID, oldDate, oldDate2, rental[4].ToString(), invoice);
            MessageBox.Show("Updated");
            */

            this.tblRentalTableAdapter1.Fill(this.luEquipmentDataSet1.tblRental);
            DataRow rental;
            rental = luEquipmentDataSet1.tblRental.Select("Inv_Num = '" + invoiceNumberTextbox.Text + "'")[0];
            short equipID = Convert.ToInt16(rental[0].ToString());

            int invoice = Convert.ToInt32(invoiceNumberTextbox.Text);
            LUEquipmentDataSet.tblRentalRow rentalRow = luEquipmentDataSet1.tblRental.FindByEquip_IDInv_Num(equipID, invoice);
            DateTime dateOut = Convert.ToDateTime(dateOutPicker.Text);
            DateTime dateDue = Convert.ToDateTime(DueDatePicker.Text);
            rentalRow.Rent_DateOut = dateOut;
            rentalRow.Rent_DateOut = dateDue;
            
            tblRentalTableAdapter1.Update(rentalRow);
            MessageBox.Show("Updated Successfully");


        }
    }
}
