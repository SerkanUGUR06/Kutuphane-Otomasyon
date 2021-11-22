using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;      // Katmanlarımı tanımladım kullanabilmek için
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class kitapkayit : Form
    {
        public kitapkayit()
        {
            InitializeComponent();
        }

        private void kitapekle_Click(object sender, EventArgs e)
        {
            if (serino.Text != "" && kitapadi.Text != "" && kitapyazari.Text != "" && kitapbasim.Text != "" && sayfasayisi.Text != "" && kitapdili.Text != "" && yayinevi.Text != "")
            {//Alanların boş olup olmadığını kontrol ediyor boş değil ise ekleme işine devam ediyor.
                EntityKitapKayit kitap = new EntityKitapKayit();    //EntityKitapkayit sınıfına ait bir nesne türettim.
                kitap.Kitap_Seri_No1 = int.Parse(serino.Text);     //ve accessdeki tablolomun değişkenlerine ve tiplerine göre textboxtaki verileri alarak veritabanına attım.
                kitap.Kitap_Adi1 = kitapadi.Text;
                kitap.Kitap_Yazari1 = kitapyazari.Text;
                kitap.Kitap_Basim_Yili1 = int.Parse(kitapbasim.Text);
                kitap.Kitap_Sayfa_Sayisi1 = int.Parse(sayfasayisi.Text);
                kitap.Kitap_Dili1 = kitapdili.Text;
                kitap.Kitap_Yayinevi1 = yayinevi.Text;
                LogicKitap.LLKitapekle(kitap);          //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına ekleme işlemini çağırıyorum.
                List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi(); //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                kitapgoster.DataSource = KitapList; //O listelenecek verileri datasourceda göstermek için kullandım.
                MessageBox.Show("Kitap Ekleme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");
            }// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
            else
            {
                MessageBox.Show("Kitap Ekleme İşleminiz Gerçekleşmemiştir. Alanları Boş Bırakmadığınızdan Emin Olun.", "Bilgi Penceresi");//Alanlar boş ise uyarı veriyor.
            }
        }

        private void kitapiptal_Click(object sender, EventArgs e)
        {

            kimlik.Text = null; // İptal et butonuna basıldığında bütün teextboxların içlerini boşaltma işlemi yaptım.
            serino.Text = null;
            kitapadi.Text = null;
            kitapyazari.Text = null;
            kitapbasim.Text = null;
            sayfasayisi.Text = null;
            kitapdili.Text = null;
            yayinevi.Text = null;
            List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi();//Entitykitakayittan nesne türetip kitap listesini çağırıyorum burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
            kitapgoster.DataSource = KitapList;//Bir nevi listemizi yenileyerek datasource ekrana veriyor.
            MessageBox.Show("Kitap İptal Etme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi"); // İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor. 
        }

        private void label10_Click(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa();//anasayfa formundan türettiğim nesne ile anasayfaya geçişini sağladım.
            anasayfagec.Show();
            this.Hide();
        }

        private void kitapgoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = kitapgoster.SelectedCells[0].RowIndex;  // Datasourceda açılan access verilerini çift tıklama özelliğini kullandım. Bu sayede verileri textbox,combobox türlerine aktarılmasını sağladım
            string Kimliki = kitapgoster.Rows[secilenalan].Cells[0].Value.ToString();
            string Kitap_Seri_Noo = kitapgoster.Rows[secilenalan].Cells[1].Value.ToString(); 
            string Kitap_Adii = kitapgoster.Rows[secilenalan].Cells[2].Value.ToString();
            string Kitap_Yazarii = kitapgoster.Rows[secilenalan].Cells[3].Value.ToString();
            string Kitap_Basim_Yilii = kitapgoster.Rows[secilenalan].Cells[4].Value.ToString();
            string Kitap_Sayfa_Sayisii = kitapgoster.Rows[secilenalan].Cells[5].Value.ToString();
            string Kitap_Dilii = kitapgoster.Rows[secilenalan].Cells[6].Value.ToString();
            string Kitap_Yayinevii = kitapgoster.Rows[secilenalan].Cells[7].Value.ToString();

            kimlik.Text = Kimliki;//Buradada verileri nerede gösterecekse yani hangi veriyi hangi textbox veya comboxda gösterecekse onu belirttim.
            serino.Text=Kitap_Seri_Noo;
            kitapadi.Text=Kitap_Adii;
            kitapyazari.Text=Kitap_Yazarii;
            kitapbasim.Text=Kitap_Basim_Yilii;
            sayfasayisi.Text=Kitap_Sayfa_Sayisii;
            kitapdili.Text=Kitap_Dilii;
            yayinevi.Text=Kitap_Yayinevii;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try//Satır seçimi yapılırsa buraya yönlenecek
            {
                EntityKitapKayit kayit = new EntityKitapKayit(); //EntityKitapkayit nesne türettim 
                kayit.Kimlik = int.Parse(kimlik.Text);           // Sonra textboxlardan bilgilerin değişimini yapılacak olanlar değiştirilmesi için veri girişleri aldım.
                kayit.Kitap_Seri_No1 = int.Parse(serino.Text);
                kayit.Kitap_Adi1 = kitapadi.Text;
                kayit.Kitap_Yazari1 = kitapyazari.Text;
                kayit.Kitap_Basim_Yili1 = int.Parse(kitapbasim.Text);
                kayit.Kitap_Sayfa_Sayisi1 = int.Parse(sayfasayisi.Text);
                kayit.Kitap_Dili1 = kitapdili.Text;
                kayit.Kitap_Yayinevi1 = yayinevi.Text;
                LogicKitap.LLKitapguncelle(kayit);           //Logic KitapKayittaki guncelleme fonksiyonunu DALKitaptan çekerek güncelleme işlemini yaptırdım.
                List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi();//Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                kitapgoster.DataSource = KitapList;//O listelenecek verileri datasourceda göstermek için kullandım.
                MessageBox.Show("Güncelleme işlemi Başarılı.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.   
            }
            catch (Exception exception)//Eger butona satır seçmeden basarsa hata mesajı verecek.
            {

                MessageBox.Show("Satır Seçilmeden Güncelleme işlemi yapılamaz.", "Bilgi Penceresi");//Hata mesajı verdi.
            }
        }

        private void Kitapsil_Click(object sender, EventArgs e)
        {
            try//Satır seçimi yapılırsa buraya yönlenecek
            {
                EntityKitapKayit ent = new EntityKitapKayit(); //Her zamanki gibi Entity kitapkayittan nesne türettim
                ent.Kimlik = Convert.ToInt32(kimlik.Text); // türettiğim nesne ile kimlik bilgisine ulaştım.
                LogicKitap.LLKitapsil(ent.Kimlik); //Kimlige göre silme fonksiyonunu çağırdım Logiclayer yardımıyla.
                List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi();//Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                kitapgoster.DataSource = KitapList;
                MessageBox.Show("Kitap Silme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
            }
            catch (Exception exception)//Satır seçimi yapmadan silme butonuna tıklarsa hata verecek.
            {
                MessageBox.Show("Satır Seçilmeden silme işlemi yapılamaz !" + exception.Message, "Bilgi Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kitapara_Click(object sender, EventArgs e)
        {

            kitapgoster.DataSource = LogicKitap.llbilgial(kitapa.Text).Tables[0];//LogicKitap katmanından arama fonksiyonumu çağırıyorum ve datasourceda göstermesini sağladım.

        }

        private void kitapkayit_Load(object sender, EventArgs e)
        {
            List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi(); // Acceess'deki verileri sayfa açılır açılmaz datasource a çeker ve gösterir.
            kitapgoster.DataSource = KitapList;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();//Programın sonlandırılması için kullandım.
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa();//anasayfa formundan türettiğim nesne ile anasayfaya geçişini sağladım.
            anasayfagec.Show();
            this.Hide();
        }

        private void kitapbasim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Harf girmesini engelledim
            {
                e.Handled = true;
            }
        }

        private void sayfasayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Harf girmesini engelledim
            {
                e.Handled = true;
            }
        }
    }
    
    
}
