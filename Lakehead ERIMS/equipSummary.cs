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
          

            string connenctionString;
            OleDbConnection cnn;
           



            connenctionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\ongar\OneDrive\Desktop\LUEquipment.mdb;Persist Security Info=True";
            cnn = new OleDbConnection(connenctionString);

            cnn.Open();
            //OleDbCommand command;
            OleDbDataReader dataReader;
            String sql, Output = "";
            string number;
            double usernumber = double.Parse(equipNumber.Text);


            var query = " SELECT * FROM tblEquip WHERE [Equip_Numb] = ?";

            var command = new OleDbCommand(query, cnn);
            command.Parameters.Add(new OleDbParameter("Equip_Numb", equipNumber.Text));

            dataReader = command.ExecuteReader();


            //sql = "Select * from [tblEquip] WHERE [Equip_Numb] = '" + equipNumber.Text.ToString() + "'";

            //command = new OleDbCommand(sql, cnn);

            //dataReader = command.ExecuteReader();

            //listBox2.Text = dataReader.ToString();
            
            
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void equipNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
