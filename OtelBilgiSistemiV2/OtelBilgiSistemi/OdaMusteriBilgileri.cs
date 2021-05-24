using System;
using System.Collections;
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
    public partial class OdaMusteriBilgileri : Form
    {
        public OdaMusteriBilgileri()
        {
            InitializeComponent();
        }
        ArrayList OdaIsimleri = new ArrayList();

        private void OdaMusteriBilgileri_Load(object sender, EventArgs e)
        {
            string IlkOdaNo;
            string DuzenlenmisOdaNo;
            

            for(int i=1; i < this.Controls.Count-3; i++)
            {
                IlkOdaNo = Convert.ToString(this.Controls.Find("buttonOda" + i.ToString(), true).FirstOrDefault() as Button);
                DuzenlenmisOdaNo = IlkOdaNo.Split(':').Last();
                DuzenlenmisOdaNo = DuzenlenmisOdaNo.Trim();
                OdaIsimleri.Add(DuzenlenmisOdaNo);

                //MessageBox.Show(DuzenlenmisOdaNo);
            }


            OdaKontrol();

        }
        

        public void OdaKontrol()
        {
            OdaIslemleri odaislemleri = new OdaIslemleri();
            
            try
            {
                foreach (string odaismi in OdaIsimleri)
                {
                    odaislemleri.OdaBilgileriniAlma(odaismi, "DOLU");
                    if (odaislemleri.OdaSonDurum == "DOLU")
                    {
                        
                        this.Controls.Find(odaislemleri.OdaButon, true)[0].BackColor = Color.Red;
                        this.Controls.Find(odaislemleri.OdaButon, true)[0].Text =odaismi+" \n"+ odaislemleri.OdadakiMusteriAdi+" "+odaislemleri.OdadakiMusteriSoyadi + " \n" ;
                        odaislemleri.OdaSonDurum ="";


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();

        }
    }
}
