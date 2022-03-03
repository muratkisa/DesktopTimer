using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopTimerApp
{
    public partial class Form1 : Form
    {

        SaveIni si = new SaveIni();
        public Form1()
        {
            InitializeComponent();
        }

        private int counter = 3600;
        private int counterRam = 3600;
        private int alarmVolume = 500;
        private int alarmTime = 1000;
        private bool msControl = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //AdministratorControl();

                if (true)
                {

                }
                this.BackgroundImage = Image.FromFile("C:\\Program Files\\DesktopTimer\\"+si.Oku("General","BackGround"));
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                label1.ForeColor = Color.White;

                if (si.Oku("General","Volume") != "0") alarmVolume = Convert.ToInt32(si.Oku("General", "Volume"));
                if (si.Oku("General", "AlarmTime") != "0") alarmTime = Convert.ToInt32(si.Oku("General", "AlarmTime"));

                if (si.Oku("General", "StartCounter") == "1")
                {
                    string hoursText = si.Oku("Time", "Hours");
                    string minutesText = si.Oku("Time", "Minutes");
                    string secondsText = si.Oku("Time", "Seconds");

                    counterRam = Convert.ToInt32(hoursText) * 3600 + Convert.ToInt32(minutesText) * 60 + Convert.ToInt32(secondsText);
                    counter = counterRam != 0 ? counterRam : 3600;
                    label1.Text = calculateTimer(counter);
                    if (si.Oku("General", "StartControl") == "1") CounterTimer.Start();
                     
                }
                else 
                {
                    label1.Text = DateTime.Now.ToString("HH:mm:ss");
                    timer1.Start();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label1.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "o" || e.KeyChar.ToString() == "O")
            {
                Settings f = new Settings();
                f.ShowDialog();

                if (f.saveChanges)
                {
                    msControl = f.msConrtol;
                    timer1.Stop();
                    CounterTimer.Stop();
                    counterRam = f.counter;
                    counter = counterRam;
                    alarmVolume = f.volume;
                    alarmTime = f.alarmTime;
                    label1.Text = calculateTimer(counter);
                    if (si.Oku("General", "StartControl") == "1") CounterTimer.Start();
                                        
                }

                this.BackgroundImage = Image.FromFile("C:\\Program Files\\DesktopTimer\\" + f.bg);

            }

            if (e.KeyChar.ToString() == "v" || e.KeyChar.ToString() == "V")
            {
                string formBorderStyle = this.FormBorderStyle.ToString();

                if (formBorderStyle == "None")
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                }
                else this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                
            }

            if (e.KeyChar.ToString() == "f" || e.KeyChar.ToString() == "F")
            {
                if (WindowState.ToString() == "Maximized")
                {
                    WindowState = FormWindowState.Normal;
                }
                else WindowState = FormWindowState.Maximized;
            }

            if (e.KeyChar.ToString() == "s" || e.KeyChar.ToString() == "S")
            {
                try
                {
                    timer1.Stop();
                    CounterTimer.Interval = 1000;
                    label1.Text = calculateTimer(counter);
                    CounterTimer.Start();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error Counter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.KeyChar.ToString() == "p" || e.KeyChar.ToString() == "P")
            {
                try
                {
                    CounterTimer.Stop();
                    timer3.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error Counter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.KeyChar.ToString() == "r" || e.KeyChar.ToString() == "R")
            {
                try
                {
                    timer1.Stop();
                    CounterTimer.Stop();
                    timer3.Stop();
                    string hoursText = si.Oku("Time", "Hours");
                    string minutesText = si.Oku("Time", "Minutes");
                    string secondsText = si.Oku("Time", "Seconds");

                    counterRam = Convert.ToInt32(hoursText) * 3600 + Convert.ToInt32(minutesText) * 60 + Convert.ToInt32(secondsText);
                    counter = counterRam != 0 ? counterRam : 3600;
                    msCounter = 100;
                    if (msControl == true) label1.Text = calculateTimer(counter);
                    else label1.Text = calculateTimer(counter);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error Counter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CounterTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                counter--;
                if (counter != 0 && counter > 0)
                {
                    if (msControl == true)
                    {
                        timer3.Start();                       
                    }
                    else label1.Text = calculateTimer(counter);
                }
                else
                {
                    label1.Text = "00:00:00";                    
                    CounterTimer.Stop();
                    timer3.Stop();
                    Console.Beep(alarmVolume, alarmTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");
                
            }
            
        }
    
        private string calculateTimer(int value) 
        {
            try
            {
                string timeText = "00:00:00";
                string minutes = "00:";
                string seconds = "00";
              

                if (msControl)
                {
                    if (counter != 0 && counter > 0)
                    {                        
                        minutes = (value / 60) >= 10 ? (value / 60).ToString() + ":" : "0" + (value / 60).ToString() + ":";
                        if (value % 60 != 0) seconds = (value % 60) >= 10 ? (value % 60).ToString() : "0" + (value % 60);
                        else seconds = "00";


                        timeText = minutes + seconds + mStext;
                    }
                }
                else 
                {
                    if (counter != 0 && counter > 0)
                    {
                        string hours = (value / 3600) >= 10 ? (value / 3600).ToString() + ":" : "0" + (value / 3600).ToString() + ":";
                        if (value % 3600 != 0)
                        {
                            int newValue = value % 3600;

                            minutes = (newValue / 60) >= 10 ? (newValue / 60).ToString() + ":" : "0" + (newValue / 60).ToString() + ":";
                            if (newValue % 60 != 0) seconds = (newValue % 60) >= 10 ? (newValue % 60).ToString() : "0" + (newValue % 60);
                            else seconds = "00";
                        }
                        else
                        {
                            minutes = "00:";
                            seconds = "00";
                        }

                        timeText = hours + minutes + seconds;
                    }
                }

                
                
                return timeText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");
            }
            return "00:00:00";
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void AdministratorControl()
        {
            try
            {
                if (!IsAdministrator())
                {
                    var psi = new ProcessStartInfo();
                    psi.FileName = Application.ExecutablePath;
                    psi.Verb = "runas";

                    var process = new Process();
                    process.StartInfo = psi;
                    process.Start();
                    process.WaitForExit();

                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
           
        }
        int msCounter = 100;
        string mStext = ":00";
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (msCounter != 0)
            {
                label1.Text = calculateTimer(counter);
                mStext = (msCounter % 100) >= 10 ? ":" + (msCounter % 100).ToString() : ":0" + (msCounter % 100);                               
                msCounter--;
            }
            else msCounter = 100;
        }
    }
}
