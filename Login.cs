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
    
    public partial class Login : Form
    {

        // Database  çağırdım.
        AppDbContext db = new AppDbContext();

        public Login()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Herhangi bir hata durumunda sorunun nerede olduğunu anlayabilmem için tüm kodu try cath içerisine aldım
            //Bir sorgu yazarak kullanıcı adı ve şifre kontrolü yaptım. Ardından giriş işlemi yaptırdım.
            //Parolayı Veritabanıma Crypt.cs Classını kullanarak şifreli bir şekilde aktardım.
            try
            {
                string userName = text_userName.Text;
                string password = txt_password.Text;
                string passwordHash = Crypt.SHA256Hash(password);
                kullanici kullanici = db.kullanici.Where(x => x.kullanici_adi == userName && x.sifre == passwordHash).FirstOrDefault();
                kullanici kullanici1 = db.kullanici.Where(x => x.kullanici_adi == userName && x.sifre == passwordHash && x.yetki_id == 1).FirstOrDefault();
                if (kullanici == null)
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Mevcut Değil");
                }
                else if(kullanici1 != null)
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    this.Hide();
                    Customers customer = new Customers(kullanici.kullanici_id);
                    customer.Show();
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata" + ex);
            }
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //Herhangi bir hata durumunda sorunun nerede olduğunu anlayabilmem için tüm kodu try cath içerisine aldım
            //Kullanıcı adı ve şifre textbox'ını değişkenlere atayıp Şifre kısmını kriptolayarak database'e aktarımını gerçekleştirdim
            try
            {
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
                    kullanici1.yetki_id = 2;
                    kullanici1.aktifMi = true;
                    db.kullanici.Add(kullanici1);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Başarılı");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

            
            
        }
    }
}
