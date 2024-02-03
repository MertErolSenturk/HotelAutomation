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
    public partial class Reservation : Form
    {
        // Database  çağırdım.
        AppDbContext db = new AppDbContext(); // Singleton Bir defa oluşturuyor.
        private readonly int _userId;
        
        public Reservation( int userId)
        {
            _userId = userId;
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRoom cus = new CustomerRoom(_userId);
            cus.Show();
        }

        private void btn_reserv_Click(object sender, EventArgs e)
        {

            // Rezervasyon İşlemleri Sırasında İlgili Bölgeler Boş Bıraklırsa Hata Mesajı Verecektir.
            if ( txt_name.Text == "" || txt_surname.Text == ""  || txt_tc.Text == "" || txt_telNo.Text == ""  ) 
            {

                MessageBox.Show("Lütfen Gerekli Alanları Doldurun.");
               
            }
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen Oda Seçin.");
            }
            // Rezerve tarihi bugünden önce olamaz.
            if (dt_start.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Başlangıç tarihi bugünden önce olamaz");
            }
            else
            {
                // Database  çağırdım.
                AppDbContext db = new AppDbContext(); // Transient her seferinde çağırabilmemiz için.
                try
                {
                   
                    // Seçili satırın DataGridViewRow nesnesini al
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // DataGridView'de ID sütununun index'ini al (örneğin, 0. sütun)
                    int idColumnIndex = 0;

                    // Seçili satırdaki ID değerini al
                    int selectedRowId = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                  

                    rezervasyon res = new rezervasyon();
                    
                    // Rezervasyon işlemleri için textbox-combobox gibi öğeleri veri tabanındakilerle eşleştirdim
                    res.oda_id = selectedRowId;
                    res.isim = txt_name.Text;
                    res.soyisim = txt_surname.Text;
                    res.cinsiyet = cb_gender.SelectedItem.ToString();
                    res.tc = txt_tc.Text;
                    res.telNo = txt_telNo.Text;
                    res.giris_tarihi= dt_start.Value;
                    res.cikis_tarihi= dt_out.Value;
                    res.olusturmaTarihi = DateTime.Now;
                    res.aktifMi = true;
                    res.kullaniciId = _userId;
                    db.rezervasyon.Add(res);

                    odalar oda = db.odalar.Where(x => x.id == res.oda_id).FirstOrDefault();
                    //Eğer rezervasyon işlemi sırasında müşteri x kişisi odayı tutmadan önce başkası tutarsa Hata mesajı verecek. Değilse normal rezervasyon işlemi gerçekleştirilecek.
                    if (oda.oda_durum == false)
                    {
                       
                        MessageBox.Show("Oda Başkası Tarafından Rezerve Edilmiş.");
                        db.Database.BeginTransaction().Rollback();
                        Reservation_Load(sender, e);
                    }
                    else
                    {

                        oda.oda_durum = false;
                        db.SaveChanges();
                        MessageBox.Show("Rezervasyon Başarılı");
                        Reservation_Load(sender, e);

                    }
                    
                }
                catch (Exception ex)
                {
                    db.Database.BeginTransaction().Rollback(); // Bir hata alırsam database işlemini iptal ediyor.
                    MessageBox.Show("Hata");
                    Console.WriteLine(ex.Message); //hata mesajını ver
                }
            }

          
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
         
            //Müşterilerin müsait odaları görmesii için daragridview'e database üzerinden verileri listelettim. Visible özelliği ile hangi başlıkları göreceklerini ayarladım.
            List<odalar> rooms = db.odalar.Where(x => x.oda_durum == true).ToList();
            dataGridView1.DataSource = rooms;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["oda_durum"].Visible = false;
            dataGridView1.Columns["rezervasyon"].Visible = false;
            dataGridView1.Columns["oda_no"].HeaderText = "Oda Numarası";
            dataGridView1.Columns["kisi_sayisi"].HeaderText = "Kişi Sayısı";
        }
    }
}
