using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class Form1 : Form
    {
        
        MainMenu mainmenu = new MainMenu();
        SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }
        public void  AdminGiris(string UserName, string UserPassword)
        {
            try
            {
                bagla.Open();
                SqlCommand com = new SqlCommand("Select *from AdminGirisi where UserName=@username AND UserPassword=@userpassword COLLATE  Turkish_100_CS_AS", bagla);
                com.Parameters.AddWithValue("@username", UserName);
                com.Parameters.AddWithValue("@userpassword", UserPassword);
                SqlDataReader AdminBilgisiOku = com.ExecuteReader();

                if (AdminBilgisiOku.Read())
                {

                    MessageBox.Show("Giriş Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainmenu.ShowDialog();
                    this.Hide();
                    Logs.LogTut("Admin Giriş");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız. Kullanıcı Adı veya Şifre Yanlış.Tekrar Deneyiniz.", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxKullanıcıAdı.Clear();
                    textBoxSifre.Clear();
                    
                }
                bagla.Close();
                

            }
            catch
            {


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
            timer1.Enabled = true;
            label3.Text = "~~~~Otel Bilgi Sistemine Hoşgeldiniz~~~~";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris(textBoxKullanıcıAdı.Text, textBoxSifre.Text);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);
        }
    }
}
