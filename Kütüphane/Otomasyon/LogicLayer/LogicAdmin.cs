using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; //Kullanacağım katmanları tanımladım
using DataAccessLayer;
using System.Data.OleDb;
namespace LogicLayer
{
    public class LogicAdmin
    {
        public static int LLAdminekle(EntityAdmin a)      //DALAdminden aldığım fonksiyona ekleme yapmam için ana programa çekmem lazım o yüzden logic katmanına çektim 
        {

            if (a.Kullanici_Adi1 != "" && a.Sifre1 != 0) //Kullanıcı adını ve sifreyi doldurmadan kayıt eklemesini kısıtlandrırdım.
            {
                return DALAdmin.AdminEkle(a); //Eğer boş değil ise eklmesini yapıyor.
            }
            else
            {
                return -1;//Boşsa -1 döndürerek ekleme yapmıyor.
            }
            
        }

        public static bool LLgiris(string a,string b) //DALAdminden aldığım fonksiyona giris yapmam için ana programa çekmem lazım o yüzden logic katmanına fonksiyonu çektim. 
        {
            return DALAdmin.giris(a, b);//DALAdminden giris fonksiyonuna ana programdan alacağım iki parametre ile fonksiyona gönderiyorum.
        }

        }
    }

