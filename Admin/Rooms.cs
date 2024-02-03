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
    public partial class Rooms : Form
    {

        AppDbContext db = new AppDbContext();
        public Rooms()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            List<odalar> rooms = db.odalar.Where(x => x.oda_durum == false).ToList();
            dataGridView1.DataSource = rooms;
            dataGridView1.Columns["oda_no"].HeaderText = "Oda Numarası";
            dataGridView1.Columns["kisi_sayisi"].HeaderText = "Kişi Sayısı";
            dataGridView1.Columns["rezervasyon"].Visible = false;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen Oda Seçiniz");
            }
            else
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                var model = db.rezervasyon.Find(id);
                model.silmeTarihi = DateTime.Now;
                model.aktifMi = false;

                var processType = db.islemTuru.Where(x => x.adi == "Silme").FirstOrDefault();

                if (processType == null)
                {
                    MessageBox.Show("Hata");
                }
                else
                {
                    islemler islem = new islemler()
                    {
                        islemId = processType.id,
                        rezervasyonId = id,
                        olusturmaTarihi = DateTime.Now
                    };
                    db.islemler.Add(islem);
                    //oda id rezervasyon tablosundaki oda id ile karşılaşırsa oda durumunu true yap
                    var room = db.odalar.Where(x => x.id == model.oda_id).FirstOrDefault();
                    room.oda_durum = true;

                    db.SaveChanges();
                    MessageBox.Show("Rezervasyon iptal edildi.");
                    Odalar_Load(sender, e);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
            {
                Odalar_Load(sender, e);
            }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_adminRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister register = new AdminRegister();
            register.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRoomUpdate update = new AdminRoomUpdate();
            update.Show();
        }
    }
    } 
