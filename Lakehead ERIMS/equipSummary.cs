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
    public partial class equipSummary : Form
    {
        
        public equipSummary()
        {
            InitializeComponent();
        }

        private void equipSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblEquip' table. You can move, or remove it, as needed.
            //this.tblEquipTableAdapter.Fill(this.lUEquipmentDataSet.tblEquip);
            /*
            try
            {


                connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
                connection.Open();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            */

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True");
            // searching for the information from the equipment number 
            connection.Open();
            OleDbDataReader reader = null;
            if (equipNumber.Text != " ")
            {
                OleDbCommand selectEquip = new OleDbCommand("Select * from tblEquip WHERE [Equip_Numb]=@NUMBER", connection);
                selectEquip.Parameters.AddWithValue("@NUMBER", int.Parse(equipNumber.Text));
                 reader = selectEquip.ExecuteReader();
                if (reader.Read())
                {
                    itemNameTextbox.Text = reader.ToString();
                }
            }
            connection.Close();
        }
    }
}
