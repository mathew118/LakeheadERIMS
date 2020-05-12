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
            //create equipment number
            string equipNumber = search1TxtBox.Text + search2TxtBox.Text;
            string whereCond = "Equip_Number ='" + equipNumber + "'"; //whereCond will be use to filter result in Access
            this.tblEquipTableAdapter1.Fill(this.luEquipmentDataSet1.tblEquip);
            //input validation
            if (equipNumber.Length != 6 || !int.TryParse(equipNumber, out int tempItemNumb))
            {
                MessageBox.Show("Please enter a valid equipment number!", "Error");
            }
            else if (this.luEquipmentDataSet1.tblEquip.Select("Equip_Number = '" + equipNumber + "'").Length != 1)
            {
                MessageBox.Show("There is no item with that number.", "Error");
            }
            else
            {
                //open up Access => open Equipment History Report with preset condition
                Access.Application oAccess = new Access.Application();
                oAccess.Visible = true;
                oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
                //open Access, equipment number will be asked within Access.
                oAccess.DoCmd.OpenReport("rptEquipHistory", Access.AcView.acViewPreview, //View
                   System.Reflection.Missing.Value,//FilterName,
                   whereCond//WhereCondition
                   );
            }
            //clear textbox
            search2TxtBox.Clear();
            search1TxtBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //press Enter = trigger Search button
        private void EquipHistory_Load(object sender, EventArgs e)
        {
            this.AcceptButton = searchBtn;
        }

        private void search1TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (search1TxtBox.Text.Length == 3)
            {
                search2TxtBox.Focus();
            }
        }

        //enter 3 numbers on the first textbox => automatically shift focus to the second textbox
    }
}
