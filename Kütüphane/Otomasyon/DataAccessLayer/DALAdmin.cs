using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; // Kullanacağım katmanları tanımladım.
using System.Data.OleDb;
using System.Data;
namespace DataAccessLayer
{
   public class DALAdmin
    {
        public static int AdminEkle(EntityAdmin a)    //Dışarıdan erişileceği için public olarak bir sınıf oluşturdum admin ekle adında
        {                                               // a değişkenimizde bizim entityadmine ulaşmamızı sağlıyor.

            OleDbCommand komut = new OleDbCommand("insert into Admin(Kullanici_Adi,Sifre) VALUES (@P1,@P2)", Baglanti.baglantiac); // Database yani Access dosyamdaki tablomu ve veri eklerken isteyeceğimiz sutunlar için ekleme kodunu yazdım.
            if (komut.Connection.State != ConnectionState.Open) // Bağlantımız açık mı değil mi sorguluyoruz
            {
                komut.Connection.Open();   // Eğer bağlantımız kapalı ise bağlantımızı açıyoruz.
            }

            komut.Parameters.AddWithValue("@P1", a.Kullanici_Adi1); //Parametrelere değer ataması yapıyorum
            komut.Parameters.AddWithValue("@P2", a.Sifre1);
            
            return komut.ExecuteNonQuery(); //Kayıt sayısını döndürmek için executenonquery kullandık.

        }

        public static bool giris(string a,string b)
        {
            //OleDbCommand sınıfını çağırıp nesne türettim ve kodun içinde tablomu belirttim.
            OleDbCommand admingiris = new OleDbCommand("select *from Admin", Baglanti.baglantiac); 
            if (admingiris.Connection.State != ConnectionState.Open) // Bağlantımız açık mı değil mi sorguluyoruz
            {
                admingiris.Connection.Open();   // Eğer bağlantımız kapalı ise bağlantımızı açıyoruz.
            }
            OleDbDataReader dr = admingiris.ExecuteReader();
            //Okunan değerler gerekli şartı sağlıyorsa ilgili satırdaki kodları işletebiliriz demektir.
            while(dr.Read())
            {
                if(dr["Kullanici_Adi"].ToString()==a && dr["Sifre"].ToString()==b)//Eğer girilen kullanıcı adı ve şifresi veritabanından eşlenirse true değerini döderiyoruz.
                {
                    return true;
                }
            }
            
            return false;
           //Whiledan çıkınca false değerini döndürmesini sağlayıp çıkmasını sağladım.
            

        }

    }
}
