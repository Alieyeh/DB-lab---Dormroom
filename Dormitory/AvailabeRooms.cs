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
    public partial class AvailabeRooms : Form
    {
        public AvailabeRooms()
        {
            InitializeComponent();
        }

        private void AvailabeRooms_Load(object sender, EventArgs e)
        {
            using (var db = new DormitoryDatabaseEntities3())
            {
                var RoomList = db.Rooms.SqlQuery("Select * from Room where OpenCapacity>0 ").ToList<Room>();
                foreach (var item in RoomList)
                {
                    dataGridView1.Rows.Add(item.RoomNum, item.FloorNum, item.BlockNum, item.Capacity, item.OpenCapacity, item.RoomPrice);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
