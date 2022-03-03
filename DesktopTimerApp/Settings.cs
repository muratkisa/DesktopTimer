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

namespace DesktopTimerApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public int counter = 0;
        public bool saveChanges = false;
        SaveIni si = new SaveIni();
        public int volume = 0;
        public int alarmTime = 0;
        public string bg = "img1.jpg";
        public bool msConrtol = false;
        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                int selected = 0;
                if (!File.Exists("C:\\Program Files\\DesktopTimer"))
                {
                    int c = 0;
                    string[] files = Directory.GetFiles("C:\\Program Files\\DesktopTimer\\", "*.jpg");
                    foreach (var file in files) 
                    {                                           
                        string[] a = file.Split("\\");                        
                        BackGroundImagesCombo.Items.Add(a.Last());

                        string back = si.Oku("General", "BackGround");                        
                        if (back == a.Last())
                        {
                            selected = c;
                        }
                        c++;
                    }
                }

                BackGroundImagesCombo.SelectedIndex = selected;


                string hoursText = si.Oku("Time", "Hours");
                string minutesText = si.Oku("Time", "Minutes");
                string secondsText = si.Oku("Time", "Seconds");
                string volume = si.Oku("General", "Volume");
                string alarmTime = si.Oku("General", "AlarmTime");
                string startWithCounter = si.Oku("General", "StartCounter");
                string startControl = si.Oku("General", "StartControl");

                HourUpDown.Value = Convert.ToInt32(hoursText);
                MinuteUpDown.Value = Convert.ToInt32(minutesText);
                SecondUpDown.Value = Convert.ToInt32(secondsText);                
                AlarmVolume.Value = Convert.ToInt32(volume) == 0 ? 1 : Convert.ToInt32(volume) / 500;
                AlarmTime.Value = Convert.ToInt32(alarmTime) == 0 ? 1 : Convert.ToInt32(alarmTime) / 1000;

                timeORcounter.Checked = startWithCounter == "1" ? true : false;
                StartControl.Checked = startControl == "1" ? true : false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "S001", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        private void HourUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (HourUpDown.Value < 0) HourUpDown.Value = 0;
            else if (HourUpDown.Value > 24) HourUpDown.Value = 24;

            if (HourUpDown.Value == 24)
            {
                MinuteUpDown.Value = 0;
                SecondUpDown.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MilliSecondCombo.Checked == false)
            {
                counter = Convert.ToInt32(HourUpDown.Value) * 3600 + Convert.ToInt32(MinuteUpDown.Value) * 60 + Convert.ToInt32(SecondUpDown.Value);
                msConrtol = false;
            }
            else 
            {
                counter = Convert.ToInt32(MinuteUpDown.Value) * 60 + Convert.ToInt32(SecondUpDown.Value);
                msConrtol = true;
            }
            

            volume = (500 * AlarmVolume.Value);
            alarmTime = (1000 * AlarmTime.Value);
            bg = BackGroundImagesCombo.SelectedItem.ToString();

            if (counter == 0)
            {
                MessageBox.Show("Please select value.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveChanges = true;
            try
            {
                si.Yaz("Time", "Hours", HourUpDown.Value.ToString());
                si.Yaz("Time", "Minutes", MinuteUpDown.Value.ToString());
                si.Yaz("Time", "Seconds", SecondUpDown.Value.ToString());
                si.Yaz("General", "Volume", (500 * AlarmVolume.Value).ToString());
                si.Yaz("General", "AlarmTime", (1000 * AlarmTime.Value).ToString());
                si.Yaz("General", "StartCounter", timeORcounter.Checked == true ? "1" : "0");
                si.Yaz("General", "StartControl", StartControl.Checked == true ? "1" : "0");
                si.Yaz("General", "BackGround", BackGroundImagesCombo.SelectedItem.ToString());
            }
            catch{ }
            this.Close();
        }

        private void MinuteUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (HourUpDown.Value == 24)
            {
                MinuteUpDown.Value = 0;
                SecondUpDown.Value = 0;
            }
            else if (MinuteUpDown.Value < 0) MinuteUpDown.Value = 0;
            else if (MinuteUpDown.Value >= 60) 
            {
                int newHours = Convert.ToInt32(MinuteUpDown.Value) / 60;
                int newMinutes = Convert.ToInt32(MinuteUpDown.Value) % 60;

                int hourTotal = Convert.ToInt32(HourUpDown.Value) + newHours;
                if (hourTotal >= 24)
                {
                    HourUpDown.Value = 24;
                    MinuteUpDown.Value = 0;
                    SecondUpDown.Value = 0;
                }
                else 
                {
                    HourUpDown.Value = hourTotal;
                    MinuteUpDown.Value = newMinutes;
                }
            }

        }

        private void SecondUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            
            if (SecondUpDown.Value == 60)
            {     
                int newMinutes = Convert.ToInt32(MinuteUpDown.Value) + 1;
                if (newMinutes >= 60)
                {                    
                    MinuteUpDown.Value = newMinutes;
                    SecondUpDown.Value = 0;
                }
                else
                {
                    SecondUpDown.Value = 0;
                    MinuteUpDown.Value = newMinutes;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            bg = BackGroundImagesCombo.SelectedItem.ToString();       
                        
            try
            {                
                si.Yaz("General", "BackGround", BackGroundImagesCombo.SelectedItem.ToString());
            }
            catch { }
            this.Close();
        }

        private void BackGroundImagesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                panel1.BackgroundImage = Image.FromFile("C:\\Program Files\\DesktopTimer\\" + BackGroundImagesCombo.SelectedItem.ToString());
                panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }
    }
}
