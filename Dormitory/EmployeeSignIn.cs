using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory
{
    public partial class EmployeeSignIn : Form
    {
        User user;
        Employee employee;
        bool okay = false;

        public EmployeeSignIn()

        {

            InitializeComponent();
        }

        private void EmployeeSignIn_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {

                var query = (from b in db.Users
                             select b);



                foreach (var item in query)
                {
                    if (Email.Text == item.Email & PasswordTextBox.Text == item.Password)
                    {
                        okay = true;
                        user = item;
                        var query2 = (from b in db.Employees
                                      select b);

                        foreach (var item2 in query2)
                        {
                            if (user.Mellicode == item2.Mellicode)
                            {
                                employee = item2;
                                break;

                            }
                            break;

                    }

                }
             

                }




                if (okay)
                {
                    MessageBox.Show("successfully signed in");
                    EmployeeProfile employeeProfile = new EmployeeProfile(user, employee);
                    this.Visible = false;
                    employeeProfile.ShowDialog();


                }
                else
                {
                    MessageBox.Show("user name or password is incorrect");


                }

            }
        }

    

    private void SignupButton_Click(object sender, EventArgs e)
        {
            EmployeeSignUp employeeSignUp = new EmployeeSignUp();
            this.Visible = false;
            employeeSignUp.ShowDialog();
        }
    }
}
