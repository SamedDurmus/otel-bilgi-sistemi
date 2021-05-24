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

namespace OtelBilgiSistemi
{
    public partial class KayıtlıMusteriListesi : Form
    {
        public KayıtlıMusteriListesi()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");


        private void MusteriBul()
        {
            dataGridView1.DataSource = new VeriTabanıIslemleri().MusteriBulma(textBoxArama.Text);
       
        }
        private void MusteriSil()
        {
            new VeriTabanıIslemleri().MusteriSilme(textBoxID.Text);
        }

        private void MusteriListesiDoldur()
        {
      
            dataGridView1.DataSource = new VeriTabanıIslemleri().MusteriListele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriListesiDoldur();
            Logs.LogTut("Kayıt Listeleme");
        }
        private void OdaDoldur()
        {
            new OdaIslemleri().OdaDoldurma(textBoxOdaNo.Text, textBoxAdı.Text, textBoxSoyadı.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxTc.Text.Length == 11 && decimal.TryParse(textBoxTc.Text, out decimal tcno) && textBoxTc.Text != "" && textBoxAdı.Text != "" && textBoxSoyadı.Text != "" && textBoxOdaNo.Text != "" && dateTimeCikis.ToString() != "" && dateTimeGiris.ToString() != "")
            {
                new VeriTabanıIslemleri().MusteriGuncelle(textBoxID.Text, textBoxAdı.Text, textBoxSoyadı.Text, comboBoxCinsiyet.Text, maskedTextBoxTel.Text, textBoxTc.Text, textBoxEmail.Text, textBoxOdaNo.Text, Convert.ToDateTime(dateTimeGiris.Text), Convert.ToDateTime(dateTimeCikis.Text));
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
                MessageBox.Show("tcnoyu düzgün gir", "HATA");
            }
            OdaDoldur();
            MusteriListesiDoldur();
            Logs.LogTut("Kayıt Güncelleme");
        }

        

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyadı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxCinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBoxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimeGiris.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimeCikis.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }
        private void OdaBosalt()
        {
            new OdaIslemleri().OdaBosaltma(textBoxOdaNo.Text, textBoxAdı.Text, textBoxSoyadı.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriSil();
            OdaBosalt();

            MusteriListesiDoldur();
            Logs.LogTut("Kayıt Silme");


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MusteriBul();
            Logs.LogTut("Kayıt Arama");

        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            textBoxArama.Clear();
        }

        private void KayıtlıMusteriListesi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();

        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Trim() == "")
                errorProvider1.SetError(textbox, "Bu Alan Boş Bırakılamaz!");
            else
                errorProvider1.SetError(textbox, "");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

