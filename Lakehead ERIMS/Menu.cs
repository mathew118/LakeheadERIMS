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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equipmentSnapshotBtn_Click(object sender, EventArgs e)
        {
            var equipSnap = new equipSummary();
            equipSnap.Show();
        }

        private void addUpdateStudentBtn_Click(object sender, EventArgs e)
        {
            var addUpdateStudent = new addUpdateStudent();
            addUpdateStudent.Show();
        }

        private void rentEquipmentBtn_Click(object sender, EventArgs e)
        {
            var rent = new form();
            rent.Show();
        }

        private void editRentalBtn_Click(object sender, EventArgs e)
        {
            var editrental = new editRental();
            editrental.Show();
        }

        private void returnEquipmentBtn_Click(object sender, EventArgs e)
        {
            var equipReturn = new ReturnEquip();
            equipReturn.Show();
        }
    }
}
