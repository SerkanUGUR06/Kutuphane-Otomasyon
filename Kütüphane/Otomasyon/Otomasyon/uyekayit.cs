using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;   // Katmanlarımı tanımladım kullanabilmek için
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class uyekayit : Form
    {
        public uyekayit()
        {
            InitializeComponent();
        }

        private void Uyeekle_Click(object sender, EventArgs e)
        {
            if (uyee.Text != "" && ad.Text != "" && dogum.Text != "" && posta.Text != "" && telefon.Text != "" && ulke.Text != "" && sehir.Text != "")//Boş değilse kayıt yapmasını sağladım.
            {
                if (uyee.Text.Length == 11) //Tc kimlik no 11'e eşit ise kayıt işlemi gerçekleştiriliyor
                {
                    EntityUyeKayit uye = new EntityUyeKayit();  //EntityUyekayit sınıfına ait bir nesne türettim.
                    uye.Uye_TC_No1 = uyee.Text;      //ve accessdeki tablolomun değişkenlerine ve tiplerine göre textlerini alarak veritabanına attım.
                    uye.Adi_ve_Soyadi1 = ad.Text;
                    uye.Dogum_Tarihi1 = DateTime.Parse(dogum.Text);//Tip dönüşümü
                    uye.E_Posta_Adresi1 = posta.Text;
                    uye.Telefon_No1 = telefon.Text;
                    uye.Yasadigi_Ulke1 = ulke.Text;
                    uye.Yasadigi_Sehir1 = sehir.Text;
                    uye.Adres1 = adres.Text;
                    LogicUye.LLUyeekle(uye);     //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına ekleme işlemini çağırıyorum.
                    List<EntityUyeKayit> UyeList = LogicUye.LLUyelistesi();//EntityUekayıtten nesne türetere LogicUyeden listeleme fonksiyonumu çağırıyorum.
                    uyegoster.DataSource = UyeList;//O listelenecek verileri datasourceda göstermek için kullandım.
                    MessageBox.Show("Üye Ekleme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");
                }// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
                else
                {
                    MessageBox.Show("TC No 11 Haneli Olmalıdır. Tekrar Bilgi Girişi Yapınız. ", "Bilgi Penceresi");//11 haneli değilse ekrana hata vermesini sağladım.
                }
            }
            else
            {
                MessageBox.Show("Üye Ekleme İşleminiz Gerçekleşmemiştir. Alanların Boş Olmadığından Emin Olunuz.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.

            }
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            uyekimlik.Text = null; // İptal et butonuna basıldığında bütün teextboxların içlerini boşaltma işlemi yaptım.
            uyee.Text = null;
            ad.Text = null;
            dogum.Text = null;
            posta.Text = null;
            telefon.Text = null;
            ulke.Text = null;
            sehir.Text = null;
            adres.Text = null;
            List<EntityUyeKayit> UyeList = LogicUye.LLUyelistesi();//Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
            uyegoster.DataSource = UyeList;//Bir nevi listemizi yenileyerek datasource ekrana veriyor.
            MessageBox.Show("Üye İptal Etme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor. 
        }

        private void label11_Click(object sender, EventArgs e)
        {   //Geri butonuna basılınca 
            anasayfa anasayfagec = new anasayfa();//anasayfa formundan nesne türettim.
            anasayfagec.Show();//O nesne ile ansayfaya geçiş sağladım.
            this.Hide();
        }

        private void Uyeguncelle_Click(object sender, EventArgs e)
        {
            try//Satır seçimi yapılırsa buraya yönlenecek
            {
                EntityUyeKayit kayit = new EntityUyeKayit();//EntityKitapkayit nesne türettim 
                kayit.Kimlik = int.Parse(uyekimlik.Text); // Sonra textboxlardan bilgilerin değişimini yapılacak olanlar değiştirilmesi için veri girişleri aldım.
                kayit.Uye_TC_No1 = uyee.Text;
                kayit.Adi_ve_Soyadi1 = ad.Text;
                kayit.Dogum_Tarihi1 = DateTime.Parse(dogum.Text);
                kayit.E_Posta_Adresi1 = posta.Text;
                kayit.Telefon_No1 = telefon.Text;
                kayit.Yasadigi_Ulke1 = ulke.Text;
                kayit.Yasadigi_Sehir1 = sehir.Text;
                kayit.Adres1 = adres.Text;
                LogicUye.LLUyeguncelle(kayit);  //Logic KitapKayittaki guncelleme fonksiyonunu DALKitaptan çekerek güncelleme işlemini yaptırdım.
                //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                List<EntityUyeKayit> UyeList = LogicUye.LLUyelistesi();// O listelenecek verileri datasourceda göstermek için kullandım.
                uyegoster.DataSource = UyeList;
                MessageBox.Show("Üye Güncelleme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
            }
            catch (Exception exception)//Eger butona satır seçmeden basarsa hata mesajı verecek.
            {

                MessageBox.Show("Satır Seçilmeden Güncelleme işlemi yapılamaz.", "Bilgi Penceresi");//Hata mesajı verdi.
            }
        }

        private void Uyesil_Click(object sender, EventArgs e)
        {
            try//Satır seçimi yapılırsa buraya yönlenecek
            {
                EntityUyeKayit ent = new EntityUyeKayit(); //Her zamanki gibi Entity uyekayittan nesne türettim
                ent.Kimlik = Convert.ToInt32(uyekimlik.Text); // türettiğim nesne ile kimlik bilgisine ulaştım.
                LogicUye.LLUyesil(ent.Kimlik); //Kimlige göre silme fonksiyonunu çağırdım Logiclayer yardımıyla.
                List<EntityUyeKayit> UyeList = LogicUye.LLUyelistesi();//Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                uyegoster.DataSource = UyeList;
                MessageBox.Show("Üye Silme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
            }
            catch (Exception exception)//Satır seçimi yapmadan silme butonuna tıklarsa hata verecek.
            {
                MessageBox.Show("Satır Seçilmeden silme işlemi yapılamaz !" + exception.Message, "Bilgi Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uyegoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = uyegoster.SelectedCells[0].RowIndex; // Datasourceda açılan access verilerini çift tıklama özelliğini kullandım. Bu sayede verileri textbox,combobox türlerine aktarılmasını sağladım
            string Kimliki = uyegoster.Rows[secilenalan].Cells[0].Value.ToString();
            string Uye_TC_Noo = uyegoster.Rows[secilenalan].Cells[1].Value.ToString();
            string Adi_ve_Soyadii = uyegoster.Rows[secilenalan].Cells[2].Value.ToString();
            string Dogum_Tarihii = uyegoster.Rows[secilenalan].Cells[3].Value.ToString();
            string E_Posta_Adresii = uyegoster.Rows[secilenalan].Cells[4].Value.ToString();
            string Telefon_Noi = uyegoster.Rows[secilenalan].Cells[5].Value.ToString();
            string Yasadigi_Ulkei = uyegoster.Rows[secilenalan].Cells[6].Value.ToString();
            string Yasadigi_Sehiri = uyegoster.Rows[secilenalan].Cells[7].Value.ToString();
            string Adresi = uyegoster.Rows[secilenalan].Cells[8].Value.ToString();

            uyekimlik.Text = Kimliki;//Buradada verileri nerede gösterecekse yani hangi veriyi hangi textbox veya comboxda gösterecekse onu belirttim.
            uyee.Text = Uye_TC_Noo;
            ad.Text = Adi_ve_Soyadii;
            dogum.Text = Dogum_Tarihii;
            posta.Text = E_Posta_Adresii;
            telefon.Text = Telefon_Noi;
            ulke.Text = Yasadigi_Ulkei;
            sehir.Text = Yasadigi_Sehiri;
            adres.Text = Adresi;
        }

        private void uyekayit_Load(object sender, EventArgs e)
        {
            List<EntityUyeKayit> UyeList = LogicUye.LLUyelistesi();// Acceess'deki verileri sayfa açılır açılmaz datasource a çeker ve gösterir.
            uyegoster.DataSource = UyeList;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();//Programın sonlandırılması için kullandım.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyegoster.DataSource = LogicUye.LLarama(tc.Text).Tables[0];//LogicUye katmanından arama fonksiyonumu çağırıyorum ve datasourceda göstermesini sağladım.
        }

        private void uyee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Harf girmesini engelledim
            {
                e.Handled = true;
            }
        }

        private void telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Harf girmesini engelledim
            {
                e.Handled = true;
            }
        }
    }
}
