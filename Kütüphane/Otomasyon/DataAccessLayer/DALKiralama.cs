using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; // Kullanacağım kantmanların tanımlamasını yaptım.
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
    public class DALKiralama
    {

        public static List<EntityKiralama>Kiralistesi() // Listelemek için method tanımladım.
        {
            List<EntityKiralama> deger = new List<EntityKiralama>();  //Entity kiralama sinifindan bir nesne türettim.
            OleDbCommand komut = new OleDbCommand("Select * from Kiralama", Baglanti.baglantiac); //Database bir nesne türettim ve tablomuzun belirttim
            if (komut.Connection.State != ConnectionState.Open)  //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }

            OleDbDataReader stnkira = komut.ExecuteReader();
            while (stnkira.Read()) //Yukarıda oluşturduğumuz stnkira komutunun okuma işlemi devam ettiği sürece
            {
                EntityKiralama ekle = new EntityKiralama(); // Entity kiralama sınıfından bir nesne türettim
                ekle.Kimlik = int.Parse(stnkira["Kimlik"].ToString()); //Bu nesne ile propertyleri ulaşım sağladım.
                ekle.Kiralayan_Uye1 = stnkira["Kiralanan_Uye"].ToString(); // ve atama işlemlerini yaptım.
                ekle.Kiralanan_Kitap1 = stnkira["Kiralanan_Kitap"].ToString();
                ekle.Alim_Tarihi1 = DateTime.Parse(stnkira["Alim_Tarihi"].ToString());
                ekle.Teslim_Tarihi1 = DateTime.Parse(stnkira["Teslim_Tarihi"].ToString());
                deger.Add(ekle); //ve yukaarıda oluşturduğum deger adındaki listeye eklmesini yaptrdım.
            }
            stnkira.Close(); //Kapatma işlemini gerçekleştirdim.
            return deger; // Degeri döndürdüm.

        
        }


        public static int KiralamaEkle(EntityKiralama ki) //Ekleme yapmak için method oluşturdum.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz ekleme işlemi için ilgili parantezin içine ekleme kodunu yazıyoruz.
            OleDbCommand komut2 = new OleDbCommand("insert into Kiralama(Kiralanan_Uye,Kiralanan_Kitap,Alim_Tarihi,Teslim_Tarihi) VALUES (@P1,@P2,@P3,@P4)", Baglanti.baglantiac);
            if (komut2.Connection.State != ConnectionState.Open)//Dosya kontrolü ile dosya kapalı mı açık mı ona bakıyoruz.
            {
                komut2.Connection.Open();//Eğer kapalı ise access dosyamızı açıyoruz.
            }

            komut2.Parameters.AddWithValue("@P1", ki.Kiralayan_Uye1);//Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P2", ki.Kiralanan_Kitap1);//Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P3", ki.Alim_Tarihi1);//Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P4", ki.Teslim_Tarihi1);//Parametrelere gelecek olan değer atamalarını yaptırıyorum.

            return komut2.ExecuteNonQuery();//Satır sayısına kadar döndürme işlemini yapıyor.


        }

        public static bool KiralamaSil(int kira)  //Silme işlemi için bool kullandım parametre gönderdim çünkü kimlige göre silecegiz.
        {

            OleDbCommand komut3 = new OleDbCommand("Delete from Kiralama where Kimlik=@P1", Baglanti.baglantiac);//Parametresi @p1 olan yeri silmesi için bu kod satırını kullandık.
            if (komut3.Connection.State != ConnectionState.Open) //Dosyamızı kontrol ediyoruz açık değil ise 
            {
                komut3.Connection.Open(); //Açılmasını sağlıyoruz.
            }

            komut3.Parameters.AddWithValue("@P1", kira); //Bu nesne ile propertyleri ulaşım sağladım ve atama işlemlerini yaptım.
            return komut3.ExecuteNonQuery() > 0; //Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
            // Yani true olacak yani birşeyi silecek.
        }


        public static bool KiralamaGuncelle(EntityKiralama kir) //Güncelleme işlemim için bool kullandım ve parametre göderdim.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz güncelleme işlemi için ilgili parantezin içine güncelleme kodunu yazıyoruz.
            OleDbCommand komut4 = new OleDbCommand("Update Kiralama SET Kiralanan_Uye=@P1,Kiralanan_Kitap=@P2,Alim_Tarihi=@P3,Teslim_Tarihi=@P4 WHERE Kimlik=@P5", Baglanti.baglantiac);//Databese ile güncelleme yapıılacak olan olanların parametrelerini tannımladık.
            if (komut4.Connection.State != ConnectionState.Open) //Dosyamızı kontrol ediyoruz açık değil ise  açmasını sağlıyoruz.
            {
                komut4.Connection.Open();
            }

            komut4.Parameters.AddWithValue("@P1", kir.Kiralayan_Uye1);  //Parametrelerimize atama işlemlerini tek tek yaptım.
            komut4.Parameters.AddWithValue("@P2", kir.Kiralanan_Kitap1);
            komut4.Parameters.AddWithValue("@P3", kir.Alim_Tarihi1);
            komut4.Parameters.AddWithValue("@P4", kir.Teslim_Tarihi1);
            komut4.Parameters.AddWithValue("@P5", kir.Kimlik);
 
            return komut4.ExecuteNonQuery() > 0; //Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
            // Yani true olacak yani birşeyi güncelleyecek.
        }

        public static DataSet arama(string aranan)
        {
            OleDbCommand komut = new OleDbCommand("Select * from Kiralama where Kiralanan_Kitap like '%" + aranan + "%'", Baglanti.baglantiac); //Database bir nesne türettim ve tablomuzun belirttim
            if (komut.Connection.State != ConnectionState.Open) //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }
            OleDbDataAdapter da = new OleDbDataAdapter(komut);//Yeni dataadapter türettim
            DataSet ds = new DataSet();// Yeni dataset türettim
            da.Fill(ds);//ve ikisini fill yaparak verileri dataadapterdan datasete aktardık.
            return ds;//Sonra Dataseti döndürdük
        }

        public static List<string> uyedoldur()
        {        //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz listeleme işlemi için ilgili parantezin içine güncelleme kodunu yazıyoruz.
            OleDbCommand cmd = new OleDbCommand("Select Adi_ve_Soyadi From Uyekayit", Baglanti.baglantiac);

            if (cmd.Connection.State != ConnectionState.Open)//Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                cmd.Connection.Open();//Açık değilse bağlantıyı açıyoruz.
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<string> uyeler = new List<string>();//uyeler adında liste oluşturuyorum

            while (dr.Read())
            {
                uyeler.Add(dr["Adi_ve_Soyadi"].ToString());//ve okunan ad ve soyadi içine atıyorum.
            }

            return uyeler;//üyeleri döndürdüm
        }

        public static List<string> kitapdoldur()
        {       //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz listeleme işlemi için ilgili parantezin içine güncelleme kodunu yazıyoruz.
            OleDbCommand cmd = new OleDbCommand("Select Kitap_Adi From Kitapkayit", Baglanti.baglantiac);

            if (cmd.Connection.State != ConnectionState.Open)//Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                cmd.Connection.Open();//Açık değilse bağlantıyı açıyoruz.
            }

            OleDbDataReader dr = cmd.ExecuteReader();
            List<string> kitaplar = new List<string>();//Kitaplar adında liste oluşturuyorum

            while (dr.Read())
            {
                kitaplar.Add(dr["Kitap_Adi"].ToString());//ve okunan Kitap adını içine atıyorum.
            }

            return kitaplar; //kitapları döndürdüm.
        }



    }

    }
