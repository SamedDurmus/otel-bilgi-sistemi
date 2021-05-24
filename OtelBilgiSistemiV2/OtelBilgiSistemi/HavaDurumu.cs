using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace OtelBilgiSistemi
{   
    public partial class HavaDurumu : Form
    {
        public HavaDurumu()
        {
            InitializeComponent();
        }
        

        private const string api = "";

        private const string link = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Aydin&amp;mode=xml&amp;units=metric&amp;APPID=" + api;
        
        public void HavaDurumu_goster2()
        {
            var svgtojpg = new NReco.ImageGenerator.HtmlToImageConverter();
            //try catch yap
            //var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=antalya");
            var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 0gC6XrWKUFTmrzcBPBw9NL:50YxvshbuZVRNR4cRsZ2qE");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            //var tumData = JsonConvert.SerializeObject(response.Content.ToString());
            //richTextBox1.Text = tumData;
            JToken jj = JToken.Parse(response.Content);
            labelgun.Text = jj["result"][0]["day"].ToString();
            labelsicaklik.Text = Math.Round(decimal.Parse(jj["result"][0]["degree"].ToString())).ToString()+"°C";
            labelgecesicaklik.Text= Math.Round(decimal.Parse(jj["result"][0]["night"].ToString())).ToString() + "°C";
            // önce alttaki gibi yapıp sonra hepsini tek satıra sığdırdım.
            //string derece = jj["result"][0]["degree"].ToString();
            //derece = Math.Round(decimal.Parse(derece)).ToString();
            ////labelsicaklik.Text = jj["result"][0]["degree"] + "°";
            //labelsicaklik.Text = derece;
            labeltarih.Text = jj["result"][0]["date"].ToString();
            labelnem.Text = "%"+jj["result"][0]["humidity"].ToString();
            labelhavadurumu.Text = jj["result"][0]["description"].ToString().ToUpper();





            //switch case çevir

            if (labelhavadurumu.Text.ToUpper() == "AÇIK")
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\Samet\source\repos\OtelBilgiSistemiV2\pictures\arkaplangunes.jpg");
                pictureBoxggunes.Visible = true;
            }
            if (labelhavadurumu.Text.ToUpper().Contains("YAĞMUR"))
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\Samet\source\repos\OtelBilgiSistemiV2\pictures\arkaplanyagmur.jpg");
                pictureBoxyyagmurlu.Visible = true;
            }
            if (labelhavadurumu.Text.ToUpper().Contains("BULUTLU") || labelhavadurumu.Text.ToUpper().Contains("KAPALI"))
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\Samet\source\repos\OtelBilgiSistemiV2\pictures\arkaplanparcali.jpg");
                pictureBoxpparcali.Visible = true;
            }

            //json to list
            //------2. gün için ------
            labelgun2.Text = jj["result"][1]["day"].ToString();
            labelsicaklik2.Text = Math.Round(decimal.Parse(jj["result"][0]["degree"].ToString())).ToString() + "°C";
            labelgecesicaklik2.Text = Math.Round(decimal.Parse(jj["result"][0]["night"].ToString())).ToString() + "°C";
            labeltarih2.Text = jj["result"][1]["date"].ToString();
            labelnem2.Text = "%" + jj["result"][1]["humidity"].ToString();
            labelhavadurumu2.Text = jj["result"][1]["description"].ToString().ToUpper();

            if (labelhavadurumu2.Text.ToUpper() == "AÇIK")
            {
                
                pictureBoxggunesli2.Visible = true;
            }
            if (labelhavadurumu2.Text.ToUpper().Contains("YAĞMUR"))
            {
                pictureBoxyyagmurlu2.Visible = true;
            }
            if (labelhavadurumu2.Text.ToUpper().Contains("BULUTLU") || labelhavadurumu2.Text.ToUpper().Contains("KAPALI"))
            {
                pictureBoxpparcali2.Visible = true;
            }





            //JavaScriptSerializer js = new JavaScriptSerializer();
            //HavaDurumu havadurumu = js.Deserialize<HavaDurumu>(response.Content);
            //labelsicaklik.Text = HttpUtility.HtmlDecode(havadurumu.Name);
        }
        public void HavaDurumu_goster()
        {
            
            XDocument hava_durumu = XDocument.Load(link);
            var sicaklik = hava_durumu.Descendants("temperature").ElementAt(0).Attribute("name").Value;
            labelsicaklik.Text = sicaklik.ToString() + "°"; // alt 248 ile derece işareti yapılıyor.
            var durum = hava_durumu.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            labelhavadurumu.Text = durum.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HavaDurumu_Load(object sender, EventArgs e)
        {
            HavaDurumu_goster2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
