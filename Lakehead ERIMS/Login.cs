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

            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

            DataRow employeeRow;

            //Checks if query returns results and if so, assigns it to employeeRow
            //If more than one user exists with the same username, warn user.
            if(usernameTbx.Text.Length == 0)
            {
                MessageBox.Show("You must enter a username.", "Error");
            }
            else if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'").Length > 1)
            {
                MessageBox.Show("Usernames must be unique.", "Error");
                usernameTbx.Clear();
            }
            else if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'").Length == 1)
            {
                employeeRow = this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'")[0];
                
                //Password Correct
                if(employeeRow[5].ToString() == passwordTbx.Text)
                {
                    //Login
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    //Once menu is closed, it will close the hidden login form
                    this.Close();
                }
                //Password incorrect
                else
                {
                    MessageBox.Show("Password is incorrect.", "Error");
                    passwordTbx.Clear();
                }
                
            }
            //If no user is found with the entered username.
            else
            {
                MessageBox.Show("No account associated with that username.", "Error");
                usernameTbx.Clear();
            }
            
        }

        private void skipLoginBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            //Once menu is closed, it will close the hidden login form
            this.Close();
        }
    }
}
