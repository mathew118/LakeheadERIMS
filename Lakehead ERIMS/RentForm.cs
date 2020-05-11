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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table. You can move, or remove it, as needed.
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void enterStudentNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudentTableAdapter1.Fill(this.luEquipmentDataSet1.tblStudent);
                DataRow info;
                info = luEquipmentDataSet1.tblStudent.Select("Stu_Number = '" + studentNumberTextBox.Text + "'")[0];
                studentNumberLabel.Text = info[1].ToString();
                studentFNameLabel.Text = info[3].ToString();
                studentLNameLabel.Text = info[2].ToString();
                studentAddressLabe.Text = info[4].ToString();
                studentPhone.Text = info[8].ToString();
                feeTextBox.Text = info[17].ToString();
            }
            catch
            {
                MessageBox.Show("Student Number not found");
            }
         

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
                DataRow equipmentrow;
                equipmentrow = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + equipNumbTextBox.Text + "'")[0];

                itemGridView.Rows.Add(itemGridView.Rows[x].Cells[0].Value = equipmentrow[1].ToString(), itemGridView.Rows[x].Cells[1].Value = equipmentrow[2].ToString(), itemGridView.Rows[x].Cells[2].Value = equipmentrow[13].ToString());
                x++;
            }
            catch
            {
                MessageBox.Show("Item number not found");
            }


        }

        private void searchButton_Click(object sender, EventArgs e)
        {


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemGridView.SelectedRows)
            {
                itemGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in itemGridView.Rows)
                {
                    try
                    {
                        itemGridView.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (itemGridView.Rows.Count > 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calcCost_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> values = new List<int>();

                foreach (DataGridViewRow row in itemGridView.Rows)
                {
                    values.Add(int.Parse(row.Cells["Price"].Value.ToString()));
                }
                int[] array = values.ToArray();
                int[] finalArray = array.Take(array.Length - 1).ToArray();
                DateTime rent = Convert.ToDateTime(dateRentedPicker.Text);
                DateTime due = Convert.ToDateTime(dateDuePicker.Text);
                TimeSpan days = due.Subtract(rent);
                int totalDays = Convert.ToInt32(days.Days);

                double sum = finalArray.Sum();

                subtotalLabel.Text = sum.ToString();

                double beforeDaysTotal = double.Parse(subtotalLabel.Text);
                double final = totalDays * beforeDaysTotal;
                subtotalLabel.Text = final.ToString();

                if (payFeeRadioButton.Checked)
                {
                    double feeOwe = Convert.ToDouble(this.feeTextBox.Text);
                    double fee = final + feeOwe;
                    subtotalLabel.Text = fee.ToString();
                }

                double subtotalFinal = Convert.ToDouble(this.subtotalLabel.Text);

                double total = subtotalFinal * 1.13;

                double hst = subtotalFinal * 0.13;

                hstLabel.Text = hst.ToString();

                totalLabel.Text = total.ToString();



                if (waiveCheckBox.Checked)
                {
                    subtotalLabel.Text = "0";
                    hstLabel.Text = "0";
                    totalLabel.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Make sure all values are correct (Rental days, student number)");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rentalButton_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (DataGridViewRow row in itemGridView.Rows)
            {
                values.Add(row.Cells["Number"].Value.ToString());
            }

            string[] insert = values.ToArray();
            string[] finalInsert = insert.Take(insert.Length - 1).ToArray();

            List<int> equipID = new List<int>();
            int counter = 0;
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
            foreach (string i in finalInsert)
            {
                DataRow Equip;
                Equip = lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + i +"'")[0];
                equipID.Add(int.Parse(Equip[0].ToString()));
                counter++;
            }
            int[] equipIDarray = equipID.ToArray();
            int newCounter = 0;

            this.tblRentalTableAdapter1.Fill(this.lUEquipmentDataSet.tblRental);
            DataRow invoice;
            invoice = lUEquipmentDataSet.tblRental.Rows[lUEquipmentDataSet.tblRental.Count - 1];

            int inNum = Convert.ToInt32(invoice[5]);
            int studentNum = Convert.ToInt32(studentNumberTextBox.Text);
            DateTime rent = Convert.ToDateTime(dateRentedPicker.Text);
            DateTime due = Convert.ToDateTime(dateDuePicker.Text);


            foreach (int i in equipIDarray)
            {
                short array = Convert.ToInt16(equipIDarray[newCounter]);
                tblRentalTableAdapter1.Insert(array,studentNum,rent,due," ",inNum + 1);
                LUEquipmentDataSet.tblEquipRow equipRow = luEquipmentDataSet1.tblEquip.FindByEquip_ID(array);
                equipRow.Status_ID = 9;
                tblEquipTableAdapter.Update(equipRow);
                this.tblRentalTableAdapter1.Fill(this.lUEquipmentDataSet.tblRental);
            }
            MessageBox.Show("Item rented");

        }

        private void studentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
