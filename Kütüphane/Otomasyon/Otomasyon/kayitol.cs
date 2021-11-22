using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;      // Katmanlarımı tanımladım kullanabilmek için
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            EntityAdmin admin = new EntityAdmin();   //EntityAdmin sınıfına ait bir nesne türettim.
            admin.Kullanici_Adi1 = kullanici.Text;     //türettiğim nesne ile eriştiğim entity katmanındaki değişkenlere bu sayfadaki textboxların içindeki verileri atadım.
            admin.Sifre1 = int.Parse(sifre.Text);      
            LogicAdmin.LLAdminekle(admin);       // Logic katmanı üzerinden DALAdmindeki admin ekle fonksiyonuna ekleme işlemini yaptırdım.  
            Form1 forma = new Form1();          //Forma1den bir nesne türeterek form1 sayfasına yönlendirmesini yaptım.
            forma.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // X tuşuna basılınca programın sonlanması için yaptım.
        }

        private void sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Harf girmesini engelledim
            {
                e.Handled = true;
            }
        }
    }
}
