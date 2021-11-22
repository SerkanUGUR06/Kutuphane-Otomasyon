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
    public partial class tumkitap : Form
    {
        public tumkitap()
        {
            InitializeComponent();
        }

        private void tumkitap_Load(object sender, EventArgs e)
        {
            List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi();//Entity kitakayittan nesne türettim ve kitap listesini çağırdım.
            tümkitap.DataSource = KitapList;//Datasourceda görünmesini sağladım.
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();//Programın kapanmasını sağladım.
        }

        private void label11_Click(object sender, EventArgs e)
        {
            anasayfa anasayfagec = new anasayfa(); //anasayfa formundan nesne türettim.
            anasayfagec.Show();//anasayfaya geçişini sağladım.
            this.Hide();
        }

        private void araaa_Click(object sender, EventArgs e)
        {
            tümkitap.DataSource = LogicKitap.llbilgial(kitap.Text).Tables[0];//arama butonuna basılınca Logickitapdan llbilgialı çağırıp textboxun içinde kitap adına göre arama yapar.
        }

        private void liste_Click(object sender, EventArgs e)
        {
            List<EntityKitapKayit> KitapList = LogicKitap.LLKitaplistesi(); // Acceess'deki verileri sayfa açılır açılmaz datasource a çeker ve gösterir.
            tümkitap.DataSource = KitapList;
        }
    }
}
