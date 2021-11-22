using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; //Access bağlantımız için tanımlama yaptım
namespace DataAccessLayer
{
    public class Baglanti
    {

        public static OleDbConnection baglantiac = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ..\..\..\Kutuphane.mdb");
        // Static türünde bağlantı adresimizi baglanti sinifinda tanımladık accessimizin konumunu yazarak. Erişmem gereken sadece adres olduğu için static tanımladık.
    }
}
