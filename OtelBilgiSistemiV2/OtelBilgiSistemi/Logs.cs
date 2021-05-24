using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    class Logs
    {
        

        public static void LogTut(string text1)
        {
            string dosya_konumu = @"C:\Users\Samet\source\repos\OtelBilgiSistemiV2\logs.txt";
            
            FileStream dosya = new FileStream(dosya_konumu, FileMode.OpenOrCreate, FileAccess.Write);
            dosya.Close();
            File.AppendAllText(dosya_konumu, Environment.NewLine + "Yeni bir "+text1 + " işlemi yapıldı. Tarih: " + DateTime.Now.ToString());

        }



       
    }
}
