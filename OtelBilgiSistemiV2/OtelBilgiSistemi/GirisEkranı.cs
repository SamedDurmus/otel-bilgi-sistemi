using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKullanıcıAdı.Text == "ad" && textBoxSifre.Text == "ad")
            {
                MainMenu mainmenu = new MainMenu();
                mainmenu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifreyi Yanlış Girdiniz!");
                textBoxSifre.Clear();
                textBoxKullanıcıAdı.Clear();
        }       
    }
}
