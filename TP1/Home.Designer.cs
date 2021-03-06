
namespace TP1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.jenisBarang = new System.Windows.Forms.ComboBox();
            this.Harga = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelItems = new System.Windows.Forms.Panel();
            this.btnBeli = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(450, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 26);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(313, 22);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(105, 26);
            this.btnWeb.TabIndex = 1;
            this.btnWeb.Text = "Web Katalog";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(180, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(98, 26);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // jenisBarang
            // 
            this.jenisBarang.FormattingEnabled = true;
            this.jenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian",
            "Makanan",
            "All"});
            this.jenisBarang.Location = new System.Drawing.Point(11, 73);
            this.jenisBarang.Name = "jenisBarang";
            this.jenisBarang.Size = new System.Drawing.Size(121, 21);
            this.jenisBarang.TabIndex = 3;
            this.jenisBarang.Text = "Jenis Barang";
            this.jenisBarang.SelectedIndexChanged += new System.EventHandler(this.jenisBarang_SelectedIndexChanged);
            // 
            // Harga
            // 
            this.Harga.FormattingEnabled = true;
            this.Harga.Items.AddRange(new object[] {
            "100000 - 200000",
            "200000 - 500000",
            "500000 - 1000000",
            "All"});
            this.Harga.Location = new System.Drawing.Point(11, 110);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(121, 21);
            this.Harga.TabIndex = 4;
            this.Harga.Text = "Harga";
            this.Harga.SelectedIndexChanged += new System.EventHandler(this.Harga_SelectedIndexChanged);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(11, 154);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 5;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "1907996";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mochamad Mufid Abiyyu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnKembali);
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.Harga);
            this.panel1.Controls.Add(this.jenisBarang);
            this.panel1.Location = new System.Drawing.Point(1, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 380);
            this.panel1.TabIndex = 28;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(11, 29);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(121, 27);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnWeb);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 73);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panelItems);
            this.panel3.Location = new System.Drawing.Point(164, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 356);
            this.panel3.TabIndex = 30;
            // 
            // panelItems
            // 
            this.panelItems.Controls.Add(this.btnBeli);
            this.panelItems.Controls.Add(this.lblPrice);
            this.panelItems.Controls.Add(this.lblName);
            this.panelItems.Controls.Add(this.imgItem);
            this.panelItems.Location = new System.Drawing.Point(3, 3);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(122, 191);
            this.panelItems.TabIndex = 0;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(14, 155);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(90, 23);
            this.btnBeli.TabIndex = 3;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Rp. 700.000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "PS4";
            // 
            // imgItem
            // 
            this.imgItem.Image = global::TP1.Properties.Resources._75_758657_ps4_transparent_png_playstation_4_pro_slim_png;
            this.imgItem.Location = new System.Drawing.Point(14, 15);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(94, 82);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgItem.TabIndex = 0;
            this.imgItem.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox jenisBarang;
        private System.Windows.Forms.ComboBox Harga;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panel3;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}