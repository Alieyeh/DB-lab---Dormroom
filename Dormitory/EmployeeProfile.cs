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
    public partial class EmployeeProfile : Form
    {
        User user;
        Employee employee;
        public EmployeeProfile(User user, Employee employee)
        {
            InitializeComponent();
            this.user = user;
            this.employee = employee;
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {

            label1.Text = user.FullName;
            label2.Text =  employee.Mellicode.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            Dedicaton dedicaton = new Dedicaton();
            this.Visible = false;
            dedicaton.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            Reports reports = new Reports();
            this.Visible = false;
            reports.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            ViewRequests requests = new ViewRequests();
            this.Visible = false;
            requests.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            EmployeeSignIn signin= new EmployeeSignIn();
            this.Visible = false;
            signin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
