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
    public partial class Profile : Form
    {
        User userp;
        Student Studentp;

        public Profile(User user , Student student)
        {
            InitializeComponent();
            this.userp = user;
            this.Studentp = student;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            RoomRequest roomRequest = new RoomRequest(userp,Studentp);
            this.Visible = false;
            roomRequest.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            ConditionReport conditionReport = new ConditionReport( Studentp);
            this.Visible = false;
            conditionReport.ShowDialog();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            label1.Text = userp.FullName;
            label3.Text = Studentp.StudentNum.ToString();
            if(Studentp.RoomNum != null) {
                label5.Text = Studentp.BlockNum.ToString();
                label6.Text = Studentp.FloorNum.ToString();
                label7.Text = Studentp.RoomNum.ToString();
            }
            else
            {
                label5.Text = " ";
                label6.Text = " ";
                label7.Text = " ";
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Visible = false;
            signInForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
