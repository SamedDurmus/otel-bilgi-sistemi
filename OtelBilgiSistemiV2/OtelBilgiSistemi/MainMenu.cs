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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        Radyo radyo = new Radyo();
        HavaDurumu hd = new HavaDurumu();
        MusteriKaydi mkaydi = new MusteriKaydi();
        KayıtlıMusteriListesi mliste = new KayıtlıMusteriListesi();
        OdaMusteriBilgileri odamusteribilgileri = new OdaMusteriBilgileri();
        LogGoruntuleme loggoruntuleme = new LogGoruntuleme();


        private void button1_Click(object sender, EventArgs e)
        {
            
            mkaydi.ShowDialog();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mliste.ShowDialog();
            this.Hide();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            odamusteribilgileri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loggoruntuleme.ShowDialog();
            this.Hide();
  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hd.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            radyo.ShowDialog();
            this.Hide();
        }
    }
}
