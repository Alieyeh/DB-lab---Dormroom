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

    public partial class ViewRequests : Form
    {
        List<RequestRoom> RoomList;
        public ViewRequests()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
        }


        private void ViewRequests_Load(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                RoomList = db.RequestRooms.SqlQuery("Select * from RequestRoom  ").ToList<RequestRoom>();
                foreach (var item in RoomList)
                {
                    dataGridView1.Rows.Add(item.StudentNum, item.RoomNum, item.FloorNum, item.BlockNum, item.RRType);



                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {


        }
    }
}