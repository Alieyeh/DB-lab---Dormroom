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
    public partial class Dedicaton : Form
    {
        public Dedicaton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                var query2 = (from b in db.Students
                              select b);
                var bl = numericUpDown1.DecimalPlaces;
                var fl = numericUpDown2.DecimalPlaces;
                var r = numericUpDown3.DecimalPlaces;

                var stnum = int.Parse(StudentNumber.Text);
              
               foreach( var item in query2)
                {
                    if(item.StudentNum == stnum)
                    {
                        db.Students.Remove(item);
                        item.BlockNum = bl;
                        item.FloorNum = fl;
                        item.RoomNum = r;
                        db.Students.Add(item);




                    }

                }

                db.SaveChanges();



                FormState.PreviousPage.Show();
                this.Hide();



            }
        }

        private void StudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
