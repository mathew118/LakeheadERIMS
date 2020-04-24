﻿using System;
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
         * Long startup times caused by the tableadapter.fills, I improved it a lot, but see if I can smooth it out any more.
         * Also maybe shouldnt have the whole DB in memory, they prob have old computers, empty tables when their tabs aren't open
         * 
         * Equipment tab is going to need multiple tables loaded such as suppliers, status, location, so I need to rework table loading.
         */



        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Shown(object sender, EventArgs e)
        {
            //Load equipment table as this is the first tab opened on startup
            Application.DoEvents();
            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);

            //Set the first item as selected
            if (equipmentLbx.Items.Count > 0)
            {
                equipmentLbx.SetSelected(0, true);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets the form size based on which tab is selected
            if(adminTabControl.SelectedIndex == 0)
            {
                ActiveForm.Size = new Size(460, 566);
                adminTabControl.Size = new Size(420, 426);
                addBtn.Location = new Point(40, 460);
                saveBtn.Location = new Point(177, 460);
                exitBtn.Location = new Point(315, 460);
            }
            else
            {
                ActiveForm.Size = new Size(430, 412);
                adminTabControl.Size = new Size(390, 272);
                addBtn.Location = new Point(40, 306);
                saveBtn.Location = new Point(160, 306);
                exitBtn.Location = new Point(280, 306);
            }

            //This pulls data from the database based on which tab you have open in order to reduce load times. It also checks if it's empty so that it only loads once.
            //Equipment Tab
            if(adminTabControl.SelectedIndex == 0)
            {               
                if (this.lUEquipmentDataSet.tblEquip.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table.
                    Application.DoEvents();
                    this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);

                    if(equipmentLbx.Items.Count > 0)
                    {
                        equipmentLbx.SetSelected(0, true);
                    }
                }
            }

            //Categories Tab
            else if (adminTabControl.SelectedIndex == 1)
            {
                if (this.lUEquipmentDataSet.tblCategory.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblCategory' table.
                    Application.DoEvents();
                    this.tblCategoryTableAdapter.Fill(this.lUEquipmentDataSet.tblCategory);

                    if (categoriesLbx.Items.Count > 0)
                    {
                        categoriesLbx.SetSelected(0, true);
                    }
                }
            }

            //Locations Tab
            else if (adminTabControl.SelectedIndex == 2)
            {
                if (this.lUEquipmentDataSet.tblLocation.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblLocation' table.
                    Application.DoEvents();
                    this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);

                    if (locationsLbx.Items.Count > 0)
                    {
                        locationsLbx.SetSelected(0, true);
                    }
                }
            }

            //Staff Tab
            else if (adminTabControl.SelectedIndex == 3)
            {
                if (this.lUEquipmentDataSet.tblEmployee.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblEmployee' table.
                    Application.DoEvents();
                    this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

                    if (staffLbx.Items.Count > 0)
                    {
                        staffLbx.SetSelected(0, true);
                    }
                }
            }

            //Status Tab
            else if (adminTabControl.SelectedIndex == 4)
            {
                if (this.lUEquipmentDataSet.tblStatus.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblStatus' table.
                    Application.DoEvents();
                    this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);

                    if (statusLbx.Items.Count > 0)
                    {
                        statusLbx.SetSelected(0, true);
                    }
                }
            }

            //Suppliers Tab
            else if (adminTabControl.SelectedIndex == 5)
            {
                if (this.lUEquipmentDataSet.tblSupplier.Rows.Count == 0)
                {
                    //This line of code loads data into the 'lUEquipmentDataSet.tblSupplier' table.
                    Application.DoEvents();
                    this.tblSupplierTableAdapter.Fill(this.lUEquipmentDataSet.tblSupplier);

                    if (suppliersLbx.Items.Count > 0)
                    {
                        suppliersLbx.SetSelected(0, true);
                    }
                }
            }
        }

        private void adminFieldChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that
            saveBtn.Enabled = false;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that
        }

        private void staffLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRow employeeRow;

            //Checks if listbox isn't empty
            if (staffLbx.SelectedValue != null)
            {
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

        }

        private void locationsLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (locationsLbx.SelectedValue != null)
            {
                locationsLocationNameTbx.Text = locationsLbx.Text;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
        }

        private void categoriesLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRow categoryRow;

            //Checks if listbox isn't empty
            if (categoriesLbx.SelectedValue != null)
            {
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
        }

        private void equipmentLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRow equipmentRow;

            //Checks if listbox isn't empty
            if (equipmentLbx.SelectedValue != null)
            {
                //Checks if query returns results and if so, assigns it to equipmentRow
                if (this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'").Length == 1)
                {
                    equipmentRow = this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'")[0];

                    //Assigns row data to textboxes
                    equipmentItemNumberSearchATbx.Text = equipmentRow[1].ToString().Substring(0, 3);
                    equipmentItemNumberSearchBTbx.Text = equipmentRow[1].ToString().Substring(3);
                    equipmentItemNameTbx.Text = equipmentRow[2].ToString();
                    equipmentDescription1Tbx.Text = equipmentRow[3].ToString();
                    equipmentDescription2Tbx.Text = equipmentRow[4].ToString();
                    equipmentDescription3Tbx.Text = equipmentRow[5].ToString();
                    equipmentManufacturerTbx.Text = equipmentRow[6].ToString();
                    equipmentModelTbx.Text = equipmentRow[7].ToString();
                    equipmentSerialNumberTbx.Text = equipmentRow[8].ToString();
                    equipmentPurchasePriceTbx.Text = equipmentRow[11].ToString();
                    equipmentPONumberTbx.Text = equipmentRow[12].ToString();
                    equipmentRentalFeeTbx.Text = equipmentRow[13].ToString();
                    equipmentLateFeeTbx.Text = equipmentRow[14].ToString();
                    equipmentNightsRentedTbx.Text = equipmentRow[15].ToString();
                    equipmentNotesTbx.Text = equipmentRow[16].ToString();

                    


                    //Lock save button until changes are made
                    saveBtn.Enabled = false;
                }
                else
                {
                    //No equipment selected

                    //MessageBox.Show("Error! Equipment not found", "Error");
                }
            }
        }

        private void statusLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (statusLbx.SelectedValue != null)
            {

                statusNameTbx.Text = statusLbx.Text;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
        }

        private void suppliersLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (suppliersLbx.SelectedValue != null)
            {
                suppliersNameTbx.Text = suppliersLbx.Text;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
        }
    }
}
