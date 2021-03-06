using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;



namespace OtelBilgiSistemi
{
    public partial class MusteriKaydi : Form
    {
        public MusteriKaydi()
        {
            InitializeComponent();
        }

        ArrayList OdaIsimleri = new ArrayList();
        SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");





        public void buttonOda1_Click(object sender, EventArgs e)

        {
            


            Button Oda = (Button)sender;
            if (Oda.BackColor == Color.Red)
            {
                textBoxOdaNo.Text = "";
                Oda.Enabled = false;
            }

            else
            {
                textBoxOdaNo.Text = "" + Oda.Text;
                
            }
            //if (textBoxOdaNo.Text == Oda.Text)
            //{
            //    Oda.BackColor = Color.Gold;
            //} seçili kaldırıldı







        }


        private void buttonUcret_Click(object sender, EventArgs e)
        {
            labelUcret.Visible = true;
            DateTime giris = Convert.ToDateTime(dateTimeGiris.Text);
            DateTime cikis = Convert.ToDateTime(dateTimeCikis.Text);
            TimeSpan total = cikis - giris;
            if (total.TotalDays < 0)
            {
                MessageBox.Show("Tarihleri hatalı girdiniz.");
            }
            else
            {
                labelGun.Text = total.TotalDays.ToString();
                int ucret = Convert.ToInt32(labelGun.Text);


                labelUcret.Text = ucret * 100 + "TL.";
            }
                


        }

        private void MusteriKaydi_Load(object sender, EventArgs e)
        {



            string IlkOdaNo;
            string DuzenlenmisOdaNo;


            for (int i = 1; i < this.Controls.Count + 7; i++)
            {


                
                IlkOdaNo = Convert.ToString(this.Controls.Find("buttonOda" + i.ToString(), true).FirstOrDefault() as Button);
                DuzenlenmisOdaNo = IlkOdaNo.Split(':').Last();
                DuzenlenmisOdaNo = DuzenlenmisOdaNo.Trim();
                OdaIsimleri.Add(DuzenlenmisOdaNo);
                //MessageBox.Show(DuzenlenmisOdaNo);
                //Text: OdaNo 1 2 3 ...
                //OdaNo 1 2 3 ....







            }


            OdaKontrol();

        }
        private void OdaKontrol()
        {
            OdaIslemleri odaislemleri = new OdaIslemleri();

            try
            {
                foreach (string odaismi in OdaIsimleri) // OdaIsimleri arraylist OdaNo 1 2 3 4 ..
                {
                    odaislemleri.OdaBilgileriniAlma(odaismi, "DOLU");
                    if (odaislemleri.OdaSonDurum == "DOLU")
                    {

                        this.Controls.Find(odaislemleri.OdaButon, true)[0].BackColor = Color.Red;
                        this.Controls.Find(odaislemleri.OdaButon, true)[0].Text = odaismi + " \n" + odaislemleri.OdadakiMusteriAdi + " " + odaislemleri.OdadakiMusteriSoyadi;
                        odaislemleri.OdaSonDurum = "";


                    }
                    if (odaislemleri.OdaSonDurum == "BOS")
                    {
                        this.Controls.Find(odaislemleri.OdaButon, true)[0].BackColor = Color.ForestGreen;

                    }

                }

            }
            catch
            {


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void MusteriKayıtEkle()
        {
            new VeriTabanıIslemleri().MusteriKaydet(textBoxAdı.Text, textBoxSoyadı.Text, comboBoxCinsiyet.Text, maskedTextBoxTel.Text, textBoxTc.Text, textBoxEmail.Text, textBoxOdaNo.Text, Convert.ToDateTime(dateTimeGiris.Text), Convert.ToDateTime(dateTimeCikis.Text));

        }

        private void OdaDoldur()
        {
            new OdaIslemleri().OdaDoldurma(textBoxOdaNo.Text, textBoxAdı.Text, textBoxSoyadı.Text);
        }

        private void buttonKayıtAl_Click(object sender, EventArgs e)
        {

                if ( textBoxTc.Text != "" && textBoxAdı.Text != "" && textBoxSoyadı.Text != "" && textBoxOdaNo.Text != "" && dateTimeCikis.ToString() != "" && dateTimeGiris.ToString() != "")
            {
                    if (textBoxTc.Text.Length == 11 && decimal.TryParse(textBoxTc.Text, out decimal TcNo))
                {

                    MusteriKayıtEkle();
                    OdaDoldur();
                    OdaKontrol();
                    Logs.LogTut("Kayıt Ekleme");
                }
                    else
                    MessageBox.Show("Lütfen TC No'yu Kontrol Ediniz.");


            }
  
                else
            {
                textBoxTc.BackColor = Color.DarkOrange;
                textBoxAdı.BackColor = Color.DarkOrange;
                textBoxSoyadı.BackColor = Color.DarkOrange;
                textBoxOdaNo.BackColor = Color.DarkOrange;
                dateTimeCikis.BackColor = Color.DarkOrange;
                dateTimeGiris.BackColor = Color.DarkOrange;
                MessageBox.Show("Turuncu alanlar boş bırakılamaz.", "BOŞ BIRAKILAMAZ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void textBoxAdı_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == "")
                errorProvider1.SetError(textbox, "Bu Alan Boş Bırakılamaz!");
            else
                errorProvider1.SetError(textbox, "");
        }

        private void buttonOda4_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
