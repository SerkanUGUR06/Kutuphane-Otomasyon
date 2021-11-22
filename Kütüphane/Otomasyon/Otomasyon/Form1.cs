using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Köşedeki çarpıya basınca programdan çıkışını sağladım.
        }

        private void giris_Click(object sender, EventArgs e)
        {

            if(LogicAdmin.LLgiris(textBox1.Text,textBox2.Text)) // Logic katmanındaki fonksiyona aldığım taxtbox verileri ile gönderiyorum. Eğer true dönerse anasayfaya yönlendirme yapacak.
            {
                anasayfa anasayfayagec = new anasayfa();//Anasayfaya ait yeni nesne türettim
                anasayfayagec.Show();//O nesne ile anasayfayı göstermesini sağladım.
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş Yaptınız !", "Bilgi Kutucuğu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Eğer değer false dönerse yani veritabanı ile uyuşmazsa uyarı verecek.
            }


        }

        private void kayitol_Click(object sender, EventArgs e)
        {
            kayitol kayitola = new kayitol();//Kayıt ol formundan nesne türettim.
            kayitola.Show();//ve o nesne ile o sayfayı gösterttim.
            this.Hide();
        }

      
    }
}
