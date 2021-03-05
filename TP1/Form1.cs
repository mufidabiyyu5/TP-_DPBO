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
    public partial class Form1 : Form
    {
        Account akun;
        public Form1()
        {
            InitializeComponent();
            this.akun = new Account();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.akun.username = Convert.ToString(tbUsername.Text);
            this.akun.password = Convert.ToString(tbPassword.Text);

            if(this.akun.password != "pbo123")
            {
                string message = "Password salah";
                MessageBox.Show(message);
            }
            else if(this.akun.username == null)
            {
                string message = "Anda Belum Memasukan Username";
                MessageBox.Show(message);
            }
            else
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
