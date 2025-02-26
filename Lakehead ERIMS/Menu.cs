﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access = Microsoft.Office.Interop.Access;
using System.Windows.Forms;

namespace Lakehead_ERIMS
{
    public partial class Menu : Form
    {
        public Menu(bool isAdministrator)
        {
            InitializeComponent();

            if (!isAdministrator)
            {
                administrativeMenuBtn.Enabled = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administrativeMenuBtn_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
        }

        private void equipmentOnLoanBtn_Click(object sender, EventArgs e)
        {
            Access.Application oAccess = new Access.Application();
            oAccess.Visible = true;
            oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory,"LUEquipment.mdb"), false);
            //this report is opened in Access and ready to print
            oAccess.DoCmd.OpenReport("rptOnLoan", Access.AcView.acViewPreview, //View
               System.Reflection.Missing.Value, //FilterName
               System.Reflection.Missing.Value //WhereCondition 
               );
        }

        private void equipmentInventoryBtn_Click(object sender, EventArgs e)
        {
            EquipInventory equipInventory = new EquipInventory();
            equipInventory.Show();
        }

        private void overdueRentalsBtn_Click(object sender, EventArgs e)
        {
            Access.Application oAccess = new Access.Application();
            oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
            //this report is opened in Access and ready to print
            oAccess.Visible = true;
            oAccess.DoCmd.OpenReport("rptOverDue", Access.AcView.acViewPreview, //View
               System.Reflection.Missing.Value, //FilterName
               System.Reflection.Missing.Value //WhereCondition 
               );
        }

        private void outstandingAccountsBtn_Click(object sender, EventArgs e)
        {
            Access.Application oAccess = new Access.Application();
            oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
            //this report is opened in Access and ready to print
            oAccess.Visible = true;
            oAccess.DoCmd.OpenReport("rptOwing", Access.AcView.acViewPreview, //View
               System.Reflection.Missing.Value, //FilterName
               System.Reflection.Missing.Value //WhereCondition 
               );

        }

        private void equipmentHistoryBtn_Click(object sender, EventArgs e)
        {
            EquipHistory equipHistory = new EquipHistory();
            equipHistory.Show();
        }

        private void rentEquipmentBtn_Click(object sender, EventArgs e)
        {
            RentForm rentForm = new RentForm();
            rentForm.ShowDialog();
        }

        private void returnEquipmentBtn_Click(object sender, EventArgs e)
        {
            ReturnEquip returnForm = new ReturnEquip();
            returnForm.ShowDialog();
        }

        private void editRentalBtn_Click(object sender, EventArgs e)
        {
            editRental editRentalForm = new editRental();
            editRentalForm.ShowDialog();
        }

        private void addUpdateStudentBtn_Click(object sender, EventArgs e)
        {
            addUpdateStudent addUpdateStudentForm = new addUpdateStudent();
            addUpdateStudentForm.ShowDialog();
        }

        private void equipmentSnapshotBtn_Click(object sender, EventArgs e)
        {
            equipSummary equipmentSummaryForm = new equipSummary();
            equipmentSummaryForm.ShowDialog();
        }
    }
}

