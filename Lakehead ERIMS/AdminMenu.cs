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
        /* TODO LIST
         * 
         * Might need to rework equipment part of the admin menu, not enough room for fields and listbox causes significant startup delay/loading times
         * Start up times still pretty bad even without equipment datatable
         */



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
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.lUEquipmentDataSet.tblSupplier);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblStatus' table. You can move, or remove it, as needed.
            this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table. You can move, or remove it, as needed.
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.lUEquipmentDataSet.tblCategory);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblLocation' table. You can move, or remove it, as needed.
            this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

        }

        private void adminFieldChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that
        }

        private void staffLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dataset should be filled but its already done in AdminMenu_Load()

            DataRow employeeRow;

            //Checks if query returns results and if so, assigns it to employeeRow
            if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_ID = '" + staffLbx.SelectedValue.ToString() + "'").Length == 1)
            {
                employeeRow = this.lUEquipmentDataSet.tblEmployee.Select("Emp_ID = '" + staffLbx.SelectedValue.ToString() + "'")[0];

                //Assigns row data to textboxes
                staffLastNameTbx.Text = employeeRow[2].ToString();
                staffFirstNameTbx.Text = employeeRow[3].ToString();
                staffUsernameTbx.Text = employeeRow[1].ToString();

                //Assign dropdown value from row
                staffTypeCbx.SelectedIndex = (employeeRow[4].ToString() == "Administrator") ? 0 : 1;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
            else
            {
                //No staff selected

                //MessageBox.Show("Error! Staff not found", "Error");
            }

        }

        private void locationsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationsLocationNameTbx.Text = locationsLbx.Text;

            //Lock save button until changes are made
            saveBtn.Enabled = false;
        }

        private void categoriesLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dataset should be filled but its already done in AdminMenu_Load()

            DataRow categoryRow;

            //Checks if query returns results and if so, assigns it to categoryRow
            if (this.lUEquipmentDataSet.tblCategory.Select("Cat_ID = '" + categoriesLbx.SelectedValue.ToString() + "'").Length == 1)
            {
                categoryRow = this.lUEquipmentDataSet.tblCategory.Select("Cat_ID = '" + categoriesLbx.SelectedValue.ToString() + "'")[0];

                //Assigns row data to textboxes
                categoriesCategoryNameTbx.Text = categoryRow[1].ToString();

                categoriesStartRangeATbx.Text = categoryRow[2].ToString().Substring(0, 3);
                categoriesStartRangeBTbx.Text = categoryRow[2].ToString().Substring(3);
                categoriesEndRangeATbx.Text = categoryRow[3].ToString().Substring(0, 3);
                categoriesEndRangeBTbx.Text = categoryRow[3].ToString().Substring(3);

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
            else
            {
                //No category selected

                //MessageBox.Show("Error! Category not found", "Error");
            }
        }

        private void equipmentLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dataset should be filled but its already done in AdminMenu_Load()

            DataRow equipmentRow;

            //Checks if query returns results and if so, assigns it to equipmentRow
            if (this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'").Length == 1)
            {
                equipmentRow = this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'")[0];

                //Assigns row data to textboxes
                equipmentItemNameTbx.Text = equipmentRow[2].ToString();

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
            else
            {
                //No equipment selected

                //MessageBox.Show("Error! Equipment not found", "Error");
            }
        }

        private void statusLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusNameTbx.Text = statusLbx.Text;

            //Lock save button until changes are made
            saveBtn.Enabled = false;
        }

        private void suppliersLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppliersNameTbx.Text = suppliersLbx.Text;

            //Lock save button until changes are made
            saveBtn.Enabled = false;
        }
    }
}
