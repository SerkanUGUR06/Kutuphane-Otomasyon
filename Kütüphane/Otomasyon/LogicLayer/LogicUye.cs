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
    public class LogicUye
    {

        public static List<EntityUyeKayit> LLUyelistesi()//Listeleme için metot oluşturdum.
        {
            return DALUye.Uyelistesi(); //Fonksiyonun içine DalUyeden çağırdığım uye listesini döndürdüm.
        }

        public static int LLUyeekle(EntityUyeKayit k)//DALUyeden aldığım fonksiyona ekleme yapmam için ana programa çekmem lazım o yüzden logic katmanına bir fonksiyon açtım
        {
            //Kullanıcıdan bütün bilgileri doldurmadan kayıt eklemesini kısıtlandrırdım.
            if (k.Adi_ve_Soyadi1 != null && k.Uye_TC_No1 != null && k.Dogum_Tarihi1 != null && k.Adres1 != null && k.E_Posta_Adresi1 != null && k.Telefon_No1 != null && k.Yasadigi_Sehir1 != null && k.Yasadigi_Ulke1 != null)
            {   
                return DALUye.UyeEkle(k);//Eğer boş değil ise eklmesini yapıyor.
            }
            else
            {
                return -1;//Boşsa -1 döndürerek ekleme yapmıyor.
            }
        }

        public static bool LLUyesil(int uy) //DalUyeden aldığım fonksiyona silme yapmam için ana programa çekmem lazım o yüzden logic katmanına yeni bir silme fonksiyonu açtım
        {
            return DALUye.UyeSil(uy); //Silme işlemi için Dal katmanındaki kitapsili çağırıyoruz aldığımız parametre ile
        }

        public static bool LLUyeguncelle(EntityUyeKayit ent)
        {        //Kullanıcıdan bütün bilgileri doldurmadan güncelleme yapmasını kısıtlandrırdım.
            if (ent.Adi_ve_Soyadi1 != null && ent.Uye_TC_No1 != null && ent.Dogum_Tarihi1 != null && ent.Adres1 != null && ent.E_Posta_Adresi1 != null && ent.Telefon_No1 != null && ent.Yasadigi_Sehir1 != null && ent.Yasadigi_Ulke1 != null)
            {
                return DALUye.UyeGuncelle(ent);//Eğer boş değil ise güncelleme işlemini yapması için Dal katmanından guncelle fonksiyonunu döndürüyor.
            }
            else
            {
                return false;//Boşsa false döndürerek ekleme yapmıyor.
            }
            
        }
        public static DataSet LLarama(string aranan)//Dataset tipinde fonksiyonu oluşturdum parametreli şekilde
        {

            return DALUye.bilgial(aranan);//ve Daluyden bilgial fonksiyonuna aldığımız parametreli bir biçimde döndürdüm.

        }
    }
}
