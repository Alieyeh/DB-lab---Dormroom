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
    public partial class ConditionReport : Form
    {
        Student Student;
        public ConditionReport(Student student)
        {
            InitializeComponent();
            this.Student = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                var Report = new ReportCondition()
                {

                    Condition = richTextBox1.Text,
                    StudentNum = Student.StudentNum,
                    ReportCDate = DateTime.Now,
                    SId = 1
                };
                db.ReportConditions.Add(Report);
            }
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
