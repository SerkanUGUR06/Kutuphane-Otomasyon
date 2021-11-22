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
    public partial class tumkiralama : Form
    {
        public tumkiralama()
        {
            InitializeComponent();
        }

        private void tumkiralama_Load(object sender, EventArgs e)
        {
            List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();//Sayfa açılır açılmaz kiralama listem gelmesi için entity sınınfan nesnemi türetip logic katmanında işleme aldığım listele methodumu çağırdım
            tümkira.DataSource = KiraList; // ve datasourceda görünmesi gerçekleşti.
        }

        private void label10_Click(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa();//anasayfa formundan nesne türettim
            anasayfagec.Show();//türettiğim nesne ile anasyafaya geçiş sağladım
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();//X basıldığında program sonlanması için yazdım.
        }

        private void arabuton_Click(object sender, EventArgs e)
        {
            tümkira.DataSource = LogicKiralama.LLara(kiraara.Text).Tables[0]; //Aramak için aldığım textboxtaki veriyi Logicteki fonksiyona gönderdim ve çıkan sonucu dataGridViewde gösterdim.
        }

        private void listele_Click(object sender, EventArgs e)
        {
            List<EntityKiralama> KiraList = LogicKiralama.LLKiralamalistesi();  //Kiralama listem gelmesi için entity sınınfan nesnemi türetip logic katmanında işleme aldığım listele methodumu çağırdım
            tümkira.DataSource = KiraList;

        }
    }
}
