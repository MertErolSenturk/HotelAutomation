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
    public partial class CustomerRoom : Form
    {
        private readonly int _userId;
        
        AppDbContext db = new AppDbContext();
        public CustomerRoom(int userId)
        {
            
            _userId = userId;
            InitializeComponent();
        }

        private void Musteri_oda_Load(object sender, EventArgs e)
        {
            //Sayfa her açıldığında datagridview1'de ilgili kullanıcının tüm rezervasyonlarını gösterdim.
            var date = DateTime.Now.Date;
            var reservations = (from reservation in db.rezervasyon
                                select new
                                {
                                    reservation.id,
                                    reservation.isim,
                                    reservation.tc,
                                    reservation.telNo,
                                    reservation.giris_tarihi,
                                    reservation.cikis_tarihi,
                                    reservation.aktifMi,
                                    reservation.kullaniciId
                                }).Where(x => x.cikis_tarihi >= date
            && x.aktifMi == true && x.kullaniciId == _userId).ToList();
            dataGridView1.DataSource = reservations;
            dataGridView1.Columns["aktifMi"].Visible = false;
            dataGridView1.Columns["kullaniciId"].Visible = false;

        }

        private void btn_rezervasyon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers main = new Customers(_userId);
            main.Show();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

  

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Müşteri Silmek İstediği Rezervasyonunu Seçtikten Sonra "Rezervasyonu İptal Et"  Butonuna Bastığında Silme İşlemi Yapar.

           AppDbContext db = new AppDbContext();
           // Rezervasyonunu seçip seçmediğini kontrol ettirdim.
           if (dataGridView1.SelectedRows.Count<=0)
            {
                MessageBox.Show("Lütfen Oda Seçiniz");
            }
            else
            {
            
                try
                {
                    // Değerleri değişkenlere atadım. Silme tarihini tabloma yazdırdım. Odanın aktiflik kısmını silme işlemi yaptığımdan false olarak güncelledim.
                    var selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    var model = db.rezervasyon.Find(id);
                    model.silmeTarihi = DateTime.Now;
                    model.aktifMi = false;


                    // Sorgu yazdım ve İslem türü silme mi değil mi kontrol ettirdim.
                    var processType = db.islemTuru.Where(x => x.adi == "Silme").FirstOrDefault();
                    if (processType == null)
                    {
                        MessageBox.Show("Hata");
                    }
                    //islemler tabloma silme işlemini kimin yaptığını ve bu işlemi ne zaman yaptığı gibi bilgileri geçirdim.
                    islemler islem = new islemler()
                    {
                        islemId = processType.id,
                        kullaniciId = _userId,
                        rezervasyonId = id,
                        olusturmaTarihi = DateTime.Now
                    };
                    db.islemler.Add(islem);

                    // odalar tablomdaki id ile rezervasyon tablomdaki oda_id eşleşiyor ise oda_durum = true şeklinde ayarlama yaptım.
                    var room = db.odalar.Where(x => x.id == model.oda_id).FirstOrDefault();
                    room.oda_durum = true;
                    
                    // Database kaydettim.
                    db.SaveChanges();
                    MessageBox.Show("Rezervasyon iptal edildi.");
                    Musteri_oda_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("İşlem Hatası");
                    db.Database.BeginTransaction().Rollback();
                }                      
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count<=0)
            {
                MessageBox.Show("Lütfen bir oda seçiniz.");
            }
            else
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int index = Convert.ToInt32(selectedRow.Cells[0].Value);
                CustomerRoomUpdate update = new CustomerRoomUpdate(index,_userId);
                update.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri_oda_Load(sender, e);
        }
    }
}
