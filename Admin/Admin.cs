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
    public partial class Admin : Form
    {
    
        public Admin() { 

            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_adminRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms adminRooms = new Rooms();
            adminRooms.Show();

        }

        private void btn_adminRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister register = new AdminRegister();
            register.Show();
        }
    }
}
