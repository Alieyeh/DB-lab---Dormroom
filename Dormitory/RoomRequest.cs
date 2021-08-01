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
    public partial class RoomRequest : Form
    {
        User User;
        Student student;
        public RoomRequest(User user , Student student)
        {
            InitializeComponent();
            this.User = user;
            this.student = student;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            AvailabeRooms availabeRooms = new AvailabeRooms();
            this.Visible = false;
            availabeRooms.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                var request = new RequestRoom()
                {

                    RoomNum = numericUpDown3.DecimalPlaces,
                    BlockNum = numericUpDown1.DecimalPlaces,
                    FloorNum = numericUpDown2.DecimalPlaces,
                    StudentNum = student.StudentNum,
                    Date = DateTime.Now


                };
                if (radioButton1.Checked)
                {
                    request.RRType = "Reserve";
                }
                else
                    request.RRType = "Cancel";

                db.RequestRooms.Add(request);
                
            }


            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
