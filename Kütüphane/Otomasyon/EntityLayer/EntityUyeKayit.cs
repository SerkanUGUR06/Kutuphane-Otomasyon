using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public 
        class EntityUyeKayit
    {


        private int kimlik;          //Uyekayit tablomuzda olan sütunları değişken olarak tanımlıyoruz.
        private string Uye_TC_No;           // Ama direk sınıf üzerinden erişim sağlayıp diğer katmanlara üzerinden çağıramayız.
        private string Adi_ve_Soyadi;       //O yüzden aşağıda bu değişkenlerin propertyllerini yaptım.
        private DateTime Dogum_Tarihi;
        private string E_Posta_Adresi;
        private string Telefon_No;
        private string Yasadigi_Ulke;
        private string Yasadigi_Sehir;
        private string Adres;

        public int Kimlik { get => kimlik; set => kimlik = value; }     //Burada yaptığım kapsülleme sayesinde diğer katmanlarda erişim sağlayabilirim.
        public string Uye_TC_No1 { get => Uye_TC_No; set => Uye_TC_No = value; }      //Eğer kapsülleme yapmazsak üst tarafta yazdığım sorun olacak yani erişim sağlayamayacağız.
        public string Adi_ve_Soyadi1 { get => Adi_ve_Soyadi; set => Adi_ve_Soyadi = value; }
        public DateTime Dogum_Tarihi1 { get => Dogum_Tarihi; set => Dogum_Tarihi = value; }
        public string E_Posta_Adresi1 { get => E_Posta_Adresi; set => E_Posta_Adresi = value; }
        public string Telefon_No1 { get => Telefon_No; set => Telefon_No = value; }
        public string Yasadigi_Ulke1 { get => Yasadigi_Ulke; set => Yasadigi_Ulke = value; }
        public string Yasadigi_Sehir1 { get => Yasadigi_Sehir; set => Yasadigi_Sehir = value; }
        public string Adres1 { get => Adres; set => Adres = value; }


    }
}
