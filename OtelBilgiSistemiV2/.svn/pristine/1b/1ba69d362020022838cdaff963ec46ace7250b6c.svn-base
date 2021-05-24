using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    class VeriTabanıIslemleri
    {
        string MusteriAdSoyad { get; set; }
        SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");
        internal void MusteriGuncelle(string MusteriID, string Adi, string Soyadi, string Cinsiyet, string Telefon, string TcNo, string Email, string OdaNo, DateTime GirisTarihi, DateTime CikisTarihi)
        {
            try
            {
                bagla.Open();
                SqlCommand com = new SqlCommand("Update MusteriBilgileri set Adi=@ad, Soyadi=@soyad, Cinsiyet=@cinsiyet, Telefon=@tel, TcNo=@tc, Email=@email, OdaNo=@odano, GirisTarihi=@gtarih, CikisTarihi=@ctarih where MusteriID=@mID", bagla);
                com.Parameters.AddWithValue("@mID", MusteriID);
                com.Parameters.AddWithValue("@ad", Adi);
                com.Parameters.AddWithValue("@soyad", Soyadi);
                com.Parameters.AddWithValue("@cinsiyet", Cinsiyet);
                com.Parameters.AddWithValue("@tel", Telefon);
                com.Parameters.AddWithValue("@tc", TcNo);
                com.Parameters.AddWithValue("@email", Email);
                com.Parameters.AddWithValue("@odano", OdaNo);
                com.Parameters.AddWithValue("@gtarih", GirisTarihi);
                com.Parameters.AddWithValue("@ctarih", CikisTarihi);
                com.ExecuteNonQuery();
                bagla.Close();

            }
            catch (Exception hata)
            {

                string warning = hata.Message;
            }



        }


        internal object MusteriBulma(string aranan)
        {
            bagla.Open();
            SqlCommand com = new SqlCommand("Select *from MusteriBilgileri where Adi like '%" + aranan + "%'", bagla);
            SqlDataAdapter dataadapter = new SqlDataAdapter(com);
            DataSet dataset = new DataSet();
            dataadapter.Fill(dataset, "MusteriBilgileri");
            //dataGridView1.DataSource = dataset.Tables[0];
            bagla.Close();
            return dataset.Tables["MusteriBilgileri"];

        }


        internal void MusteriSilme(string MusteriID)
        {
            bagla.Open();
            SqlCommand com = new SqlCommand("Delete from MusteriBilgileri where MusteriID=@mID", bagla);
            com.Parameters.AddWithValue("@mID", MusteriID);
            com.ExecuteNonQuery();
            bagla.Close();

        }

        internal object MusteriListele()
        {
            SqlDataAdapter dataAdapt = new SqlDataAdapter("Select *from MusteriBilgileri", bagla);
            DataSet dataset = new DataSet();
            bagla.Open();
            dataAdapt.Fill(dataset, "MusteriBilgileri");
            bagla.Close();

            return dataset.Tables["MusteriBilgileri"];
        }



        internal void MusteriKaydet(string Adi, string Soyadi, string Cinsiyet, string Telefon, string TcNo, string Email, string OdaNo, DateTime GirisTarihi, DateTime CikisTarihi)
        {
            
            try
            {
                if (TcNo.Length == 11 && decimal.TryParse(TcNo, out decimal tcno))
                {


                    bagla.Open();
                    SqlCommand com = new SqlCommand("insert into MusteriBilgileri (Adi,Soyadi,Cinsiyet,Telefon,TcNo,Email,OdaNo,GirisTarihi,CikisTarihi) values(@ad,@soyad,@cinsiyet,@tel,@tc,@email,@odano,@gtarih,@ctarih)", bagla);

                    com.Parameters.AddWithValue("@ad", Adi);
                    com.Parameters.AddWithValue("@soyad", Soyadi);
                    com.Parameters.AddWithValue("@cinsiyet", Cinsiyet);
                    com.Parameters.AddWithValue("@tel", Telefon);
                    com.Parameters.AddWithValue("@tc", TcNo);
                    com.Parameters.AddWithValue("@email", Email);
                    com.Parameters.AddWithValue("@odano", OdaNo);
                    com.Parameters.AddWithValue("@gtarih", GirisTarihi);
                    com.Parameters.AddWithValue("@ctarih", CikisTarihi);
                    com.ExecuteNonQuery();
                    bagla.Close();
                    MessageBox.Show("Kaydınız başarıyla oluşturuldu.");
                }
                else
                {
                    
                    
                    MessageBox.Show("Lütfen TC NO'yu kontrol edip tekrar giriniz.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
