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
    public partial class SignInForm : Form
    {

        bool ok = false;
        User user1;
        Student student;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {

                //var query = (from b in db.Users
                             //select b);
                List<User> query = db.Users.SqlQuery("Select * from Users").ToList<User>();



                //foreach (var u in userList)
                //{
                //    if (u.UserName == UsernameTextBox.Text && u.Password == PasswordTextBox.Text)
                //    {
                //        ok = true;
                //        return;

                //    }
                //}


                foreach (var item in query)
                {
                    if (Email.Text == item.Email & PasswordTextBox.Text == item.Password)
                    {
                        ok = true;
                        user1 = item;
                        var query2 = (from b in db.Students
                                      select b);

                        foreach (var item2 in query2)
                        {
                            if (user1.Mellicode == item2.Mellicode)
                            {
                                student = item2;
                                break;

                            }

                        }
                        break;

                    }


                }
              






            }
            if (ok)
            {
                MessageBox.Show("successfully signed in");
                Profile profile = new Profile(user1, student);
                this.Visible = false;
                profile.ShowDialog();


            }
            else
            {
                MessageBox.Show("user name or password is incorrect");


            }
        }



        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Visible = false;
            signUpForm.ShowDialog();

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

