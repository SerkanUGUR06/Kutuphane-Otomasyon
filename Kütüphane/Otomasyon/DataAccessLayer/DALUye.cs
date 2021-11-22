using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;  // Kullanacağım kantmanların tanımlamasını yaptım.
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
   public class DALUye
    {
        public static List<EntityUyeKayit> Uyelistesi()  //Listelemek için entityuyekayittan uyelistesi adında method oluşturdum.
        {
            List<EntityUyeKayit> deger = new List<EntityUyeKayit>(); //Entity Kitapkayittan sinifindan bir nesne türettim.
            OleDbCommand komut = new OleDbCommand("Select * from Uyekayit", Baglanti.baglantiac);  //Database bir nesne türettim ve tablomuzun belirttim
            if (komut.Connection.State != ConnectionState.Open) //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }

            OleDbDataReader stnuye = komut.ExecuteReader();
            while (stnuye.Read())  //Yukarıda oluşturduğumuz stnuye komutunun okuma işlemi devam ettiği sürece
            {
                EntityUyeKayit ekle = new EntityUyeKayit();  // Entityuyekayit sınıfından bir nesne türettim
                ekle.Kimlik = int.Parse(stnuye["Kimlik"].ToString());  //Bu nesne ile propertyleri ulaşım sağladım.
                ekle.Uye_TC_No1 = stnuye["Uye_TC_No"].ToString();
                ekle.Adi_ve_Soyadi1 = stnuye["Adi_ve_Soyadi"].ToString(); // ve atama işlemlerini yaptım.
                ekle.Dogum_Tarihi1 = DateTime.Parse(stnuye["Dogum_Tarihi"].ToString());
                ekle.Telefon_No1 = stnuye["Telefon_No"].ToString();
                ekle.E_Posta_Adresi1 = stnuye["E_Posta_Adresi"].ToString();
                ekle.Yasadigi_Ulke1 = stnuye["Yasadigi_Ulke"].ToString();
                ekle.Yasadigi_Sehir1 = stnuye["Yasadigi_Sehir"].ToString();
                ekle.Adres1 = stnuye["Adres"].ToString();
                deger.Add(ekle); //ve yukaarıda oluşturduğum deger adındaki listeye eklmesini yaptrdım.
            }
            stnuye.Close();   //Kapatma işlemini gerçekleştirdim.
            return deger;  // Degeri döndürdüm.


        }


        public static int UyeEkle(EntityUyeKayit u) //Ekleme yapmak için method oluşturdum.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz ekleme işlemi için ilgili parantezin içine ekleme kodunu yazıyoruz.
            OleDbCommand komut2 = new OleDbCommand("insert into Uyekayit(Uye_TC_No,Adi_ve_Soyadi,Dogum_Tarihi,Telefon_No,E_Posta_Adresi,Yasadigi_Ulke,Yasadigi_Sehir,Adres) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", Baglanti.baglantiac);
            if (komut2.Connection.State != ConnectionState.Open)//Yine burada dosya kontrolü yapıyoruz 
            {
                komut2.Connection.Open();//Eğer kapalı ise access dosyamızı açıyoruz.
            }

            komut2.Parameters.AddWithValue("@P1", u.Uye_TC_No1); //Parametrelere değer atamlarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P2", u.Adi_ve_Soyadi1);
            komut2.Parameters.AddWithValue("@P3", u.Dogum_Tarihi1);
            komut2.Parameters.AddWithValue("@P4", u.Telefon_No1);
            komut2.Parameters.AddWithValue("@P5", u.E_Posta_Adresi1);
            komut2.Parameters.AddWithValue("@P6", u.Yasadigi_Ulke1);
            komut2.Parameters.AddWithValue("@P7", u.Yasadigi_Sehir1);
            komut2.Parameters.AddWithValue("@P8", u.Adres1);

            return komut2.ExecuteNonQuery();//Satır sayısına kadar döndürme işlemini yapıyor.



        }

        public static bool UyeSil(int uye)//Silme işlemi için bool kullandım parametre gönderdim çünkü kimlige göre silecegiz.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz silme işlemi için ilgili parantezin içine silme kodunu yazıyoruz.
            OleDbCommand komut3 = new OleDbCommand("Delete from Uyekayit where Kimlik=@P1", Baglanti.baglantiac);
            if (komut3.Connection.State != ConnectionState.Open)//Dosyamızı kontrol ediyoruz açık değil ise 
            {
                komut3.Connection.Open();//Eğer kapalı ise access dosyamızı açıyoruz.
            }

            komut3.Parameters.AddWithValue("@P1", uye);//Bu nesne ile propertyleri ulaşım sağladım ve atama işlemlerini yaptım.
            return komut3.ExecuteNonQuery() > 0;//Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
                                                // yani true olacak yani birşeyi silecek.

        }


        public static bool UyeGuncelle(EntityUyeKayit uyegun)
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz güncelleme işlemi için ilgili parantezin içine güncelleme kodunu yazıyoruz.
            OleDbCommand komut4 = new OleDbCommand("Update Uyekayit SET Uye_TC_No=@P1,Adi_ve_Soyadi=@P2,Dogum_Tarihi=@P3,Telefon_No=@P4,E_Posta_Adresi=@P5,Yasadigi_Ulke=@P6,Yasadigi_Sehir=@P7,Adres=@P8 WHERE Kimlik=@P9", Baglanti.baglantiac);
            if (komut4.Connection.State != ConnectionState.Open)//Dosyamızı kontrol ediyoruz açık değil ise açıyoruz.
            {
                komut4.Connection.Open();//Dosyamız kapalı ise açıyoruz.
            }

            komut4.Parameters.AddWithValue("@P1", uyegun.Uye_TC_No1);//Parametrelerimize atama işlemlerini tek tek yaptım.
            komut4.Parameters.AddWithValue("@P2", uyegun.Adi_ve_Soyadi1);
            komut4.Parameters.AddWithValue("@P3", uyegun.Dogum_Tarihi1);
            komut4.Parameters.AddWithValue("@P4", uyegun.Telefon_No1);
            komut4.Parameters.AddWithValue("@P5", uyegun.E_Posta_Adresi1);
            komut4.Parameters.AddWithValue("@P6", uyegun.Yasadigi_Ulke1);
            komut4.Parameters.AddWithValue("@P7", uyegun.Yasadigi_Sehir1);
            komut4.Parameters.AddWithValue("@P8", uyegun.Adres1);
            komut4.Parameters.AddWithValue("@P9", uyegun.Kimlik);
            return komut4.ExecuteNonQuery() > 0;//Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
            //yani true olacak yani birşeyi güncelleyecek.
        }
        public static DataSet bilgial(string aranan)
        {      // OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz arama işlemi için ilgili parantezin içine arama kodunu yazıyoruz ve neye göre ardaığımızı belirtiyoruz.
            OleDbCommand komut = new OleDbCommand("Select * from Uyekayit where Uye_TC_No like '%" + aranan + "%'", Baglanti.baglantiac); 
            if (komut.Connection.State != ConnectionState.Open) //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }
            OleDbDataAdapter da = new OleDbDataAdapter(komut); //Yeni dataadapter türettim
            DataSet ds = new DataSet();//Yeni dataset türettim
            da.Fill(ds); //ve ikisini fill yaparak verileri dataadapterdan datasete aktardık.
            return ds;//Sonra Dataseti döndürdük
        }
    }
}
