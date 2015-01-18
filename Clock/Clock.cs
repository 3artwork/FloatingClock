using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Clock.Properties;

namespace Clock
{
    public partial class Clock : Form
    {
        bool ringing = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private int hr, min, sec;
        private bool pm;

        private bool alarmset;
        private DateTime mytime;
        private DateTime alarmDateTime;
        bool blink;
        System.Media.SoundPlayer startSoundPlayer;
        public Clock()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            alarmset = false;
            pm = false;
            mytime = DateTime.UtcNow.AddHours(-8);
            hr = mytime.Hour;
            min = mytime.Minute;
            sec = mytime.Second;
            if(hr > 12)
            {
                pm = true;
                hr -= 12;
            }
            else if(hr == 0)
            {
                hr = 12;
            }
            
            if (pm)
            {
                _pm.Text = "PM";
            }
            else _pm.Text = "AM";
        }
        public void setNewAlarm(DateTime time)
        {
            alarmDateTime = time;
            CountDown.Maximum = Convert.ToInt32(time.Subtract(DateTime.UtcNow.AddHours(-8)).TotalMinutes) * 60;
            CountDown.Value = CountDown.Maximum;
            alarmset = true;
            ringing = false;
            TimeHR.ForeColor = Color.LimeGreen;
            TimeMIN.ForeColor = Color.LimeGreen;
            colon.ForeColor = Color.LimeGreen;
            _pm.ForeColor = Color.PaleGreen;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                pm = false;
                mytime = DateTime.UtcNow.AddHours(-8);
                hr = mytime.Hour;
                min = mytime.Minute;
                sec = mytime.Second;
                
                if (hr > 12)
                {
                    pm = true;
                    hr -= 12;
                }
                else if (hr == 0)
                {
                    hr = 12;
                }
                TimeHR.Text = Convert.ToString(hr);
                if (min < 10)
                {
                    TimeMIN.Text = String.Format("0{0}", min);
                }
                else TimeMIN.Text = Convert.ToString(min);
                if (CountDown.Value != 0 && alarmset == true)
                {
                    CountDown.Value = Convert.ToInt32(alarmDateTime.Subtract(mytime).TotalSeconds);
                }
                else if (CountDown.Value <= 0 || CountDown.Maximum <=0)
                {
                    alarmset = false;
                    CountDown.Maximum = 5;
                    CountDown.Value = CountDown.Maximum;
                    ringing = true;
                }
                if (ringing)
                {
                    if (blink)
                    {
                        TimeHR.ForeColor = Color.Red;
                        TimeMIN.ForeColor = Color.Red;
                        colon.ForeColor = Color.Red;
                        _pm.ForeColor = Color.LightCoral;
                        blink = !blink;
                        startSoundPlayer.Play();
                    }
                    else
                    {
                        TimeHR.ForeColor = Color.White;
                        TimeMIN.ForeColor = Color.White;
                        colon.ForeColor = Color.White;
                        _pm.ForeColor = Color.LightGray;
                        blink = !blink;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                this.TopMost = true;
            if(!checkBox1.Checked)
                this.TopMost = false;
        }

        private void Clock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ringing)
                {
                    ringing = false;
                    CountDown.Value = CountDown.Maximum;
                    TimeHR.ForeColor = Color.LimeGreen;
                    TimeMIN.ForeColor = Color.LimeGreen;
                    colon.ForeColor = Color.LimeGreen;
                    _pm.ForeColor = Color.PaleGreen;
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlarmSet myAlarm = new AlarmSet(this);
            myAlarm.Show();
            myAlarm.Location = this.Location;
            if (checkBox1.Checked)
                myAlarm.TopMost = true;
            this.Hide();
        }

        private void Clock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.OnTop = this.TopMost;
            Properties.Settings.Default.Save();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowLocation != null)
            {
                this.Location = Properties.Settings.Default.WindowLocation;
                if(Properties.Settings.Default.OnTop)
                    checkBox1.Checked = true;
            }
            ringing = false;
            TimeHR.ForeColor = Color.LimeGreen;
            TimeMIN.ForeColor = Color.LimeGreen;
            colon.ForeColor = Color.LimeGreen;
            CountDown.Value = CountDown.Maximum;
            startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Notify Calendar.wav");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.x;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.alarm;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Resources.alarm_light;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Resources.x_light;
        }
    }
}
