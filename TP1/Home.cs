using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Home : Form
    {
        List<Items> dataItem = new List<Items>();//list barang
        //deklarasi untuk harga dan jenis barang
        private int hargaMin = -1;
        private int hargaMax = -1;
        private string jenis = null;
        public Home()
        {
            InitializeComponent();
            //langsung panggil
            setBarang();
            viewBarang();
            btnKembali.Hide();//button kembali di sembunyikan dulu
        }

        void setBarang()
        {
            //set barangnya
            this.dataItem.Add(new Items("PS4", "Elektronik", 700000, 0));
            this.dataItem.Add(new Items("Seblak Sultan", "Makanan", 500000, 1));
            this.dataItem.Add(new Items("Baju Raja", "Pakaian", 800000, 2));
            this.dataItem.Add(new Items("Coklat Emas", "Makanan", 600000, 3));
            this.dataItem.Add(new Items("Kaos Kaki Supreme", "Pakaian", 900000, 4));
        }

        void viewBarang()
        {
            //panel di clear
            panel3.Controls.Clear();
            //tampilkan barang2 dengan looping
            foreach(var data in this.dataItem)
            {
                //cek-cek kalo masuk syarat tampilkan
                if(data.jenis == this.jenis)
                {
                    if(this.hargaMin <= data.harga && this.hargaMax >= data.harga)
                    {
                        panel3.Controls.Add(createBox(data.nama, data.harga, data.id));
                        
                    }
                    else if(this.hargaMin == -1)
                    {
                        panel3.Controls.Add(createBox(data.nama, data.harga, data.id));

                    }
                }else if(this.jenis == null)
                {
                    if (this.hargaMin <= data.harga && this.hargaMax >= data.harga)
                    {
                        panel3.Controls.Add(createBox(data.nama, data.harga, data.id));

                    }
                    else if (this.hargaMin == -1)
                    {
                        panel3.Controls.Add(createBox(data.nama, data.harga, data.id));

                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //button logout
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            //button web katalog
            System.Diagnostics.Process.Start("Chrome", "http://tokopedia.com/");
        }

        private void jenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.jenis = jenisBarang.SelectedItem.ToString();//jenisBarang adalah nama combobox nya
            //cek kalo di combobox dipilih all
            if (this.jenis == "All")
            {
                //jenis di null kan
                this.jenis = null;
            }
        }

        private void Harga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price = Harga.SelectedItem.ToString();//Harga adalah nama combobox nya
            //cek kisaran harga yang dipilih
            if (price == "100000 - 200000")
            {
                this.hargaMin = 100000;
                this.hargaMax = 200000;
            }
            else if (price == "200000 - 500000")
            {
                this.hargaMin = 200000;
                this.hargaMax = 500000;
            }
            else if (price == "500000 - 1000000")
            {
                this.hargaMin = 500000;
                this.hargaMax = 1000000;
            }
            else if (price == "All")
            {
                //kembali ke default
                this.hargaMin = -1;
                this.hargaMax = -1;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            //button cari ketika diklik
            viewBarang();
        }

        public void btnBeli_Click(object sender, EventArgs e)
        {
            //button beli ketika diklik
            string idBtn = (sender as Button).Name;//idBtn = nama dari button beli
            foreach(var data in this.dataItem)//masuk looping
            {
                //cek kalo sama
                if(data.id.ToString() == idBtn)
                {
                    //masukan nilai jenis dan harga produk ke jenis dan hargamax & min
                    jenis = data.jenis;
                    hargaMax = data.harga;
                    hargaMin = data.harga;
                }
            }
            //hide and show
            jenisBarang.Hide();
            Harga.Hide();
            btnCari.Hide();
            btnKembali.Show();
            //panggil untuk menampilkan barang yang diklik
            viewBarang();
        }

        
        Panel createBox(string nama, int harga, int id)
        {
            //membuat box-box / panel untuk barang2
            Panel panelItems = new Panel();

            PictureBox img = createImg();
            panelItems.Controls.Add(img);

            Label lbName = createName(nama);
            panelItems.Controls.Add(lbName);

            Label lbPrice = createPrice(harga);
            panelItems.Controls.Add(lbPrice);

            Button btbeli = createBeli(id);
            panelItems.Controls.Add(btbeli);

            panelItems.Location = new System.Drawing.Point(23, 20);
            panelItems.Name = "panelItems";
            panelItems.Size = new System.Drawing.Size(122, 191);
            panelItems.TabIndex = 0;

            return panelItems;
        }

        PictureBox createImg()
        {
            //membuat picture box
            PictureBox imgItem = new PictureBox();

            imgItem.Image = global::TP1.Properties.Resources._75_758657_ps4_transparent_png_playstation_4_pro_slim_png;
            imgItem.Location = new System.Drawing.Point(14, 15);
            imgItem.Name = "imgItem";
            imgItem.Size = new System.Drawing.Size(94, 82);
            imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imgItem.TabIndex = 0;
            imgItem.TabStop = false;

            return imgItem;
        }

        Label createName(string name)
        {
            //membuat label nama
            Label lblName = new Label();

            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(11, 110);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(27, 13);
            lblName.TabIndex = 1;
            lblName.Text = name;

            return lblName;
        }

        Label createPrice(int harga)
        {
            //membuat label harga
            Label lblPrice = new Label();

            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(11, 132);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(66, 13);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Rp." + harga.ToString();

            return lblPrice;
        }

        Button createBeli(int id)
        {
            //membuat button beli
            Button btnBeli = new Button();

            btnBeli.Location = new System.Drawing.Point(14, 155);
            btnBeli.Name = id.ToString();
            btnBeli.Size = new System.Drawing.Size(90, 23);
            btnBeli.TabIndex = 3;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += new System.EventHandler(btnBeli_Click);

            return btnBeli;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            //button kembali ketika diklik
            //hide and show
            jenisBarang.Show();
            Harga.Show();
            btnCari.Show();
            btnKembali.Hide();
            //balikin lagi value jenis dan hargamax & min seperti semula
            jenis = null;
            hargaMax = -1;
            hargaMin = -1;
            //panggil untuk menampilkan
            viewBarang();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //sama kaya button kembali
            jenisBarang.Show();
            Harga.Show();
            btnCari.Show();
            btnKembali.Hide();

            jenis = null;
            hargaMax = -1;
            hargaMin = -1;

            viewBarang();
        }
    }
}
