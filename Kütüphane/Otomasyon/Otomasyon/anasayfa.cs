using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void kitapkayit_Click(object sender, EventArgs e)
        {
            kitapkayit kitapkayitagec = new kitapkayit();  // kitapkayit formundan yeni nesne türettim.
            kitapkayitagec.Show();// ve bu nesne ile kitapkayit sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void uyekayit_Click(object sender, EventArgs e)
        {
            uyekayit uyekayitagec = new uyekayit();// uyekayit formundan yeni nesne türettim.
            uyekayitagec.Show();// ve bu nesne ile uyekayit sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void kitapkiralama_Click(object sender, EventArgs e)
        {
            kitapkirala kitapkiralayagec = new kitapkirala();// kitapkirala formundan yeni nesne türettim.
            kitapkiralayagec.Show();// ve bu nesne ile kitapkirala sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Form1 girissayfasi = new Form1();// Form1 formundan yeni nesne türettim.
            girissayfasi.Show();// ve bu nesne ile Form1 sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void tumuye_Click(object sender, EventArgs e)
        {
            tumuye tumuyegec = new tumuye();// tumuye formundan yeni nesne türettim.
            tumuyegec.Show();// ve bu nesne ile tumuye sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void tumkitap_Click(object sender, EventArgs e)
        {
            tumkitap tumkitapgec = new tumkitap();// tumkitap formundan yeni nesne türettim.
            tumkitapgec.Show();// ve bu nesne ile tumkitap sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void tumkira_Click(object sender, EventArgs e)
        {
            tumkiralama tumkiralamagec = new tumkiralama();// tumkiralama formundan yeni nesne türettim.
            tumkiralamagec.Show();// ve bu nesne ile tumkiralama sayfasını göstermesini sağladım.
            this.Hide();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit(); // X ' ya basılınca program sonlanmasını sağladım
        }

  
    }
}
