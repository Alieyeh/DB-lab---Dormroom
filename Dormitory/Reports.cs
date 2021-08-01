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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                var reports = db.ReportConditions.SqlQuery("Select * from ReportCondition  ").ToList<ReportCondition>();
                foreach (var item in reports)
                {
                    dataGridView1.Rows.Add(item.StudentNum, item.Condition);



                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
