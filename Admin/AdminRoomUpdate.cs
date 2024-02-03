using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAutomation
{
    public partial class AdminRoomUpdate : Form
    {
        AppDbContext db = new AppDbContext();
        public AdminRoomUpdate()
        {
            InitializeComponent();
        }

        private void AdminRoomUpdate_Load(object sender, EventArgs e)
        {
            var availableRooms = db.odalar.Where(x => x.oda_durum == true).ToList();
            dataGridView1.DataSource = availableRooms;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
