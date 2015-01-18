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

namespace Clock
{
    public partial class AlarmSet : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Clock Parent;
        private bool newalarmset;
        private DateTime mytime;
        public AlarmSet(Clock parentClock)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            AlarmTime.MinDate = DateTime.UtcNow.AddHours(-8).AddSeconds(30);
            AlarmTime.Value = DateTime.UtcNow.AddHours(-8).AddMinutes(1);
            
            Parent = parentClock;
            newalarmset = false;
        }

        private void SET_Click(object sender, EventArgs e)
        {
            newalarmset = true;
            mytime = AlarmTime.Value;
            if(!(mytime.AddDays(-1) < DateTime.UtcNow.AddHours(-8)))
            {
                mytime.AddDays(-1);
            }
            Parent.setNewAlarm(mytime);
            Parent.Show();
            Parent.Location = this.Location;
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AlarmTime.MinDate = DateTime.UtcNow.AddHours(-8).AddSeconds(30);
        }
    }
}
