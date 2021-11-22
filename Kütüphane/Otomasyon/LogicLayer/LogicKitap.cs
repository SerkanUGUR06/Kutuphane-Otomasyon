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
    public class LogicKitap
    {

        public static List<EntityKitapKayit> LLKitaplistesi()  //Listeleme için metot oluşturdum.
        {
            return DALKitap.Kitaplistesi();//Fonksiyonun içine DALKitapdan çağırdığım kitap listesini döndürdüm.
        }

        public static int LLKitapekle(EntityKitapKayit k)//DALKitaptan aldığım fonksiyona ekleme yapmam için ana programa çekmem lazım o yüzden logic katmanına bir fonksiyon açtım
        {       //Kullanıcıdan bütün bilgileri doldurmadan kayıt eklemesini kısıtlandrırdım.
            if (k.Kitap_Adi1!=null && k.Kitap_Seri_No1!=0 && k.Kitap_Basim_Yili1!=0 && k.Kitap_Sayfa_Sayisi1!=0 && k.Kitap_Dili1!=null && k.Kitap_Yayinevi1!=null && k.Kitap_Yazari1!=null)
            {
                return DALKitap.KitapEkle(k);//Eğer boş değil ise eklmesini yapıyor.
            }
            else
            {
                return -1;//Boşsa -1 döndürerek ekleme yapmıyor.
            }
            
        }

        public static bool LLKitapsil(int kit)//DALKitaptan aldığım fonksiyona silme yapmam için ana programa çekmem lazım o yüzden logic katmanına yeni bir silme fonksiyonu açtım
        {
            return DALKitap.KitapSil(kit);//Silme işlemi için Dal katmanındaki kitapsili çağırıyoruz aldığımız parametre ile
        }

        public static bool LLKitapguncelle(EntityKitapKayit ent)
        {       //Kullanıcıdan bütün bilgileri doldurmadan güncelleme yapmasını kısıtlandrırdım.
            if (ent.Kitap_Adi1 != "" && ent.Kitap_Seri_No1 != 0 && ent.Kitap_Basim_Yili1 != 0 && ent.Kitap_Sayfa_Sayisi1 != 0 && ent.Kitap_Dili1 != null && ent.Kitap_Yayinevi1 != null && ent.Kitap_Yazari1 != null)
            {

                return DALKitap.KitapGuncelle(ent);//Eğer boş değil ise güncelleme işlemini yapması için Dal katmanından guncelle fonksiyonunu döndürüyor.
            }
            else
            {
                return false;//Boşsa false döndürerek ekleme yapmıyor.
            }

        }
        public static DataSet llbilgial(string aranan)//DALKitaptan aldığım fonksiyona arama yapmam için ana programa çekmem lazım o yüzden logic katmanına yeni bir arama fonksiyonu açtım
        {

            return DALKitap.bilgial(aranan);//Arama işlemi için Dal katmanındaki bilgialı çağırıyoruz aldığımız parametre ile

        }
    }
}
