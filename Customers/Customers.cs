using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAutomation;

namespace HotelAutomation
{
    public partial class Customers : Form
    {
        private readonly int _userId; 
        public Customers(int? userId = null)
        {
            //int gelirse koy yoksa koyma Explicit operator
            _userId = (int)userId;
          
           
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void btn_rezervasyon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation res = new Reservation(_userId);
            res.Show();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRoom cus = new CustomerRoom(_userId);
            cus.Show();

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
