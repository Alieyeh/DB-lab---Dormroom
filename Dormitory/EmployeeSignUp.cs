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
    public partial class EmployeeSignUp : Form
    {
        User user1;
        Employee Employee1;
        public EmployeeSignUp()
        {
            InitializeComponent();
            using (var db = new DormitoryDatabaseEntities3())
            {

                var query = from b in db.Jobs
                            select b.JobName;



                foreach (var item in query)
                {
                    job.Items.Add(item);
                    job.SelectedItem = 0;
                }








            };
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {

                var JobList = db.Jobs.SqlQuery("Select * from Job").ToList<Job>();


                var user = new User()
                {
                    FullName = NameTextBox.Text,
                    BirthDate = BirthdateTimePicker.Value,
                    Password = PasswordTextBox.Text,
                    Mellicode = int.Parse(CodeMelliTtextBox.Text),
                    UserAddress = AddressTextBox.Text,
                };
                if (FemaleradioButton.Checked)
                {
                    user.UserGender = "F";
                }
                else
                    user.UserGender = "M";

                var employee = new Employee()
                {
                    EId = int.Parse(CodeMelliTtextBox.Text),
                    JId = JobList.ElementAt(0).Jid,
                    Mellicode = int.Parse(CodeMelliTtextBox.Text)


                };
                user1 = user;
                Employee1 = employee;
                db.Users.Add(user);
                db.Employees.Add(employee);
                

            }
            EmployeeProfile employeeProfile = new EmployeeProfile(user1, Employee1);
            this.Visible = false;
            employeeProfile.ShowDialog();

        }

        private void MaleradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
