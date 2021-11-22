using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data.OleDb;
using System.Data;
namespace LogicLayer
{
    public class LogicKiralama
    {
        public static List<EntityKiralama> LLKiralamalistesi() //Listeleme için metot oluşturdum.
        {
            return DALKiralama.Kiralistesi();//Fonksiyonun içine DALKitapdan çağırdığım kitap listesini döndürdüm.
        }

        public static int LLKiraekle(EntityKiralama k)//DALKiralamadan aldığım fonksiyona ekleme yapmam için ana programa çekmem lazım o yüzden logic katmanına bir fonksiyon açtım
        {        //Kullanıcıdan bütün bilgileri doldurmadan kayıt eklemesini kısıtlandrırdım.
            if (k.Kiralanan_Kitap1 != null && k.Kiralayan_Uye1 != null && k.Teslim_Tarihi1 !=null && k.Alim_Tarihi1!=null)
            {
                return DALKiralama.KiralamaEkle(k);//Eğer boş değil ise eklmesini yapıyor.
            }
            else
            {
                return -1;//Boşsa -1 döndürerek ekleme yapmıyor.
            }
        }

        public static bool LLKirasil(int uy)//DALKiralamadan aldığım fonksiyona silme yapmam için ana programa çekmem lazım o yüzden logic katmanına yeni bir silme fonksiyonu açtım
        {
            return DALKiralama.KiralamaSil(uy);//Silme işlemi için Dal katmanındaki kitapsili çağırıyoruz aldığımız parametre ile
        }

        public static bool LLKiraguncelle(EntityKiralama ent)
        {        //Kullanıcıdan bütün bilgileri doldurmadan güncelleme yapmasını kısıtlandrırdım.
            if (ent.Alim_Tarihi1 != null && ent.Teslim_Tarihi1 != null && ent.Kiralanan_Kitap1 != null && ent.Kiralayan_Uye1 != null)
            {
                return DALKiralama.KiralamaGuncelle(ent);//Eğer boş değil ise güncelleme işlemini yapması için Dal katmanından guncelle fonksiyonunu döndürüyor.
            }
            else
            {
                return false;//Boşsa false döndürerek ekleme yapmıyor.
            }
        }

        public static DataSet LLara(string aranan)//DALKiralamadan aldığım fonksiyona arama yapmam için ana programa çekmem lazım o yüzden logic katmanına yeni bir arama fonksiyonu açtım
        {

            return DALKiralama.arama(aranan);//Arama işlemi için Dal katmanındaki bilgialı çağırıyoruz aldığımız parametre ile

        }

        public static List<string> LLuyedoldur() //Ana programda comboboxu doldurmak için oluşturdum.
        {
            return DALKiralama.uyedoldur();
        }

        public static List<string> LLkkitapdoldur() //Ana programda comboboxu doldurmak için oluşturdum.
        {
            return DALKiralama.kitapdoldur();
        }

    }
}
