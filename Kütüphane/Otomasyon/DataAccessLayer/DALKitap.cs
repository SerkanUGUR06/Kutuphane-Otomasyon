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
    public class DALKitap
    {
        public static List<EntityKitapKayit> Kitaplistesi() //Listelemek için entitykitapkayittan kitaplistesi adında method oluşturdum.
        {
            List<EntityKitapKayit> deger = new List<EntityKitapKayit>();//Entity Kitapkayittan sinifindan bir nesne türettim.
            OleDbCommand komut = new OleDbCommand("Select * from Kitapkayit", Baglanti.baglantiac); //Database sınıfından bir nesne türettim ve tablomuzun belirttim tüm tabloyu göstermek için gereken kodu yazdım.
            if (komut.Connection.State != ConnectionState.Open) //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }

            OleDbDataReader stn = komut.ExecuteReader();
            while(stn.Read()) //Yukarıda oluşturduğumuz stn komutunun okuma işlemi devam ettiği sürece
            {
                EntityKitapKayit ent = new EntityKitapKayit();   // Entitykitapkayit sınıfından bir nesne türettim
                ent.Kimlik = int.Parse(stn["Kimlik"].ToString());  //Bu nesne ile propertyleri ulaşım sağladım.
                ent.Kitap_Seri_No1 = int.Parse(stn["Kitap_Seri_No"].ToString()); // ve atama işlemlerini yaptım.
                ent.Kitap_Adi1 = stn["Kitap_Adi"].ToString();
                ent.Kitap_Yazari1 = stn["Kitap_Yazari"].ToString();
                ent.Kitap_Basim_Yili1 = int.Parse(stn["Kitap_Basim_Yili"].ToString());
                ent.Kitap_Sayfa_Sayisi1 = int.Parse(stn["Kitap_Sayfa_Sayisi"].ToString());
                ent.Kitap_Dili1 = stn["Kitap_Dili"].ToString();
                ent.Kitap_Yayinevi1= stn["Kitap_Yayinevi"].ToString();
                deger.Add(ent); //ve yukaarıda oluşturduğum deger adındaki listeye eklmesini yaptrdım.
            }
            stn.Close(); //Kapatma işlemini gerçekleştirdim.
            return deger; // Degeri döndürdüm.

        }


        public static int KitapEkle(EntityKitapKayit k) //Ekleme yapmak için method oluşturdum.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz ekleme işlemi için ilgili parantezin içine ekleme kodunu yazıyoruz.
            OleDbCommand komut2 = new OleDbCommand("insert into Kitapkayit(Kitap_Seri_No,Kitap_Adi,Kitap_Yazari,Kitap_Basim_Yili,Kitap_Sayfa_Sayisi,Kitap_Dili,Kitap_Yayinevi) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", Baglanti.baglantiac);
            if(komut2.Connection.State != ConnectionState.Open) //Yine burada dosya kontrolü yapıyoruz 
            {
                komut2.Connection.Open();//Dosyamız açık değilse dosyamızı açıyoruz.
            }

            komut2.Parameters.AddWithValue("@P1", k.Kitap_Seri_No1); //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P2", k.Kitap_Adi1);    //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P3", k.Kitap_Yazari1); //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P4", k.Kitap_Basim_Yili1); //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P5", k.Kitap_Sayfa_Sayisi1);   //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P6", k.Kitap_Dili1);   //Parametrelere gelecek olan değer atamalarını yaptırıyorum.
            komut2.Parameters.AddWithValue("@P7", k.Kitap_Yayinevi1);   //Parametrelere gelecek olan değer atamalarını yaptırıyorum.

            return komut2.ExecuteNonQuery();//Satır sayısına kadar döndürme işlemini yapıyor.



        }

        public static bool KitapSil(int k)//Silme işlemi için bool kullandım parametre gönderdim çünkü kimlige göre silecegiz.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz silme işlemi için ilgili parantezin içine silme kodunu yazıyoruz.
            OleDbCommand komut3 = new OleDbCommand("Delete from Kitapkayit where Kimlik=@P1", Baglanti.baglantiac);
            if(komut3.Connection.State != ConnectionState.Open)//Dosyamızı kontrol ediyoruz açık değil ise 
            {
                komut3.Connection.Open();//Eğer kapalı ise access dosyamızı açıyoruz.
            }

            komut3.Parameters.AddWithValue("@P1", k);//Bu nesne ile propertyleri ulaşım sağladım ve atama işlemlerini yaptım.
            return komut3.ExecuteNonQuery() > 0;  //Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
                // yani true olacak yani birşeyi silecek.


        }


        public static bool KitapGuncelle(EntityKitapKayit ent)//Güncelleme işlemim için bool kullandım ve parametre göderdim.
        {
            //OleDbCommand sınıfını çağırıyoruz bir değişken türetiyoruz güncelleme işlemi için ilgili parantezin içine güncelleme kodunu yazıyoruz.
            OleDbCommand komut4 = new OleDbCommand("Update Kitapkayit SET Kitap_Seri_No=@P1,Kitap_Adi=@P2,Kitap_Yazari=@P3,Kitap_Basim_Yili=@P4,Kitap_Sayfa_Sayisi=@P5,Kitap_Dili=@P6,Kitap_Yayinevi=@P7 WHERE Kimlik=@P8", Baglanti.baglantiac);
            if(komut4.Connection.State != ConnectionState.Open)//Dosyamızı kontrol ediyoruz açık değil ise açıyoruz.
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Kitap_Seri_No1);//Parametrelerimize atama işlemlerini tek tek yaptım.
            komut4.Parameters.AddWithValue("@P2", ent.Kitap_Adi1);
            komut4.Parameters.AddWithValue("@P3", ent.Kitap_Yazari1);
            komut4.Parameters.AddWithValue("@P4", ent.Kitap_Basim_Yili1);
            komut4.Parameters.AddWithValue("@P5", ent.Kitap_Sayfa_Sayisi1);
            komut4.Parameters.AddWithValue("@P6", ent.Kitap_Dili1);
            komut4.Parameters.AddWithValue("@P7", ent.Kitap_Yayinevi1);
            komut4.Parameters.AddWithValue("@P8", ent.Kimlik
                );
            return komut4.ExecuteNonQuery() > 0;//Bool yaptığımız için yukarıdaki şartları sağlağan bir değer varsa 1 döndürecek.
            // yani true olacak yani birşeyi güncelleyecek.
        }

       public static DataSet bilgial(string aranan)
        {
            OleDbCommand komut = new OleDbCommand("Select * from Kitapkayit where Kitap_Adi like '%"+aranan+"%'", Baglanti.baglantiac); //Database bir nesne türettim ve tablomuzun belirttim
            if (komut.Connection.State != ConnectionState.Open) //Bağlantımız açık olup olmadığını kontrol ediyoruz
            {
                komut.Connection.Open();  //Açık değilse bağlantıyı açıyoruz.
            }
            OleDbDataAdapter da = new OleDbDataAdapter(komut);//Yeni dataadapter türettim
            DataSet ds = new DataSet();//Yeni dataset türettim
            da.Fill(ds);//ve ikisini fill yaparak verileri dataadapterdan datasete aktardık.
            return ds;//Sonra Dataseti döndürdük
        }
    }
}
