using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityKiralama
    {



        private int kimlik;          //Kiralama tablomuzda olan sütunları değişken olarak tanımlıyoruz.
        private string Kiralanan_Kitap;         // Ama direk sınıf üzerinden erişim sağlayıp diğer katmanlara üzerinden çağıramayız.
        private string Kiralayan_Uye;           //O yüzden aşağıda bu değişkenlerin propertyllerini yaptım.
        private DateTime Alim_Tarihi;
        private DateTime Teslim_Tarihi;

        public int Kimlik { get => kimlik; set => kimlik = value; }  //Burada yaptığım kapsülleme sayesinde diğer katmanlarda erişim sağlayabilirim.
        public string Kiralanan_Kitap1 { get => Kiralanan_Kitap; set => Kiralanan_Kitap = value; }      //Eğer kapsülleme yapmazsak üst tarafta yazdığım sorun olacak yani erişim sağlayamayacağız.
        public string Kiralayan_Uye1 { get => Kiralayan_Uye; set => Kiralayan_Uye = value; }
        public DateTime Alim_Tarihi1 { get => Alim_Tarihi; set => Alim_Tarihi = value; }
        public DateTime Teslim_Tarihi1 { get => Teslim_Tarihi; set => Teslim_Tarihi = value; }
    }
}
