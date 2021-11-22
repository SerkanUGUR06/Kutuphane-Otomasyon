using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKitapKayit
    {

        private int kimlik;              //Kitaykayit tablomuzda olan sütunları değişken olarak tanımlıyoruz.
        private int Kitap_Seri_No;       // Ama direk sınıf üzerinden erişim sağlayıp diğer katmanlara üzerinden çağıramayız.
        private string Kitap_Adi;            //O yüzden aşağıda bu değişkenlerin propertyllerini yaptım.
        private string Kitap_Yazari;
        private int Kitap_Basim_Yili;
        private int Kitap_Sayfa_Sayisi;
        private string Kitap_Dili;
        private string Kitap_Yayinevi;

        public int Kimlik { get => kimlik; set => kimlik = value; }    //Burada yaptığım kapsülleme sayesinde diğer katmanlarda erişim sağlayabilirim.
        public int Kitap_Seri_No1 { get => Kitap_Seri_No; set => Kitap_Seri_No = value; } //Eğer kapsülleme yapmazsak üst tarafta yazdığım sorun olacak yani erişim sağlayamayacağız.
        public string Kitap_Adi1 { get => Kitap_Adi; set => Kitap_Adi = value; }
        public string Kitap_Yazari1 { get => Kitap_Yazari; set => Kitap_Yazari = value; }
        public int Kitap_Basim_Yili1 { get => Kitap_Basim_Yili; set => Kitap_Basim_Yili = value; }
        public int Kitap_Sayfa_Sayisi1 { get => Kitap_Sayfa_Sayisi; set => Kitap_Sayfa_Sayisi = value; }
        public string Kitap_Dili1 { get => Kitap_Dili; set => Kitap_Dili = value; }
        public string Kitap_Yayinevi1 { get => Kitap_Yayinevi; set => Kitap_Yayinevi = value; }
        
    }
}
