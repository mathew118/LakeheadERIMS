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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Will query database but for now just go to menu
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            //Once menu is closed, it will close the hidden login form
            this.Close();
        }
    }
}
