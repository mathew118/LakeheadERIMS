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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

        }

        private void staffLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dataset should be filled but its already done in AdminMenu_Load()

            DataRow employeeRow;

            //Checks if query returns results and if so, assigns it to employeeRow
            if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + staffLbx.Text + "'").Length == 1)
            {
                employeeRow = this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + staffLbx.Text + "'")[0];

                //Assigns row data to textboxes
                staffLastNameTbx.Text = employeeRow[2].ToString();
                staffFirstNameTbx.Text = employeeRow[3].ToString();
                staffUsernameTbx.Text = employeeRow[1].ToString();

                //Assign dropdown value from row
                staffTypeCbx.SelectedIndex = (employeeRow[4].ToString() == "Administrator") ? 0 : 1;

            }
            else
            {
                MessageBox.Show("Error! Staff not found", "Error");
            }

        }

        private void adminTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            //TODO Make if statements that automatically query the selected index of listboxes into the fields. (ALSO MAKE SURE THE LISTBOX ISNT EMPTY)
        }
    }
}
