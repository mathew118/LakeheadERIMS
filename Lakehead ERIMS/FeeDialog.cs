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
    public partial class FeeDialog : Form
    {
        int invoiceNumber = -1;
        int studentId = -1;
        double lateFee = 0;

        public bool handled = false;

        public FeeDialog(int invoiceNum, double LateFee, int studentID)
        {
            invoiceNumber = invoiceNum;
            InitializeComponent();
            lateFee = LateFee;
            studentId = studentID;
            
        }

        private void FeeDialog_Load(object sender, EventArgs e)
        {
            if(invoiceNumber != -1)
            {
                tblRentalTableAdapter1.Fill(luEquipmentDataSet1.tblRental);

                invoiceLateFeesTbx.Text = lateFee.ToString("C");
                invoiceNumberTbx.Text = invoiceNumber.ToString();

            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            tblStudentTableAdapter1.Fill(luEquipmentDataSet1.tblStudent);

            if (invoiceLateFeesTbx.Text != (0).ToString("C"))
            {
                if (waiveLateFeesCbx.Checked || payLateFeesCbx.Checked || accumulateLateFeesCbx.Checked)
                {
                    if (accumulateLateFeesCbx.Checked)
                    {
                        if (this.luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + studentId + "'").Length > 0)
                        {
                            LUEquipmentDataSet.tblStudentRow studentRow = (LUEquipmentDataSet.tblStudentRow)luEquipmentDataSet1.tblStudent.Select("Stu_ID = '" + studentId + "'")[0];
                            float stuOwes = (!studentRow.IsStu_OweNull()) ? studentRow.Stu_Owe : 0;

                            stuOwes += float.Parse(invoiceLateFeesTbx.Text, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo);

                            studentRow.Stu_Owe = stuOwes;
                            tblStudentTableAdapter1.Update(studentRow);
                        }
                        else
                        {
                            MessageBox.Show("Unable to find student.", "Error");
                        }
                    }
                    handled = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select an option.", "Error");
                }
            }
        }
    }
}
