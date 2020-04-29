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

        //Look at lines 47-54 to see an example of dataset querying

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
            //Fills tblEmployee with a query from the database
            this.tblEmployeeTableAdapter.Fill(this.lUEquipmentDataSet.tblEmployee);

            DataRow employeeRow;

            //Checks if query returns results and if so, assigns it to employeeRow
            //If more than one user exists with the same username, warn user.
            if(usernameTbx.Text.Length == 0)
            {
                MessageBox.Show("You must enter a username.", "Error");
            }
            //Checks if the select query returns more than 1 row
            else if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'").Length > 1)
            {
                MessageBox.Show("Usernames must be unique.", "Error");
                usernameTbx.Clear();
            }
            //Checks if the select query returns exactly 1 row
            else if (this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'").Length == 1)
            {
                //Performs select query checking if Emp_UName col matches the text inside the username textbox. ([0] selects the first row in the query and there should only be 1 row returned)
                employeeRow = this.lUEquipmentDataSet.tblEmployee.Select("Emp_UName = '" + usernameTbx.Text + "'")[0];
                
                //Password Correct (Check if the 6th column (Emp_Password) in the row is equal to the text inside the password textbox)
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
