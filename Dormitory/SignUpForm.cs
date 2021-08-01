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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            using (var db = new DormitoryDatabaseEntities3())
            {

                var query = from b in db.Cities
                            select b.CityName;



                foreach (var item in query)
                {
                    CityComboBox.Items.Add(item);
                    CityComboBox.SelectedItem = 0;
                }

                query = from b in db.Majors
                        select b.MName;



                foreach (var item in query)
                {
                    MajorComboBox.Items.Add(item);
                    MajorComboBox.SelectedItem = 0;
                }


                query = from b in db.Levels
                        select b.LName;



                foreach (var item in query)
                {
                    LevelComboBox.Items.Add(item);
                    LevelComboBox.SelectedItem = 0;
                }


            };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            
                using (var db = new DormitoryDatabaseEntities3())
                {
                var cityList = db.Cities
                  .SqlQuery("Select * from City")
                  .ToList<City>();
                var MajorList = db.Majors.SqlQuery("Select * from Major").ToList<Major>();
                var levelList = db.Levels.SqlQuery("Select * from Level").ToList<Level>();


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
                    }else
                        user.UserGender = "M";

                var student = new Student()
                {
                    StudentNum = int.Parse(StudentNumber.Text),
                    EnteranceYear = int.Parse(enteryear.Text),
                    City = cityList.ElementAt(0),
                    Major = MajorList.ElementAt(0),
                    Level = levelList.ElementAt(0),
                    Mellicode = int.Parse(CodeMelliTtextBox.Text)

                };
                if (Day.Checked)
                {
                    student.DNType = "Day";
                }
                else
                    student.DNType = "Night";


                db.Users.Add(user);
                db.Students.Add(student);


                Profile profile = new Profile(user, student);
                this.Visible = false;
                profile.ShowDialog();

            }
            





        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Major_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeMelliTtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void MaleradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

      

     

      
    }

