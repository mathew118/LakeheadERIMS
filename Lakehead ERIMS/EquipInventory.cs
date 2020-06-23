using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access = Microsoft.Office.Interop.Access;
using System.Windows.Forms;
using System.IO;

namespace Lakehead_ERIMS
{
    public partial class EquipInventory : Form
    {
        public EquipInventory()
        {
            InitializeComponent();
        }

        private void EquipInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblLocation' table. You can move, or remove it, as needed.
            this.tblLocationTableAdapter.Fill(this.lUEquipmentDataSet.tblLocation);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.lUEquipmentDataSet.tblCategory);
            // TODO: This line of code loads data into the 'lUEquipmentDataSet.tblStatus' table. You can move, or remove it, as needed.
            this.tblStatusTableAdapter.Fill(this.lUEquipmentDataSet.tblStatus);


            //all categories option
            DataRow newRow = lUEquipmentDataSet.tblCategory.NewRow();
            newRow["Cat_Name"] = "All Categories";
            newRow["Cat_ID"] = "-1";
            lUEquipmentDataSet.tblCategory.Rows.InsertAt(newRow, 0);
            //all location option
            DataRow newRow1 = lUEquipmentDataSet.tblLocation.NewRow();
            newRow1["Loc_Name"] = "All Locations";
            newRow1["Loc_ID"] = "-1";
            lUEquipmentDataSet.tblLocation.Rows.InsertAt(newRow1, 0);
            // all status option
            DataRow newRow2 = lUEquipmentDataSet.tblStatus.NewRow();
            newRow2["Status_Name"] = "All Status";
            newRow2["Status_ID"] = "-1";
            lUEquipmentDataSet.tblStatus.Rows.InsertAt(newRow2, 0);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printCategoryBtn_Click(object sender, EventArgs e)
        {
            //this button is only for printing out category reports regardless of location and status.
            string strCriteria;
            string CatIDStart = "";
            string CatIDEnd = "";

            //check if "All Categories has been selected"
            if (categoriesLbx.SelectedValue.ToString() == "-1")
            {
                strCriteria = "";
            }
            else 
            {
                CatIDStart = lUEquipmentDataSet.tblCategory.FindByCat_ID(int.Parse(categoriesLbx.SelectedValue.ToString())).Cat_IDStart;
                CatIDEnd = lUEquipmentDataSet.tblCategory.FindByCat_ID(int.Parse(categoriesLbx.SelectedValue.ToString())).Cat_IDEnd;
                strCriteria = "Equip_Number between '" + CatIDStart + "' AND '" + CatIDEnd + "'";
            }
            Access.Application oAccess = new Access.Application();
            oAccess.Visible = true;
            oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
            oAccess.DoCmd.SetParameter("category", locationsLbx.SelectedValue.ToString());
            oAccess.DoCmd.OpenReport("rptEquipment", Access.AcView.acViewPreview, //View
               System.Reflection.Missing.Value,//FilterName
               strCriteria);
        }

        private void printEquipBtn_Click(object sender, EventArgs e)
        {
            string CatIDStart;
            string CatIDEnd;
            string strCriteria="";
            if (categoriesLbx.SelectedValue.ToString() == "-1") //all category
            {
                 CatIDStart="";
                 CatIDEnd="";
                if (locationsLbx.SelectedValue.ToString() == "-1" && statusLbx.SelectedValue.ToString() != "-1") // all locations but NOT all status
                {
                    strCriteria = "Status_ID LIKE '" + statusLbx.SelectedValue+ "'";
                }
                else if (locationsLbx.SelectedValue.ToString() == "-1" && statusLbx.SelectedValue.ToString() == "-1") //all locations AND all status
                {
                    strCriteria = "";
                }
                else if (locationsLbx.SelectedValue.ToString() != "-1" && statusLbx.SelectedValue.ToString() == "-1") //NOT ALL locations AND all status
                {
                    strCriteria = "Loc_ID LIKE '" + locationsLbx.SelectedValue.ToString() +"'";
                }
                else if (locationsLbx.SelectedValue.ToString() != "-1" && statusLbx.SelectedValue.ToString() != "-1") //specific location,specific status
                {
                    strCriteria = "Loc_ID LIKE '" + locationsLbx.SelectedValue + "' AND Status_ID LIKE '" + statusLbx.SelectedValue + "'";
                }

            }
            else //specific category
            {
                CatIDStart = lUEquipmentDataSet.tblCategory.FindByCat_ID(int.Parse(categoriesLbx.SelectedValue.ToString())).Cat_IDStart;
                CatIDEnd = lUEquipmentDataSet.tblCategory.FindByCat_ID(int.Parse(categoriesLbx.SelectedValue.ToString())).Cat_IDEnd;
                if (locationsLbx.SelectedValue.ToString() == "-1" && statusLbx.SelectedValue.ToString() != "-1") // all locations but NOT all status
                {
                    strCriteria = "Status_ID LIKE '" + statusLbx.SelectedValue + "' AND Equip_Number between '" + CatIDStart + "' AND '" + CatIDEnd + "'";
                }
                else if (locationsLbx.SelectedValue.ToString() == "-1" && statusLbx.SelectedValue.ToString() == "-1") //all locations AND all status
                {
                    strCriteria = "Equip_Number between '" + CatIDStart + "' AND '" + CatIDEnd + "'";
                }
                else if (locationsLbx.SelectedValue.ToString() != "-1" && statusLbx.SelectedValue.ToString() == "-1") //NOT ALL locations AND all status
                {
                    strCriteria = "Loc_ID LIKE '" + locationsLbx.SelectedValue.ToString() + "' AND Equip_Number between '" + CatIDStart + "' AND '" + CatIDEnd + "'";
                }
                else if (locationsLbx.SelectedValue.ToString() != "-1" && statusLbx.SelectedValue.ToString() != "-1") //specific location,specific status
                {
                    strCriteria = "Loc_ID LIKE '" + locationsLbx.SelectedValue + "' AND Status_ID LIKE '" + statusLbx.SelectedValue + "' AND Equip_Number between '" + CatIDStart + "' AND '" + CatIDEnd + "'";
                }
            }



            //print Equipment by location
            Access.Application oAccess = new Access.Application();
            oAccess.Visible = true;
            oAccess.OpenCurrentDatabase(Path.Combine(Environment.CurrentDirectory, "LUEquipment.mdb"), false);
            oAccess.DoCmd.OpenReport("rptEquipment", Access.AcView.acViewPreview, //View
            System.Reflection.Missing.Value, strCriteria
           );

        }

    }
}
