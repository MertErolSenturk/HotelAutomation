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
    public partial class AdminRegister : Form
    {
        AppDbContext db = new AppDbContext();
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                //textboxlardaki değeri değişkenlere atadım. Ardından kullanici adında sorgu yaptım. Eğer kullanici_adi değişkeni userName değişkenine eşit ise
                //Böyle bir kullanıcı daha önceden kayıt edildiğinden dolayı uygun hata mesajını verdim.
                //Ardından eğer böyle bir kullanıcı yok ise Admin kaydını gerçekleştirdim. yetki_turu tablomda tanımladığım admin yetkisini verdim.
                string userName = text_userName.Text;
                string password = txt_password.Text;

                kullanici kullanici = db.kullanici.Where(x => x.kullanici_adi == userName).FirstOrDefault();


                if (kullanici != null)
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Mevcut");
                }
                else
                {
                    kullanici kullanici1 = new kullanici();
                    kullanici1.kullanici_adi = userName;
                    kullanici1.sifre = Crypt.SHA256Hash(password);
                    kullanici1.olusturmaTarihi = DateTime.Now;
                    kullanici1.yetki_id = 1;
                    kullanici1.aktifMi = true;
                    db.kullanici.Add(kullanici1);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Başarılı");
                    this.Hide();
                    Admin main = new Admin();
                    main.Show();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }



        }
    }
}
