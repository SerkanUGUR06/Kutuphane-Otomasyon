using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer; //Katmanlarımı tanımladım.
using DataAccessLayer;
using LogicLayer;
using System.Data.OleDb;
namespace Otomasyon
{
    public partial class tumuye : Form
    {
        public tumuye()
        {
            InitializeComponent();
        }

        private void tumuye_Load(object sender, EventArgs e)
        {
            List<EntityUyeKayit> uyelist = LogicUye.LLUyelistesi(); //Sayfa açılır açılmaz uye listem gelmesi için entity sınınfan nesnemi türetip logic katmanında işleme aldığım listele methodumu çağırdım
            tümüye.DataSource = uyelist; // ve datasourceda görünmesi gerçekleşti.
        }

        private void label11_Click(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa(); //anasayfa formundan nesne türettim
            anasayfagec.Show();//türettiğim nesne ile anasyafaya geçiş sağladım
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit(); //X basıldığında program sonlanması için yazdım.
        }

        private void listee_Click(object sender, EventArgs e)
        {
            List<EntityUyeKayit> uyelist = LogicUye.LLUyelistesi(); //Uye listem gelmesi için entity sınınfan nesnemi türetip logic katmanında işleme aldığım listele methodumu çağırdım
            tümüye.DataSource = uyelist; // ve datasourceda görünmesi gerçekleşti.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tümüye.DataSource = LogicUye.LLarama(tc.Text).Tables[0]; //Aramak için aldığım textboxtaki veriyi Logicteki fonksiyona gönderdim ve çıkan sonucu dataGridViewde gösterdim.
        }
    }
}
