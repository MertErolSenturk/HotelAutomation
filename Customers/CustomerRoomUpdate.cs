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
    public partial class CustomerRoomUpdate : Form
    {
        private AppDbContext db = new AppDbContext(); // Veritabanı bağlantısı
        private readonly int _reservationId;
        private readonly int _userid;
        public CustomerRoomUpdate(int reservationId,int userid)
        {
            _userid = userid;
            _reservationId = reservationId;
            InitializeComponent();
        }
 

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Bu sorgu ile aynı kullanıcı daha önce güncelleme işlemi yaptıysa Tekrar yapamayacaktır ve hata mesajı alacaktır. Eğer yapmadıysa kod devam edecektir.
            islemler islemKontrol = db.islemler.Where(x => x.rezervasyonId == _reservationId && x.kullaniciId == _userid && x.islemId == 1).FirstOrDefault();
            if (islemKontrol != null)
            {
                MessageBox.Show("Güncelleme İşlemi İçin Sadece 1 Hakkınız Bulunmaktadır. Güncelleme Yapamazsınız");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen Oda Seçiniz");
                }
                else
                {
                    // Müşteri yeni giriş-çıkış tarihi ve geçmek istediği odayı seçtikten sonra güncelle buttonuna basar ve aşağıdaki kod satırları ile veritabanına
                    // Güncellenmiş veriler kaydedilir.
                    var reservation = db.rezervasyon.Where(x => x.id == _reservationId).FirstOrDefault();
                    var currentRoom = db.odalar.Where(x => x.id == reservation.oda_id).FirstOrDefault();
                    currentRoom.oda_durum = true;
                    reservation.giris_tarihi = dt_startUpdate.Value;
                    reservation.cikis_tarihi = dt_outUpdate.Value;
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    reservation.oda_id = Convert.ToInt32(selectedRow.Cells[0].Value);

                   

                    if (dataGridView1.SelectedRows.Count<=0)
                    {
                        MessageBox.Show("Lütfen Oda Seçiniz");
                    }
                    else
                    {
                        //Yeni Seçilen odanın durumunu false konumuna getirdim.
                        var selectedRoomId = dataGridView1.SelectedRows[0];
                        var id = Convert.ToInt32(selectedRoomId.Cells[0].Value);
                        var selectedRoomModel = db.odalar.Where(x => x.id == id).FirstOrDefault();
                        selectedRoomModel.oda_durum = false;
                    }
                   

                    //Yapılan işlem güncelleme ise işlem tablosuna gerekli Logları kaydettim.
                    var processType = db.islemTuru.Where(x => x.adi == "Guncelleme").FirstOrDefault();
                    if (processType == null)
                    {

                        MessageBox.Show("İşlem Hatası");
                    }
                    else
                    {
                        islemler islem = new islemler();
                        islem.kullaniciId = _userid;
                        islem.rezervasyonId = _reservationId;
                        islem.islemId = processType.id;
                        islem.olusturmaTarihi = DateTime.Now;
                        db.islemler.Add(islem);
                    }
                    //database'i Kaydettim
                    db.SaveChanges();
                    MessageBox.Show("İşlem Başarılı");
                    CustomerRoomUpdate_Load(sender, e);

                }
            }
           
            

            
                              
        }

        private void CustomerRoomUpdate_Load(object sender, EventArgs e)
        {
            //Müşterinin Geçebileceği Müsait odaları görüntüledim.
            var availableRooms = db.odalar.Where(x => x.oda_durum == true).ToList();
            dataGridView1.DataSource = availableRooms;

        }
    }
}
