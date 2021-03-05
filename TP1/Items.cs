using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1
{
    class Items
    {
        public Items()
        {

        }

        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }
        public int id { get; set; }
        public Items(string nama, string jenis, int harga, int id)
        {
            this.nama = nama;
            this.jenis = jenis;
            this.harga = harga;
            this.id = id;
        }

    }

}
