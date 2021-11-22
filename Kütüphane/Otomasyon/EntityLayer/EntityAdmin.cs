using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAdmin
    {

        private int kimlik;   //Admin tablomuzda olan sütunları değişken olarak tanımlıyoruz.
        private string Kullanici_Adi;  // Ama direk sınıf üzerinden erişim sağlayıp diğer katmanlara üzerinden çağıramayız.
        private int Sifre;             //O yüzden aşağıda bu değişkenlerin propertyllerini yaptım.

        public int Kimlik { get => kimlik; set => kimlik = value; } //Burada yaptığım kapsülleme sayesinde diğer katmanlarda erişim sağlayabilirim.
        public string Kullanici_Adi1 { get => Kullanici_Adi; set => Kullanici_Adi = value; }    //Eğer kapsülleme yapmazsak üst tarafta yazdığım sorun olacak yani erişim sağlayamayacağız.
        public int Sifre1 { get => Sifre; set => Sifre = value; }
    }
}
