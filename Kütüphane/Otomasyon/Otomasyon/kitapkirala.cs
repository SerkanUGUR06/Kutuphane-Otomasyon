using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;  // Katmanlarımı tanımladım kullanabilmek için
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class kitapkirala : Form
    {
        public kitapkirala()
        {
            InitializeComponent();
        }

        private void kiraekle_Click(object sender, EventArgs e)
        {
            if (kiralananki.Text != "" && Kiralananuy.Text != "" && date.Text != "" && datee.Text != "")
            {
                EntityKiralama kira = new EntityKiralama();   //EntityKiralama sınıfına ait bir nesne türettim.
                kira.Kiralanan_Kitap1 = kiralananki.Text;     //ve accessdeki tablolarımın değişkenlerine göre textlerini alarak veritabanına attım.
                kira.Kiralayan_Uye1 = Kiralananuy.Text;
                kira.Alim_Tarihi1 = DateTime.Parse(date.Text);
                kira.Teslim_Tarihi1 = DateTime.Parse(datee.Text);
                LogicKiralama.LLKiraekle(kira);                //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına ekleme işlemini çağırıyorum.
                List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();  //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                kiragoster.DataSource = KiraList;  //O listelenecek verileri datasourceda göstermek için kullandım.
                MessageBox.Show("Kiralama İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");
            }// İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.
            else
            {
                MessageBox.Show("Kiralama İşleminiz Gerçekleşmemiştir. Alanları Kontrol Ediniz. Boş Alan Bırakmayınız. ", "Bilgi Penceresi");
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            kiralananki.Text = null;  // İptal et butonuna basıldığında bütün teextboxların içlerini boşaltma işlemi yaptım.
            Kiralananuy.Text = null;  
            date.Text = null;
            datee.Text = null;
            List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi(); //Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
            kiragoster.DataSource = KiraList;                                  //Bir nevi listemizi yenileyerek datasource ekrana veriyor.
            MessageBox.Show("İptal İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi");               // İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.                                                                       
        }

        private void kiraguncel_Click(object sender, EventArgs e)
        {
            try//Satır seçimi yapılırsa buraya yönlenecek
            {
                EntityKiralama kayit = new EntityKiralama();  //EntityKiralamadan nesne türettim 
                kayit.Kimlik = int.Parse(kimlik.Text);        //Sonra comboboxlardan deiğişimini yapılackların girişini aldım
                kayit.Kiralanan_Kitap1 = kiralananki.Text;
                kayit.Kiralayan_Uye1 = Kiralananuy.Text;
                kayit.Alim_Tarihi1 = DateTime.Parse(date.Text);
                kayit.Teslim_Tarihi1 = DateTime.Parse(datee.Text);
                LogicKiralama.LLKiraguncelle(kayit);          //Logic kiralamadaki guncelleme fonksiyonunu DALKiralamadan çekerek güncelleme ilemini yaptırdım.
                List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();
                kiragoster.DataSource = KiraList;
                MessageBox.Show("Kiralama Güncelleme İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi"); // İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.   
            }
            catch (Exception exception)//Eger butona satır seçmeden basarsa hata mesajı verecek.
            {

                MessageBox.Show("Satır Seçilmeden Güncelleme işlemi yapılamaz.", "Bilgi Penceresi");//Hata mesajı verdi.
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                try//Satır seçimi yapılırsa buraya yönlenecek
                {
                    EntityKiralama ent = new EntityKiralama(); //Her zamanki gibi Entity kiralamadan nesne türettim
                     ent.Kimlik = Convert.ToInt32(kimlik.Text);// türettiğim nesne ile kimlik bilgisine ulaştım.
                     LogicKiralama.LLKirasil(ent.Kimlik);//Kimlige göre silme fonksiyonunu çağırdım Logiclayer yardımıyla.
                List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();//Burada da LogicLayer katmanında yaptığım fonksiyon ile DataAccessLayer katmanından veri tabanına listeleme işlemini çağırıyorum.
                kiragoster.DataSource = KiraList;
                    MessageBox.Show("Kiralama Teslim Alma İşleminiz Gerçekleşmiştir.", "Bilgi Penceresi"); // İşlem Tamamlandığı zaman messsagebox ile mesaj veriyor.  
                }
            catch (Exception exception)//Eger butona satır seçmeden basarsa hata mesajı verecek.
            {

                MessageBox.Show("Satır Seçilmeden Silme işlemi yapılamaz.", "Bilgi Penceresi");//Hata mesajı verdi.
            }
        }

        private void kiragoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = kiragoster.SelectedCells[0].RowIndex;    // Datasourceda açılan access verilerini çift tıklama özelliğini kullandım. Bu sayede verileri textbox,combobox türlerine aktarılmasını sağladım.
            string Kimliki = kiragoster.Rows[secilenalan].Cells[0].Value.ToString();    
            string Kiralanan_Kitapp = kiragoster.Rows[secilenalan].Cells[1].Value.ToString();
            string Kiralayan_Uyee = kiragoster.Rows[secilenalan].Cells[2].Value.ToString();
            string Alim_Tarihii = kiragoster.Rows[secilenalan].Cells[3].Value.ToString();
            string Teslim_Tarihii = kiragoster.Rows[secilenalan].Cells[4].Value.ToString();

            kimlik.Text = Kimliki; //Buradada verileri nerede gösterecekse yani hangi veriyi hangi textbox veya comboxda gösterecekse onu belirttim.
            kiralananki.Text = Kiralanan_Kitapp;
            Kiralananuy.Text = Kiralayan_Uyee;
            date.Text = Alim_Tarihii;
            datee.Text = Teslim_Tarihii;
        }

        private void kitapkirala_Load(object sender, EventArgs e)
        {

            Kiralananuy.DataSource = LogicKiralama.LLuyedoldur(); // Combobox verilerimi dolduruyorum
            kiralananki.DataSource = LogicKiralama.LLkkitapdoldur();// Combobox verilerimi dolduruyorum
            kiralananki.SelectedIndex = -1;//İlk açılışta boş olsun diye -1 yaptım
            Kiralananuy.SelectedIndex = -1;//İlk açılışta boş olsun diye -1 yaptım

            List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();  // Acceess'deki verileri sayfa açılır açılmaz datasource a çeker ve gösterir.
            kiragoster.DataSource = KiraList;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); Application.Exit(); //Programı sonlandırması için x butonuna ekledim.
        }

        private void label10_Click(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa();  //Anasayfadan nesne türeterek Geri butonuna basınca anasayfaya geçişini sağladım.
            anasayfagec.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kiragoster.DataSource = LogicKiralama.LLara(kitapara.Text).Tables[0];//LogicKiralama katmanından arama fonksiyonumu çağırıyorum ve datasourceda göstermesini sağladım.
        }
    }
}
