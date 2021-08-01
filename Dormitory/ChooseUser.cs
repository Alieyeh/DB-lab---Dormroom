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
    public partial class ChooseUser : Form
    {
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SignInForm signInForm = new SignInForm();
            this.Visible = false;
            signInForm.ShowDialog();
        }

        private void ChooseUser_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeSignIn employeeSignIn = new EmployeeSignIn();
            this.Visible = false;
            employeeSignIn.ShowDialog();
        }
    }
}
