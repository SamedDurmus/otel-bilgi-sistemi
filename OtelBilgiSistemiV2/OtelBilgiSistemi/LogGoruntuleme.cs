using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class LogGoruntuleme : Form
    {
        public LogGoruntuleme()
        {
            InitializeComponent();
        }
        public void LogOku()
        {
            string dosyakonumu = @"C:\Users\Samet\source\repos\OtelBilgiSistemiV2\logs.txt";
            StreamReader logoku = new StreamReader(dosyakonumu, Encoding.UTF8);
            while(!logoku.EndOfStream)
 {
                listBox1.Items.Add(logoku.ReadLine());
            }
            
            logoku.Close();
            
        }

        private void LogGoruntuleme_Load(object sender, EventArgs e)
        {
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LogOku();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
