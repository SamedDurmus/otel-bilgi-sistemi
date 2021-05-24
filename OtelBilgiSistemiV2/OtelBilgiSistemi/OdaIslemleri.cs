using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    class OdaIslemleri
    {


        
        //SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");
        internal void OdaBosaltma(string OdaNo, string MusteriAdi, string MusteriSoyadi)
        {
            try
            {
                Statik.bagla.Open();
                SqlCommand com = new SqlCommand("update OdaBilgileri set MusteriAdi=@musteriadi, MusteriSoyadi=@musterisoyadi, OdaDurumu=@odadurumu where OdaNo=@odano", Statik.bagla);
                com.Parameters.AddWithValue("@odano", OdaNo);
                com.Parameters.AddWithValue("@musteriadi", "");
                com.Parameters.AddWithValue("@musterisoyadi", "");

                com.Parameters.AddWithValue("@odadurumu", "BOS");
                com.ExecuteNonQuery();
                Statik.bagla.Close();

            }
            catch
            {


            }
        }

        internal void OdaDoldurma(string OdaNo, string MusteriAdi, string MusteriSoyadi)
        {

            try
            {
                Statik.bagla.Open();
                SqlCommand com = new SqlCommand("update OdaBilgileri set MusteriAdi=@musteriadi, MusteriSoyadi=@musterisoyadi, OdaDurumu=@odadurumu where OdaNo=@odano", Statik.bagla);

                com.Parameters.AddWithValue("@odano", OdaNo);
                com.Parameters.AddWithValue("@musteriadi", MusteriAdi);
                com.Parameters.AddWithValue("@musterisoyadi", MusteriSoyadi);
                com.Parameters.AddWithValue("@odadurumu", "DOLU");
                com.ExecuteNonQuery();
                Statik.bagla.Close();




            }
            catch
            {


            }

        }



        public string OdadakiMusteriAdi { get; set; }

        public string OdadakiMusteriSoyadi { get; set; }
        public string OdaSonDurum { get; set; }
        public string OdaButon { get; set; }
        public string CikisTarihi { get; set; }
        public void OdaBilgileriniAlma(string OdaNo,string OdaDurumu)
        {
            try
            {
                Statik.bagla.Open();
                SqlCommand com = new SqlCommand("Select *from OdaBilgileri where OdaNo=@odano AND OdaDurumu=@odadurumu  ", Statik.bagla);
                com.Parameters.AddWithValue("@odano" , OdaNo);
                com.Parameters.AddWithValue("@odadurumu", OdaDurumu);
                SqlDataReader OdaBilgisiOku = com.ExecuteReader();
                
                if(OdaBilgisiOku.Read())
                {
                    //MessageBox.Show("okudum");
                    OdadakiMusteriAdi = OdaBilgisiOku["MusteriAdi"].ToString();
                    OdadakiMusteriSoyadi = OdaBilgisiOku["MusteriSoyadi"].ToString();
                    OdaSonDurum = OdaBilgisiOku["OdaDurumu"].ToString();
                    OdaButon = OdaBilgisiOku["OdaButonu"].ToString();
                    


                }
                
                
                


            }
            catch 
            {

                
            }
            finally { Statik.bagla.Close(); }
        }


    }
}
