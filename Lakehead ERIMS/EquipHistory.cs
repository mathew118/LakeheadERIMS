using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access = Microsoft.Office.Interop.Access;
using System.IO;
using System.Windows.Forms;

namespace Lakehead_ERIMS
{
    public partial class EquipHistory : Form
    {
        public EquipHistory()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string equipNumber = searchTxtBox.Text;
            string whereCond = "Equip_Number ='" + equipNumber + "'";
            this.tblEquipTableAdapter1.Fill(this.luEquipmentDataSet1.tblEquip);
            //input validation
            if (equipNumber.Length !=6 || !int.TryParse(equipNumber, out int tempItemNumb))
            {
                MessageBox.Show("Please enter a valid equipment number!","Error");
            }
            else if (this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + searchTxtBox.Text + "'").Length != 1)
            {
                MessageBox.Show("There is no item with that number.", "Error");
            }
            else
            {
                Access.Application oAccess = new Access.Application();
                oAccess.Visible = true;
                oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
                //open Access, equipment number will be asked within Access.
                oAccess.DoCmd.OpenReport("rptEquipHistory", Access.AcView.acViewPreview, //View
                   System.Reflection.Missing.Value,//FilterName,
                   whereCond//WhereCondition
                   );
            }
        }
    }
}
