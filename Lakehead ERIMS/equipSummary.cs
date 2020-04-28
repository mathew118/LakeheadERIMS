﻿using System;
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
            string connenctionString;
            OleDbConnection cnn;
            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);
            cnn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = cnn;
            command.CommandText = "SELECT Equip_Name FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            itemNameLabel.Text = command.ExecuteScalar().ToString();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = cnn;
            command1.CommandText = "SELECT Equip_Descrip1 FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            desc1Label.Text = command1.ExecuteScalar().ToString();

            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = cnn;
            command2.CommandText = "SELECT Equip_Descrip2 FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            desc2Label.Text = command2.ExecuteScalar().ToString();

            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = cnn;
            command3.CommandText = "SELECT Equip_Descrip3 FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            desc3Label.Text = command3.ExecuteScalar().ToString();

            //suppler connection
            // OleDbCommand command4 = new OleDbCommand();
            //command4.Connection = cnn;
            //command4.CommandText = "SELECT tblEquip.Supp_ID, tblSupplier.Supp_Name FROM tblEquip INNER JOIN tblSupplier ON tblEquip.Supp_ID=tblSupplier.Supp_ID WHERE Equip_Number = '" + equipNumber.Text + "'";
            //suppLabel.Text = command4.ExecuteScalar().ToString();

            OleDbCommand command5 = new OleDbCommand();
            command5.Connection = cnn;
            command5.CommandText = "SELECT Equip_Manufacturer FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            manuLabel.Text = command5.ExecuteScalar().ToString();

            OleDbCommand command6 = new OleDbCommand();
            command6.Connection = cnn;
            command6.CommandText = "SELECT Equip_Model FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            modelLabel.Text = command6.ExecuteScalar().ToString();

            OleDbCommand command7 = new OleDbCommand();
            command7.Connection = cnn;
            command7.CommandText = "SELECT Equip_Serial FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            serialLabel.Text = command7.ExecuteScalar().ToString();

            OleDbCommand command8 = new OleDbCommand();
            command8.Connection = cnn;
            command8.CommandText = "SELECT Equip_Notes FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            notesListBox.Text = command8.ExecuteScalar().ToString();

            //home location
            //OleDbCommand command9 = new OleDbCommand();
            //command9.Connection = cnn;
            //command9.CommandText = "SELECT Equip_Descrip3 FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            //desc3Label.Text = command9.ExecuteScalar().ToString();

            OleDbCommand command10 = new OleDbCommand();
            command10.Connection = cnn;
            command10.CommandText = "SELECT Equip_Nights FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            nightLabel.Text = command10.ExecuteScalar().ToString();

            OleDbCommand command11 = new OleDbCommand();
            command11.Connection = cnn;
            command11.CommandText = "SELECT Equip_RentalPrice FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            rentalFeeLabel.Text = command11.ExecuteScalar().ToString();

            OleDbCommand command12 = new OleDbCommand();
            command12.Connection = cnn;
            command12.CommandText = "SELECT Equip_LateFee FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            lateFeeLabel.Text = command12.ExecuteScalar().ToString();

            //status
            OleDbCommand command13 = new OleDbCommand();
            command13.Connection = cnn;
            command13.CommandText = "SELECT Status_ID FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            string status = command13.ExecuteScalar().ToString();
            OleDbCommand commandEquipID = new OleDbCommand();
            commandEquipID.Connection = cnn;
            commandEquipID.CommandText = "SELECT Equip_ID FROM tblEquip WHERE Equip_Number = '" + equipNumber.Text + "'";
            string EquipID = commandEquipID.ExecuteScalar().ToString();

            if (status == "9")
            {
                statusLabel.Text = "Out";
                
                string query = "SELECT Rent_DateDue FROM tblRental WHERE Equip_ID = '" + EquipID + "'";
                OleDbCommand commandStudentInfo = new OleDbCommand(query, cnn);
                OleDbDataReader reader = commandStudentInfo.ExecuteReader();
                reader.Read();
                dateDueLabel.Text = commandStudentInfo.ExecuteScalar().ToString();
                reader.Close();
            }


            //statusLabel.Text = status;

            cnn.Close();
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
