using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTimerApp
{
    public class SaveIni
    {
        //private string DOSYAYOLU = Application.StartupPath + @"\Settings.ini";
        private string DOSYAYOLU = "C:\\Program Files\\DesktopTimer" + @"\Settings.ini"; 

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public SaveIni()
        {
            //DOSYAYOLU = dosyaYolu;

        
            if (!File.Exists("C:\\Program Files\\DesktopTimer")) 
            {
                Directory.CreateDirectory("C:\\Program Files\\DesktopTimer");
            }
        }       
        public string Varsayilan { get; set; }
        public string Oku(string bolum, string ayaradi)
        {
            if (File.Exists(DOSYAYOLU))
            {
                Varsayilan = Varsayilan ?? String.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            else return "0";
            
        }
        public long Yaz(string bolum, string ayaradi, string deger)
        {
            return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
        }
    }
}
