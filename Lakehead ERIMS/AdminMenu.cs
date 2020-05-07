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
         * !!!!!!!!!!!!!!!!!!!! EQUIPMENT !!!!!!!!!!!!!!!!!!!!
         * Need to figure out which fields are required and which are not, and need to include the ability to empty those comboboxes & date.
         * Add proper nights calculating (Remember the DB value is the TOTAL CUMALATIVE, the field will contain the nights from current rental)
         * Add button/ability to clear comboboxes and datepicker.
         * See if I can make it so when you go to edit an empty purchase date, it doesn't start at 1899.
         * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         * 
         * 
         * Long startup times caused by the tableadapter.fills, I improved it a lot, but see if I can smooth it out any more.
         * Also maybe shouldnt have the whole DB in memory, they prob have old computers, empty tables when their tabs aren't open
         * 
         * I should also make certain status rows permanent since other parts of the application rely on certain status and their index
         * 
         * Duplicate names may cause issues.
         * 
         * ERIC's COMMENTS
         * 1. I assume that all of the tabs on this menu allow for changes. updates, deletion, of the appropriate data (ie equipment, locations. etc)
         * 2. The large drop-down box with equipment in it, located at the top - interesting idea - Is that so that I can scroll through and pick an item to enter the details below? If so, more detail is needed there - specifically the item number. Also, can one jump to an item or does it need to be scrolled though - there are 9,000 items in the inventory. (ADD ITEM NUMBERS TO THE LISTBOX)
         * 3. the item number field by the Search Button can be shortened or at least limited to the input length -  each section is only 3 digits - visually if you could add a dash (hyphen) between the two boxes that would look more like how they appear on the inventory items (ADD HYPEN IN-BETWEEN AND LIMIT CHARACTERS TO 3 EACH)
         * 4. The boxes that display text (eg Item Name, Description 1, Model, etc) will need to be wider to accommodate the full text - the sample you have here has short data, but many are longer  - try some other items like 371-117, 860-257, 980-218 See the Equipment table (tblEquip) in the MSAccess inventory file to see the field lengths. (WIDEN FIELDS)
         * 5. Notes field will also need to be wider so that more than a few words are displayed at once (WIDEN FIELD)
         * 6. Nights Rented field - this needs to be a calculated field so that each night it is rented it will add to this number. (THE COLUMN IN THE TABLE IS THE CUMULATIVE TOTAL OF THE NIGHTS RENTED, THIS FIELD SHOULD DISPLAY THE AMOUNT FOR THIS PARTICULAR RENTAL?)
         * 7. The price and fees fields should be displayed as $175.00 rather than just 175 (FORMAT TEXT ACCORDINGLY)
         * 8. Will there be error messages that pop up, eg typing in an equipment number that does not exist. Currently, a message comes up saying it does not exist, do you want to create it? - this would be helpful. (ADD PROPER ERROR CHECKING AND ERROR MESSAGES)
         * Make sure when equipment is rented out, total rental days are added to nights. If The rental is cancelled or returned early, it should subtract the remaining days from equipment nights.
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
            this.tblSupplierTableAdapter.Fill(this.lUEquipmentDataSet.tblSupplier);
            this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);
            this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);
            
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
                ActiveForm.Size = new Size(600, 566);
                adminTabControl.Size = new Size(560, 426);
                addBtn.Location = new Point(40, 460);
                saveBtn.Location = new Point(249, 460);
                exitBtn.Location = new Point(458, 460);
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
                }

                if (equipmentLbx.Items.Count > 0)
                {
                    equipmentLbx.SetSelected(0, true);
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
                }

                if (categoriesLbx.Items.Count > 0)
                {
                    categoriesLbx.SetSelected(0, true);
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
                }

                if (locationsLbx.Items.Count > 0)
                {
                    locationsLbx.SetSelected(0, true);
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
                }

                if (staffLbx.Items.Count > 0)
                {
                    staffLbx.SetSelected(0, true);
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
                }

                if (statusLbx.Items.Count > 0)
                {
                    statusLbx.SetSelected(0, true);
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
                }

                if (suppliersLbx.Items.Count > 0)
                {
                    suppliersLbx.SetSelected(0, true);
                }
            }
        }

        private void adminFieldChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
            
        }

        private void equipmentDatePurchasedDpk_ValueChanged(object sender, EventArgs e)
        {
            if(equipmentDatePurchasedDpk.Value == DateTime.FromOADate(0))
            {
                equipmentDatePurchasedDpk.Format = DateTimePickerFormat.Custom;
                equipmentDatePurchasedDpk.CustomFormat = " ";
            }
            else
            {
                equipmentDatePurchasedDpk.Format = DateTimePickerFormat.Long;
            }                                            
        }

        private void HandleNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void equipmentLbx_Format(object sender, ListControlConvertEventArgs e)
        {
            string itemNumber = ((DataRowView)e.ListItem)[1].ToString();
            string itemName = ((DataRowView)e.ListItem)[2].ToString();

            e.Value = itemNumber.Substring(0, 3) + "-" + itemNumber.Substring(3) + ": " + itemName;
        }

        private void equipmentLocationClearBtn_Click(object sender, EventArgs e)
        {
            equipmentHomeLocationCbx.SelectedIndex = -1;
        }

        private void equipmentSupplierClearBtn_Click(object sender, EventArgs e)
        {
            equipmentSupplierCbx.SelectedIndex = -1;
        }

        private void equipmentPurchaseDateClearBtn_Click(object sender, EventArgs e)
        {
            equipmentDatePurchasedDpk.Value = DateTime.FromOADate(0);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that

            
            //Equipment
            if(adminTabControl.SelectedIndex == 0)
            {
                string newItemNum = equipmentItemNumberATbx.Text + equipmentItemNumberBTbx.Text;
                string newItemName = equipmentItemNameTbx.Text.Trim();
                string newDescription1 = equipmentDescription1Tbx.Text.Trim();
                string newDescription2 = equipmentDescription2Tbx.Text.Trim();
                string newDescription3 = equipmentDescription3Tbx.Text.Trim();
                string newNotes = equipmentNotesTbx.Text.Trim();
                DateTime newPurchaseDate = equipmentDatePurchasedDpk.Value;
                string newPurchasePrice = equipmentPurchasePriceTbx.Text.Trim();
                string newPONumber = equipmentPONumberTbx.Text.Trim();
                string newManufacturer = equipmentManufacturerTbx.Text.Trim();
                string newModel = equipmentModelTbx.Text.Trim();
                string newSerialNumber = equipmentSerialNumberTbx.Text.Trim();
                string newRentalFee = equipmentRentalFeeTbx.Text.Trim();
                string newLateFee = equipmentLateFeeTbx.Text.Trim();
                float newPurchasePriceFlt = -1;
                float newRentalFeeFlt = -1;
                float newLateFeeFlt = -1;
                short? newStatusId = (equipmentStatusCbx.SelectedIndex != -1) ? short.Parse(equipmentStatusCbx.SelectedValue.ToString()) : (short?)null;
                int? newLocationId = (equipmentHomeLocationCbx.SelectedIndex != -1) ? int.Parse(equipmentHomeLocationCbx.SelectedValue.ToString()) : (int?)null;              
                short? newSupplierId = (equipmentSupplierCbx.SelectedIndex != -1) ? short.Parse(equipmentSupplierCbx.SelectedValue.ToString()) : (short?)null;            

                //Validate Input
                if(newItemNum.Length != 6 || !int.TryParse(newItemNum, out int tempItemNum))
                {
                    MessageBox.Show("Item number is invalid.", "Error");
                }
                //If an item with the same number exists and you're adding new, or an item with the same number exists and you're not editing that same item, show an error
                else if ((this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + newItemNum + "'").Length > 0) && (equipmentLbx.SelectedIndex == -1 || (equipmentLbx.SelectedIndex != -1 && lUEquipmentDataSet.tblEquip.FindByEquip_ID(int.Parse(equipmentLbx.SelectedValue.ToString())).Equip_Number != newItemNum)) )
                {
                    MessageBox.Show("An item with that equipment number already exists.", "Error");
                }
                else if (newPurchasePrice.Length != 0 && !float.TryParse(newPurchasePrice, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out newPurchasePriceFlt))
                {
                    MessageBox.Show("Purchase price is invalid, please enter in the following format: 123.45", "Error");
                }
                //Rental Fee is not optional
                else if (newRentalFee.Length == 0 || !float.TryParse(newRentalFee, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out newRentalFeeFlt))
                {
                    MessageBox.Show("Rental fee is invalid, please enter in the following format: 123.45", "Error");
                }
                else if (newLateFee.Length != 0 && !float.TryParse(newLateFee, System.Globalization.NumberStyles.Currency, System.Globalization.NumberFormatInfo.CurrentInfo, out newLateFeeFlt))
                {
                    MessageBox.Show("Late fee is invalid, please enter in the following format: 123.45", "Error");
                }
                else if (!newStatusId.HasValue)
                {
                    MessageBox.Show("Status invalid, please select a status", "Error");
                }
                else
                {
                    //Validated

                    //Add New
                    if (equipmentLbx.SelectedIndex == -1)
                    {

                        //Insert row                  
                        tblEquipTableAdapter.Insert(newItemNum, newItemName, newDescription1, newDescription2, newDescription3, newManufacturer, newModel, newSerialNumber, newSupplierId, newPurchaseDate, (newPurchasePriceFlt != -1) ? newPurchasePriceFlt : (float?)null, newPONumber, (newRentalFeeFlt != -1) ? newRentalFeeFlt : (float?)null, (newLateFeeFlt != -1) ? newLateFeeFlt : (float?)null, 0, newNotes, newStatusId, newLocationId);
                        this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);

                        //Maintain current row selection
                        int equipmentListboxIndex = equipmentLbx.FindStringExact(newItemNum.Substring(0, 3) + "-" + newItemNum.Substring(3) + ": " + newItemName);
                        if (equipmentListboxIndex != -1)
                        {
                            equipmentLbx.SetSelected(equipmentListboxIndex, true);
                        }
                        saveBtn.Enabled = false;

                    }
                    //Update
                    else
                    {
                        int equipmentIndex = -1;
                        int.TryParse(equipmentLbx.SelectedValue.ToString(), out equipmentIndex);
                        int equipmentListboxIndex = equipmentLbx.SelectedIndex;


                        if (equipmentIndex != -1)
                        {
                            //It'd be better to just add an updateById to the table adapter but am unable to do that due to collaborators. Regular Update() was causing errors with nulls in the old values
                            LUEquipmentDataSet.tblEquipRow equipmentRow = lUEquipmentDataSet.tblEquip.FindByEquip_ID(equipmentIndex);
                            
                            equipmentRow.Equip_Number = newItemNum;
                            equipmentRow.Equip_Name = newItemName; 
                            equipmentRow.Equip_Descrip1 = newDescription1;
                            equipmentRow.Equip_Descrip2 = newDescription2;
                            equipmentRow.Equip_Descrip3 = newDescription3;
                            equipmentRow.Equip_Notes = newNotes;                      
                            equipmentRow.Equip_PONumber = newPONumber;
                            equipmentRow.Equip_Manufacturer = newManufacturer;
                            equipmentRow.Equip_Model = newModel;
                            equipmentRow.Equip_Serial = newSerialNumber;
                            if (newRentalFeeFlt != -1) { equipmentRow.Equip_RentalPrice = newRentalFeeFlt; } else { equipmentRow.SetEquip_RentalPriceNull(); }
                            if (newLateFeeFlt != -1) { equipmentRow.Equip_LateFee = newLateFeeFlt; } else { equipmentRow.SetEquip_LateFeeNull(); }
                            if (newPurchasePriceFlt != -1) { equipmentRow.Equip_Price = newPurchasePriceFlt; } else { equipmentRow.SetEquip_PriceNull(); }
                            if (newPurchaseDate != DateTime.FromOADate(0)) { equipmentRow.Equip_DatePurch = newPurchaseDate; } else { equipmentRow.SetEquip_DatePurchNull(); }
                            if (newStatusId.HasValue) { equipmentRow.Status_ID = newStatusId.Value; } else { equipmentRow.SetStatus_IDNull(); }
                            if (newLocationId.HasValue) { equipmentRow.Loc_ID = newLocationId.Value; } else{ equipmentRow.SetLoc_IDNull(); }
                            if (newSupplierId.HasValue) { equipmentRow.Supp_ID = newSupplierId.Value; } else { equipmentRow.SetSupp_IDNull(); }

                            //Update row                  
                            tblEquipTableAdapter.Update(equipmentRow);
                            this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);

                            //Maintain current row selection
                            equipmentListboxIndex = equipmentLbx.FindStringExact(newItemNum.Substring(0, 3) + "-" + newItemNum.Substring(3) + ": " + newItemName);
                            if (equipmentListboxIndex != -1)
                            {
                                equipmentLbx.SetSelected(equipmentListboxIndex, true);
                            }
                            saveBtn.Enabled = false; 
                        }
                        else
                        {
                            MessageBox.Show("Invalid item selected.", "Error");
                        }
                    }
                }             
            }

            //Categories
            else if(adminTabControl.SelectedIndex == 1)
            {
                //Add New
                if (categoriesLbx.SelectedIndex == -1)
                {
                    string newCategoryName = categoriesCategoryNameTbx.Text.Trim();
                    string newCategoryStart = categoriesStartRangeATbx.Text + categoriesStartRangeBTbx.Text;
                    string newCategoryEnd = categoriesEndRangeATbx.Text + categoriesEndRangeBTbx.Text;
                    //Checks if both start and end range are entirely numeric
                    bool startNumeric = int.TryParse(newCategoryStart, out int tempStart);
                    bool endNumeric = int.TryParse(newCategoryEnd, out int tempEnd);

                    //Validate input
                    if (newCategoryName.Length > 0 && newCategoryStart.Length == 6 && newCategoryEnd.Length == 6 && startNumeric && endNumeric)
                    {
                        //Add row                  
                        tblCategoryTableAdapter.Insert(newCategoryName, newCategoryStart, newCategoryEnd);
                        this.tblCategoryTableAdapter.Fill(this.lUEquipmentDataSet.tblCategory);

                        //Select row
                        int categoryListboxIndex = categoriesLbx.FindStringExact(newCategoryName);
                        if (categoryListboxIndex != -1)
                        {
                            categoriesLbx.SetSelected(categoryListboxIndex, true);
                        }
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Category name empty or range invalid.", "Error");
                    }

                }
                //Update
                else
                {
                    int categoryIndex = -1;
                    int.TryParse(categoriesLbx.SelectedValue.ToString(), out categoryIndex);
                    int categoryListboxIndex = categoriesLbx.SelectedIndex;


                    if (categoryIndex != -1)
                    {
                        string newCategoryName = categoriesCategoryNameTbx.Text.Trim();
                        string newCategoryStart = categoriesStartRangeATbx.Text + categoriesStartRangeBTbx.Text;
                        string newCategoryEnd = categoriesEndRangeATbx.Text + categoriesEndRangeBTbx.Text;
                        //Checks if both start and end range are entirely numeric
                        bool startNumeric = int.TryParse(newCategoryStart, out int tempStart);
                        bool endNumeric = int.TryParse(newCategoryEnd, out int tempEnd);

                        //Validate input
                        if (newCategoryName.Length > 0 && newCategoryStart.Length == 6 && newCategoryEnd.Length == 6 && startNumeric && endNumeric)
                        {
                            //Update row                  
                            tblCategoryTableAdapter.Update(newCategoryName, newCategoryStart, newCategoryEnd, categoryIndex, lUEquipmentDataSet.tblCategory.FindByCat_ID(categoryIndex).Cat_Name, lUEquipmentDataSet.tblCategory.FindByCat_ID(categoryIndex).Cat_IDStart, lUEquipmentDataSet.tblCategory.FindByCat_ID(categoryIndex).Cat_IDEnd);
                            this.tblCategoryTableAdapter.Fill(this.lUEquipmentDataSet.tblCategory);

                            //Maintain current row selection
                            categoryListboxIndex = categoriesLbx.FindStringExact(newCategoryName);
                            if (categoryListboxIndex != -1)
                            {
                                categoriesLbx.SetSelected(categoryListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Category name empty or range invalid.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid category selected.", "Error");
                    }
                }
            }

            //Locations
            else if (adminTabControl.SelectedIndex == 2)
            {
                //Add New
                if(locationsLbx.SelectedIndex == -1)
                {
                    string newLocationName = locationsLocationNameTbx.Text.Trim();

                    //Validate input
                    if (newLocationName.Length > 0)
                    {
                        //Add row                  
                        tblLocationTableAdapter.Insert(newLocationName);
                        this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);

                        //Select row
                        int locationListboxIndex = locationsLbx.FindStringExact(newLocationName);
                        if (locationListboxIndex != -1)
                        {
                            locationsLbx.SetSelected(locationListboxIndex, true);
                        }
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Location name cannot be empty.", "Error");
                    }
                    
                }
                //Update
                else
                {
                    int locationIndex = -1;
                    int.TryParse(locationsLbx.SelectedValue.ToString(), out locationIndex);
                    int locationListboxIndex = locationsLbx.SelectedIndex;

                    if (locationIndex != -1)
                    {
                        string newLocationName = locationsLocationNameTbx.Text.Trim();

                        //Validate input
                        if (newLocationName.Length > 0)
                        {
                            //Update row                  
                            tblLocationTableAdapter.Update(newLocationName, locationIndex, lUEquipmentDataSet.tblLocation.FindByLoc_ID(locationIndex).Loc_Name);
                            this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);

                            //Maintain current row selection
                            locationListboxIndex = locationsLbx.FindStringExact(newLocationName);
                            if (locationListboxIndex != -1)
                            {
                                locationsLbx.SetSelected(locationListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Location name cannot be empty.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid location selected.", "Error");
                    }
                }                
            }

            //Staff
            else if (adminTabControl.SelectedIndex == 3)
            {
                //Add New
                if (staffLbx.SelectedIndex == -1)
                {
                    string newStaffUsername = staffUsernameTbx.Text.Trim();
                    string newStaffLastName = staffLastNameTbx.Text.Trim();
                    string newStaffFirstName = staffFirstNameTbx.Text.Trim();
                    string newStaffType = staffTypeCbx.Text;
                    string newStaffPassword = staffPasswordResetTbx.Text.Trim();

                    //Validate input
                    if (newStaffUsername.Length > 0 && newStaffLastName.Length > 0 && newStaffFirstName.Length > 0 && newStaffType.Length > 0)
                    {
                        if (newStaffPassword.Length > 0)
                        {
                            //Add row                  
                            tblEmployeeTableAdapter.Insert(newStaffUsername, newStaffLastName, newStaffFirstName, newStaffType, newStaffPassword);
                            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

                            //Select row
                            int employeeListboxIndex = staffLbx.FindStringExact(newStaffUsername);
                            if (employeeListboxIndex != -1)
                            {
                                staffLbx.SetSelected(employeeListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a new password.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("All fields must not be empty.", "Error");
                    }

                }
                //Update
                else
                {
                    int staffIndex = -1;
                    int.TryParse(staffLbx.SelectedValue.ToString(), out staffIndex);
                    int staffListboxIndex = staffLbx.SelectedIndex;

                    if (staffIndex != -1)
                    {
                        string newStaffUsername = staffUsernameTbx.Text.Trim();
                        string newStaffLastName = staffLastNameTbx.Text.Trim();
                        string newStaffFirstName = staffFirstNameTbx.Text.Trim();
                        string newStaffType = staffTypeCbx.Text;

                        //Validate input
                        if (newStaffUsername.Length > 0 && newStaffLastName.Length > 0 && newStaffFirstName.Length > 0 && newStaffType.Length > 0)
                        {
                            //Update row                  
                            tblEmployeeTableAdapter.Update(newStaffUsername, newStaffLastName, newStaffFirstName, newStaffType, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Password, staffIndex, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_UName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_LName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_FName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Type, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Password);
                            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

                            //Maintain current row selection
                            staffListboxIndex = staffLbx.FindStringExact(newStaffUsername);
                            if (staffListboxIndex != -1)
                            {
                                staffLbx.SetSelected(staffListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("All fields must not be empty.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid staff selected.", "Error");
                    }
                }
            }

            //Status
            else if (adminTabControl.SelectedIndex == 4)
            {
                //Add New
                if (statusLbx.SelectedIndex == -1)
                {
                    string newStatusName = statusNameTbx.Text.Trim();

                    //Validate input
                    if (newStatusName.Length > 0)
                    {
                        //Add row                  
                        tblStatusTableAdapter.Insert(newStatusName);
                        this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);

                        //Select row
                        int statusListboxIndex = statusLbx.FindStringExact(newStatusName);
                        if (statusListboxIndex != -1)
                        {
                            statusLbx.SetSelected(statusListboxIndex, true);
                        }
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Status name cannot be empty.", "Error");
                    }

                }
                //Update
                else
                {
                    int statusIndex = -1;
                    int.TryParse(statusLbx.SelectedValue.ToString(), out statusIndex);
                    int statusListboxIndex = statusLbx.SelectedIndex;

                    if (statusIndex != -1)
                    {
                        string newStatusName = statusNameTbx.Text.Trim();

                        //Validate input
                        if (newStatusName.Length > 0)
                        {
                            //Update row                  
                            tblStatusTableAdapter.Update(newStatusName, statusIndex, lUEquipmentDataSet.tblStatus.FindByStatus_ID(statusIndex).Status_Name);
                            this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);

                            //Maintain current row selection
                            statusListboxIndex = statusLbx.FindStringExact(newStatusName);
                            if (statusListboxIndex != -1)
                            {
                                statusLbx.SetSelected(statusListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Status name cannot be empty.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid status selected.", "Error");
                    }
                }               
            }

            //Suppliers
            else if (adminTabControl.SelectedIndex == 5)
            {
                //Add New
                if (suppliersLbx.SelectedIndex == -1)
                {
                    string newSupplierName = suppliersNameTbx.Text.Trim();

                    //Validate input
                    if (newSupplierName.Length > 0)
                    {
                        //Add row                  
                        tblSupplierTableAdapter.Insert(newSupplierName);
                        this.tblSupplierTableAdapter.Fill(this.lUEquipmentDataSet.tblSupplier);

                        //Select row
                        int supplierListboxIndex = suppliersLbx.FindStringExact(newSupplierName);
                        if (supplierListboxIndex != -1)
                        {
                            suppliersLbx.SetSelected(supplierListboxIndex, true);
                        }
                        saveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Supplier name cannot be empty.", "Error");
                    }

                }
                //Update
                else
                {
                    int supplierIndex = -1;
                    int.TryParse(suppliersLbx.SelectedValue.ToString(), out supplierIndex);
                    int supplierListboxIndex = suppliersLbx.SelectedIndex;

                    if (supplierIndex != -1)
                    {
                        string newSupplierName = suppliersNameTbx.Text.Trim();

                        //Validate input
                        if (newSupplierName.Length > 0)
                        {
                            //Update row                  
                            tblSupplierTableAdapter.Update(newSupplierName, supplierIndex, lUEquipmentDataSet.tblSupplier.FindBySupp_ID(supplierIndex).Supp_Name);
                            this.tblSupplierTableAdapter.Fill(this.lUEquipmentDataSet.tblSupplier);

                            //Maintain current row selection
                            supplierListboxIndex = suppliersLbx.FindStringExact(newSupplierName);
                            if (supplierListboxIndex != -1)
                            {
                                suppliersLbx.SetSelected(supplierListboxIndex, true);
                            }
                            saveBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Supplier name cannot be empty.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid supplier selected.", "Error");
                    }
                }
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //Get selected tab and make changes based on that
            //Equipment
            if (adminTabControl.SelectedIndex == 0)
            {
                //Clear fields
                equipmentLbx.SelectedIndex = -1;
                equipmentItemNumberATbx.Clear();
                equipmentItemNumberBTbx.Clear();
                equipmentItemNameTbx.Clear();
                equipmentDescription1Tbx.Clear();
                equipmentDescription2Tbx.Clear();
                equipmentDescription3Tbx.Clear();
                equipmentStatusCbx.SelectedIndex = 0;
                equipmentHomeLocationCbx.SelectedIndex = 0;
                equipmentNotesTbx.Clear();
                equipmentSupplierCbx.SelectedIndex = 0;
                equipmentDatePurchasedDpk.Format = DateTimePickerFormat.Short;
                equipmentDatePurchasedDpk.Value = DateTime.Today;
                equipmentPurchasePriceTbx.Clear();
                equipmentPONumberTbx.Clear();
                equipmentManufacturerTbx.Clear();
                equipmentModelTbx.Clear();
                equipmentSerialNumberTbx.Clear();
                equipmentRentalFeeTbx.Clear();
                equipmentLateFeeTbx.Clear();
                
            }

            //Categories
            else if (adminTabControl.SelectedIndex == 1)
            {
                //Clear fields
                categoriesLbx.SelectedIndex = -1;
                categoriesCategoryNameTbx.Clear();
                categoriesStartRangeATbx.Clear();
                categoriesStartRangeBTbx.Clear();
                categoriesEndRangeATbx.Clear();
                categoriesEndRangeBTbx.Clear();
            }

            //Locations
            else if (adminTabControl.SelectedIndex == 2)
            {
                //Clear fields
                locationsLbx.SelectedIndex = -1;
                locationsLocationNameTbx.Clear();
            }

            //Staff
            else if (adminTabControl.SelectedIndex == 3)
            {
                //Clear fields
                staffLbx.SelectedIndex = -1;
                staffUsernameTbx.Clear();
                staffLastNameTbx.Clear();
                staffFirstNameTbx.Clear();
                staffPasswordResetTbx.Clear();
                staffTypeCbx.SelectedIndex = 0;

                staffResetPasswordBtn.Visible = false;
            }

            //Status
            else if (adminTabControl.SelectedIndex == 4)
            {
                //Clear fields
                statusLbx.SelectedIndex = -1;
                statusNameTbx.Clear();
            }

            //Suppliers
            else if (adminTabControl.SelectedIndex == 5)
            {
                //Clear fields
                suppliersLbx.SelectedIndex = -1;
                suppliersNameTbx.Clear();
            }

        }

        private void staffResetPasswordBtn_Click(object sender, EventArgs e)
        {
            if (staffLbx.SelectedIndex != -1)
            {
                int staffIndex = -1;
                int.TryParse(staffLbx.SelectedValue.ToString(), out staffIndex);

                if (staffIndex != -1)
                {
                    string newStaffPassword = staffPasswordResetTbx.Text.Trim();

                    //Validate input
                    if (newStaffPassword.Length > 0)
                    {
                        //Update row                  
                        tblEmployeeTableAdapter.Update(lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_UName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_LName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_FName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Type, newStaffPassword, staffIndex, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_UName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_LName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_FName, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Type, lUEquipmentDataSet.tblEmployee.FindByEmp_ID(staffIndex).Emp_Password);
                        staffPasswordResetTbx.Clear();
                        MessageBox.Show("Password changed.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Password must not be empty.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid staff selected.", "Error");
                }
            }
            else
            {
                //Adding new
            }
        }

        private void equipmentItemNumberSearchBtn_Click(object sender, EventArgs e)
        {
            DataRow equipmentRow;
            string itemNumber = equipmentItemNumberSearchingATbx.Text + equipmentItemNumberSearchingBTbx.Text;
            bool itemNumberNumeric = int.TryParse(itemNumber, out int itemNumberInt);

            if (itemNumber.Length == 6 && itemNumberNumeric)
            {
                if (this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + itemNumber + "'").Length == 1)
                {
                    equipmentRow = this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + itemNumber + "'")[0];
                    string equipmentListboxName = itemNumber.Substring(0, 3) + "-" + itemNumber.Substring(3) + ": " + equipmentRow[2].ToString();

                    int equipmentListboxIndex = equipmentLbx.FindStringExact(equipmentListboxName);
                    if (equipmentListboxIndex != -1)
                    {
                        equipmentLbx.SetSelected(equipmentListboxIndex, true);
                    }
                    else
                    {
                        MessageBox.Show("Item does not exist in list.", "Error");
                    }

                }
                else if (this.lUEquipmentDataSet.tblEquip.Select("Equip_Number = '" + itemNumber + "'").Length > 1)
                {
                    MessageBox.Show("Item number duplicate exists.", "Error");
                }
                else
                {
                    MessageBox.Show("Item does not exist.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid item number entered.", "Error");
            }
        }

        private void staffLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRow employeeRow;

            //Checks if listbox isn't empty
            if (staffLbx.SelectedValue != null && adminTabControl.SelectedIndex == 3)
            {
                //Checks if query returns results and if so, assigns it to employeeRow
                if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_ID = '" + staffLbx.SelectedValue.ToString() + "'").Length == 1)
                {
                    employeeRow = this.lUEquipmentDataSet.tblEmployee.Select("Emp_ID = '" + staffLbx.SelectedValue.ToString() + "'")[0];

                    //Assigns row data to textboxes
                    staffLastNameTbx.Text = employeeRow[2].ToString();
                    staffFirstNameTbx.Text = employeeRow[3].ToString();
                    staffUsernameTbx.Text = employeeRow[1].ToString();
                    staffPasswordResetTbx.Clear();

                    //Assign dropdown value from row
                    staffTypeCbx.SelectedIndex = (employeeRow[4].ToString() == "Administrator") ? 0 : 1;

                    //Lock save button until changes are made
                    saveBtn.Enabled = false;
                    staffResetPasswordBtn.Visible = true;
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
            if (locationsLbx.SelectedValue != null && adminTabControl.SelectedIndex == 2)
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
            if (categoriesLbx.SelectedValue != null && adminTabControl.SelectedIndex == 1)
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
            if (equipmentLbx.SelectedValue != null && adminTabControl.SelectedIndex == 0)
            {
                //Checks if query returns results and if so, assigns it to equipmentRow
                if (this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'").Length == 1)
                {
                    equipmentRow = this.lUEquipmentDataSet.tblEquip.Select("Equip_ID = '" + equipmentLbx.SelectedValue.ToString() + "'")[0];

                    //Assigns row data to textboxes
                    /* 0 - Equip_ID
                     * 1 - Equip_Number
                     * 2 - Equip_Name
                     * 3 - Equip_Descrip1
                     * 4 - Equip_Descrip2
                     * 5 - Equip_Descrip3
                     * 6 - Equip_Manufacturer
                     * 7 - Equip_Model
                     * 8 - Equip_Serial
                     * 9 - Supp_ID
                     * 10 - Equip_DatePurch
                     * 11 - Equip_Price
                     * 12 - Equip_PONumber
                     * 13 - Equip_RentalPrice
                     * 14 - Equip_LateFee
                     * 15 - Equip_Nights
                     * 16 - Equip_Notes
                     * 17 - Status_ID
                     * 18 - Loc_ID
                     */
                    equipmentItemNumberATbx.Text = equipmentRow[1].ToString().Substring(0, 3);
                    equipmentItemNumberBTbx.Text = equipmentRow[1].ToString().Substring(3);
                    equipmentItemNameTbx.Text = equipmentRow[2].ToString();
                    equipmentDescription1Tbx.Text = equipmentRow[3].ToString();
                    equipmentDescription2Tbx.Text = equipmentRow[4].ToString();
                    equipmentDescription3Tbx.Text = equipmentRow[5].ToString();
                    equipmentManufacturerTbx.Text = equipmentRow[6].ToString();
                    equipmentModelTbx.Text = equipmentRow[7].ToString();
                    equipmentSerialNumberTbx.Text = equipmentRow[8].ToString();
                    equipmentPurchasePriceTbx.Text = (double.TryParse(equipmentRow[11].ToString(), out double purchasePriceDbl)) ? purchasePriceDbl.ToString("C") : equipmentRow[11].ToString();
                    equipmentPONumberTbx.Text = equipmentRow[12].ToString();
                    equipmentRentalFeeTbx.Text = (double.TryParse(equipmentRow[13].ToString(), out double rentalFeeDbl)) ? rentalFeeDbl.ToString("C") : equipmentRow[13].ToString();
                    equipmentLateFeeTbx.Text = (double.TryParse(equipmentRow[14].ToString(), out double lateFeeDbl)) ? lateFeeDbl.ToString("C") : equipmentRow[14].ToString();                   
                    equipmentNotesTbx.Text = equipmentRow[16].ToString();


                    //Need proper nights calculating
                    equipmentNightsRentedTbx.Text = equipmentRow[15].ToString();

                    //Set Status
                    int statusId = 0;
                    string statusName = "";
                    int.TryParse(equipmentRow[17].ToString(), out statusId);
                    
                    if (statusId != 0)
                    {
                        statusName = lUEquipmentDataSet.tblStatus.FindByStatus_ID(statusId).Status_Name;
                    }
                    
                    equipmentStatusCbx.SelectedIndex = equipmentStatusCbx.FindStringExact(statusName);

                    //Set Location
                    int locationId = 0;
                    string locationName = "";
                    int.TryParse(equipmentRow[18].ToString(), out locationId);

                    if (locationId != 0)
                    {
                        locationName = lUEquipmentDataSet.tblLocation.FindByLoc_ID(locationId).Loc_Name;
                    }

                    equipmentHomeLocationCbx.SelectedIndex = equipmentHomeLocationCbx.FindStringExact(locationName);

                    //Set Supplier
                    int supplierId = 0;
                    string supplierName = "";
                    int.TryParse(equipmentRow[9].ToString(), out supplierId);

                    if (supplierId != 0)
                    {
                        supplierName = lUEquipmentDataSet.tblSupplier.FindBySupp_ID(supplierId).Supp_Name;
                    }

                    equipmentSupplierCbx.SelectedIndex = equipmentSupplierCbx.FindStringExact(supplierName);

                    //Set Purchase Date
                    if(equipmentRow[10].ToString() != "")
                    {
                        equipmentDatePurchasedDpk.Value = (DateTime)equipmentRow[10];
                    }
                    else
                    {
                        equipmentDatePurchasedDpk.Value = DateTime.FromOADate(0);
                    }

                    //Lock save button until changes are made
                    saveBtn.Enabled = false;
                }
                else
                {
                    //No equipment selected

                    MessageBox.Show("Error! Equipment not found", "Error");
                }
            }
        }

        private void statusLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (statusLbx.SelectedValue != null && adminTabControl.SelectedIndex == 4)
            {

                statusNameTbx.Text = statusLbx.Text;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
        }

        private void suppliersLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if listbox isn't empty
            if (suppliersLbx.SelectedValue != null && adminTabControl.SelectedIndex == 5)
            {
                suppliersNameTbx.Text = suppliersLbx.Text;

                //Lock save button until changes are made
                saveBtn.Enabled = false;
            }
        }
    }
}
